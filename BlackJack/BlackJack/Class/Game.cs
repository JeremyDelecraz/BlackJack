using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Game
    {        
        private Deck deck;
        private List<PlayerLambda> lstPlayer;
        private PlayerBank bank;
        private PlayerPro playerPro;
        private int sabotValue = 0;
        public double realSabotValue = 0.0;
        private int nbDeck;
        private int nbPlayer;
        private FrmMain frm;

        public Game(int nbDeck, int nbPlayer,int cash,FrmMain frm)
        {
            this.nbDeck = nbDeck;
            this.nbPlayer = nbPlayer;
            this.frm = frm;
            deck = new Deck(nbDeck);
            initPLayer(nbPlayer,cash);
        }

        private void initPLayer(int nbPlayer,int cash)
        {
            bank = new PlayerBank(this);
            playerPro = new PlayerPro(this, bank,cash);
            lstPlayer = new List<PlayerLambda>();
            for (int i = 0; i < nbPlayer; i++)
            {
                lstPlayer.Add(new PlayerLambda(this,bank,cash));
            }
        }

        public void play(int nbTurn)
        {
            for (int j = 0; j < nbTurn; j++)
            {
                testEnoughCard();
                betTurnByTurn();
                distributeCard();
                playTurnByTurn();
                verifWinLose();
                replay();
            }
        }

        private void betTurnByTurn()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].bet();
            }
            playerPro.bet();
        }

        private void playTurnByTurn()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].play();
            }
            playerPro.play();
            bank.play();
        }

        private void testEnoughCard()
        {
            if(deck.getNbCard() < (nbPlayer + 2) * 5)
            {
                deck.reset();
                sabotValue = 0;
            }
        }

        private void distributeCard()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < lstPlayer.Count; i++)
                {
                    lstPlayer[i].addCard(0);
                }
                if (playerPro.isPlaying) { playerPro.addCard(0); }
                bank.addCard(0);
            }
        }

        private void verifWinLose()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].verifWinLose(bank.getHandValue(0),bank.getNbCard(0));
            }
            if (playerPro.isPlaying) { playerPro.verifWinLose(bank.getHandValue(0), bank.getNbCard(0)); }
        }
        
        private void replay()
        {
            for (int i = 0; i < lstPlayer.Count; i++)
            {
                lstPlayer[i].resetHand();
            }
            bank.resetHand();
            playerPro.resetHand();
        }
        
        public Card requestCard()
        {
            Card c = deck.getCard();
            sabotValue += c.SabotValue;
            realSabotValue = sabotValue / deck.getNbDeck();
            return c;
        }

        public int getCashProPlayer()
        {
            return playerPro.getCash();
        }

        public List<int> getWinEqualLose()
        {
            return new List<int> { playerPro.getNbWin(), playerPro.getNbEqual(), playerPro.getNbLose() };
        }
    }
}