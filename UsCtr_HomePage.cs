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
        }

        private void UsCtr_HomePage_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void LoadCards()
        {
            int n = 4;
            UsCtr_Card[] cards = new UsCtr_Card[n];

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new UsCtr_Card();
                pnCardView.Controls.Add(cards[i]);

                cards[i].ItemName = "Shogun";

                if (i == 0) cards[i].Location = new Point(30, 15);
                else cards[i].Location = new Point(cards[i - 1].Location.X + 300, 15);

            }
        }
    }
}
