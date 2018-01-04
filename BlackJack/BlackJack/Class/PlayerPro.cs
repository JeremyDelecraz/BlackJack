using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class PlayerPro : Player
    {
        public static int SABOT_TO_STAY = 3;
        public static int SABOT_TO_PLAY = 10;
        private const int SABOT_TO_PLAY2 = 13;
        private const int SABOT_TO_PLAY3 = 15;
        private const int SABOT_TO_PLAY4 = 17;
        private const int MAX_BET_STAY = 2;
        private const int MAX_BET = 6;
        private const int MAX_BET2 = 10;
        private const int MAX_BET3 = 15;
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
                int bFirCaValue = Bank.getFirstCardValue();
                insurance();
                for (int i = 0; i < LstHand.Count; i++)
                {
                    testEnoughCardInHand(i);
                    int handValue = LstHand[i].Value;
                    Card plaFirC = LstHand[i].getFirstCard();
                    if (GameTable.RealSabotValue >= SABOT_TO_PLAY && (equalCard(plaFirC,"A") || equalCard(plaFirC, "6") || equalCard(plaFirC, "7") || equalCard(plaFirC, "8") || equalCard(plaFirC, "9") || handValue == 20))
                    {
                        if (bFirCaValue < 7 && bFirCaValue > 3)
                        {
                            testSplit(i);
                            handValue = LstHand[i].Value;
                        }
                    }
                    if (GameTable.RealSabotValue >= SABOT_TO_PLAY && handValue <= 11 && handValue > 6)
                    {
                        if (bFirCaValue < 7 && bFirCaValue > 3)
                        {
                            doubleBet(i);
                            return;
                        }
                    }
                    while (LstHand[i].Value <= 11)
                    {
                        addCard(i);
                    }
                }
            }
        }

        /// <summary>
        /// Lorsque la première carte du banquier est un As, toujours prendre une assurance
        /// </summary>
        private void insurance()
        {
            if (GameTable.RealSabotValue >= SABOT_TO_STAY)
            {
                Card bFirCard = Bank.getFirstCard();
                TakingInsurance = equalCard(bFirCard, "A");
                if (TakingInsurance)
                {
                    BetValueInsurance = lstBetValue[0] / 2;
                    Cash -= BetValueInsurance;
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
            if (GameTable.RealSabotValue >= SABOT_TO_PLAY)
            {
                isPlaying = true;
                /*if (setBetValue(SABOT_TO_PLAY4, MAX_BET4)) return;
                if (setBetValue(SABOT_TO_PLAY3, MAX_BET3)) return;
                if (setBetValue(SABOT_TO_PLAY2, MAX_BET2)) return;*/
                if (setBetValue(SABOT_TO_PLAY, MAX_BET4)) return;
                //if (setBetValue(SABOT_TO_STAY, MAX_BET_STAY)) return;
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
            if (GameTable.RealSabotValue >= sabotValue)
            {
                lstBetValue.Add(Cash * betValue / 100);
                Cash -= Cash * betValue / 100;
                return true;
            }
            return false;
        }
    }
}
