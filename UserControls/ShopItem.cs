using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace OOAD_Project
{
    public partial class ShopItem : UserControl
    {
        FireBaseConnection fireBaseConnection = new FireBaseConnection();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);

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
        int itemID;
        public ShopItem(int ID)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            fireBaseConnection.RetrieveImage(pbDisc, "Disc/" + ID);

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

        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (CheckExistingDisc())
            {
                AddExistingDisc();
            }
            else
            {
                AddNewDisc();
            }
            UpdateAmount();
        }

        private void UpdateAmount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update DISC set DISC_INSTOCK = DISC_INSTOCK - 1 where DISC_ID = " + ItemID, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void AddNewDisc()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CART_DETAIL (USER_ID, DISC_ID, AMOUNT) " +
                                            "values (" + fLogin.ID + ", " + itemID + ", " + 1 + ") ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added to cart", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void AddExistingDisc()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update CART_DETAIL set AMOUNT = AMOUNT + " + 1 +
                                            " where USER_ID = " + fLogin.ID + " and DISC_ID = " + ItemID, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added to cart", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private bool CheckExistingDisc()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from CART_DETAIL where USER_ID = " + fLogin.ID + " and DISC_ID = " + ItemID, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                con.Close();
                return true;
            }
            dr.Close();
            con.Close();
            return false;
        }
    }
}
