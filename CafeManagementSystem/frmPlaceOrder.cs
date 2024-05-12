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
        public static decimal total;
        BLLOrderData bLLOrderData = new BLLOrderData("", DateTime.Now, 0, "", "", "", "", "" , "");
        public frmPlaceOrder()
        {
            InitializeComponent();
            flowLayoutPanel1.Enabled = false;

        }

        private void bpayment_Click(object sender, EventArgs e)
        {
            total = Convert.ToDecimal(lbTotal.Text);
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
                btn.Text = p.getProductName() + "\n" + p.getPrice().ToString();
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
                btn.Text = p.getProductName() + "\n" + p.getPrice().ToString();
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
            int quantity = frmDetails.quantity;
            string productID = ((Button)sender).Name;
            string price = ((Button)sender).Text.Split('\n')[1];
            string productName1 = ((Button)sender).Text.Split('\n')[0];
            BLLOrderDetails.AddOrderDetail(orderID, productID, productName1, quantity, Convert.ToDecimal(price));
            loadGRD();
            updateTotal();





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
            bLLOrderData.AddOrderData(DateTime.Now, 0, frmLogin.username, tableID, lbOrder.Text, "0", frmShift.shiftID, "Not pay yet");
            
             


            flowLayoutPanel3.Enabled = true;
            flowLayoutPanel4.Enabled = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //Create membership ( Search for customer phoneNum, then if exist add to the order, else create new one and add, else let customerID is 0 


        }

        void loadGRD()
        {
            grd.DataSource = BLLOrderDetails.GetData(orderID);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            //check if the order detail is selected or not
            if (lbID.Text == "0")
            {
                MessageBox.Show("Please select the order detail you want to edit");
                return;
            }
            frmDetails frmDetails = new frmDetails();
            frmDetails.ShowDialog();
            int quantity = frmDetails.quantity;
            int orderDetailID = Convert.ToInt32(lbID.Text);
            BLLOrderDetails.updateQuantity(orderDetailID, quantity);
            loadGRD();
            updateTotal();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            int orderDetailID = Convert.ToInt32(lbID.Text);
            //check message yes delete, no cancel
            DialogResult result = MessageBox.Show("Do you want to delete this order detail?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BLLOrderDetails.deleteOrderDetail(orderDetailID);
                loadGRD();
                updateTotal();
            }
            else
            {
                return; 
            }


                
        }

        private void grd_Click(object sender, EventArgs e)
        {
            lbID.Text = grd.CurrentRow.Cells[0].Value.ToString();
        }

        private decimal caltotal()
        {
            decimal total = 0;
            for (int i = 0; i < grd.Rows.Count; i++)
            {
                
                total += Convert.ToDecimal(grd.Rows[i].Cells[4].Value) * Convert.ToDecimal(grd.Rows[i].Cells[5].Value);
        }
            return total;
        }
        private void updateTotal()
        {
            lbTotal.Text = caltotal().ToString();
        }
    }
}