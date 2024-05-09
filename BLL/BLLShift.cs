using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL; 

namespace BLL
{
    public class BLLShift
    {
        static DALShift dalshift;

        public BLLShift(String shiftID, DateTime shiftStart, DateTime shiftEnd)
        {
            dalshift = new DALShift(shiftID, shiftStart, shiftEnd);
        }

        public  string createShiftID()
        {
            if (dalshift == null)
            {
                DALShift dalshift = new DALShift("", DateTime.Now, DateTime.Now);
            }
            return dalshift.createShiftID();
        }   

        public void addShift(DateTime shiftStart, DateTime shiftEnd)
        {
            if (dalshift == null)
            {
                DALShift dalshift = new DALShift("", DateTime.Now, DateTime.Now);
            }
            dalshift.addShift(shiftStart, shiftEnd);
        }

    }
}
