using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Class;
using BlackJack.UserControls;

namespace BlackJack
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FrmData pie = new FrmData();
            FrmGame frmGame = new FrmGame((int)nupNbDeck.Value, (int)nupNbPlayer.Value, (int)nupNbTurn.Value, (int)nupNbTable.Value, (int)nupCash.Value,pie);
            frmGame.Show();
        }
    }
}
