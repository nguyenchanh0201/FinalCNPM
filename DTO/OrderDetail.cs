﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail
    {

        private int orderDetailID;
        private string orderID;
        private string productID;
        private int quantity;
        private decimal price;

        public OrderDetail(int orderDetailID, string orderID, string productID, int quantity, decimal price)
        {
            this.orderDetailID = orderDetailID;
            this.orderID = orderID;
            this.productID = productID;
            this.quantity = quantity;
            this.price = price;
        }

        public int getOrderDetailID()
        {
            return orderDetailID;
        }

        public string getOrderID()
        {
            return orderID;
        }

        public string getProductID()
        {
            return productID;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public decimal getPrice()
        {
            return price;
        }
    }
}
