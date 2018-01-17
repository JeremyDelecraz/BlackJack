using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    public class PlayerBank : Player
    {
        public PlayerBank(Table g) : base(g)
        {

        }

        /// <summary>
        /// La simulation d'une banque
        /// </summary>
        public override void play()
        {
            while(LstHand[0].Value < 17)
            {
                addCard(0);
            }      
        }

        public int getFirstCardValue()
        {
            return LstHand[0].getFirstCard().CardValue;
        }

        public Card getFirstCard()
        {
            return LstHand[0].getFirstCard();
        }
    }
}
