using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Deck
    {
        private List<String> LST_ONE_COLOR_DECK = new List<string> {"2","3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private const int NB_COLOR_DECK = 4;
        private const int NB_CARD_ONE_DECK = 52;
        private List<Card> lstCard;
        private int nbDeck;

        public Deck(int nbDeck)
        {
            this.nbDeck = nbDeck;
            lstCard = new List<Card>();
            init();
        }

        private void init()
        {
            for (int i = 0; i < nbDeck; i++)
            {
                distributeColor();
            }
            lstCard = shuffle();
            removeFiveCard();
        }

        public void reset()
        {
            lstCard.Clear();
            init();
        }

        private void distributeColor()
        {
            for (int i = 0; i < NB_COLOR_DECK; i++)
            {
                addCardInDeck();
            }
        }

        //Sabot value-> 2, 3, 4 , 5, 6	    Comptez +1
        //              7, 8, 9	            Comptez 0
        //              10, J, Q, K, A      Comptez -1
        private void addCardInDeck()
        {
            int cardValue;
            int sabotValue;
            int realValue;
            for (int i = 0; i < LST_ONE_COLOR_DECK.Count; i++)
            {
                realValue = i + 2;
                cardValue = (realValue <= 10) ? realValue : 10;
                sabotValue = (realValue <= 6) ? 1 : (realValue > 9) ? -1 : 0;
                lstCard.Add(new Card(LST_ONE_COLOR_DECK[i], cardValue, sabotValue));
            }
            //Pour l'as --> Valeur 11 ou 1
            lstCard[lstCard.Count - 1].CardValue = 11;
            lstCard[lstCard.Count - 1].SecondValue = 1; 
        }

        private List<Card> shuffle()
        {
            List<Card> randomList = new List<Card>();

            Random r = new Random();
            int randomIndex = 0;
            while (lstCard.Count > 0)
            {
                randomIndex = r.Next(0, lstCard.Count);
                randomList.Add(lstCard[randomIndex]);
                lstCard.RemoveAt(randomIndex);
            }

            return randomList;
        }

        public Card getCard()
        {
            Card c = lstCard[lstCard.Count - 1];
            lstCard.RemoveAt(lstCard.Count - 1);
            return c;
        }

        public int getNbCard()
        {
            return lstCard.Count;
        }

        public void removeFiveCard()
        {
            lstCard.RemoveRange(lstCard.Count - 6, 5);
        }

        public double getNbDeck()
        {
            return (double)lstCard.Count / (double)NB_CARD_ONE_DECK;
        }
    }
}
