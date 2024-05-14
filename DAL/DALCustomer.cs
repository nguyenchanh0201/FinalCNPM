using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

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

        public void insert(String customerName, String phoneNumber, string gender, int points, int rankID)
        {
            string customerID = createCustomerID();
            string sql = "insert into Customers values('" + customerID + "', N'" + customerName + "', '" + phoneNumber + "'," + points + ", " + rankID + ")";
            // Rest of the code
            Connection.actionQuery(sql);
        }

        public void update(String customerName, String phoneNumber)
        {
            string sql = "update Customers set customerName = N'" + customerName + "', phoneNumber = '" + phoneNumber + "' where id = '" + c.getCustomerID() + "'";
            Connection.actionQuery(sql);
        }
        public void delete(int customerID)
        {
            string sql = "delete from Customers where id = '" + customerID + "'";
            Connection.actionQuery(sql);
        }


        public List<Customer> getCustomer()
        {
            List<Customer> list = new List<Customer>();
            string sql = "select * from Customers";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Customer c = new Customer(dr);
                list.Add(c);
            }
            return list;
        }
        public DataTable select()
        {
            string sql = "select * from Customers";
            return Connection.selectQuery(sql);
        }




    }
}