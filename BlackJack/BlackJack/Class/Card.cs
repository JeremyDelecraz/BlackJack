using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Card
    {
        public string Label { get; set; }
        public int CardValue { get; set; }
        public int SecondValue { get; set; }
        public int SabotValue { get; set; }
        public int IndexImage { get; set; }

        public Card(string label, int sabotValue, int firstValue,int indexImage)
        {
            Label = label;
            CardValue = firstValue;
            SabotValue = sabotValue;
            IndexImage = indexImage;
        }

        public Card(string label) : this(label,0,0,0)
        {
        }

        public override bool Equals(Object c)
        {
            return Label.Equals(((Card)c).Label);
        }
    }
}
