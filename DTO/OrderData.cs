using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderData
    {

        private string orderID;
        private DateTime orderDate;
        private decimal totalAmount;
        private string username;
        private string tableID;
        private string orderType;
        private string customerID;
        private string shiftID;
        private string paymentMethod;
        public OrderData(string orderID, DateTime orderDate, decimal totalAmount, string username, string tableID, string orderType, string customerID, string shiftID, string paymentMethod)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.totalAmount = totalAmount;
            this.username = username;
            this.tableID = tableID;
            this.orderType = orderType;
            this.customerID = customerID;
            this.shiftID = shiftID;
            this.paymentMethod = paymentMethod;
        }

        public string getOrderID()
        {
            return orderID;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public decimal getTotalAmount()
        {
            return totalAmount;
        }

        public string getUsername()
        {
            return username;
        }

        public string getTableID()
        {
            return tableID;
        }

        public string getOrderType()
        {
            return orderType;
        }

        public string getCustomerID()
        {
            return customerID;
        }

        public string getShiftID()
        {
            return shiftID;
        }

        public string getPaymentMethod()
        {
            return paymentMethod; 
        }
    }
}
