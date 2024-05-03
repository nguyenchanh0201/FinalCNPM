using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class frmPlaceOrder : Form
    {
        public frmPlaceOrder()
        {
            InitializeComponent();
        }

        private void bpayment_Click(object sender, EventArgs e)
        {
            frmPayment
                frm = new frmPayment();
            frm.ShowDialog();

        }
    }
}
