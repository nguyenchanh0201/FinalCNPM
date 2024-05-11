
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace CafeManagementSystem
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            showGRD();
        }
        public void showGRD()
        {
            ListOrder.Items.Clear();
            List<OrderDetail> orderDetails = BLLOrderDetails.GetOrderDetails("1");


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }

        private void listRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
