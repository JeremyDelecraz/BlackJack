using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    public class PlayerPro : Player
    {
        public static int SABOT_TO_STAY = 2;
        public static int SABOT_TO_PLAY = 5;
        private const int SABOT_TO_PLAY2 = 7;
        private const int SABOT_TO_PLAY3 = 13;
        private const int SABOT_TO_PLAY4 = 16;
        private const int MAX_BET_STAY = 2;
        private const int MAX_BET = 6;
        private const int MAX_BET2 = 10;
        private const int MAX_BET3 = 15;
        private const int MAX_BET4 = 25;
        public bool isPlaying = true;

        public PlayerPro(Table g,PlayerBank b,int cash) : base(g,b,cash) { }
        
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
                if (BetValueInsurance == 0)
                {
                    for (int i = 0; i < LstHand.Count; i++)
                    {
                        playEachHand(i, bFirCaValue);
                    }
                }
            }
        }

        /// <summary>
        /// Ce que fait le joueur pro pour chaque main
        /// </summary>
        /// <param name="i"></param>
        /// <param name="bFirCaValue"></param>
        private void playEachHand(int i,int bFirCaValue)
        {
            testEnoughCardInHand(i);
            int handValue = split(LstHand[i].getFirstCard(), bFirCaValue, i);
            if (handValue >= 17 && handValue <= 21)
            {
                return;
            }
            if (handValue >= 9 && handValue <= 11 && bFirCaValue >= 2 && bFirCaValue <= 6)
            {
                doubleBet(i);
                return;
            }
            if (handValue >= 12 && handValue <= 16)
            {
                if (bFirCaValue > 6)
                    addCard(i);
                else
                {
                    if (LstHand[i].testContains(new Card("A")))
                    {
                        addCard(i);
                    }
                }
            }
            while (LstHand[i].Value <= 11)
            {
                addCard(i);
            }
        }

        /// <summary>
        /// Split sous certaines conditions
        /// </summary>
        /// <param name="plaFirC"></param>
        /// <param name="bFirCaValue"></param>
        /// <param name="idHand"></param>
        /// <returns></returns>
        private int split(Card plaFirC,int bFirCaValue,int idHand)
        {
            if (equalCard(plaFirC, "A") && bFirCaValue < 7)
            {
                testSplit(idHand);
                return LstHand[idHand].Value;
            }
            if (equalCard(plaFirC, "8") && bFirCaValue < 8 && bFirCaValue > 2)
            {
                testSplit(idHand);
                return LstHand[idHand].Value;
            }
            if (equalCard(plaFirC, "9") && bFirCaValue < 6 && bFirCaValue > 2)
            {
                testSplit(idHand);
                return LstHand[idHand].Value;
            }
            if(bFirCaValue >= 2 && bFirCaValue <= 6)
            {
                if (equalCard(plaFirC, "2"))
                {
                    testSplit(idHand);
                    return LstHand[idHand].Value;
                }
                if (equalCard(plaFirC, "3"))
                {
                    testSplit(idHand);
                    return LstHand[idHand].Value;
                }
                if (equalCard(plaFirC, "4"))
                {
                    testSplit(idHand);
                    return LstHand[idHand].Value;
                }
            }
            return LstHand[idHand].Value;
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
                if (TakingInsurance && LstHand[0].Value < 21)
                {
                    BetValueInsurance = lstBetValue[0] / 2;
                    Cash -= BetValueInsurance;
                    return;
                }
            }
            BetValueInsurance = 0;
            return;
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
            if (GameTable.RealSabotValue >= SABOT_TO_STAY)
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
