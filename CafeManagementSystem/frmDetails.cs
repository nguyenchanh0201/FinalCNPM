using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL; 

namespace CafeManagementSystem
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            string orderID = frmPlaceOrder.orderID; 
            
        }
    }
}
