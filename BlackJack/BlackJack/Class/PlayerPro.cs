using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class PlayerPro : Player
    {
        public static int SABOT_TO_STAY = 5;
        public static int SABOT_TO_PLAY = 15;
        private const int SABOT_TO_PLAY2 = 18;
        private const int SABOT_TO_PLAY3 = 20;
        private const int SABOT_TO_PLAY4 = 23;
        private const int MAX_BET_STAY = 5;
        private const int MAX_BET = 10;
        private const int MAX_BET2 = 15;
        private const int MAX_BET3 = 20;
        private const int MAX_BET4 = 25;
        public bool isPlaying = true;

        public PlayerPro(Game g,PlayerBank b,int cash) : base(g,b,cash) { }
        
        public PlayerPro(int cash) : base(null, null, cash) { }

        /// <summary>
        /// La simulation de jeu d'un joueur pro
        /// </summary>
        public override void play()
        {
            if (isPlaying)
            {
                for (int i = 0; i < lstHand.Count; i++)
                {
                    testEnoughCardInHand(i);
                    int bankFirstCardValue = Bank.getFirstCardValue();
                    int handValue = lstHand[i].Value;
                    Card plaFirC = lstHand[i].getFirstCard();
                    if (equalCard(plaFirC,"A") || equalCard(plaFirC, "7") || equalCard(plaFirC, "8") || equalCard(plaFirC, "9") || handValue == 20)
                    {
                        if (bankFirstCardValue <= 7 && bankFirstCardValue > 1)
                        {
                            testSplit(i);
                            handValue = lstHand[i].Value;
                        }
                    }
                    if (Game.RealSabotValue >= SABOT_TO_STAY && handValue <= 11 && handValue >= 6)
                    {
                        if (bankFirstCardValue < 7 && bankFirstCardValue > 1)
                        {
                            doubleBet(i);
                            return;
                        }
                    }
                    while (lstHand[i].Value <= 11)
                    {
                        addCard(i);
                    }
                }
            }
        }

        /// <summary>
        /// Vérification si 2 cartes sont identiques
        /// </summary>
        /// <param name="c">La carte testée</param>
        /// <param name="lblCard">Le label d'une carte</param>
        /// <returns></returns>
        private bool equalCard(Card c, String lblCard)
        {
            return c.Equals(new Card(lblCard));
        }

        /// <summary>
        /// Mise du joueur pro
        /// </summary>
        public override void bet()
        {
            if (Game.RealSabotValue >= SABOT_TO_STAY)
            {
                isPlaying = true;
                if (setBetValue(SABOT_TO_PLAY4, MAX_BET4)) return;
                if (setBetValue(SABOT_TO_PLAY3, MAX_BET3)) return;
                if (setBetValue(SABOT_TO_PLAY2, MAX_BET2)) return;
                if (setBetValue(SABOT_TO_PLAY, MAX_BET)) return;
                if (setBetValue(SABOT_TO_STAY, MAX_BET_STAY)) return;
            }
            else
            {
                isPlaying = false;
            }
        }

        /// <summary>
        /// Mise à jour de la liste des mises
        /// </summary>
        /// <param name="sabotValue">La valeure du sabot</param>
        /// <param name="betValue">La valeur de la mise</param>
        /// <returns></returns>
        private bool setBetValue(int sabotValue,int betValue)
        {
            if (Game.RealSabotValue >= sabotValue)
            {
                lstBetValue.Add(Cash * betValue / 100);
                Cash -= Cash * betValue / 100;
                return true;
            }
            return false;
        }
    }
}
