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
            string query = "SELECT [Contest_ID],[Phase_ID],[Phase_Name],[Phase_Score],[Phase_Minus],[Phase_Time],[Sequence]"
                            +" FROM [Phase]";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase Phase = new Phase();
                    Phase.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Phase.IDPhase = Convert.ToInt32(item["Phase_ID"].ToString());
                    Phase.NamePhase = item["Phase_Name"].ToString();
                    Phase.ScorePhase = Convert.ToInt32(item["Phase_Score"].ToString());
                    Phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"].ToString());
                    Phase.TimePhase = Convert.ToInt32(item["Phase_Time"].ToString());
                    Phase.Sequence = Convert.ToInt32(item["Sequence"].ToString());

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
            string query = "SELECT [Phase_ID],[Contest_ID],[Phase_Name],[Phase_Score],[Phase_Minus],[Phase_Time],[Sequence]"
                            + " FROM [Phase]"
                            + " WHERE [Contest_ID] = '" + phase.IDContest + "'";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase Phase = new Phase();
                    Phase.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Phase.IDPhase = Convert.ToInt32(item["Phase_ID"].ToString());
                    Phase.NamePhase = item["Phase_Name"].ToString();
                    Phase.ScorePhase = Convert.ToInt32(item["Phase_Score"].ToString());
                    Phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"].ToString());
                    Phase.TimePhase = Convert.ToInt32(item["Phase_Time"].ToString());
                    Phase.Sequence = Convert.ToInt32(item["Sequence"].ToString());

                    PhaseList.Add(Phase);
                    //i++;
                }
            }
            return PhaseList;
        }
        //Insert Phase
        public bool AddPhase(Phase Phase)
        {
            string query = "INSERT INTO [Phase]"
                + "([Contest_ID],[Phase_Name],[Phase_Score],[Phase_Minus],[Phase_Time],[Sequence])"
                +" VALUES ('" + Phase.IDContest + "','" + Phase.NamePhase + "',"
                + "'" + Phase.ScorePhase + "','" + Phase.MinusPhase + "','" + Phase.TimePhase + "','" + Phase.Sequence + "')";
            if (DA.InsertDatabase(query))
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
            string query = "UPDATE [Phase]"
                         + " SET [Phase_Name] ='" + Phase.NamePhase + "', [Phase_Score]= ='" + Phase.ScorePhase + "'"
                         + ",[Phase_Minus] ='" + Phase.MinusPhase + "', [Phase_Time]='" + Phase.TimePhase + "', [Sequence]='" + Phase.Sequence + "'"
                         + " WHERE [Phase_ID] = '" + Phase.IDPhase + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Phase
        public bool DeletePhasebyID(Phase Phase)
        {
            string query = "DELETE FROM [Phase]"
                         + " WHERE [Contest_ID] = '" + Phase.IDContest + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
