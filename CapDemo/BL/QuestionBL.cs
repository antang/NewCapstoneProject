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
    class QuestionBL
    {
        DatabaseAccess DA;
        FileAccess FA;
        public QuestionBL()
        {
            DA = new DatabaseAccess();
            FA = new FileAccess();
        }
//SELECT QUESTION
        //SELECT All QUESTION
        public List<Question> GetQuestion()
        {
            List<Question> QuestionList = new List<Question>();
            string query = "SELECT q.Question_ID,q.Question_Title, q.Question_Name, q.Question_Type, q.Catalogue_ID, c.Catalogue_Name, q.Question_Title, q.[Date_Create]"
                         + " FROM Question q"
                         + " INNER JOIN Catalogue c ON c.Catalogue_ID = q.Catalogue_ID";
                         
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Question Question = new Question();
                    Question.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    Question.QuestionTitle = item["Question_Title"].ToString();
                    Question.NameQuestion = item["Question_Name"].ToString();
                    Question.TypeQuestion = item["Question_Type"].ToString();
                    Question.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"]);
                    //Question.NameCatalogue = item["Catalogue_Name"].ToString();
                    Question.Date = (DateTime)item["Date_Create"];
                    Question.Sequence = i;
                    Question.Catalogue.NameCatalogue = item["Catalogue_Name"].ToString();
                    //Question.Catalogue.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"]);
                    QuestionList.Add(Question);
                    i++;
                }
            }
            return QuestionList;
        }

        public List<Question> GetQuestionByID(Question question)
        {
            List<Question> QuestionList = new List<Question>();
            string query = "SELECT q.Question_ID,q.Question_Title, q.Question_Name, q.Question_Type, q.Catalogue_ID, c.Catalogue_Name, q.Question_Title, q.[Date_Create]"
                         + " FROM Question q"
                         + " INNER JOIN Catalogue c ON c.Catalogue_ID = q.Catalogue_ID"
                         + " WHERE q.Question_ID='" + question.IDQuestion + "'";

            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Question Question = new Question();
                    Question.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    Question.QuestionTitle = item["Question_Title"].ToString();
                    Question.NameQuestion = item["Question_Name"].ToString();
                    Question.TypeQuestion = item["Question_Type"].ToString();
                    Question.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"]);
                    //Question.NameCatalogue = item["Catalogue_Name"].ToString();
                    Question.Date = (DateTime)item["Date_Create"];
                    Question.Sequence = i;
                    Question.Catalogue.NameCatalogue = item["Catalogue_Name"].ToString();
                    //Question.Catalogue.IDCatalogue = Convert.ToInt32(item["Catalogue_ID"]);
                    QuestionList.Add(Question);
                    i++;
                }
            }
            return QuestionList;
        }

        //Select question by ID catalogue
        public List<Question> GetQuestionByCatalogue(Catalogue Catalogue)
        {
            List<Question> QuestionList = new List<Question>();
            string query = "SELECT q.Question_ID, q.Question_Title, q.Question_Name, q.Question_Type, c.Catalogue_Name"
                         + " FROM Question q "
                         + " INNER JOIN Catalogue c ON c.Catalogue_ID = q.Catalogue_ID"
                         + " WHERE q.Catalogue_ID='"+Catalogue.IDCatalogue+"'";
            DataTable dt = DA.SelectDatabase(query);
            int i=1;
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Question Question = new Question();
                    Question.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    Question.QuestionTitle = item["Question_Title"].ToString();
                    Question.NameQuestion = item["Question_Name"].ToString();
                    Question.TypeQuestion = item["Question_Type"].ToString();
                    Question.NameCatalogue = item["Catalogue_Name"].ToString();
                    Question.Sequence = i;
                    QuestionList.Add(Question);
                    i++;
                }
            }
            return QuestionList;
        }
        //Select Answer by Question ID
        public List<Answer> GetAnswerByQuestionID(Question Question)
        {
            List<Answer> AnswerList = new List<Answer>();
            string query = "SELECT a.Answer_ID, a.Answer_Name, a.Question_ID, a.Correct_Answer"
                         + " FROM Answer a "
                         + " WHERE a.Question_ID='" + Question.IDQuestion + "'";
            //string query = "SELECT *"
            //            + " FROM Answer a "
            //            + " WHERE a.Question_ID='" + Question.IDQuestion + "'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Answer Answer = new Answer();
                    Answer.IDAnswer = Convert.ToInt32(item["Answer_ID"]);
                    Answer.ContentAnswer = item["Answer_Name"].ToString() ;
                    Answer.IDQuestion = Convert.ToInt32(item["Question_ID"].ToString());
                    Answer.IsCorrect = (bool)item["Correct_Answer"];
                    AnswerList.Add(Answer);
                }
            }
            return AnswerList;
        }

