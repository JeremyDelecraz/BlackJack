using BlackJack.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Data
{
    public class HandData
    {
        public int Value { get; set; }
        public int Nbcard { get; set; }

        public HandData(Hand hand)
        {
            Value = hand.Value;
            Nbcard = hand.getNbCard();
        }
    }
}
