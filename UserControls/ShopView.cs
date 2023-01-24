using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class ShopView : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public ShopView()
        {
            InitializeComponent();
        }

        private void ShopView_Load(object sender, EventArgs e)
        {
            LoadAllProduct("");
            AutoCompleteText();
        }

        private void AutoCompleteText()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            con.Open();
            string loadDT = "SELECT DISC_NAME FROM DISC";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    auto.Add(reader["DISC_NAME"].ToString());
                }
            }
            tbxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxSearch.AutoCompleteCustomSource = auto;
            con.Close();
        }

        private void LoadAllProduct(string discName)
        {
            int sum;
            string query;
            if (discName.CompareTo("") == 0)
            {
                sum = int.Parse(SQLConnection.GetFieldValues("select COUNT(*) from DISC"));
                query = "select DISC_ID, DISC_NAME, GENRE_NAME, DISC_PRICE " +
                "from DISC, GENRE " +
                "where DISC.DISC_GENRE = GENRE.GENRE_ID and DISC_AMOUNT > 0";
            }
            else
            {
                sum = int.Parse(SQLConnection.GetFieldValues("select COUNT(*) from DISC WHERE DISC_NAME = N'" + tbxSearch.Text.Trim() + "'"));
                query = "select DISC_ID, DISC_NAME, GENRE_NAME, DISC_PRICE " +
                "from DISC, GENRE " +
                "where DISC.DISC_GENRE = GENRE.GENRE_ID and DISC_AMOUNT > 0 and DISC_NAME = N'" + discName + "'";
            }
            if (sum == 0) return;
            ShopItem[] shopItem = new ShopItem[sum];
            int count;

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                count = 0;
                while (reader.Read())
                {
                    shopItem[count] = new ShopItem();
                    pnView.Controls.Add(shopItem[count]);

                    //Thay đổi tên SP, giá và hình ảnh trên UI theo từng hàng dữ liệu lấy được 
                    //shopItem[count].ItemImage = Image.FromFile("../../Resources/" + reader["HinhMinhHoa"].ToString());
                    shopItem[count].ItemID = (int)reader["DISC_ID"];
                    shopItem[count].ItemName = reader["DISC_NAME"].ToString();
                    shopItem[count].ItemGenre = reader["GENRE_NAME"].ToString();
                    shopItem[count].ItemPrice = string.Format("{0:#,###}đ", reader["DISC_PRICE"]) + "/h";


                    //Thiết lập vị trí của các item
                    if (count % 4 == 0)
                    {
                        if (count > 0) shopItem[count].Location = new Point(70, shopItem[count - 1].Location.Y + 380);
                        else shopItem[count].Location = new Point(70, 15);
                    }
                    else
                    {
                        shopItem[count].Location = new Point(shopItem[count - 1].Location.X + 300, shopItem[count - 1].Location.Y);
                    }
                    count++;
                }
                reader.Close();
            }
            con.Close();

        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pnView.Controls.Clear();
                LoadAllProduct(tbxSearch.Text);
                return;
            }
        }
    }
}
