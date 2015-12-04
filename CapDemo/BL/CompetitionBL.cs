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
    class CompetitionBL
    {
        DatabaseAccess DA;
        public CompetitionBL()
        {
            DA = new DatabaseAccess();
        }
        //Get Competition
        public List<Competition> GetCompetition()
        {
            List<Competition> CompetitionList = new List<Competition>();
            string query = "SELECT [Competition_ID],[Competition_Name]"
                         + " FROM [Competition]";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Competition Competition = new Competition();
                    Competition.IDCompetition = Convert.ToInt32(item["Competition_ID"].ToString());
                    Competition.NameCompetition = item["Competition_Name"].ToString();
                    //Competition.Sequence = i;
                    CompetitionList.Add(Competition);
                    //i++;
                }
            }
            return CompetitionList;
        }

        //Insert Competition
        public bool AddCompetition(Competition Competition)
        {
            string query = "INSERT INTO [Competition]([Competition_Name])"
                            + " VALUES('" + Competition.NameCompetition + "')";

            if (ExistCompetition(Competition) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }
        //Check Competition Exist
        public bool ExistCompetition(Competition Competition)
        {
            string query = "SELECT [Competition_ID],[Competition_Name]"
                         + " FROM [Competition]"
                         + " WHERE [Competition_Name] = '" + Competition.NameCompetition.ToUpper() + "'";
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
        //Edit competition exist in competition table
        public bool EditExistCompetiton(Competition Competition)
        {
            string query = "SELECT [Competition_ID],[Competition_Name]"
                         + " FROM [Competition]"
                         + " WHERE [Competition_Name]= '" + Competition.NameCompetition.ToUpper() + "'"
                         + " AND [Competition_ID] <> '" + Competition.IDCompetition + "'";
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
        //Edit Competition
        public bool EditCompetitionbyID(Competition Competition)
        {
            string query = "UPDATE [Competition]"
                         + " SET [Competition_Name] ='" + Competition.NameCompetition.Replace("'","''") + "'"
                         + " WHERE [Competition_ID] = '" + Competition.IDCompetition + "'";

            if (EditExistCompetiton(Competition) == true)
            {
                return false;
            }
            else
            {
                return DA.UpdateDatabase(query);
            }
        }

        //Delete Competition
        public bool DeleteCompetitionbyID(Competition Competition)
        {
            string query = "DELETE FROM [Competition]"
                         + " WHERE [Competition_ID] = '" + Competition.IDCompetition + "'";
            return DA.DeleteDatabase(query);
        }
        //GET MAXIMUM ID QUESTION
        public int MaxIDCompetition()
        {
            string query = "SELECT MAX(Competition_ID) FROM Competition";
            return DA.MaxID(query);
        }
    }
}