//INSERT QUESTION AND CATALOGUE
        //INSERT QUESTION
        public bool AddQuestion(Question Question)
        {
            string query = "INSERT INTO Question (Question_Title,Question_Name, Question_Type, Catalogue_ID, Date_Create)"
                        + " VALUES ('" + Question.QuestionTitle.Replace("'", "''") + "','" + Question.NameQuestion.Replace("'", "''") + "','" + Question.TypeQuestion + "','" + Question.IDCatalogue + "','" + Question.Date.ToString("yyyy-MM-dd hh:mm:ss") + "')";

            return DA.InsertDatabase(query);


        }
        //INSERT ANSWER
        public bool AddAnswer( Answer Answer)
        {
            string query= " INSERT INTO Answer (Answer_Name, Correct_Answer, Question_ID, Catalogue_ID)"
                        + " VALUES ('" + Answer.ContentAnswer.Replace("'", "''") + "'," +Answer.Check + ",'" + Answer.IDQuestion + "','" + Answer.IDCatalogue + "')";
            return DA.InsertDatabase(query);
        }
//EDIT QUESTION AND ANSWER
        //EDIT QUESTION
        public bool EditQuestionbyID(Question Question)
        {
            string query = "UPDATE Question"
                         + " SET Question_Name ='" + Question.NameQuestion.Replace("'", "''") + "'"
                         + " WHERE Question_ID = '" + Question.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }
        //Update Question Type
        public bool EditQuestionTypebyID(Question Question)
        {
            string query = "UPDATE Question"
                         + " SET Question_Type ='" + Question.TypeQuestion + "'"
                         + " WHERE Question_ID = '" + Question.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }

        //EDIT ANSWER
        public bool EditAnswerbyID(Answer Answer)
        {
            string query = "UPDATE Answer"
                         + " SET Answer_Name ='" + Answer.ContentAnswer.Replace("'", "''") + "', Correct_Answer='" + Answer.Check + "'"
                         + " WHERE Question_ID = '" + Answer.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }
//DELETE QUESTION
        //DELETE QUESTION
        public bool DeleteQuestionByID(Question Question)
        {
            string query = "DELETE FROM Question"
                          + " WHERE Question_ID = '" + Question.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }
        //DELETE ANSWER
        public bool DeleteAnswerByIDQuestion(Question Question)
        {
            string query = "DELETE FROM Answer"
                          + " WHERE Question_ID = '" + Question.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }
