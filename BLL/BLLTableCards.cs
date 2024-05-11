using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLTableCards
    {
        static DALTableCards daltablecards;

        public BLLTableCards(String tableID, string tableName, string status)
        {
            daltablecards = new DALTableCards(tableID, tableName, status);
        }

        public static List<TableCard> getTableCards()
        {
            if (daltablecards == null)
            {
                daltablecards = new DALTableCards("", "", "");
            }


            return daltablecards.getTableCards();
        }

        public void insertTableCard(TableCard tc)
        {
            daltablecards.insertTableCard(tc);
        }

        public void updateTableCard(TableCard tc)
        {
            daltablecards.updateTableCard(tc);
        }
    }
}
