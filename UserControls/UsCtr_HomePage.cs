using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_HomePage : UserControl
    {
        public UsCtr_HomePage()
        {
            InitializeComponent();
            LoadCard();
        }

        private void UsCtr_HomePage_Load(object sender, EventArgs e)
        {
        }

        private void LoadCard()
        {
            int n = 4;
            UsCtr_Card[] DiscCard = new UsCtr_Card[n];

            for (int i = 0; i < DiscCard.Length; i++)
            {
                DiscCard[i] = new UsCtr_Card(1);
                pnCardView.Controls.Add(DiscCard[i]);

                DiscCard[i].ItemImage = Properties.Resources.film_poster;
                DiscCard[i].ItemName = "Shogun";
                if (i == 0)
                    DiscCard[i].Location = new Point(25, 100);
                else
                    DiscCard[i].Location = new Point(DiscCard[i - 1].Location.X + 300, 100);
            }
        }
    }
}