//LOAD FILE QUESTION
        // LOAD QUESTION FILE XML

        public List<Question> GetFileXML(string file)
        {
            if (FA.FileContentXML(file) == null)
            {
                return null;
            }
            else
            {
                string content = FA.FileContentXML(file);
                int stt = 1;
                DataTable dtb = new DataTable();
                dtb.Columns.Add("Sequence", typeof(string));
                dtb.Columns.Add("QuestionTitle", typeof(string));
                dtb.Columns.Add("NameQuestion", typeof(string));
                dtb.Columns.Add("TypeQuestion", typeof(string));
                dtb.Columns.Add("AnswerContent", typeof(string));

                string[] QuestionContent = content.Split(new string[] { "</question>" }, StringSplitOptions.None);

                for (int i = 0; i < QuestionContent.Length - 1; i++)
                {
                    string[] QuestionItem = QuestionContent[i].Split(new string[] { "---" }, StringSplitOptions.None);
                    dtb.Rows.Add(stt.ToString(),QuestionItem[1], QuestionItem[2], QuestionItem[0], QuestionItem[3]);
                    stt++;
                }

                List<Question> QuestionList = new List<Question>();
                if (dtb != null && dtb.Rows.Count > 0)
                {
                    foreach (DataRow item in dtb.Rows)
                    {
                        Question Question = new Question();
                        Question.Sequence = Convert.ToInt32(item["Sequence"]);
                        Question.QuestionTitle = item["QuestionTitle"].ToString();
                        Question.NameQuestion = item["NameQuestion"].ToString();
                        Question.TypeQuestion = item["TypeQuestion"].ToString();

                        string AnswerContent = item["AnswerContent"].ToString().Trim().Replace("''","'");
                        AnswerContent = AnswerContent.Replace("+++", "---");
                        Question.AnswerContent = AnswerContent;
                        QuestionList.Add(Question);
                    }
                    return QuestionList;
                }
                else
                {
                    return null;
                } 
            }
            
        }

        //LOAD QUESTION FILE TEXT
        public List<Question> GetFileTXT(string file)
        {
            string content = FA.FileContentTXT(file);

            int stt = 1;
            DataTable dtb = new DataTable();
            dtb.Columns.Add("Sequence", typeof(string));
            dtb.Columns.Add("QuestionTitle", typeof(string));
            dtb.Columns.Add("NameQuestion", typeof(string));
            dtb.Columns.Add("TypeQuestion", typeof(string));
            dtb.Columns.Add("AnswerContent", typeof(string));

            content = content.Replace("[Q]", "");
            content = content.Replace("[NQ]", "---");
            content = content.Replace("[/NQ]", "");
            content = content.Replace("[TQ]", "---");
            content = content.Replace("[/TQ]", "---");

            string[] QuestionContent = content.Split(new string[] { "[/Q]" }, StringSplitOptions.None);

            for (int i = 0; i < QuestionContent.Length-1; i++)
            {
                string[] QuestionItem = QuestionContent[i].Split(new string[] { "---" }, StringSplitOptions.None);
                dtb.Rows.Add(stt.ToString(), QuestionItem[1], QuestionItem[0], QuestionItem[2], QuestionItem[3]);
                stt++;
            }

            List<Question> QuestionList = new List<Question>();
            if (dtb != null && dtb.Rows.Count>0)
            {
                foreach (DataRow item in dtb.Rows)
                {
                    Question Question = new Question();
                    Question.Sequence = Convert.ToInt32(item["Sequence"]);
                    Question.QuestionTitle = item["QuestionTitle"].ToString();
                    Question.NameQuestion = item["NameQuestion"].ToString();
                    Question.TypeQuestion = item["TypeQuestion"].ToString();

                    string AnswerContent = item["AnswerContent"].ToString().Trim().Replace("[A][P]", "");
                    AnswerContent = AnswerContent.Replace("[/P]", "---");
                    AnswerContent = AnswerContent.Replace("[/A]", "</answer>");
                    Question.AnswerContent = AnswerContent;

                    QuestionList.Add(Question);
                }
                return QuestionList;
            }
            else
            {
                return null;
            }  
        }

        //GET MAXIMUM ID QUESTION
        public int MaxIDQuestion()
        {
            string query = "SELECT MAX(Question_ID) FROM Question";
            return DA.MaxID(query);
        }
//LOAD DATA TABLE QUESTION
        public DataTable DatatableQuestion()
        {
            string query = "SELECT q.Question_ID, q.Question_Title, q.Question_Name, q.Question_Type, q.Catalogue_ID, c.Catalogue_Name, q.Date_Create"
                         + " FROM Question q"
                         + " INNER JOIN Catalogue c ON c.Catalogue_ID = q.Catalogue_ID";

            DataTable dt = DA.SelectDatabase(query);
            return dt;
        }


    }
}
