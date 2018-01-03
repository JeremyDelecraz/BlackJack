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
    public partial class CardUC : UserControl
    {
        public CardUC()
        {
            InitializeComponent();
        }

        public void setCard(int id)
        {
            this.pbxCard.BackgroundImage = imgListCard.Images[id];
        }
    }
}
