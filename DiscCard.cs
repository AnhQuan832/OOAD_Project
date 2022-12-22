using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class DiscCard : UserControl
    {
        bool isSubscribe = false;

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

        public DiscCard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadButtonText();

        }

        public string ItemName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public Image ItemImage
        {
            get { return pbDisc.Image; }
            set
            {
                pbDisc.Image = value;
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            isSubscribe = !isSubscribe;
            LoadButtonText();
        }

        private void LoadButtonText()
        {
            if (isSubscribe)
            {
                btnSubscribe.Text = "UnSubscribe";
            }
            else
            {
                btnSubscribe.Text = "Subscribe";
            }
        }
    }
}
