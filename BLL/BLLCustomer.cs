using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Security.Cryptography;

namespace BLL
{
    public class BLLCustomer
    {
        DALCustomer dalCustomer;
        public BLLCustomer(int customerId, String customerName, String phoneNumber, string gender, int points, int rankID)
        {
            dalCustomer = new DALCustomer(customerId, customerName, phoneNumber, gender, points, rankID);
        }

        public string createCustomerID()
        {
            return dalCustomer.createCustomerID();
        }

        public void insert(String customerName, String phoneNumber, String gender, int points, int rankID)
        {
            if (dalCustomer == null)
            {
                dalCustomer = new DALCustomer(0, "", "", "", 0, 0);
            }
            dalCustomer.insert(customerName, phoneNumber, gender, points, rankID);
        }


    }
}