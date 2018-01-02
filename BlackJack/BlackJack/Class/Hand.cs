using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Hand
    {
        private List<Card> lstCard = new List<Card>();

        public int Value { get; set; } = 0;

        public Hand()
        {

        }

        public Hand(Card c)
        {
            addCard(c);
        }

        /// <summary>
        /// Ajoute une carte à la main
        /// </summary>
        /// <param name="newCard">La carte à ajouter</param>
        public void addCard(Card newCard)
        {
            lstCard.Add(newCard);
            Value += newCard.CardValue;
            if (Value > 21) {
                testAs();
           }
        }

        /// <summary>
        /// Retire et retourne la dernière carte
        /// </summary>
        /// <returns></returns>
        public Card removeLastCard()
        {
            Card c = this.lstCard[lstCard.Count - 1];
            this.lstCard.RemoveAt(lstCard.Count - 1);
            return c;
        }

        /// <summary>
        /// Vérifie si y a un As dans la main et le transforme en 1
        /// </summary>
        private void testAs()
        {
            for (int i = 0; i < lstCard.Count; i++)
            {
                if(lstCard[i].Equals(new Card("A")) && lstCard[i].CardValue == 11)
                {
                    lstCard[i].CardValue = lstCard[i].SecondValue;
                    Value -= 10;  
                    break;
                }
            }
        }

        /// <summary>
        /// Retoure la première carte de la main
        /// </summary>
        /// <returns></returns>
        public Card getFirstCard()
        {
            return lstCard[0];
        }

        /// <summary>
        /// Vérification si la main à uniquement 2 carte identique 
        /// </summary>
        /// <returns></returns>
        public bool isSameCard()
        {
            return lstCard[0].Equals(lstCard[1]) && lstCard.Count == 2;
        }
        
        public int getNbCard()
        {
            return lstCard.Count;
        }
    }
}
