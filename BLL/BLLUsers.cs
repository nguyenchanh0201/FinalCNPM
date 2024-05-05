using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 
using System.Data;
namespace BLL
{
    public class BLLUsers
    {
        DALUsers dalusers;

        public BLLUsers(String username, String password, String role)
        {
            dalusers = new DALUsers(username, password, role);
        }

        public void insert()
        {
            dalusers.insert();
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

    }
}
