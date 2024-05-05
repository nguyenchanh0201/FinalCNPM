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

        private void button33_Click(object sender, EventArgs e)
        {
            //Close the form 
            this.Close();
        }
        void loadTable()
        {


            List<TableCard> tableCards = BLLTableCards.getTableCards();
            foreach (TableCard tc in tableCards)
            {
                Button btn = new Button();
                btn.Text = tc.getTableName();
                btn.Name = tc.getTableCardID();
                btn.Width = 153;
                btn.Height = 107;

                // Load the image from a file if available
                // btn.Image = Image.FromFile("path_to_your_image.png");

                // Or assign the image directly if it's available as a resource
                btn.Image = Properties.Resources.icons8_table_501; // Assuming the image is named icons8_table_501

                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;

                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}