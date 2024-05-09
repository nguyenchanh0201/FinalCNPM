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
        public DALUsers (String username, String password, String role,String name, String phone)
        {
            u = new Users(username, password, role,name, phone);
        }
        public void insert(String username, String password, String role, String name, String phone)
        {
            string sql = "insert into users values ('" + username + "','" + password + "','" + role + "','" + name + "','" + phone + "')";
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
        public void updatePassword(String username, String password)
        {
            string sql = "update users set password = '" + password + "' where username = '" + username + "'";
            Connection.actionQuery(sql);
        }

        public String getRole(String username)
        {
            string sql = "select role from users where username = '" + username + "'";
            DataTable dt = Connection.selectQuery(sql);
            return dt.Rows[0][0].ToString();


        }
        public List<Users> getUsers()
        {
            List<Users> list = new List<Users>();
            string sql = "select * from users";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Users u = new Users(dr);
                list.Add(u);
            }
            return list;
        }   
    }
}
