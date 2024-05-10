using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL; 

namespace BLL
{
    public class BLLCustomer
    {
        DALCustomer dalCustomer;
        public BLLCustomer(String customerId, String customerName, String phoneNumber, string gender, int points, int rankID)
        {
            dalCustomer = new DALCustomer(customerId, customerName, phoneNumber, gender, points, rankID);
        }
    }
}
