using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTableCards
    {
        public static List<DTO.TableCard> getTableCards()
        {
            List<DTO.TableCard> tableCards = new List<DTO.TableCard>();
            string sql = "select * from TableCards";
            System.Data.DataTable dt = Connection.selectQuery(sql);
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                int tableCardID = int.Parse(dr["TableCardID"].ToString());
                string tableName = dr["TableName"].ToString();
                string status = dr["Status"].ToString();
                DTO.TableCard tc = new DTO.TableCard(tableCardID, tableName, status);
                tableCards.Add(tc);
            }
            return tableCards;
        }
        
        public void insertTableCard(DTO.TableCard tc)
        {
            string sql = "insert into TableCards values('" + tc.getTableName() + "','" + tc.getStatus() + "')";
            Connection.actionQuery(sql);
        }
    }
}
