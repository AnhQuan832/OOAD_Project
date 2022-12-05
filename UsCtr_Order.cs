using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Order : UserControl
    {
        public UsCtr_Order()
        {
            InitializeComponent();
        }

        private void UsCtr_Order_Load(object sender, EventArgs e)
        {
            this.dgvOrder.Rows.Add("0001", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Not Return");
            this.dgvOrder.Rows.Add("0002", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Completed");
            this.dgvOrder.Rows.Add("0003", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Ordering");
            this.dgvOrder.Rows.Add("0004", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Not Return");
            this.dgvOrder.Rows.Add("0005", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Not Return");
        }
    }
}
