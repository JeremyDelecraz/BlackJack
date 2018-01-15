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
    public partial class HandUC : UserControl
    {
        public HandUC()
        {
            InitializeComponent();
        }

        public void setCard(int value,int nbCard)
        {
            lblHandValue.Text = value.ToString();
            if (value == 21 && nbCard == 2) { BackColor = Color.ForestGreen; }
        }
    }
}
