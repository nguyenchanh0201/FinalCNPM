using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DALTableCards
    {

        TableCard tc;
        public DALTableCards(String tableID, string tableName, string status)
        {
            tc = new TableCard(tableID, tableName, status);
        }

        public List<TableCard> getTableCards()
        {
            List<TableCard> list = new List<TableCard>();
            string sql = "SELECT * FROM TableCards ORDER BY CAST(RIGHT(ID, LEN(ID) - 1) AS INT);";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new TableCard(dr));
            }
            return list;

        }

        public void insertTableCard(TableCard tc)
        {
            string sql = "insert into tablecards values ('" + tc.getTableCardID() + "','" + tc.getTableName() + "','" + tc.getStatus() + "')";
            Connection.actionQuery(sql);
        }

        public void updateTableCard(TableCard tc)
        {
            string sql = "update tablecards set TableName = '" + tc.getTableName() + "', Status = '" + tc.getStatus() + "' where TableCardID = '" + tc.getTableCardID() + "'";
            Connection.actionQuery(sql);
        }

        

    }
}
