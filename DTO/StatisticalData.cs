using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatisticalData
    {
        public int StatisticalID { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        public string OrderMethod { get; set; }
        public float Total { get; set; }
        public int CustomerID { get; set; }


    }
}
