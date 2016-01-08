using CapDemo.DA;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string query = "SELECT [Contest_ID],[Round_ID],[Contest_Name],[Bonus],[Request_Time],[Challenge_Score],[Number_Challenge]"
                        + ",[Time_show_Anwer],[Time_show_Question],[Time_of_True],[Time_of_False]"
                        + " FROM [Contest]";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Contest Contest = new Contest();
                    Contest.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Contest.IDRound = Convert.ToInt32(item["Round_ID"].ToString());
                    Contest.NameContest = (item["Contest_Name"]).ToString();
                    Contest.Bonus = Convert.ToInt32(item["Bonus"].ToString());
                    Contest.TimeSupport = Convert.ToInt32(item["Request_Time"].ToString());
                    Contest.ChallengceScore = Convert.ToInt32(item["Challenge_Score"].ToString());
                    Contest.NumberChallenge = Convert.ToInt32(item["Number_Challenge"].ToString());
                    Contest.TimeShowAnswer = Convert.ToInt32(item["Time_show_Anwer"].ToString());
                    Contest.TimeShowQuestion = Convert.ToInt32(item["Time_show_Question"].ToString());
                    Contest.TimesTrue = Convert.ToInt32(item["Time_of_True"].ToString());
                    Contest.TimesFalse= Convert.ToInt32(item["Time_of_False"].ToString());

                    ContestList.Add(Contest);
                    //i++;
                }
            }
            return ContestList;
        }
        //Get competition/round/contest

        public List<Contest> GetAllSetup()
        {
            List<Contest> ContestList = new List<Contest>();
            string query = "SELECT c.[Contest_ID],c.[Round_ID],c.[Contest_Name],c.[Bonus],c.[Request_Time],c.[Challenge_Score],c.[Number_Challenge]"
                        + ",c.[Time_show_Anwer],c.[Time_show_Question],c.[Time_of_True],c.[Time_of_False]"
                        + ",r.[Round_Name],n.[Competition_Name],r.[Competition_ID], c.[EndContest]"
                        + " FROM [Contest] c"
                        + " INNER JOIN [Round] r ON r.[Round_ID] = c.[Round_ID]"
                        + " INNER JOIN [Competition] n ON n.[Competition_ID] = r.[Competition_ID]";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Contest Contest = new Contest();
                    Contest.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Contest.IDRound = Convert.ToInt32(item["Round_ID"].ToString());
                    Contest.NameContest = (item["Contest_Name"]).ToString();
                    Contest.Bonus = Convert.ToInt32(item["Bonus"].ToString());
                    Contest.TimeSupport = Convert.ToInt32(item["Request_Time"].ToString());
                    Contest.ChallengceScore = Convert.ToInt32(item["Challenge_Score"].ToString());
                    Contest.NumberChallenge = Convert.ToInt32(item["Number_Challenge"].ToString());
                    Contest.TimeShowAnswer = Convert.ToInt32(item["Time_show_Anwer"].ToString());
                    Contest.TimeShowQuestion = Convert.ToInt32(item["Time_show_Question"].ToString());
                    Contest.TimesTrue = Convert.ToInt32(item["Time_of_True"].ToString());
                    Contest.Status = (bool)item["EndContest"];
                    //round
                    Contest.TimesFalse = Convert.ToInt32(item["Time_of_False"].ToString());
                    Contest.Round.IDRound = Convert.ToInt32(item["Round_ID"].ToString());
                    Contest.Round.IDCompetition = Convert.ToInt32(item["Competition_ID"].ToString());
                    Contest.Round.NameRound = (item["Round_Name"]).ToString();
                    Contest.Competition.NameCompetition = (item["Competition_Name"]).ToString();

                    ContestList.Add(Contest);
                    //i++;
                }
            }
            return ContestList;
        }

        //Get contest to run game
        public List<Contest> GetContestByID(Contest contest)
        {
            List<Contest> ContestList = new List<Contest>();
            string query = "SELECT c.[Contest_ID],c.[Round_ID],c.[Contest_Name],c.[Bonus],c.[Request_Time],c.[Challenge_Score],c.[Number_Challenge]"
                        + ",c.[Time_show_Anwer],c.[Time_show_Question],c.[Time_of_True],c.[Time_of_False]"
                        //+ ",ph.[Phase_Name],ph.[Phase_ID],ph.[Phase_Time],ph.[Phase_Score],ph.[Sequence]"
                        //+ ",pl.[Player_Name],pl.[Player_ID],pl.[Color],pl.[Player_Score],pl.[Player_Sequence]"
                        + " FROM [Contest] c"
                        //+ " INNER JOIN Player pl ON pl.Contest_ID = c.Contest_ID"
                        //+ " INNER JOIN Phase ph ON ph.Contest_ID = c.Contest_ID"
                        + " WHERE c.[Contest_ID] = '" + contest.IDContest + "'";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 0;
            if (dt != null)
            {
                
                foreach (DataRow item in dt.Rows)
                {
                    Contest Contest = new Contest();
                    Contest.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Contest.IDRound = Convert.ToInt32(item["Round_ID"].ToString());
                    Contest.NameContest = (item["Contest_Name"]).ToString();
                    Contest.Bonus = Convert.ToInt32(item["Bonus"].ToString());
                    Contest.TimeSupport = Convert.ToInt32(item["Request_Time"].ToString());
                    Contest.ChallengceScore = Convert.ToInt32(item["Challenge_Score"].ToString());
                    Contest.NumberChallenge = Convert.ToInt32(item["Number_Challenge"].ToString());
                    Contest.TimeShowAnswer = Convert.ToInt32(item["Time_show_Anwer"].ToString());
                    Contest.TimeShowQuestion = Convert.ToInt32(item["Time_show_Question"].ToString());
                    Contest.TimesTrue = Convert.ToInt32(item["Time_of_True"].ToString());
                    Contest.TimesFalse = Convert.ToInt32(item["Time_of_False"].ToString());
                    //Player
                    //Contest.Player.PlayerName = (item["Player_Name"].ToString());
                    //Contest.Player.PlayerScore = Convert.ToInt32( (item["Player_Score"].ToString()));
                    //Contest.Player.Sequence = Convert.ToInt32((item["Player_Sequence"].ToString()));
                    ////Contest.Player.IDPlayer = Convert.ToInt32((item["Player_ID"].ToString()));
                    ////Contest.Player.PlayerName = (item["Player_Name"].ToString());
                    //Contest.PlayerList.Add(Contest.Player);
                    

                    ContestList.Add(Contest);
                    //i++;
                }
               
            }
            return ContestList;
        }

        //Get round by id contest
        public List<Contest> GetRoundByIDContest(Contest contest)
        {
            List<Contest> ContestList = new List<Contest>();
            string query = "SELECT c.[Contest_ID],c.[Round_ID],c.[Contest_Name],c.[Bonus],c.[Request_Time],c.[Challenge_Score],c.[Number_Challenge]"
                        + ",c.[Time_show_Anwer],c.[Time_show_Question],c.[Time_of_True],c.[Time_of_False], r.[Round_Name]"
                        + " FROM [Contest] c"
                        + " INNER JOIN Round r ON r.Round_ID = c.Round_ID"
                        + " WHERE c.[Contest_ID] = '" + contest.IDContest + "'";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 0;
            if (dt != null)
            {

                foreach (DataRow item in dt.Rows)
                {
                    Contest Contest = new Contest();
                    Contest.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Contest.IDRound = Convert.ToInt32(item["Round_ID"].ToString());
                    Contest.NameContest = (item["Contest_Name"]).ToString();
                    Contest.Bonus = Convert.ToInt32(item["Bonus"].ToString());
                    Contest.TimeSupport = Convert.ToInt32(item["Request_Time"].ToString());
                    Contest.ChallengceScore = Convert.ToInt32(item["Challenge_Score"].ToString());
                    Contest.NumberChallenge = Convert.ToInt32(item["Number_Challenge"].ToString());
                    Contest.TimeShowAnswer = Convert.ToInt32(item["Time_show_Anwer"].ToString());
                    Contest.TimeShowQuestion = Convert.ToInt32(item["Time_show_Question"].ToString());
                    Contest.TimesTrue = Convert.ToInt32(item["Time_of_True"].ToString());
                    Contest.TimesFalse = Convert.ToInt32(item["Time_of_False"].ToString());
                    Contest.Round.NameRound = (item["Round_Name"].ToString());
                    ContestList.Add(Contest);
                }

            }
            return ContestList;
        }
        //Insert Contest
        public bool AddContest(Contest Contest)
        {
            string query = "INSERT INTO [Contest]"
                +"([Round_ID],[Contest_Name],[Bonus],[Request_Time],[Challenge_Score],[Number_Challenge],"
                +"[Time_show_Anwer],[Time_show_Question],[Time_of_True],[Time_of_False],[EndContest])"
                + " VALUES ('" + Contest.IDRound + "','" + Contest.NameContest.Replace("'", "''") + "','" + Contest.Bonus + "',"
                            + "'" + Contest.TimeSupport + "','" + Contest.ChallengceScore + "','" + Contest.NumberChallenge + "',"
                            + "'" + Contest.TimeShowAnswer + "','" + Contest.TimeShowQuestion + "','" + Contest.TimesTrue + "','" + Contest.TimesFalse + "','" + Contest.EndContest + "')";
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
            string query = "SELECT [Contest_ID],[Round_ID],[Contest_Name],[Bonus],[Request_Time],[Challenge_Score],[Number_Challenge]"
                        + ",[Time_show_Anwer],[Time_show_Question],[Time_of_True],[Time_of_False]"
                        + " FROM [Contest]";
            DataTable dt = DA.SelectDatabase(query);
            int i = 0;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (Convert.ToInt32(item["Round_ID"])==Contest.IDRound && item["Contest_Name"].ToString().ToUpper()==Contest.NameContest.ToUpper())
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

        //Edit Contest
        public bool EditContestbyID(Contest Contest)
        {
            string query = "UPDATE [Contest]"
                         + " SET [Round_ID] = '" + Contest.IDRound + "',[Contest_Name] = '" + Contest.NameContest.Replace("'", "''") + "'"
                         + ",[Bonus]='" + Contest.Bonus + "',[Request_Time]='" + Contest.TimeSupport + "'"
                         + ",[Challenge_Score] = '" + Contest.ChallengceScore + "', [Number_Challenge] = '" + Contest.NumberChallenge + "'"
                         + ",[Time_show_Anwer] = '" + Contest.TimeShowAnswer + "', [Time_show_Question] = '" + Contest.TimeShowQuestion + "'"
                         + ",[Time_of_True] = '" + Contest.TimesTrue + "', [Time_of_False] = '" + Contest.TimesFalse + "'"
                         + " WHERE [Contest_ID] = '" + Contest.IDContest + "'";
            if (EditExistContest(Contest) == true)
            {
                return false;
            }
            else
            {
                return DA.UpdateDatabase(query);
            }
        }
        //Update contest by id
        public bool EditGeneralSetting(Contest Contest)
        {
            string query = "UPDATE [Contest]"
                         + " SET [Round_ID] = '" + Contest.IDRound + "',[Contest_Name] = '" + Contest.NameContest.Replace("'", "''") + "'"
                         + ",[Bonus]='" + Contest.Bonus + "'"
                         + ",[Time_show_Anwer] = '" + Contest.TimeShowAnswer + "', [Time_show_Question] = '" + Contest.TimeShowQuestion + "'"
                         + ",[Time_of_True] = '" + Contest.TimesTrue + "', [Time_of_False] = '" + Contest.TimesFalse + "'"
                         + " WHERE [Contest_ID] = '" + Contest.IDContest + "'";
            if (EditExistContest(Contest) == true)
            {
                return false;
            }
            else
            {
                return DA.UpdateDatabase(query);
            }
        }

        //Update status contest when contest have run
        public bool EditStatusContestbyID(Contest Contest)
        {
            string query = "UPDATE [Contest]"
                         + " SET [EndContest] = '" + Contest.EndContest + "'"
                         + " WHERE [Contest_ID] = '" + Contest.IDContest + "'";
            
            return DA.UpdateDatabase(query);
           
        }
        //Check Edit Contest Exist
        public bool EditExistContest(Contest Contest)
        {
            string query = "SELECT [Contest_ID],[Round_ID],[Contest_Name],[Bonus],[Request_Time],[Challenge_Score],[Number_Challenge]"
                        + ",[Time_show_Anwer],[Time_show_Question],[Time_of_True],[Time_of_False]"
                        + " FROM [Contest]";
            DataTable dt = DA.SelectDatabase(query);
            int i = 0;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (Convert.ToInt32(item["Round_ID"]) == Contest.IDRound && item["Contest_Name"].ToString().ToUpper() == Contest.NameContest.ToUpper() && Convert.ToInt32(item["Contest_ID"])!=Contest.IDContest)
                    {
                        i++;
                    }
                }
            }
            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Delete Contest
        public bool DeleteContestbyID(Contest Contest)
        {
            string query = "DELETE FROM [Contest]"
                         + " WHERE [Contest_ID] = '" + Contest.IDContest + "'";
            return DA.DeleteDatabase(query);
        }
        //GET MAXIMUM ID QUESTION
        public int MaxIDContest()
        {
            string query = "SELECT MAX(Contest_ID) FROM Contest";
            return DA.MaxID(query);
        }
    }
}
