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
    class QuestionBL
    {
        DatabaseAccess DA;
        FileAccess FA;
        public QuestionBL()
        {
            DA = new DatabaseAccess();
            FA = new FileAccess();
        }
        //SELECT All QUESTION
        public List<Question> GetQuestion()
        {
            List<Question> QuestionList = new List<Question>();
            string query = "SELECT q.Question_ID, q.Question_Name, q.Question_Type, c.Catalogue_Name"
                         + " FROM Question q"
                         + " INNER JOIN Catalogue c ON c.Catalogue_ID = q.Catalogue_ID";
                         
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Question Question = new Question();
                    Question.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    Question.NameQuestion = item["Question_Name"].ToString();
                    Question.TypeQuestion = item["Question_Type"].ToString();
                    Question.NameCatalogue = item["Catalogue_Name"].ToString();
                    //Question.Catalogue.NameCatalogue = item["Catalogue_Name"].ToString();
                    QuestionList.Add(Question);
                }
            }
            return QuestionList;
        }

        //Select question by ID question
        public List<Question> GetQuestionByCatalogue(Catalogue Catalogue)
        {
            List<Question> QuestionList = new List<Question>();
            string query = "SELECT q.Question_ID, q.Question_Name, q.Question_Type, c.Catalogue_Name"
                         + " FROM Question q "
                         + " INNER JOIN Catalogue c ON c.Catalogue_ID = q.Catalogue_ID"
                         + " WHERE q.Catalogue_ID='"+Catalogue.IDCatalogue+"'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Question Question = new Question();
                    Question.IDQuestion = Convert.ToInt32(item["Question_ID"]);
                    Question.NameQuestion = item["Question_Name"].ToString();
                    Question.TypeQuestion = item["Question_Type"].ToString();
                    Question.NameCatalogue = item["Catalogue_Name"].ToString();
                    QuestionList.Add(Question);
                }
            }
            return QuestionList;
        }

        //INSERT QUESTION
        public bool AddQuestion(Question Question)
        {
            string query = "INSERT INTO Question (Question_Name, Question_Type, Catalogue_ID)"
                        + " VALUES ('" + Question.NameQuestion + "','" + Question.TypeQuestion + "','" + Question.IDCatalogue + "')";

            return DA.InsertDatabase(query);
        }
        //INSERT ANSWER
        public bool AddAnswer( Answer Answer)
        {
            string query= " INSERT INTO Answer (Answer_Name, Correct_Answer, Question_ID)"
                        + " VALUES ('" + Answer.ContentAnswer + "','" + Answer.IsCorrect + "','" + Answer.IDQuestion + "')";
            return DA.InsertDatabase(query);
        }

        //EDIT QUESTION
        public bool EditQuestionbyID(Question Question)
        {
            string query = "UPDATE Question"
                         + " SET Catalogue_Name ='" + Question.NameQuestion + "'"
                         + " WHERE Question_ID = '" + Question.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }

        //EDIT ANSWER
        public bool EditAnswerbyID(Answer Answer)
        {
            string query = "UPDATE Answer"
                         + " SET Answer_Name ='" + Answer.ContentAnswer + "', Correct_Answer='" + Answer.IsCorrect + "'"
                         + " WHERE Question_ID = '" + Answer.IDQuestion + "' AND Answer_ID='" + Answer.IDAnswer + "'";
            return DA.UpdateDatabase(query);
        }

        //DELETE QUESTION
        public bool DeleteQuestionByID(Question Question)
        {
            string query = "DELETE FROM Question"
                          + " WHERE Question_ID = '" + Question.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }
        //DELETE ANSWER
        public bool DeleteQuestionByIDQuestion(Answer Answer)
        {
            string query = "DELETE FROM Answer"
                          + " WHERE Question_ID = '" + Answer.IDQuestion + "'";
            return DA.UpdateDatabase(query);
        }

        // load file content
        public List<Question> GetFile(string file)
        {
            string content= FA.FileContent(file);

            int stt = 1;
            DataTable dtb = new DataTable();
            dtb.Columns.Add("Sequence", typeof(string));
            dtb.Columns.Add("NameQuestion", typeof(string));
            dtb.Columns.Add("TypeQuestion", typeof(string));
            dtb.Columns.Add("Answer", typeof(string));

            string[] QuestionContent = content.Split(new string[] { "/**/" }, StringSplitOptions.None);

            for (int i = 0; i < QuestionContent.Length; i++)
            {
                string[] QuestionItem = QuestionContent[i].Split(new string[] { "---" }, StringSplitOptions.None);
                dtb.Rows.Add(stt.ToString(), QuestionItem[0], QuestionItem[1], QuestionItem[2]);
                stt++;
            }

            List<Question> QuestionList = new List<Question>();
            if (dtb != null)
            {
                foreach (DataRow item in dtb.Rows)
                {
                    Question Question = new Question();
                    Question.Sequence = Convert.ToInt32(item["Sequence"]);
                    Question.NameQuestion = item["NameQuestion"].ToString();
                    Question.TypeQuestion = item["TypeQuestion"].ToString();
                    Question.AnswerContent = item["Answer"].ToString();
                    QuestionList.Add(Question);
                }
            }
            return QuestionList;
        }

        //Get Max Question
        public int MaxIDQuestion()
        {
            string query = "SELECT MAX(Question_ID) FROM Question";
            return DA.MaxID(query);
        }


    }
}
