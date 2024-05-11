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

        private string tableCardID;
        private string tableName;
        private string status;

        public TableCard(string tableCardID, string tableName, string status)
        {
            this.tableCardID = tableCardID; 
            this.tableName = tableName;
            this.status = status;
        }
        public string getTableCardID()
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

        public TableCard(DataRow dr)
        {
            this.tableCardID = dr["ID"].ToString();
            this.tableName = dr["TableName"].ToString();
            this.status = dr["Status"].ToString();

        }

    }
}
