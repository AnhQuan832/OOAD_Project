using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Card : UserControl
    {
        bool isRegist = false;
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

        public Image ItemImage
        {
            get { return pbDisc.Image; }
            set
            {
                pbDisc.Image = value;
            }
        }

        public string ItemName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public UsCtr_Card()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadButton(isRegist);
        }

        private void LoadButton(bool isRegist)
        {
            if (isRegist == false)
            {
                btnRegist.Text = "Regist";
            }
            else
            {
                btnRegist.Text = "Unregist";
            }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            isRegist = !isRegist;
            LoadButton(isRegist);
        }


    }
}
