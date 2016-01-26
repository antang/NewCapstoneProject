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
    class RecordBL
    {
        DatabaseAccess DA;

        public RecordBL()
        {
            DA = new DatabaseAccess();
        }
        //get score player
        public List<Record> GetsScoreplayerByIDContest(Record record)
        {
            List<Record> RecordList = new List<Record>();
            string query = "SELECT [PlayerScore],[Player_ID]"
                        + " FROM [Record]"
                        + " WHERE [Contest_ID] = '" + record.IDContest + "'";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Record Record = new Record();
                    Record.TeamScore = Convert.ToInt32(item["PlayerScore"].ToString());
                    Record.IDPlayer = Convert.ToInt32(item["Player_ID"].ToString());
                    RecordList.Add(Record);
                }
            }
            return RecordList;
        }

        //
        public List<Record> GetRecordByIDContest(Record record)
        {
            List<Record> RecordList = new List<Record>();
            string query = "SELECT [Contest_ID],[Player_ID],[Phase_ID],[NumofCorrect],[NumofIncorrect],[Defy],[Support],[Exist],[PhaseIndex],"
                        + "[PlayerScore],[TotalCorrect],[PlayerSequence],[PM],[Undie],[PlayerTurn],[Turn]"
                        + " FROM [Record]"
                        + " WHERE [Contest_ID] = '" + record.IDContest + "' ORDER BY [PlayerSequence] ASC";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Record Record = new Record();
                    Record.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Record.IDPlayer = Convert.ToInt32(item["Player_ID"].ToString());
                    Record.IDPhase = Convert.ToInt32(item["Phase_ID"].ToString());
                    Record.NumPass = Convert.ToInt32(item["NumofCorrect"].ToString());
                    Record.NumFail = Convert.ToInt32(item["NumofIncorrect"].ToString());
                    Record.Defy = (bool)(item["Defy"]);
                    Record.Support = (bool)(item["Support"]);
                    Record.Exist = (bool)(item["Exist"]);
                    Record.PhaseIndex = Convert.ToInt32(item["PhaseIndex"].ToString());
                    Record.TeamScore = Convert.ToInt32(item["PlayerScore"].ToString());
                    Record.TotalPass = Convert.ToInt32(item["TotalCorrect"].ToString());
                    Record.SequecePlayer = Convert.ToInt32(item["PlayerSequence"].ToString());
                    Record.PM = (bool)(item["PM"]);
                    Record.Undie = (bool)(item["Undie"]);
                    Record.PlayerTurn = (bool)(item["PlayerTurn"]);
                    Record.Turn = Convert.ToInt32(item["Turn"].ToString());
                    
                    RecordList.Add(Record);
                }
            }
            return RecordList;
        }


        //Insert Record
        public bool AddRecord(Record Record)
        {
            string query = "INSERT INTO [Record]"
                + "([Contest_ID],[Player_ID],[Phase_ID],[NumofCorrect],[NumofIncorrect],[Defy],[Support],[Exist],[PhaseIndex],"
                + "[PlayerScore],[TotalCorrect],[PlayerSequence],[PM],[Undie],[PlayerTurn],[Turn])"
                + " VALUES ('" + Record.IDContest + "','" + Record.IDPlayer + "', '" + Record.IDPhase + "', '" + Record.NumPass + "',"
                + "'" + Record.NumFail + "','" + Record.Defy_I + "','" + Record.Support_I + "','" + Record.Exist_I + "', '" + Record.PhaseIndex + "',"
                + "'" + Record.TeamScore + "', '" + Record.TotalPass + "','" + Record.SequecePlayer + "', '" + Record.PM_I + "', '" + Record.Undie_I + "', '" + Record.PlayerTurn_I + "', '" + Record.Turn + "')";
            if (ExistRecord(Record) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }
        //
        public bool ExistRecord(Record Record)
        {
            string query = "SELECT [Contest_ID]"
                        + " FROM [Record]";
            DataTable dt = DA.SelectDatabase(query);
            int i = 0;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (Convert.ToInt32(item["Contest_ID"].ToString()) == Record.IDContest)
                    {
                        i++;
                    }
                }
            }
            if (i== 0 || i<Record.AmountTeam)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //update record
        public bool EditRecordByIDContest(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [Contest_ID]='" + Record.IDContest + "', [Player_ID]='" + Record.IDPlayer + "', [Phase_ID]='" + Record.IDPhase + "'"
                         + ",[NumofCorrect]='" + Record.NumPass + "',[NumofIncorrect]='" + Record.NumFail + "',[Defy]='" + Record.Defy_I + "'"
                         + ",[Support]='" + Record.Support_I + "',[Exist]='" + Record.Exist_I + "',[PhaseIndex]='" + Record.PhaseIndex + "'"
                         + ",[PlayerScore]='" + Record.TeamScore + "',[TotalCorrect]='" + Record.TotalPass + "',[PlayerSequence]='" + Record.SequecePlayer + "',[PM]='" + Record.PM_I + "'"
                         + ",[Undie]= '" + Record.Undie_I + "', [PlayerTurn] = '" + Record.PlayerTurn_I + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Phase
        public bool UpdateIDPhase(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [Phase_ID]='" + Record.IDPhase + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Turn
        public bool UpdateTurn(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [PlayerTurn] = '" + Record.PlayerTurn_I + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update number of correct
        public bool UpdateNumofCorrect(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [NumofCorrect]='" + Record.NumPass + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update number of incorrect
        public bool UpdateNumofIncorrect(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [NumofIncorrect]='" + Record.NumFail + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Defy
        public bool UpdateDefy(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [Defy]='" + Record.Defy_I + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Support
        public bool UpdateSupport(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [Support]='" + Record.Support_I + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Exist
        public bool UpdateExist(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [Exist]='" + Record.Exist_I + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Phase index
        public bool UpdatePhaseIndex(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [PhaseIndex]='" + Record.PhaseIndex + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Team Score
        public bool UpdateTeamScore(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [PlayerScore]='" + Record.TeamScore + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Total Pass
        public bool UpdateTotalCorrect(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [TotalCorrect]='" + Record.TotalPass + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update PM Phase
        public bool UpdatePM(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [PM]='" + Record.PM_I + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Update to team is undie
        public bool UpdateUndie(Record Record)
        {
            string query = "UPDATE [Record]"
                         + " SET [Undie]= '" + Record.Undie_I + "'"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "' AND [Player_ID] = '" + Record.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Record
        public bool DeleteRecordByIDContest(Record Record)
        {
            string query = "DELETE FROM [Record]"
                         + " WHERE [Contest_ID] = '" + Record.IDContest + "'";
            return DA.DeleteDatabase(query);
        }

    }
}
