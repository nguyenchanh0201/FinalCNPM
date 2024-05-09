using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DALCategory
    {
        ProductCategory pc;

        public DALCategory(string categoryID, string categoryName)
        {
            pc = new ProductCategory(categoryID, categoryName);
        }

        public string getCategoryName()
        {
            return pc.getCategoryName();
        }

        public List<ProductCategory> getCategory() {
            string sql = "SELECT * FROM Categories";
            List<ProductCategory> list = new List<ProductCategory>();
            foreach (DataRow dr in Connection.selectQuery(sql).Rows)
            {
                list.Add(new ProductCategory(dr));
            }
            return list;
        }

        


    }
}
