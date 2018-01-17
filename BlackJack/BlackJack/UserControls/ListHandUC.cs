using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Data;

namespace BlackJack.UserControls
{
    public partial class ListHandUC : UserControl
    {
        public ListHandUC()
        {
            InitializeComponent();
        }

        public void setHands(List<HandData> lstHand)
        {
            removeHand();
            int dist = 40;
            int x = 0;
            int y = 0;
            foreach (HandData hand in lstHand)
            {
                HandUC handUC = new HandUC();
                handUC.Location = new Point(x, y);
                handUC.setCard(hand);
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
