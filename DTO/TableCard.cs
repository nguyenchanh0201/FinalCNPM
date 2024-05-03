using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableCard
    {

        private int tableCardID;
        private string tableName;
        private string status;

        public TableCard(int tableCardID, string tableName, string status)
        {
            this.tableCardID = tableCardID; 
            this.tableName = tableName;
            this.status = status;
        }
        public int getTableCardID()
        {
            return tableCardID;
        }

        public String getTableName()
        {
            return tableName;
        }

        public String getStatus()
        {
            return status;
        }

    }
}
