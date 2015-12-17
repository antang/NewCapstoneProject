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
    class LogBL
    {
        DatabaseAccess DA;
        public LogBL()
        {
            DA = new DatabaseAccess();
        }
        public bool AddLog(Log Log)
        {
            string query = "INSERT INTO [Log]"
                + "([Contest_ID],[Player_ID],[Phase_ID],[Player_Score],[True],[False],[Exist])"
                + " VALUES ('" + Log.ContestID + "','" + Log.PlayerID + "','" + Log.PhaseID + "',"
                            + "'" + Log.PlayerScore+ "','" + Log.CurrentNumofTrue + "','" + Log.CurrentNumofFalse + "',"
                            + "'" + Log.Check + "')";

                return DA.InsertDatabase(query);
        }

        //select log
        public List<Log> GetLogByIdContest(Log log)
        {
            List<Log> LogList = new List<Log>();
            string query = "SELECT [Contest_ID],[Player_ID],[Phase_ID],[Player_Score],[True],[False],[Exist]"
                        + " FROM [Log]"
                        + " WHERE Contest_ID = '"+log.ContestID+"'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Log Log = new Log();
                    Log.ContestID = Convert.ToInt32(item["Contest_ID"].ToString());
                    Log.PlayerID = Convert.ToInt32(item["Player_ID"].ToString());
                    Log.PhaseID = Convert.ToInt32(item["Phase_ID"].ToString());
                    Log.PlayerScore = Convert.ToInt32(item["Player_Score"].ToString());
                    Log.CurrentNumofTrue = Convert.ToInt32(item["True"].ToString());
                    Log.CurrentNumofFalse = Convert.ToInt32(item["False"].ToString());
                    Log.Exist = (bool)item["Exist"];

                    LogList.Add(Log);
                }
            }
            return LogList;
        }
        //select log
        public List<Log> GetLogByIdPlayer(Log log)
        {
            List<Log> LogList = new List<Log>();
            string query = "SELECT [Contest_ID],[Player_ID],[Phase_ID],[Player_Score],[True],[False],[Exist]"
                        + " FROM [Log]"
                        + " WHERE Player_ID = '" + log.PlayerID + "'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Log Log = new Log();
                    Log.ContestID = Convert.ToInt32(item["Contest_ID"].ToString());
                    Log.PlayerID = Convert.ToInt32(item["Player_ID"].ToString());
                    Log.PhaseID = Convert.ToInt32(item["Phase_ID"].ToString());
                    Log.PlayerScore = Convert.ToInt32(item["Player_Score"].ToString());
                    Log.CurrentNumofTrue = Convert.ToInt32(item["True"].ToString());
                    Log.CurrentNumofFalse = Convert.ToInt32(item["False"].ToString());
                    Log.Exist = (bool)item["Exist"];

                    LogList.Add(Log);
                }
            }
            return LogList;
        }
        //Edit Log
        public bool UpdatePhase(Log Log)
        {
            string query = "UPDATE [Log]"
                         + " SET [Phase_ID]='" + Log.PhaseID + "'"
                         + " WHERE [Contest_ID] = '" + Log.ContestID + "'";

            return DA.UpdateDatabase(query);
        }

        //Edit Log
        public bool EditLogbyID(Log Log)
        {
            string query = "UPDATE [Log]"
                         + " SET [Contest_ID] = '" + Log.ContestID + "',[Player_ID] = '" +Log.PlayerID + "'"
                         + ",[Phase_ID]='" +Log.PhaseID+ "',[Player_Score]='" + Log.PlayerScore + "'"
                         + ",[True] = '" + Log.CurrentNumofTrue + "', [False] = '" +Log.CurrentNumofFalse + "'"
                         + ",[Exist] = '" + Log.Check + "'"
                         + " WHERE [Contest_ID] = '" + Log.ContestID+ "'";
            
                return DA.UpdateDatabase(query);
        }

        //Edit Log
        public bool EditLogbyIDPlayer(Log Log)
        {
            string query = "UPDATE [Log]"
                         + " SET [Phase_ID]='" + Log.PhaseID + "',[Player_Score]='" + Log.PlayerScore + "'"
                         + ",[True] = '" + Log.CurrentNumofTrue + "', [False] = '" + Log.CurrentNumofFalse + "'"
                         + ",[Exist] = '" + Log.Check + "'"
                         + " WHERE [Player_ID] = '" + Log.PlayerID + "'";

            return DA.UpdateDatabase(query);
        }
    }
}
