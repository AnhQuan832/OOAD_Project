using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_RentingDetail : UserControl
    {
        int ID;
        public UsCtr_RentingDetail(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void UsCtr_RentingDetail_Load(object sender, System.EventArgs e)
        {

        }
    }
}
