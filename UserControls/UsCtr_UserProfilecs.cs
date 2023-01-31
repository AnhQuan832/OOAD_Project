using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_UserProfilecs : UserControl
    {
        FireBaseConnection fireBaseConnection = new FireBaseConnection();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public UsCtr_UserProfilecs()
        {
            InitializeComponent();
            LoadData();
            RetrieveAvatar();
        }

        private void LoadData()
        {
            con.Open();
            string loadDT = "select USER_FULLNAME, USER_MAIL, USER_ID_NUMBER, USER_ADDRESS " +
                            "from USERS where USER_ID = " + fLogin.ID;
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbName.Text = (string)reader["USER_FULLNAME"];
                    tbEmail.Text = (string)reader["USER_MAIL"];
                    tbID.Text = (string)reader["USER_ID_NUMBER"];
                    tbAddress.Text = (string)reader["USER_ADDRESS"];
                }
                reader.Close();
            }
            con.Close();
            RetrieveAvatar();
        }

        private void RetrieveAvatar()
        {
            fireBaseConnection.RetrieveImage(avatarImgBox, "Avatar/" + fLogin.ID);
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


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbEmail.Text == "" || tbID.Text == "" || tbAddress.Text == "")
            {
                message.Caption = "Please fill out information";
                message.Show();
            }
            else
            {
                con.Open();
                string update = "update USERS set USER_FULLNAME = '" + tbName.Text.Trim() + "', USER_MAIL = '" + tbEmail.Text.Trim() +
                    "', USER_ID_NUMBER = " + tbID.Text.Trim() + ", USER_ADDRESS = '" + tbAddress.Text.Trim() + "' where USER_ID = " + fLogin.ID;
                cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                con.Close();

                message.Caption = "Update successfully";
                message.Show();
                fireBaseConnection.PushImage(avatarImgBox, "Avatar/" + fLogin.ID);
                LoadData();
            }
        }



        private void btnChangepass_Click(object sender, EventArgs e)
        {
            fChangePassword fChangePassword = new fChangePassword();
            fChangePassword.ShowDialog();
        }
    }
}
