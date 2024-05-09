using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {

        private string productID;
        private string productName;
        private string categoryID;
        private decimal price;
        private string status;

        public Product(string productID, string productName, string categoryID, decimal price, string status)
        {
            this.productID = productID;
            this.productName = productName;
            this.categoryID = categoryID;
            this.price = price;
            this.status = status;
        }

        public string getProductID()
        {
            return productID;
        }

        public string getProductName()
        {
            return productName;
        }

        public string getCategoryID()
        {
            return categoryID;
        }

        public decimal getPrice()
        {
            return price;
        }

        public string getStatus()
        {
            if (status == "1")
            {
                status = "Active";
            }
            else
            {
                status = "Inactive";
            }
            return status;
        }

        public Product(System.Data.DataRow dr)
        {
            this.productID = dr["PID"].ToString();
            this.productName = dr["PName"].ToString();
            this.categoryID = dr["CateID"].ToString();
            this.price = decimal.Parse(dr["Price"].ToString());
            this.status = dr["Status"].ToString();
        }
    }
}
