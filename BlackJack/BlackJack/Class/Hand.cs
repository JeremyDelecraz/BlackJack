using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Hand
    {
        public const int MAX_HAND_VALUE = 21;
        private List<Card> lstCard = new List<Card>();
        private int value = 0;
        
        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Hand()
        {

        }

        public Hand(Card c)
        {
            addCard(c);
        }

        public void addCard(Card c)
        {
            lstCard.Add(c);
            this.value += c.CardValue;
            if (Value > 21) {
                testAs();
           }
        }

        public Card removeLastCard()
        {
            Card c = this.lstCard[lstCard.Count - 1];
            this.lstCard.RemoveAt(lstCard.Count - 1);
            return c;
        }

        public void reset()
        {
            lstCard.Clear();
            this.value = 0;
        }

        private void testAs()
        {
            for (int i = 0; i < lstCard.Count; i++)
            {
                if(lstCard[i].Equals(new Card("A",11)))
                {
                    lstCard[i].CardValue = lstCard[i].SecondValue;
                    this.value -= 10;  
                    break;
                }
            }
        }

        public Card getFirstCard()
        {
            return lstCard[0];
        }

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
