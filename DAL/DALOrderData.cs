using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALOrderData
    {
        OrderData o;

        public DALOrderData(string orderID, DateTime orderDate, decimal totalAmount, string username, string tableID, string orderType, string customerID, string shiftID, string paymentMethod)
        {
            o = new OrderData(orderID, orderDate, totalAmount, username, tableID, orderType, customerID, shiftID, paymentMethod);
        }

        public string getOrderID()
        {
            return o.getOrderID();
        }

        public DateTime getOrderDate()
        {
            return o.getOrderDate();

        }

        public decimal getTotalAmount()
        {
            return o.getTotalAmount();
        }

        public string getUsername()
        {
            return o.getUsername();
        }

        public string getTableID()
        {
            return o.getTableID();
        }

        public string getOrderType()
        {
            return o.getOrderType();
        }

        public string getCustomerID()
        {
            return o.getCustomerID();
        }

        public void AddOrderData(DateTime orderDate, decimal totalAmmount, String username, String tableID, String orderType, String CustomerID, String shiftID, String paymentMethod)
        {
            // Add order data to database
            string orderID = createOrderID();
            string sql = "insert into Orders values('" + orderID + "','" + orderDate + "','" + totalAmmount + "','" + username + "','" + tableID + "','" + orderType + "','" + CustomerID + "','" + shiftID + "','" + paymentMethod + "')";

            Connection.actionQuery(sql);

        }

        public string createOrderID()
        {
            //Call for procedure 
            string sql = "exec generate_orderID";
            string orderID = Connection.selectQuery(sql).Rows[0][0].ToString();

            return orderID;
        }

        public void updatePaymentMethod(string paymentMethod, string orderID)
        {
            string sql = "update Orders set paymentMethod = '" + paymentMethod + "' where orderID = '" + orderID + "'";
            Connection.actionQuery(sql);
        }






    }
}
