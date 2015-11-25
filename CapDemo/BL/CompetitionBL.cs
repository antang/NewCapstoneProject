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
                         + " FROM [Capstone].[dbo].[Competition]";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Competition Competition = new Competition();
                    Competition.IDCompetition = Convert.ToInt32(item["Competition_ID"]);
                    Competition.NameCompetition = item["Competition_Name"].ToString();
                    //Competition.Sequence = i;
                    CompetitionList.Add(Competition);
                    i++;
                }
            }
            return CompetitionList;
        }

        //Insert Competition
        public bool AddCompetition(Competition Competition)
        {
            string query = "INSERT INTO Competition (Competition_Name)"
                        + " VALUES ('" + Competition.NameCompetition.Replace("'", "''") + "')";

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
            string query = "SELECT Competition_ID, Competition_Name FROM Competition"
                         + " WHERE Competition_Name = '" + Competition.NameCompetition.ToUpper() + "'";
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
            string query = "UPDATE Competition SET Competition_Name ='" + Competition.NameCompetition + "'"
                         + " WHERE Competition_ID = '" + Competition.IDCompetition + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Competition
        public bool DeleteCompetitionbyID(Competition Competition)
        {
            string query = "DELETE FROM Competition"
                         + " WHERE Competition_ID = '" + Competition.IDCompetition + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
