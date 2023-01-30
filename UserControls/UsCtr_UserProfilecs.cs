using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_UserProfilecs : UserControl
    {
        FireBaseConnection fireBaseConnection = new FireBaseConnection();

        public UsCtr_UserProfilecs()
        {
            InitializeComponent();

            TestConnectFireBase();
            RetrieveAvatar();
        }

        private void RetrieveAvatar()
        {
            fireBaseConnection.RetrieveImage(avatarImgBox, "Avatar/" + fLogin.ID);
        }

        private void TestConnectFireBase()
        {
            if (fireBaseConnection.client != null)
            {
                MessageBox.Show("Firebase connected!");
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose image";
            ofd.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                avatarImgBox.Image = img.GetThumbnailImage(360, 200, null, new IntPtr());

                fireBaseConnection.PushImage(avatarImgBox, "Avatar/" + fLogin.ID);
                fireBaseConnection.RetrieveImage(avatarImgBox, "Avatar/" + fLogin.ID);
            }
        }
    }
}
