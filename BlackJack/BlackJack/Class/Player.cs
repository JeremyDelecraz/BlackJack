using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Player
    {
        private const int BLACKJACK = 21;
        public int NbWin { get; private set; } = 0;
        public int NbLose { get; private set; } = 0;
        public int NbEqual { get; private set; } = 0;
        public int Cash { get; protected set; }
        protected List<int> lstBetValue = new List<int>();
        protected List<Hand> lstHand = new List<Hand>();
        public Game Game { protected get; set; }
        public PlayerBank Bank { protected get; set; }

        public Player(Game g,PlayerBank b,int cash) {
            this.Game = g;
            this.Bank = b;
            Cash = cash;
        }

        public Player(Game g)
        {
            this.Game = g;
        }

        public virtual void play()
        {
        }

        public virtual void bet()
        {
        }
        
        /// <summary>
        /// Vérification si on peut split les cartes d'une main ou non
        /// </summary>
        /// <param name="idHand">Id de la main</param>
        public void testSplit(int idHand)
        {
            if (lstHand[idHand].isSameCard())
            {
                split(idHand);
            }
        }

        /// <summary>
        /// Split la main en deux
        /// </summary>
        /// <param name="idHand">Id de la main</param>
        public void split(int idHand)
        {
            Hand h = new Hand(lstHand[idHand].removeLastCard());
            lstHand.Add(h);
            lstHand[idHand].Value /= 2;
            lstHand[idHand].addCard(Game.requestCard());
            lstBetValue.Add(lstBetValue[idHand]);
            testSplit(idHand);
        }

        /// <summary>
        /// Ajoute une carte à la main
        /// </summary>
        /// <param name="idHand">Id de la main</param>
        public void addCard(int idHand)
        {
            if (!lstHand.Any()) {
                lstHand.Add(new Hand());
            }
            lstHand[idHand].addCard(Game.requestCard());
        }
        
        /// <summary>
        /// Vérification pour savoir si les mains sont gagnantes ou perdantes
        /// </summary>
        /// <param name="bankHandValue">La valeur de la main de la banque</param>
        /// <param name="nbCardBank">Le nombre de carte de la banque</param>
        public void verifWinLose(int bankHandValue,int nbCardBank)
        {
            for (int i = 0; i < lstHand.Count; i++)
            {
                int handValue = lstHand[i].Value;
                if (handValue > BLACKJACK) { loseCash(i); return; }
                if (handValue == BLACKJACK && lstHand[i].getNbCard() == 2 && lstHand.Count == 1) { winBlackJack(i); return; }
                if (bankHandValue > BLACKJACK && handValue <= BLACKJACK) { winCash(i); return; }
                if (bankHandValue == BLACKJACK && nbCardBank == 2) { loseCash(i); return; }
                if (bankHandValue == handValue) { equalCash(i); return; }
                if (bankHandValue <= BLACKJACK && handValue > bankHandValue) { winCash(i); return; }
                if (handValue < bankHandValue) { loseCash(i); return; }
            }
        }

        /// <summary>
        /// Lors d'une victoire par blackjack
        /// </summary>
        /// <param name="idBet">L'id de la mise</param>
        public void winBlackJack(int idBet)
        {
            int cashWin = lstBetValue[idBet] / 2;
            Cash += cashWin;
            Bank.Cash -= cashWin;
            winCash(idBet);
        }

        /// <summary>
        /// Lors d'une victoire
        /// </summary>
        /// <param name="idBet">L'id de la mise</param>
        public void winCash(int idBet)
        {
            Cash += lstBetValue[idBet] * 2;
            Bank.Cash -= lstBetValue[idBet];
            NbWin++;
        }

        /// <summary>
        /// Lors d'une égalité
        /// </summary>
        /// <param name="idBet">L'id de la mise</param>
        public void equalCash(int idBet)
        {
            this.Cash += lstBetValue[idBet];
            NbEqual++;
        }

        /// <summary>
        /// Lors d'une défaite
        /// </summary>
        /// <param name="idBet">L'id de la mise</param>
        public void loseCash(int idBet)
        {
            NbLose++;
            Bank.Cash += lstBetValue[idBet];
        }

        /// <summary>
        /// Recommencer le tour
        /// </summary>
        public void resetHand()
        {
            lstHand.Clear();
            lstBetValue.Clear();
        }

        /// <summary>
        /// Doubler la mise
        /// </summary>
        /// <param name="idBet"></param>
        public void doubleBet(int idBet)
        {
            Cash -= lstBetValue[idBet];
            lstBetValue[idBet] *= 2;
            addCard(idBet);
        }

        /// <summary>
        /// Vérifie que la main à au minimum 2 cartes
        /// </summary>
        /// <param name="idHand"></param>
        public void testEnoughCardInHand(int idHand)
        {
            if (lstHand[idHand].getNbCard() < 2)
            {
                lstHand[idHand].addCard(Game.requestCard());
            }
        }

        /// <summary>
        /// Retourne la valeur de la main
        /// </summary>
        /// <param name="idHand"></param>
        /// <returns></returns>
        public int getHandValue(int idHand)
        {
            return lstHand[idHand].Value;
        }

        /// <summary>
        /// Retourne le nombre de carte d'une main
        /// </summary>
        /// <param name="idHand"></param>
        /// <returns></returns>
        public int getNbCard(int idHand)
        {
            return lstHand[idHand].getNbCard();
        }
    }
}
