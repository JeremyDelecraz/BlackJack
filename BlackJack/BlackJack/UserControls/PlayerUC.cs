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
    public partial class PlayerUC : UserControl
    {
        public PlayerUC()
        {
            InitializeComponent();
        }

        public void setPlayer(PlayerData playerData,int idProfImage, string namePlayer)
        {
            lblCashValue.Text = playerData.Cash.ToString();
            lblNamePlayer.Text = namePlayer;
            pbxProfil.BackgroundImage = lstImageProfil.Images[idProfImage];
            lstHandUC.setHands(playerData.LstHand);
        }
    }
}
