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

        public void setHands(List<List<int>> lstHandIndexImage,List<int> lstValue)
        {
            removeHand();
            int dist = 90;
            int x = 0;
            int y = -2;
            int index = 0;
            foreach (List<int> lstIndexImage in lstHandIndexImage)
            {
                HandUC handUC = new HandUC();
                handUC.Location = new Point(x, y);
                handUC.setCard(lstIndexImage,lstValue[index++]);
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
