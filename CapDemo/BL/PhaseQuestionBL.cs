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
    class PhaseQuestionBL
    {
        DatabaseAccess DA;
        public PhaseQuestionBL()
        {
            DA = new DatabaseAccess();
        }
        //Insert Phase
        public bool AddPhaseQuestion(Phase Phase)
        {
            string query = "INSERT INTO [PhaseQuestion]"
                + "([Phase_ID],[Question_ID],[Status],[Contest_ID])"
                + " VALUES ('" + Phase.IDPhase + "','" + Phase.IDQuestion + "', '" + Phase.Status + "', '" + Phase.IDContest + "')";
            if (DA.InsertDatabase(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //seclect question by id phase
        public List<Phase> getquestionByIDQuestion(Phase Phase)
        {
            List<Phase> PhaseList = new List<Phase>();
            string query = "SELECT p.[Phase_ID],p.[Contest_ID],p.[Phase_Name],p.[Phase_Time],p.[Phase_Score],p.[Phase_Minus],p.[Sequence],"
                        + " q.[Question_ID],q.[Catalogue_ID],q.[Question_Title],q.[Question_Name],q.[Question_Type] "
                        + " FROM [PhaseQuestion] pq"
                        + " INNER JOIN [Phase] p ON p.[Phase_ID] = pq.[Phase_ID]"
                        + " INNER JOIN [Question] q ON q.[Question_ID] = pq.[Question_ID]"
                        + " WHERE pq.[Question_ID] = '" + Phase.IDQuestion + "'";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase phase = new Phase();

                    phase.IDPhase = Convert.ToInt32(item["Phase_ID"]);
                    phase.IDContest = Convert.ToInt32(item["Contest_ID"]);
                    phase.NamePhase = (item["Phase_Name"]).ToString();
                    phase.TimePhase = Convert.ToInt32(item["Phase_Time"]);
                    phase.ScorePhase = Convert.ToInt32(item["Phase_Score"]);
                    phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"]);
                    phase.Sequence = Convert.ToInt32(item["Sequence"]);

                    phase.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    phase.NameQuestion = item["Question_Name"].ToString();
                    phase.TypeQuestion = item["Question_Type"].ToString();
                    phase.SequenceQuestion = i;
                    
                    PhaseList.Add(phase);
                    i++;
                }
            }
            return PhaseList;
        }
        //seclect question by id phase
        public List<Phase> getquestionRunGame(Phase Phase)
        {
            List<Phase> PhaseList = new List<Phase>();
            string query = "SELECT p.[Phase_ID],p.[Contest_ID],p.[Phase_Name],p.[Phase_Time],p.[Phase_Score],p.[Phase_Minus],p.[Sequence],"
                        + " q.[Question_ID],q.[Catalogue_ID],q.[Question_Title],q.[Question_Name],q.[Question_Type] "
                        + " FROM [PhaseQuestion] pq"
                        + " INNER JOIN [Phase] p ON p.[Phase_ID] = pq.[Phase_ID]"
                        + " INNER JOIN [Question] q ON q.[Question_ID] = pq.[Question_ID]"
                        + " WHERE pq.[Phase_ID] = '" + Phase.IDPhase + "' AND pq.[Status] = '"+1+"'";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase phase = new Phase();

                    phase.IDPhase = Convert.ToInt32(item["Phase_ID"]);
                    phase.IDContest = Convert.ToInt32(item["Contest_ID"]);
                    phase.NamePhase = (item["Phase_Name"]).ToString();
                    phase.TimePhase = Convert.ToInt32(item["Phase_Time"]);
                    phase.ScorePhase = Convert.ToInt32(item["Phase_Score"]);
                    phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"]);
                    phase.Sequence = Convert.ToInt32(item["Sequence"]);

                    phase.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    phase.NameQuestion = item["Question_Name"].ToString();
                    phase.TypeQuestion = item["Question_Type"].ToString();
                    phase.SequenceQuestion = i;

                    PhaseList.Add(phase);
                    i++;
                }
            }
            return PhaseList;
        }

        //seclect question by id phase
        public List<Phase> getquestionRunGame_1()
        {
            List<Phase> PhaseList = new List<Phase>();
            string query = "SELECT p.[Phase_ID],p.[Contest_ID],p.[Phase_Name],p.[Phase_Time],p.[Phase_Score],p.[Phase_Minus],p.[Sequence],"
                        + " q.[Question_ID],q.[Catalogue_ID],q.[Question_Title],q.[Question_Name],q.[Question_Type] "
                        + " FROM [PhaseQuestion] pq"
                        + " INNER JOIN [Phase] p ON p.[Phase_ID] = pq.[Phase_ID]"
                        + " INNER JOIN [Question] q ON q.[Question_ID] = pq.[Question_ID]"
                        + " WHERE pq.[Status] = '" + 1 + "'";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase phase = new Phase();

                    phase.IDPhase = Convert.ToInt32(item["Phase_ID"]);
                    phase.IDContest = Convert.ToInt32(item["Contest_ID"]);
                    phase.NamePhase = (item["Phase_Name"]).ToString();
                    phase.TimePhase = Convert.ToInt32(item["Phase_Time"]);
                    phase.ScorePhase = Convert.ToInt32(item["Phase_Score"]);
                    phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"]);
                    phase.Sequence = Convert.ToInt32(item["Sequence"]);

                    phase.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    phase.NameQuestion = item["Question_Name"].ToString();
                    phase.TypeQuestion = item["Question_Type"].ToString();
                    phase.SequenceQuestion = i;

                    PhaseList.Add(phase);
                    i++;
                }
            }
            return PhaseList;
        }

        //seclect all question in phase
        public List<Phase> getquestionRunGameS(Phase Phase)
        {
            List<Phase> PhaseList = new List<Phase>();
            string query = "SELECT p.[Phase_ID],p.[Contest_ID],p.[Phase_Name],p.[Phase_Time],p.[Phase_Score],p.[Phase_Minus],p.[Sequence],"
                        + " q.[Question_ID],q.[Catalogue_ID],q.[Question_Title],q.[Question_Name],q.[Question_Type], pq.[Status] "
                        + " FROM [PhaseQuestion] pq"
                        + " INNER JOIN [Phase] p ON p.[Phase_ID] = pq.[Phase_ID]"
                        + " INNER JOIN [Question] q ON q.[Question_ID] = pq.[Question_ID]"
                        + " WHERE pq.[Phase_ID] = '" + Phase.IDPhase + "'";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase phase = new Phase();

                    phase.IDPhase = Convert.ToInt32(item["Phase_ID"]);
                    phase.IDContest = Convert.ToInt32(item["Contest_ID"]);
                    phase.NamePhase = (item["Phase_Name"]).ToString();
                    phase.TimePhase = Convert.ToInt32(item["Phase_Time"]);
                    phase.ScorePhase = Convert.ToInt32(item["Phase_Score"]);
                    phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"]);
                    phase.Sequence = Convert.ToInt32(item["Sequence"]);

                    phase.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    phase.NameQuestion = item["Question_Name"].ToString();
                    phase.TypeQuestion = item["Question_Type"].ToString();
                    phase.StatusShow = (bool)item["Status"];
                    phase.SequenceQuestion = i;

                    PhaseList.Add(phase);
                    i++;
                }
            }
            return PhaseList;
        }

        //seclect question by id phase
        public List<Phase> getquestionByIDContest(Phase Phase)
        {
            List<Phase> PhaseList = new List<Phase>();
            string query = "SELECT p.[Phase_ID],p.[Contest_ID],p.[Phase_Name],p.[Phase_Time],p.[Phase_Score],p.[Phase_Minus],p.[Sequence],"
                        + " q.[Question_ID],q.[Catalogue_ID],q.[Question_Title],q.[Question_Name],q.[Question_Type] "
                        + " FROM [PhaseQuestion] pq"
                        + " INNER JOIN [Phase] p ON p.[Phase_ID] = pq.[Phase_ID]"
                        + " INNER JOIN [Question] q ON q.[Question_ID] = pq.[Question_ID]"
                        + " WHERE p.[Contest_ID] = '" + Phase.IDContest + "'";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Phase phase = new Phase();

                    phase.IDPhase = Convert.ToInt32(item["Phase_ID"]);
                    phase.IDContest = Convert.ToInt32(item["Contest_ID"]);
                    phase.NamePhase = (item["Phase_Name"]).ToString();
                    phase.TimePhase = Convert.ToInt32(item["Phase_Time"]);
                    phase.ScorePhase = Convert.ToInt32(item["Phase_Score"]);
                    phase.MinusPhase = Convert.ToInt32(item["Phase_Minus"]);
                    phase.Sequence = Convert.ToInt32(item["Sequence"]);

                    phase.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    //phase.Question.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"]);
                    //phase.NameQuestion = item["Question_Title"].ToString();
                    phase.NameQuestion = item["Question_Name"].ToString();
                    phase.TypeQuestion = item["Question_Type"].ToString();
                    phase.SequenceQuestion = i;

                    //phase.Question.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    ////phase.Question.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"]);
                    //phase.Question.NameQuestion = item["Question_Title"].ToString();
                    //phase.Question.NameQuestion = item["Question_Name"].ToString();
                    //phase.Question.TypeQuestion = item["Question_Type"].ToString();
                    //phase.Question.Sequence = i;

                    PhaseList.Add(phase);
                    i++;
                }
            }
            return PhaseList;
        }
        //EDIT QUESTION AND ANSWER
        //EDIT QUESTION
        public bool EditQuestionStatus(Phase Phase)
        {
            string query = "UPDATE PhaseQuestion"
                         + " SET Status ='"+0+"'"
                         + " WHERE Question_ID = '" + Phase.IDQuestion + "' AND Phase_ID = '" + Phase.IDPhase+ "' ";
            return DA.UpdateDatabase(query);
        }

        //EDIT QUESTION
        public bool EditQuestionStatus_1(Phase Phase)
        {
            string query = "UPDATE PhaseQuestion"
                         + " SET Status ='" + 0 + "'"
                         + " WHERE Question_ID = '" + Phase.IDQuestion + "' AND Phase_ID = '" + Phase.IDContest + "' ";
            return DA.UpdateDatabase(query);
        }
        //delete question
        //Delete Phase
        public bool DeleteQuestionbyID(Phase Phase)
        {
            string query = "DELETE FROM [PhaseQuestion]"
                         + " WHERE [Question_ID] = '" + Phase.IDQuestion + "' AND [Phase_ID] = '" + Phase.IDPhase+ "'";
            return DA.DeleteDatabase(query);
        }
        public bool DeletePhaseQuestionbyIDQuestion(Question Question)
        {
            string query = "DELETE FROM [PhaseQuestion]"
                         + " WHERE [Question_ID] = '" + Question.IDQuestion + "'";
            return DA.DeleteDatabase(query);
        }

        public bool DeletePhaseQuestionbyIDPhase(Phase Phase)
        {
            string query = "DELETE FROM [PhaseQuestion]"
                         + " WHERE [Phase_ID] = '" + Phase.IDPhase + "'";
            return DA.DeleteDatabase(query);
        }

        public bool DeletePhaseQuestionbyIDContest(Phase Phase)
        {
            string query = "DELETE FROM [PhaseQuestion]"
                         + " WHERE [Contest_ID] = '" + Phase.IDContest + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
