using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALShift
    {
         Shift s; 

        public DALShift(String shiftID, DateTime shiftStart, DateTime shiftEnd)
        {
            s = new Shift(shiftID, shiftStart, shiftEnd);
        }

        

        //Create a method to create shift ID 
        public string createShiftID()
        {
            //Call for procedure 
            string sql = "exec generate_shiftID";
            string shiftID = Connection.selectQuery(sql).Rows[0][0].ToString();

            return shiftID;
        }


        public  void addShift(DateTime shiftStart, DateTime shiftEnd)
        {
            //Add to shift table
            
            string shiftID = createShiftID();

            string sql = "INSERT INTO Shift (shiftID, shiftStart, shiftEnd) VALUES ('" + shiftID + "', '" + shiftStart + "', '" + shiftEnd + "')";
            Connection.actionQuery(sql);
        }
    }
}
