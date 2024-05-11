using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class DALOrderDetails
    {
        OrderDetail od;


        public DALOrderDetails(int orderDetailID, string orderID, string productID, int quantity, decimal price)
        {
            od = new OrderDetail(orderDetailID, orderID, productID, quantity, price);
        }

        public int getOrderDetailID()
        {
            return od.getOrderDetailID();
        }

        public string getOrderID()
        {
            return od.getOrderID();
        }

        public string getProductID()
        {
            return od.getProductID();
        }

        public int getQuantity()
        {
            return od.getQuantity();
        }

        public decimal getPrice()
        {
            return od.getPrice();
        }

        public void AddOrderDetail(string orderID, string productID, int quantity, decimal price)
        {
            // Add order detail to database
            string sql = "INSERT INTO OrderDetails (orderID, productID, quantity, price) VALUES ('" + orderID + "', '" + productID + "', '" + quantity + "', '" + price + "')";
            Connection.actionQuery(sql);

        }

        public void UpdateOrderDetail(int orderDetailID, string orderID, string productID, int quantity, decimal price)
        {
            // Update order detail in database
            string sql = "UPDATE OrderDetails SET orderID = '" + orderID + "', productID = '" + productID + "', quantity = '" + quantity + "', price = '" + price + "' WHERE orderDetailID = '" + orderDetailID + "'";
            Connection.actionQuery(sql);
        }

        public List<OrderDetail> GetOrderDetails(string orderID)
        {
            // Get order details from database
            string sql = "SELECT * FROM OrderDetails WHERE orderID = '" + orderID + "'";
            List<OrderDetail> list = new List<OrderDetail>();
            System.Data.DataTable dt = Connection.selectQuery(sql);
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                OrderDetail od = new OrderDetail(dr);
                list.Add(od);
            }
            // Add order details to list
            return list;

        }


    }
}
