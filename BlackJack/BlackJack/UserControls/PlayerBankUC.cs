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
    public partial class PlayerBankUC : UserControl
    {
        private HandUC handUC = null;
        public PlayerBankUC()
        {
            InitializeComponent();
        }

        public void setHand(List<int> lstIndexImage, int value)
        {
            removeHand();
            handUC = new HandUC();
            handUC.Location = new Point(0, 19);
            handUC.setCard(lstIndexImage,value);
            Controls.Add(handUC);
        }

        private void removeHand()
        {
            if (handUC != null)
                Controls.Remove(handUC);
        }
    }
}
