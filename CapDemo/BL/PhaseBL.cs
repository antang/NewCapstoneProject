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
    class PhaseBL
    {
        DatabaseAccess DA;
        public PhaseBL()
        {
            DA = new DatabaseAccess();
        }
        //select Phase table
        public List<Phase> GetPhase()
        {
            List<Phase> PhaseList = new List<Phase>();
            string query = "SELECT p.[Contest_ID],p.[Phase_Name]"
                        + " FROM [Capstone].[dbo].[Phase] p";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase Phase = new Phase();
                    Phase.IDContest = Convert.ToInt32(item["Contest_ID"]);
                    Phase.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    Phase.NamePhase = item["Phase_Name"].ToString();
                    PhaseList.Add(Phase);
                    i++;
                }
            }
            return PhaseList;
        }

        //Insert Phase
        public bool AddPhase(Phase Phase)
        {
            string query = "INSERT INTO [Capstone].[dbo].[Phase]([Phase_Name])"
                           + "VALUES ('" + Phase.NamePhase + "')";
            if (ExistPhase(Phase) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }

        //Check Phase Exist
        public bool ExistPhase(Phase Phase)
        {
            string query = "SELECT [Contest_ID],[Phase_Name]"
                       + " FROM [Capstone].[dbo].[Phase]"
                       + " WHERE [Phase_Name] = '" + Phase.NamePhase.ToUpper() + "'";
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

        //Edit Phase
        public bool EditPhasebyID(Phase Phase)
        {
            string query = "UPDATE Phase SET Phase_Name ='" + Phase.NamePhase + "'"
                         + " WHERE Contest_ID = '" + Phase.IDContest + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Phase
        public bool DeletePhasebyID(Phase Phase)
        {
            string query = "DELETE FROM Phase"
                         + " WHERE Contest_ID = '" + Phase.IDContest + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
