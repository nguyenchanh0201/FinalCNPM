using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLProducts
    {
        static DALProducts dalproducts;

        public BLLProducts(string productID, string productName, string categoryID,  decimal price, string status)
        {
            dalproducts = new DALProducts(productID, productName, categoryID, price, status);
        }

        public static List<Product> GetProducts()
        {
            if (dalproducts == null)
            {
                dalproducts = new DALProducts("", "", "", 0, "");
            }
            return dalproducts.GetProducts();
        }


        public void insertProduct(Product p)
        {
            dalproducts.insertProduct(p);
        }
        public void updateProduct(Product p)
        {
            dalproducts.updateProduct(p);
        }

        public void deleteProduct(Product p)
        {
            dalproducts.deleteProduct(p);
        }


        public static List<Product> GetProductsByCategory(string categoryname)
        {
            return dalproducts.GetProductsByCategory(categoryname);
        }


    }
}
