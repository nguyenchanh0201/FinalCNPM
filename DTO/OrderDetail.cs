using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail
    {

        private int orderDetailID;
        private int orderID;
        private int productID;
        private int quantity;
        private float price;

        public OrderDetail(int orderDetailID, int orderID, int productID, int quantity, float price)
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

        public int getOrderID()
        {
            return orderID;
        }

        public int getProductID()
        {
            return productID;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public float getPrice()
        {
            return price;
        }
    }
}
