using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.UserControls
{
    public partial class ListHandUC : UserControl
    {
        public ListHandUC()
        {
            InitializeComponent();
        }

        public void setHands(List<int> lstValue, List<int> lstNbCard)
        {
            removeHand();
            int dist = 40;
            int x = 0;
            int y = 0;
            int index = 0;
            foreach (int value in lstValue)
            {
                HandUC handUC = new HandUC();
                handUC.Location = new Point(x, y);
                handUC.setCard(value,lstNbCard[index++]);
                Controls.Add(handUC);
                x += dist;
            }
        }

        private void removeHand()
        {
            Controls.Clear();
        }
    }
}
