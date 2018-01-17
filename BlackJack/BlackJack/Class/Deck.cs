using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    public class Deck
    {
        private List<String> LST_ONE_COLOR_DECK = new List<string> {"2","3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private const int NB_COLOR_DECK = 4;
        public static int NB_CARD_ONE_DECK = 52;
        private List<Card> lstCard;
        private int nbDeck;

        public Deck(int nbDeck)
        {
            this.nbDeck = nbDeck;
            lstCard = new List<Card>();
            init();
        }

        /// <summary>
        /// Création du deck de carte
        /// </summary>
        private void init()
        {
            for (int i = 0; i < nbDeck; i++)
            {
                distributeColor();
            }
            lstCard = shuffle();
            removeFiveCard();
        }

        /// <summary>
        /// Réinitialisation du deck de carte
        /// </summary>
        public void reset()
        {
            lstCard.Clear();
            init();
        }

        /// <summary>
        /// Création de 1 deck
        /// </summary>
        private void distributeColor()
        {
            for (int i = 0; i < NB_COLOR_DECK; i++)
            {
                addCardInDeck(i);
            }
        }


        //Sabot value-> 2, 3, 4 , 5, 6	    Comptez +1
        //              7, 8, 9	            Comptez 0
        //              10, J, Q, K, A      Comptez -1

        /// <summary>
        /// Ajout des objets cartes dans le deck
        /// </summary>
        /// <param name="indexImage">index de l'image qu'aura la carte</param>
        private void addCardInDeck(int indexImage)
        {
            int cardValue;
            int sabotValue;
            int realValue;
            for (int i = 0; i < LST_ONE_COLOR_DECK.Count; i++)
            {
                realValue = i + 2;
                cardValue = (realValue <= 10) ? realValue : 10;
                sabotValue = (realValue <= 6) ? 1 : (realValue > 9) ? -1 : 0;
                lstCard.Add(new Card(LST_ONE_COLOR_DECK[i], sabotValue,cardValue, indexImage * 13 + i));
            }
            //Pour l'as --> Valeur 11 ou 1
            lstCard[lstCard.Count - 1].CardValue = 11;
            lstCard[lstCard.Count - 1].SecondValue = 1; 
        }

        /// <summary>
        /// Mélange le deck
        /// </summary>
        /// <returns></returns>
        private List<Card> shuffle()
        {
            List<Card> randomList = new List<Card>();

            Random r = Table.RAND;
            int randomIndex = 0;
            while (lstCard.Count > 0)
            {
                randomIndex = r.Next(0, lstCard.Count);
                randomList.Add(lstCard[randomIndex]);
                lstCard.RemoveAt(randomIndex);
            }

            return randomList;
        }

        /// <summary>
        /// Lorsqu'un mélange à été fait, les 5 premières cartes sont défaussée
        /// </summary>
        public void removeFiveCard()
        {
            lstCard.RemoveRange(lstCard.Count - 6, 5);
        }

        /// <summary>
        /// Distribue la carte du dessus
        /// </summary>
        /// <returns></returns>
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

        public double getNbDeck()
        {
            return (Double)lstCard.Count / (Double)NB_CARD_ONE_DECK;
        }
    }
}
