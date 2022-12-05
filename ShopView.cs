using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class ShopView : UserControl
    {
        public ShopView()
        {
            InitializeComponent();
        }

        private void ShopView_Load(object sender, EventArgs e)
        {
            LoadAllProduct();
        }

        private void LoadAllProduct()
        {
            int n = 10;
            ShopItem[] shopItem = new ShopItem[n];

            for (int i = 0; i < shopItem.Length; i++)
            {
                shopItem[i] = new ShopItem();
                pnView.Controls.Add(shopItem[i]);

                shopItem[i].ItemImage = Properties.Resources.film_poster;
                shopItem[i].ItemImageLayout = PictureBoxSizeMode.StretchImage;
                shopItem[i].ItemName = "Shogun";
                shopItem[i].ItemGenre = "Inazuma";
                shopItem[i].ItemPrice = "100.000";
                if (i % 4 == 0)
                {
                    if (i > 0) shopItem[i].Location = new Point(70, shopItem[i - 1].Location.Y + 380);
                    else shopItem[i].Location = new Point(70, 15);
                }
                else
                {
                    shopItem[i].Location = new Point(shopItem[i - 1].Location.X + 300, shopItem[i - 1].Location.Y);
                }
            }

        }
    }
}
