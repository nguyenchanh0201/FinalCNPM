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
    public partial class frmPayment : Form
    {
        public static string paymentMethod;
        public frmPayment()
        {
            InitializeComponent();
            

        }
        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            paymentMethod = "momo";
            AddControls(new frmMomo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new frmCash());
            paymentMethod = "cash";
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            AddControls(new frmCash());

            lbTotal.Text = frmPlaceOrder.total.ToString();
            paymentMethod = "cash";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Write code to go back to the previous form
            this.Close();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Check if the payment is successful
            //If successful, print the bill
            //Print bills and close place order form , this form then reopen place order form
            if (paymentMethod == "cash")
            {
                //Print the bill
                MessageBox.Show("Bill printed successfully");
                //Close the form
                BLLOrderData.updatePaymentMethodAndTotal(frmPlaceOrder.orderID,paymentMethod,Convert.ToDecimal(lbTotal.Text));
                this.Close();
            }
            else if (paymentMethod == "momo")
            {
                //Print the bill
                MessageBox.Show("Bill printed successfully");
                //Close the form
                this.Close();
            }
        }
    }
}
