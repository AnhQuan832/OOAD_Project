using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_HomePage : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
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
            int count = 0;
            UsCtr_Card[] DiscCard = new UsCtr_Card[n];
            string[] listDisc = new string[4];
            con.Open();
            string loadDT = "select distinct(DISC_NAME) from COMINGDISC, DISC where COMINGDISC.DISC_ID = DISC.DISC_ID";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listDisc[count] = (string)reader["DISC_NAME"];
                    ++count;
                }
                reader.Close();
            }
            con.Close();

            if (count < 4)
                for (int i = count; i < 4; i++)
                    listDisc[i] = "Coming soon";

            for (int i = 0; i < 4; i++)
            {
                DiscCard[i] = new UsCtr_Card(1);
                pnCardView.Controls.Add(DiscCard[i]);

                //DiscCard[i].ItemImage = Properties.Resources.film_poster;
                DiscCard[i].ItemName = listDisc[i];
                if (DiscCard[i].ItemName.CompareTo("Coming soon") == 0)
                    DiscCard[i].DisableButton();
                if (i == 0)
                    DiscCard[i].Location = new Point(25, 100);
                else
                    DiscCard[i].Location = new Point(DiscCard[i - 1].Location.X + 300, 100);
            }
        }
    }
}
