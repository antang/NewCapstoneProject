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
            string query = "SELECT [Round_ID],[Competition_ID],[Round_Name]"
                            + " FROM [Round]";
            DataTable dt = DA.SelectDatabase(query);
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Round Round = new Round();
                    Round.IDRound = Convert.ToInt32(item["Round_ID"].ToString());
                    Round.IDCompetition = Convert.ToInt32(item["Competition_ID"].ToString());
                    Round.NameRound = item["Round_Name"].ToString();
                    RoundList.Add(Round);
                }
            }
            return RoundList;
        }

        //select Round by id Competition
        public List<Round> GetRoundByIDCompetition(Round round)
        {
            List<Round> RoundList = new List<Round>();
            string query = "SELECT [Round_ID],[Competition_ID],[Round_Name]"
                            + " FROM [Round]"
                            + "WHERE [Competition_ID] = '"+round.IDCompetition+"'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Round Round = new Round();
                    Round.IDRound = Convert.ToInt32(item["Round_ID"].ToString());
                    Round.IDCompetition = Convert.ToInt32(item["Competition_ID"].ToString());
                    Round.NameRound = item["Round_Name"].ToString();
                    RoundList.Add(Round);
                }
            }
            return RoundList;
        }

        //Insert Round
        public bool AddRound(Round Round)
        {
            string query = "INSERT INTO [Round]([Competition_ID],[Round_Name])"
                           + " VALUES ('" + Round.IDCompetition+ "','" + Round.NameRound.Replace("'","''") + "')";
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
            string query = "SELECT [Round_ID],[Competition_ID],[Round_Name]"
                            + " FROM [Round]";
            DataTable dt = DA.SelectDatabase(query);
            int i = 0;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["Round_Name"].ToString().ToUpper() == Round.NameRound.ToUpper() && Convert.ToInt32(item["Competition_ID"])== Round.IDCompetition)
                    {
                        i++;
                    }
                }
            }
            if (i==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Edit Round
        //public bool EditRoundbyID(Round Round)
        //{
        //    string query = "UPDATE [Round] SET"
        //                 + " [Round_Name] ='" + Round.NameRound.Replace("'","''") + "'"
        //                 + " WHERE [Round_ID] = '" + Round.IDRound + "'";
        //    if (EditExistRound(Round) == true)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return DA.UpdateDatabase(query);
        //    }
        //}
        ////Edit Round exist in Round table
        //public bool EditExistRound(Round Round)
        //{
        //    string query = "SELECT [Round_ID],[Competition_ID],[Round_Name]"
        //                 + " FROM [Round]"
        //                 + " WHERE [Round_Name]= '" + Round.NameRound.ToUpper() + "'"
        //                 + " AND [Competition_ID] = '" + Round.IDCompetition + "'"
        //                 + " AND [Round_ID] <> '" + Round.IDRound + "'";
        //    DataTable dt = DA.SelectDatabase(query);
        //    if (dt != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //Delete Round
        public bool DeleteRoundbyID(Round Round)
        {
            string query = "DELETE FROM [Round]"
                         + " WHERE [Round_ID] = '" + Round.IDRound + "'";
            return DA.DeleteDatabase(query);
        }
        //GET MAXIMUM ID QUESTION
        public int MaxIDRound()
        {
            string query = "SELECT MAX(Round_ID) FROM Round";
            return DA.MaxID(query);
        }
    }
}
