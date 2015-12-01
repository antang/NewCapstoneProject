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
            string query = "SELECT [Contest_ID],[Catalogue_ID],[Phase_Name],[Phase_Score],[Phase_Minus],[Phase_Time]"
                            +" FROM [Capstone].[dbo].[Phase]";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase Phase = new Phase();
                    Phase.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Phase.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"].ToString());
                    Phase.NamePhase = item["Phase_Name"].ToString();
                    Phase.ScorePhase = Convert.ToInt32(item["Phase_Score"].ToString());
                    Phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"].ToString());
                    Phase.TimePhase = Convert.ToInt32(item["Phase_Time"].ToString());

                    PhaseList.Add(Phase);
                    //i++;
                }
            }
            return PhaseList;
        }
        //Get phase by id contest
        public List<Phase> GetPhaseByIDContest(Phase phase)
        {
            List<Phase> PhaseList = new List<Phase>();
            string query = "SELECT [Contest_ID],[Catalogue_ID],[Phase_Name],[Phase_Score],[Phase_Minus],[Phase_Time]"
                            + " FROM [Capstone].[dbo].[Phase]"
                            + " WHERE [Contest_ID] = '" + phase.IDContest + "'";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase Phase = new Phase();
                    Phase.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Phase.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"].ToString());
                    Phase.NamePhase = item["Phase_Name"].ToString();
                    Phase.ScorePhase = Convert.ToInt32(item["Phase_Score"].ToString());
                    Phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"].ToString());
                    Phase.TimePhase = Convert.ToInt32(item["Phase_Time"].ToString());

                    PhaseList.Add(Phase);
                    //i++;
                }
            }
            return PhaseList;
        }
        //Insert Phase
        public bool AddPhase(Phase Phase)
        {
            string query = "INSERT INTO [Capstone].[dbo].[Phase]"
                +"([Contest_ID],[Catalogue_ID],[Phase_Name],[Phase_Score],[Phase_Minus],[Phase_Time])"
                +" VALUES ('" + Phase.IDContest + "','" + Phase.IDCatalogue + "','" + Phase.NamePhase + "',"
                            +"'" + Phase.ScorePhase + "','" + Phase.MinusPhase + "','" + Phase.TimePhase + "')";
            if (DA.InsertDatabase(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ////Check Phase Exist
        //public bool ExistPhase(Phase Phase)
        //{
        //    string query = "SELECT [Contest_ID],[Phase_Name]"
        //               + " FROM [Capstone].[dbo].[Phase]"
        //               + " WHERE [Contest_ID] = '" + Phase.NamePhase.ToUpper() + "'";
        //    DataTable dt = DA.SelectDatabase(query);
        //    if (dt.Rows.Count != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

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
