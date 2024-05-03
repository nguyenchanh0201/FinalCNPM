using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private int customerID;
        private string customerName;
        private string phoneNumber;
        private int points;
        private string membershipLevel;

        public Customer(int customerID, string customerName, string phoneNumber, int points, string membershipLevel)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.points = points;
            this.membershipLevel = membershipLevel;
        }

        public int getCustomerID()
        {
            return customerID;
        }

        public string getCustomerName()
        {
            return customerName;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public int getPoints()
        {
            return points;
        }

        public string getMembershipLevel()
        {
            return membershipLevel;
        }
    }
}
