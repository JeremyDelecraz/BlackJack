using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Game
    {
        public static Random RAND = new Random();
        private Deck deck;
        private List<PlayerLambda> lstPlayer;
        private PlayerBank bank;
        private PlayerPro playerPro;
        private int sabotValue = 0;
        public double RealSabotValue { get; private set; } = 0.0;
        private int nbDeck;
        private int nbPlayer;

        public Game(int nbDeck, int nbPlayer,int cash)
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
            lstPlayer = new List<PlayerLambda>();
            for (int i = 0; i < nbPlayer; i++)
            {
                lstPlayer.Add(new PlayerLambda(this,bank,cash));
            }
        }

        /// <summary>
        /// Lors du déroulement d'un tour
        /// </summary>
        public void play()
        {
            testEnoughCard();
            betTurnByTurn();
            distributeCard();
            playTurnByTurn();
            verifWinLose();
            replay();
        }

        /// <summary>
        /// Tout les joueurs misent
        /// </summary>
        private void betTurnByTurn()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].bet();
            }
            if (playerPro != null) playerPro.bet();
        }

        /// <summary>
        /// Tout les joueurs joue
        /// </summary>
        private void playTurnByTurn()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].play();
            }
            if (playerPro != null) playerPro.play();
            bank.play();
        }

        /// <summary>
        /// Vérification si le nombre de carte dans le paquet sons sufisant
        /// En moyenne (3.5 cartes par personne sont utilisée)
        /// </summary>
        private void testEnoughCard()
        {
            if(deck.getNbCard() < (nbPlayer + 2) * 4.5)
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
                for (int i = 0; i < lstPlayer.Count; i++)
                {
                    lstPlayer[i].addCard(0);
                }
                if (playerPro != null && playerPro.isPlaying) { playerPro.addCard(0); }
                bank.addCard(0);
            }
        }

        /// <summary>
        /// Vérification des victoires et des défaite des joueurs
        /// </summary>
        private void verifWinLose()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].verifWinLose(bank.getHandValue(0),bank.getNbCard(0));
            }
            if (playerPro != null && playerPro.isPlaying) { playerPro.verifWinLose(bank.getHandValue(0), bank.getNbCard(0)); }
        }
        
        /// <summary>
        /// Recommencez le tour
        /// </summary>
        private void replay()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].resetHand();
            }
            bank.resetHand();
            if (playerPro != null) playerPro.resetHand();
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
            int nbDeck = deck.getNbDeck();
            RealSabotValue = sabotValue / ((nbDeck > 0) ? nbDeck : 1);
            return c;
        }

        /// <summary>
        /// Vire le joueur pro de la table
        /// </summary>
        /// <returns></returns>
        public PlayerPro removePlayerPro()
        {
            PlayerPro p = playerPro;
            playerPro = null;
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
            this.playerPro = pPro;
        }
    }
}