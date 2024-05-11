using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO; 

namespace BLL
{
    public class BLLCategories
    {

        static DALCategory dalcategory;

        public BLLCategories(string categoryID, string categoryName)
        {
            dalcategory = new DALCategory(categoryID, categoryName);
        }

        public static string getCategoryName()
        {
            return dalcategory.getCategoryName();
        }

        public static  List<ProductCategory> getCategory()
        {
            if (dalcategory == null)
            {
                dalcategory = new DALCategory("", "");
            }
            return dalcategory.getCategory();
        }

    }
}
