using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class PlayerBank : Player
    {
        public PlayerBank(Game g) : base(g)
        {

        }

        public override void play()
        {
            while(lstHand[0].Value < 17)
            {
                addCard(0);
            }      
        }

        public int getFirstCard()
        {
            return lstHand[0].getFirstCard().CardValue;
        }
    }
}
