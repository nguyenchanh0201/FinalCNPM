using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALCustomer
    {
        Customer c;

        public DALCustomer(int customerID, string customerName, string phoneNumber, string gender, int points, int rankID)
        {
            c = new Customer(customerID, customerName, phoneNumber, gender, points, rankID);
        }

        public string createCustomerID()
        {
            string sql = "exec CreateCustomerID";
            return Connection.selectQuery(sql).Rows[0][0].ToString();
        }

        public void insert(String customerName, String phoneNumber, string gender)
        {
            string customerID = createCustomerID();
            string sql = "insert into Customer values ('" + customerID + "', N'" + customerName + "', '" + phoneNumber + "',N'" + gender + "')";
            // Rest of the code
            Connection.actionQuery(sql);
        }

        public void insert(string customerName, string phoneNumber, string gender, int points, int rankID)
        {
            throw new NotImplementedException();
        }

        public void update(String customername, String phoneNumber, String gender)
        {
            string sql = "update Customer set CustomerName = N'" + customername + "', PhoneNumber = '" + phoneNumber + "' where CustomerID = '" + c.getCustomerID() + "'";
            Connection.actionQuery(sql);
        }



    }
}