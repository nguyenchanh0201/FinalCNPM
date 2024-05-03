using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {

        private int productID;
        private string productName;
        private int categoryID;
        private float price;
        private string status;

        public Product(int productID, string productName, int categoryID, float price, string status)
        {
            this.productID = productID;
            this.productName = productName;
            this.categoryID = categoryID;
            this.price = price;
            this.status = status;
        }

        public int getProductID()
        {
            return productID;
        }

        public string getProductName()
        {
            return productName;
        }

        public int getCategoryID()
        {
            return categoryID;
        }

        public float getPrice()
        {
            return price;
        }

        public string getStatus()
        {
            return status;
        }
    }
}
