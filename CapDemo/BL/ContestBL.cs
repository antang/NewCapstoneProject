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
    class ContestBL
    {
        DatabaseAccess DA;
        public ContestBL()
        {
            DA = new DatabaseAccess();
        }
        //select Contest table
        public List<Contest> GetContest()
        {
            List<Contest> ContestList = new List<Contest>();
            string query = "SELECT r.[Contest_ID],r.[Contest_Name]"
                        + " FROM [Capstone].[dbo].[Contest] r";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Contest Contest = new Contest();
                    Contest.IDContest = Convert.ToInt32(item["Contest_ID"]);
                    Contest.NameContest = item["Contest_Name"].ToString();
                    //Contest.Sequence = i;
                    ContestList.Add(Contest);
                    //i++;
                }
            }
            return ContestList;
        }

        //Insert Contest
        public bool AddContest(Contest Contest)
        {
            string query = "INSERT INTO [Capstone].[dbo].[Contest]([Contest_Name])"
                           + "VALUES ('" + Contest.NameContest.Replace("'","''") + "')";
            if (ExistContest(Contest) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }

        //Check Contest Exist
        public bool ExistContest(Contest Contest)
        {
            string query = "SELECT [Contest_ID],[Contest_Name]"
                       + " FROM [Capstone].[dbo].[Contest]"
                       + " WHERE [Contest_Name] = '" + Contest.NameContest.ToUpper() + "'";
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

        //Edit Contest
        public bool EditContestbyID(Contest Contest)
        {
            string query = "UPDATE Contest SET Contest_Name ='" + Contest.NameContest + "'"
                         + " WHERE Contest_ID = '" + Contest.IDContest + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Contest
        public bool DeleteContestbyID(Contest Contest)
        {
            string query = "DELETE FROM Contest"
                         + " WHERE Contest_ID = '" + Contest.IDContest + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
