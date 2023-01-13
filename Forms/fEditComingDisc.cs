using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project.Forms
{
    public partial class fEditComingDisc : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public fEditComingDisc(string discName, string picture)
        {
            InitializeComponent();
            cbDiscName.Items.Add(discName);
            cbDiscName.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnReady_Click(object sender, System.EventArgs e)
        {
        }
    }
}
