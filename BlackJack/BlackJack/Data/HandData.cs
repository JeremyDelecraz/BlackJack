using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Data
{
    class HandData
    {
        public int Value { get; set; }
        public int Nbcard { get; set; }

        public HandData(int value,int nbCard)
        {
            Value = value;
            Nbcard = nbCard;
        }
    }
}
