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
using DTO;

namespace CafeManagementSystem
{
    public partial class frmEditOrder : Form
    {
        public frmEditOrder()
        {
            InitializeComponent();
            
            AddOrderBinding();
            txtOrderID.Enabled = false;
            txtOrderDate.Enabled = false;
            txtTotal.Enabled = false;         

        }
        void loadListOrder()
        {
            grd.DataSource = BLLOrderData.select();
        }
        void AddOrderBinding()
        {
            txtOrderID.DataBindings.Add(new Binding("Text", grd.DataSource, "orderID"));
            txtOrderDate.DataBindings.Add(new Binding("Text", grd.DataSource, "orderDate"));
            txtTotal.DataBindings.Add(new Binding("Text", grd.DataSource, "total"));
            txtUserName.DataBindings.Add(new Binding("Text", grd.DataSource, "username"));
            txtTableID.DataBindings.Add(new Binding("Text", grd.DataSource, "tableID"));
            txtOrderType.DataBindings.Add(new Binding("Text", grd.DataSource, "orderType"));
            txtCustomerID.DataBindings.Add(new Binding("Text", grd.DataSource, "customerID"));
            txtShiftID.DataBindings.Add(new Binding("Text", grd.DataSource, "shiftID"));
            txtPaymentMethod.DataBindings.Add(new Binding("Text", grd.DataSource, "paymentMethod"));

        }

        private void Update_Click(object sender, EventArgs e)
        {
            String orderID = txtOrderID.Text;
            DateTime orderDate = DateTime.Now;
            string orderDateString = orderDate.ToString();
            decimal total = decimal.Parse(txtTotal.Text);
            String username = txtUserName.Text;
            String tableID = txtTableID.Text;
            String orderType = txtOrderType.Text;
            String customerID = txtCustomerID.Text;
            String shiftID = txtShiftID.Text;
            String paymentMethod = txtPaymentMethod.Text;
            BLLOrderData.update(orderID, orderDate, total, username, tableID, orderType, customerID, shiftID,paymentMethod);
            MessageBox.Show("Update success");
            grd.Refresh();
            loadListOrder();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string orderID = txtOrderID.Text;
            //YesNo Message
            DialogResult result = MessageBox.Show("Do you want to delete this order?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            BLLOrderData.delete(orderID);
            MessageBox.Show("Delete success");
            grd.Refresh();
            loadListOrder();
        }
    }
}
