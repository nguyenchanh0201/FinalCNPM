using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DALProducts
    {
        Product p;

        public DALProducts(string productID, string productName, string categoryID, decimal price, string status)
        {
            p = new Product(productID, productName, categoryID, price, status);
        }


        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Products";
            List<Product> list = new List<Product>();
            foreach (DataRow dr in Connection.selectQuery(sql).Rows)
            {
                list.Add(new Product(dr));
            }
            return list;
        }

        public void insertProduct(Product p)
        {
            string sql = "insert into products values ('" + p.getProductID() + "','" + p.getProductName() + "','" + p.getCategoryID() + "','" + p.getPrice() + "','" + p.getStatus() + "')";
            Connection.actionQuery(sql);
        }

        public void updateProduct(Product p)
        {
            string sql = "update products set ProductName = '" + p.getProductName() + "', CategoryID = '" + p.getCategoryID() + "', Price = '" + p.getPrice() + "', Status = '" + p.getStatus() + "' where ProductID = '" + p.getProductID() + "'";
            Connection.actionQuery(sql);
        }
        public void deleteProduct(Product p)
        {
            string sql = "delete from products where ProductID = '" + p.getProductID() + "'";

            Connection.actionQuery(sql);
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            string sql = "SELECT * FROM Products WHERE CateID in ( select CateID from Categories where CateName = '" + categoryName + "')";
            List<Product> list = new List<Product>();
            foreach (DataRow dr in Connection.selectQuery(sql).Rows)
            {
                list.Add(new Product(dr));
            }
            return list;
        }   






    }
}
