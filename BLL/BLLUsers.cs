using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 
using System.Data;
using DTO;
namespace BLL

{
    public class BLLUsers
    {
        static DALUsers dalusers;

        public BLLUsers(String username, String password, String role,String name,String phone)
        {
            dalusers = new DALUsers(username, password, role,name,phone);
        }

        public void insert(String username, String password, String role, String name, String phone)
        {
            dalusers.insert(username, password, role, name, phone);
        }


        public bool login(String username, String password)
        {
            return dalusers.login(username,password);
        }

        public String getRole(String username)
        {
            return dalusers.getRole(username);
        }

        public void updatePassword(String username, String password)
        {
            dalusers.updatePassword(username, password);
        }
        public static List<Users> getUsers()
        {
            return dalusers.getUsers();
        }


    }
}
