using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Card
    {
        private string label;
        private int cardValue;
        private int secondValue;
        private int sabotValue;

        public string Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
            }
        }
        public int CardValue
        {
            get
            {
                return cardValue;
            }

            set
            {
                cardValue = value;
            }
        }
        public int SecondValue
        {
            get
            {
                return secondValue;
            }

            set
            {
                secondValue = value;
            }
        }
        public int SabotValue
        {
            get
            {
                return sabotValue;
            }

            set
            {
                sabotValue = value;
            }
        }

        public Card(string label,int firstValue, int sabotValue)
        {
            this.Label = label;
            this.CardValue = firstValue;
            this.SabotValue = sabotValue;
        }

        public Card(string label,int sabotValue)
        {
            this.label = label;
            this.sabotValue = sabotValue;
        }

        public override bool Equals(Object c)
        {
            return this.cardValue == ((Card)c).cardValue && this.label.Equals(((Card)c).Label);
        }
    }
}
