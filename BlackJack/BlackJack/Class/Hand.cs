using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    public class Hand
    {
        public List<Card> LstCard { get; private set; } = new List<Card>();

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
            LstCard.Add(newCard);
            Value += newCard.CardValue;
            if (Value > 21) {
                testAs();
           }
        }

        /// <summary>
        /// Retire et retourne la dernière carte
        /// </summary>
        /// <returns></returns>
        public Card removeAndGetLastCard()
        {
            Card c = this.LstCard[LstCard.Count - 1];
            this.LstCard.RemoveAt(LstCard.Count - 1);
            return c;
        }

        /// <summary>
        /// Vérifie si y a un As dans la main et le transforme en 1
        /// </summary>
        private void testAs()
        {
            for (int i = 0; i < LstCard.Count; i++)
            {
                if(LstCard[i].Equals(new Card("A")) && LstCard[i].CardValue == 11)
                {
                    LstCard[i].CardValue = LstCard[i].SecondValue;
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
            return LstCard[0];
        }

        /// <summary>
        /// Vérification si la main à uniquement 2 carte identique 
        /// </summary>
        /// <returns></returns>
        public bool isSameCard()
        {
            return LstCard[0].Equals(LstCard[1]) && LstCard.Count == 2;
        }
        
        public int getNbCard()
        {
            return LstCard.Count;
        }

        public bool testContains(Card c)
        {
            for (int i = 0; i < LstCard.Count; i++)
            {
                if (LstCard[i].Equals(c)) return true;
            }
            return false;
        }
    }
}
