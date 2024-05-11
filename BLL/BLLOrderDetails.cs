using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLOrderDetails
    {
        DALOrderDetails dalorderdetails;

        public BLLOrderDetails(int orderDetailID, string orderID, string productID, int quantity, decimal price)
        {
            dalorderdetails = new DALOrderDetails(orderDetailID, orderID, productID, quantity, price);
        }

        public int getOrderDetailID()
        {
            return dalorderdetails.getOrderDetailID();
        }

        public string getOrderID()
        {
            return dalorderdetails.getOrderID();
        }


        public string getProductID()
        {
            return dalorderdetails.getProductID();
        }

        public int getQuantity()
        {
            return dalorderdetails.getQuantity();
        }

        public decimal getPrice()
        {
            return dalorderdetails.getPrice();
        }

        public void AddOrderDetail(string orderID, string productID, int quantity, decimal price)
        {
            dalorderdetails.AddOrderDetail(orderID, productID, quantity, price);
        }
    }
}
