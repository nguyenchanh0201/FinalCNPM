using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderData
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public int CustomerID { get; set; }
    }
}
