using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {

        private string username;
        private string password;
        private string role;

        public Users(string username , string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public String getUsername()
        {
            return username;
        }   

        public String getPassword()
        {
            return password;
        }

        public String getRole()
        {
            return role;
        }





    }
}
