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
    public partial class PlayerUC : UserControl
    {
        public PlayerUC()
        {
            InitializeComponent();
        }

        public void setPlayer(List<int> lstValue, List<int> lstNbCard, int cash,int idProfImage, string namePlayer)
        {
            lblCashValue.Text = cash.ToString();
            lblNamePlayer.Text = namePlayer;
            pbxProfil.BackgroundImage = lstImageProfil.Images[idProfImage];
            lstHandUC.setHands(lstValue, lstNbCard);
        }
    }
}
