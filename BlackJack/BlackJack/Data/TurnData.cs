using BlackJack.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Data
{
    class TurnData
    {
        public List<TableData> LstTable { get; set; } = new List<TableData>();
        public PlayerData PlayerPro { get; set; } = null;

        public TurnData() { }

        public void addTableData(TableData tableData)
        {
            LstTable.Add(tableData);
        }
        
        public void setPlayerPro(PlayerPro playerPro)
        {
            PlayerPro = new PlayerData(playerPro.Cash, playerPro.NbWin, playerPro.NbEqual, playerPro.NbLose, playerPro.LstHand);
        }
    }
}
