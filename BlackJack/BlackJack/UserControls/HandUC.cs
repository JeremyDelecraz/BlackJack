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
    public partial class HandUC : UserControl
    {
        public HandUC()
        {
            InitializeComponent();
        }

        public void setCard(HandData hand)
        {
            lblHandValue.Text = hand.Value.ToString();
            if (hand.Value == 21 && hand.Nbcard == 2) { BackColor = Color.ForestGreen; }
        }
    }
}
