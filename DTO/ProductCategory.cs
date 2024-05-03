using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductCategory
    {

        private int categoryID;
        private string categoryName;
        public ProductCategory(int categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }

        public int getCategoryID()
        {
            return categoryID;
        }

        public string getCategoryName()
        {
            return categoryName;
        }
    }
}
