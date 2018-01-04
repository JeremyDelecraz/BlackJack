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

        public void setCard(List<int> lstIndexImage,int value)
        {
            int x = 0;
            int y = 12;
            int dist = 6;
            for (int i = 0; i < lstIndexImage.Count; i++)
            {
                displayOneCard(x + i * dist, y, lstIndexImage[i]);
            }
            lblHandValue.Text = value.ToString();
        }

        private void displayOneCard(int x, int y, int idCard)
        {
            CardUC cardUC = new CardUC();
            cardUC.setCard(idCard);
            cardUC.Location = new Point(x, y);
            this.Controls.Add(cardUC);
        }
    }
}
