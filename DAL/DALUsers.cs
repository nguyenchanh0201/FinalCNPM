using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO ;
using System.Data;

namespace DAL
{
    public class DALUsers
    {
        Users u; 
        public DALUsers (String username, String password, String role)
        {
            u = new Users(username, password, role);
        }
        public void insert()
        {
            string sql = "insert into users values ('" + u.getUsername() + "','" + u.getPassword() + "','" + u.getRole() + "')";
            Connection.actionQuery(sql);
        }

        public bool login (String username, String password)
        {
            string sql = "select * from users where username = '" + username + "' and password = '" +  password + "'";
            if (Connection.check(sql))
            {
                System.Console.WriteLine(Connection.check(sql));
                return true;
                
            }
            return false;


        }

        public String getRole(String username)
        {
            string sql = "select role from users where username = '" + username + "'";
            DataTable dt = Connection.selectQuery(sql);
            return dt.Rows[0][0].ToString();


        }

    }
}
