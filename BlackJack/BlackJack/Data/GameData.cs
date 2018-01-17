using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Data
{
    public class GameData
    {
        public List<TurnData> LstTurnData { get; set; } = new List<TurnData>();

        public GameData()
        {
        }

        public void addTurnData(TurnData turnData)
        {
            LstTurnData.Add(turnData);
        }
    }
}
