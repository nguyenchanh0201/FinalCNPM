using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class BLLOrderData
    {
        DALOrderData dalOrderData;

        public BLLOrderData(string orderID, DateTime orderDate, decimal totalAmount, string username, string tableID, string orderType, string customerID, string shiftID, string paymentMethod)
        {
            dalOrderData = new DALOrderData(orderID, orderDate, totalAmount, username, tableID, orderType, customerID, shiftID, paymentMethod);
        }

        public string getOrderID()
        {
            return dalOrderData.getOrderID();
        }

        public DateTime getOrderDate()
        {
            return dalOrderData.getOrderDate();

        }

        public decimal getTotalAmount()
        {
            return dalOrderData.getTotalAmount();
        }

        public string getUsername()
        {
            return dalOrderData.getUsername();
        }

        public string getTableID()
        {
            return dalOrderData.getTableID();
        }

        public string getOrderType()
        {
            return dalOrderData.getOrderType();
        }

        public string getCustomerID()
        {
            return dalOrderData.getCustomerID();
        }

        public void AddOrderData(DateTime orderDate, decimal totalAmmount, String username, String tableID, String orderType, String CustomerID, String shiftID, string paymentMethod)
        {
            dalOrderData.AddOrderData(orderDate, totalAmmount, username, tableID, orderType, CustomerID, shiftID, paymentMethod);
        }

        public String createOrderID()
        {
            return dalOrderData.createOrderID();
        }

        public void updatePaymentMethod(string orderID, string paymentMethod)
        {
            dalOrderData.updatePaymentMethod(paymentMethod, orderID);
        }
    }
}
