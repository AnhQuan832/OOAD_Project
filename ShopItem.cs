using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace OOAD_Project
{
    public partial class ShopItem : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public ShopItem()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public Image ItemImage
        {
            get { return pbDisc.Image; }
            set
            {
                pbDisc.Image = value;
            }
        }

        public PictureBoxSizeMode ItemImageLayout
        {
            get { return pbDisc.SizeMode; }
            set { pbDisc.SizeMode = value; }

        }

        public string ItemName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public string ItemGenre
        {
            get { return lbGenre.Text; }
            set { lbGenre.Text = value; }
        }

        public string ItemPrice
        {
            get { return lbPrice.Text; }
            set { lbPrice.Text = value; }
        }




    }
}
