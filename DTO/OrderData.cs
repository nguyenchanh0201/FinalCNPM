using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderData
    {

        private int orderID;
        private DateTime orderDate;
        private float totalAmount;
        private string paymentMethod;
        private int customerID;

        public OrderData(int orderID, DateTime orderDate, float totalAmount, string paymentMethod, int customerID)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.totalAmount = totalAmount;
            this.paymentMethod = paymentMethod;
            this.customerID = customerID;
        }

        public int getOrderID()
        {
            return orderID;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public float getTotalAmount()
        {
            return totalAmount;
        }

        public string getPaymentMethod()
        {
            return paymentMethod;
        }

        public int getCustomerID()
        {
            return customerID;
        }
    }
}
