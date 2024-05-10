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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }
        

        private void bPlaceOrder_Click(object sender, EventArgs e)
        {
            if (frmShift.shiftStatus == false)
            {
                MessageBox.Show("Please start the shift first");
                return;
            }
            frmPlaceOrder frm = new frmPlaceOrder();
            frm.ShowDialog();

        }

        private void bCustomer_Click(object sender, EventArgs e)
        {

        }

        private void bTable_Click(object sender, EventArgs e)
        {

        }
    }
}
