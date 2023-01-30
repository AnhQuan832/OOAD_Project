using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_HomePage : UserControl
    {
        string positon;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public UsCtr_HomePage()
        {
            InitializeComponent();
            GetPermission();
            LoadCard();
        }

        private void GetPermission()
        {
            con.Open();
            string loadDT = "select POSITION_NAME from USERS, POSITION where USERS.USER_POSITION = POSITION.POSITION_ID and USER_ID = '" + fLogin.ID + "'";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    positon = reader["POSITION_NAME"].ToString();
                }
                reader.Close();
            }
            con.Close();
        }

        private void UsCtr_HomePage_Load(object sender, EventArgs e)
        {
        }

        private void LoadCard()
        {
            int permision = 0;
            if (positon.CompareTo("Customer") != 0)
            {
                permision = 1;
            }
            int n = 4;
            int count = 0;
            int subDisc = 0;
            UsCtr_Card[] DiscCard = new UsCtr_Card[n];
            string[] listDisc = new string[4];
            int[] discID = new int[4];
            int[] listID = new int[] { 0, 0, 0, 0 };
            con.Open();
            string loadDT = "select distinct(DISC_NAME), COMINGDISC.DISC_ID from COMINGDISC, DISC "
                + "where COMINGDISC.DISC_ID = DISC.DISC_ID";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listDisc[count] = (string)reader["DISC_NAME"];
                    discID[count] = (int)reader["DISC_ID"];
                    ++count;
                }
                reader.Close();
            }
            con.Close();

            con.Open();
            loadDT = "select COMINGDISC.DISC_ID, USER_ID from COMINGDISC,  SUBSCRIBE  "
                + "where SUBSCRIBE.DISC_ID = COMINGDISC.DISC_ID and USER_ID = " + fLogin.ID;
            cmd = new SqlCommand(loadDT, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (discID[i] == (int)reader["DISC_ID"])
                        {
                            listID[i] = 1;
                            break;
                        }
                    }
                }
                reader.Close();
            }
            con.Close();

            if (count < 4)
                for (int i = count; i < 4; i++)
                    listDisc[i] = "Coming soon";

            for (int i = 0; i < 4; i++)
            {
                DiscCard[i] = new UsCtr_Card(permision, discID[i]);
                if (listID[i] == 1)
                    DiscCard[i].SubscribedDisc();
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
