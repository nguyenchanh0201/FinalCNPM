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
        String tableID;
        public static string orderID;
        BLLOrderData bLLOrderData = new BLLOrderData("", DateTime.Now, 0, "", "", "", "", "" , "");
        public frmPlaceOrder()
        {
            InitializeComponent();
            flowLayoutPanel1.Enabled = false;

        }

        private void bpayment_Click(object sender, EventArgs e)
        {
            //
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


                btn.Image = Properties.Resources.icons8_table_501;

                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                //Create event handler for each button
                btn.Click += new EventHandler((sender, e) => btnTable_Click(sender, e, tc.getTableName()));
                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {
            loadTable();
            LoadCategory();
            flowLayoutPanel3.Enabled = false;
            flowLayoutPanel4.Enabled = false;
            LoadProduct();
            bNewOrder.Enabled = false;


        }

        private void button19_Click(object sender, EventArgs e)
        {
            lbOrder.Text = "Take Away";
            flowLayoutPanel1.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            lbOrder.Text = "Dine-in";
            flowLayoutPanel1.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lbOrder.Text = "Shipping";
            flowLayoutPanel1.Enabled = true;
        }

        private void btnTable_Click(object sender, EventArgs e, string tableName)
        {
            lbTable.Text = tableName;
            tableID = ((Button)sender).Name;
            bNewOrder.Enabled = true;


        }

        void LoadCategory()
        {

            List<ProductCategory> categories = BLLCategories.getCategory();
            foreach (ProductCategory c in categories)
            {
                Button btn = new Button();
                btn.Text = c.getCategoryName();
                btn.Name = c.getCategoryID();
                btn.Width = 159;
                btn.Height = 156;
                btn.Click += new EventHandler((sender, e) => btnCategory_Click(sender, e));
                flowLayoutPanel3.Controls.Add(btn);
            }

        }

        void LoadProduct()
        {
            List<Product> products = BLLProducts.GetProducts();
            foreach (Product p in products)
            {
                Button btn = new Button();
                btn.Text = p.getProductName();
                btn.Name = p.getProductID();
                btn.Width = 159;
                btn.Height = 156;
                btn.Click += new EventHandler((sender, e) => btnProduct_Click(sender, e, p.getProductName()));
                flowLayoutPanel4.Controls.Add(btn);
            }
        }

        void LoadProductByCategory(string categoryname)
        {
            List<Product> products = BLLProducts.GetProductsByCategory(categoryname);
            foreach (Product p in products)
            {
                Button btn = new Button();
                btn.Text = p.getProductName();
                btn.Name = p.getProductID();
                btn.Width = 159;
                btn.Height = 156;
                btn.Click += new EventHandler((sender, e) => btnProduct_Click(sender, e, p.getProductName()));
                flowLayoutPanel4.Controls.Add(btn);
            }
        }

        private void btnProduct_Click(object sender, EventArgs e, string productName)
        {
            
            frmDetails frmDetails = new frmDetails();
            frmDetails.ShowDialog();

        }



        private void btnCategory_Click(object sender, EventArgs e)
        {

            flowLayoutPanel4.Controls.Clear();
            //get the name of the button 
            string categoryname = ((Button)sender).Text;



            LoadProductByCategory(categoryname);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            lbOrderID.Text = bLLOrderData.createOrderID();
            orderID = lbOrderID.Text;
            bLLOrderData.AddOrderData(DateTime.Now, 0, frmLogin.username, tableID, lbOrder.Text, "0", frmShift.shiftID, "");
            
             


            flowLayoutPanel3.Enabled = true;
            flowLayoutPanel4.Enabled = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //Create membership ( Search for customer phoneNum, then if exist add to the order, else create new one and add, else let customerID is 0 

            frmMembership frmMembership = new frmMembership();
            frmMembership.ShowDialog();

        }
    }
}