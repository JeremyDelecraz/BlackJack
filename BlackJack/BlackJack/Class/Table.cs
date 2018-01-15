using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Table
    {
        public static Random RAND = new Random();
        private Deck deck;
        public List<PlayerLambda> LstPlayer { get; private set; }
        private PlayerBank bank;
        public PlayerPro PlayerPro { get; private set; }
        private int sabotValue = 0;
        public double RealSabotValue { get; private set; } = 0.0;
        private int nbDeck;
        private int nbPlayer;

        public Table(int nbDeck, int nbPlayer,int cash)
        {
            this.nbDeck = nbDeck;
            this.nbPlayer = nbPlayer;
            deck = new Deck(nbDeck);
            initPLayer(nbPlayer,cash);
        }

        /// <summary>
        /// Initialise tout les joueurs
        /// </summary>
        /// <param name="nbPlayer">Nombre de joueurs</param>
        /// <param name="cash">L'argent qu'ils auront de base</param>
        private void initPLayer(int nbPlayer,int cash)
        {
            bank = new PlayerBank(this);
            LstPlayer = new List<PlayerLambda>();
            for (int i = 0; i < nbPlayer; i++)
            {
                LstPlayer.Add(new PlayerLambda(this,bank,cash));
            }
        }

        /// <summary>
        /// Lors du déroulement d'un tour
        /// </summary>
        public void play()
        {
            replay();
            testEnoughCard();
            betTurnByTurn();
            distributeCard();
            playTurnByTurn();
            verifWinLose();
        }

        /// <summary>
        /// Tout les joueurs misent
        /// </summary>
        private void betTurnByTurn()
        {
            for (int i = 0; i < LstPlayer.Count; i++)
            {
                LstPlayer[i].bet();
            }
            if (PlayerPro != null) PlayerPro.bet();
        }

        /// <summary>
        /// Tout les joueurs joue
        /// </summary>
        private void playTurnByTurn()
        {
            for (int i = 0; i < LstPlayer.Count; i++)
            {
                LstPlayer[i].play();
            }
            if (PlayerPro != null) PlayerPro.play();
            bank.play();
        }

        /// <summary>
        /// Vérification si le nombre de carte dans le paquet sont sufisant
        /// Lorsqu'il reste 1 quart des cartes
        /// </summary>
        private void testEnoughCard()
        {
            if(deck.getNbCard() <= nbDeck * Deck.NB_CARD_ONE_DECK / 4)
            {
                deck.reset();
                sabotValue = 0;
                RealSabotValue = 0;
            }
        }

        /// <summary>
        /// Distibution des cartes aux joueurs
        /// </summary>
        private void distributeCard()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < LstPlayer.Count; i++)
                {
                    LstPlayer[i].addCard(0);
                }
                if (PlayerPro != null && PlayerPro.isPlaying) { PlayerPro.addCard(0); }
                bank.addCard(0);
            }
        }

        /// <summary>
        /// Vérification des victoires et des défaite des joueurs
        /// </summary>
        private void verifWinLose()
        {
            int bHandValue = bank.getHandValue(0);
            int bNbCard = bank.getNbCard(0);
            for (int i = 0; i < LstPlayer.Count; i++)
            {
                LstPlayer[i].verifWinLose(bHandValue, bNbCard);
            }
            if (PlayerPro != null && PlayerPro.isPlaying) { PlayerPro.verifWinLose(bHandValue, bNbCard); }
        }
        
        /// <summary>
        /// Recommencez le tour
        /// </summary>
        private void replay()
        {
            for (int i = 0; i < LstPlayer.Count; i++)
            {
                LstPlayer[i].resetHand();
            }
            bank.resetHand();
            if (PlayerPro != null) PlayerPro.resetHand();
        }
        
        ///Valeur réel : Valeur du sabot / Nombre de carte restant
        /// <summary>
        /// Récupère et retourne une carte du paquet
        /// </summary>
        /// <returns></returns>
        public Card requestCard()
        {
            Card c = deck.getCard();
            sabotValue += c.SabotValue;
            RealSabotValue = sabotValue / deck.getNbDeck();
            return c;
        }

        /// <summary>
        /// Vire le joueur pro de la table
        /// </summary>
        /// <returns></returns>
        public PlayerPro removeAndGetPlayerPro()
        {
            PlayerPro p = PlayerPro;
            PlayerPro = null;
            return p;
        }

        /// <summary>
        /// Ajoute un joueur pro sur la table
        /// </summary>
        /// <param name="pPro"></param>
        public void addPlayerPro(PlayerPro pPro)
        {
            pPro.GameTable = this;
            pPro.Bank = bank;
            this.PlayerPro = pPro;
        }

        public Hand getBankHand()
        {
            return bank.LstHand[0];
        }

        public int getNbCardInDeck()
        {
            return deck.getNbCard();
        }
    }
}