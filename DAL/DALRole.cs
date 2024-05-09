using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO; 

namespace DAL
{
    public class DALRole
    {
        Role role;

        public DALRole(int roleID, String roleName)
        {
            role = new Role(roleID, roleName);
        }
        public List<Role> getRole()
        {
            List<Role> list = new List<Role>();
            string sql = "select * from role";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Role r = new Role(dr);
                list.Add(r);
            }
            return list;
        }

        public void insert(Role role)
        {
            string sql = "insert into role values ('" + role.getRoleID() + "','" + role.getRoleName() + "')";
            Connection.actionQuery(sql);
        }

        public void update(int roleID, String roleName)
        {
            string sql = "update role set roleName = '" + roleName + "' where roleID = '" + roleID + "'";
            Connection.actionQuery(sql);
        }

        public void delete(int roleID)
        {
            string sql = "delete from role where roleID = '" + roleID + "'";
            Connection.actionQuery(sql);
        }

        

    }
}
