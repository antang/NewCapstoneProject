using CapDemo.DA;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.BL
{
    class RoundBL
    {
        DatabaseAccess DA;
        public RoundBL()
        {
            DA = new DatabaseAccess();
        }
        //select Round table
        public List<Round> GetRound()
        {
            List<Round> RoundList = new List<Round>();
            string query = "SELECT r.[Round_ID],r.[Round_Name]"
                        + " FROM [Capstone].[dbo].[Round] r";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Round Round = new Round();
                    Round.IDRound = Convert.ToInt32(item["Round_ID"]);
                    Round.NameRound = item["Round_Name"].ToString();
                    Round.Sequence = i;
                    RoundList.Add(Round);
                    i++;
                }
            }
            return RoundList;
        }

        //Insert Round
        public bool AddRound(Round Round)
        {
            string query = "INSERT INTO [Capstone].[dbo].[Round]([Round_Name])"
                           + "VALUES ('" + Round.NameRound + "')";
            if (ExistRound(Round) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }

        //Check Round Exist
        public bool ExistRound(Round Round)
        {
            string query = "SELECT [Round_ID],[Round_Name]"
                       + " FROM [Capstone].[dbo].[Round]"
                       + " WHERE [Round_Name] = '" + Round.NameRound.ToUpper() + "'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Edit Round
        public bool EditRoundbyID(Round Round)
        {
            string query = "UPDATE Round SET Round_Name ='" + Round.NameRound + "'"
                         + " WHERE Round_ID = '" + Round.IDRound + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Round
        public bool DeleteRoundbyID(Round Round)
        {
            string query = "DELETE FROM Round"
                         + " WHERE Round_ID = '" + Round.IDRound + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
