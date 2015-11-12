using CapDemo.BL;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            loadCatalogue();
            //loadQuestion();

            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                        comboBox1.Items.Add(CatList.ElementAt(i).NameCatalogue);
                }
            
        }

        public void loadCatalogue()
        {
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                dataGridView1.DataSource = CatList;
           // int s = CatList.ElementAt(0).IDCatalogue;
        }

        public void loadQuestion()
        {
            QuestionBL QuestionBL = new QuestionBL();
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestion();
            if (QuestionList != null)
                dataGridView1.DataSource = QuestionList;
            dataGridView1.Columns["IDCatalogue"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //notifyIcon1.ShowBalloonTip(5000, "Hello", "Noi dung", ToolTipIcon.Info);
            Catalogue cata = new Catalogue();
            cata.NameCatalogue = textBox1.Text;

            CatalogueBL catabl = new CatalogueBL();
            catabl.AddCatalogue(cata);
            loadCatalogue();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Catalogue cata = new Catalogue();
            cata.IDCatalogue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
            CatalogueBL catabl = new CatalogueBL();
            //delete catalouge and question
            catabl.DeleteQuestionbyIDCatalogue(cata);
            catabl.DeleteCataloguebyID(cata);
            loadCatalogue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuestionBL questionBL = new QuestionBL();
            OpenFileDialog OpenFile = new OpenFileDialog();
            DialogResult Result = OpenFile.ShowDialog();
            if (Result == DialogResult.OK)
            {
                  QuestionBL QuestionBL = new QuestionBL();

                  List<DO.Question> QuestionList;
                  QuestionList = QuestionBL.GetFile(OpenFile.FileName);
                  if (QuestionList != null)
                    dataGridView1.DataSource = QuestionList;


                  dataGridView1.Columns["IDCatalogue"].Visible = false;
                  dataGridView1.Columns["IDQuestion"].Visible = false;
                  dataGridView1.Columns["NameCatalogue"].Visible = false;
                  dataGridView1.Columns["AnswerContent"].Visible = false;
                  DataGridViewCheckBoxColumn CheckColumn = new DataGridViewCheckBoxColumn();
                  CheckColumn.Name="check";
                  dataGridView1.Columns.Add(CheckColumn);
                  
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            Answer answer = new Answer();
            QuestionBL questionBL = new QuestionBL();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["NameQuestion"].Value != null && row.Cells["check"].Value != null)
                {
                    question.NameQuestion = row.Cells["NameQuestion"].Value.ToString();
                    question.TypeQuestion = row.Cells["TypeQuestion"].Value.ToString();
                    question.IDCatalogue = Convert.ToInt32(textBox2.Text);
                    questionBL.AddQuestion(question);

                    //textBox1.Text = row.Cells["AnswerContent"].Value.ToString().Trim();
                    string[] AnswerItem = row.Cells["AnswerContent"].Value.ToString().Trim().Split('\t');
                    for (int i = 0; i < AnswerItem.Length; i++)
                    {
                        textBox1.Text += AnswerItem[i];
                        if (AnswerItem[i].Contains("[T]") == true)
                        {
                            answer.IsCorrect = true;
                            answer.ContentAnswer = AnswerItem[i].Replace("[T]", "").ToString();
                            answer.IDQuestion = questionBL.MaxIDQuestion();
                            questionBL.AddAnswer(answer);
                        }
                        else
                        {
                            answer.IsCorrect = false;
                            answer.ContentAnswer = AnswerItem[i].Replace("[F]", "").ToString();
                            
                            answer.IDQuestion = questionBL.MaxIDQuestion();
                            questionBL.AddAnswer(answer);
                        }
                    }
                    
                    
                    
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Catalogue catalogue = new Catalogue();
            CatalogueBL CatBL = new CatalogueBL();

            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                for (int i = 0; i < CatList.Count; i++)
                {
                    if (comboBox1.SelectedItem.ToString() == CatList.ElementAt(i).NameCatalogue)
                    {
                        catalogue.IDCatalogue = CatList.ElementAt(i).IDCatalogue;
                    }
                }

            QuestionBL QuestionBL = new QuestionBL();
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestionByCatalogue(catalogue);
            if (QuestionList != null)
            {
                dataGridView1.DataSource = QuestionList;
            }

            dataGridView1.Columns["IDCatalogue"].Visible = false;
            dataGridView1.Columns["Sequence"].Visible = false;
            dataGridView1.Columns["AnswerContent"].Visible = false;

            DataGridViewCheckBoxColumn CheckColumn = new DataGridViewCheckBoxColumn();
            CheckColumn.Name = "check";
            dataGridView1.Columns.Add(CheckColumn);
        }

        public void saveQuestion()
        {
           Question question = new Question();
           Answer answer = new Answer();
           QuestionBL questionBL = new QuestionBL();
           foreach (DataGridViewRow row in dataGridView1.Rows)
           {
               if (row.Cells["check"].Value != null)
               {
                   
                   question.NameQuestion = row.Cells["NameQuestion"].Value.ToString();
                   question.TypeQuestion = row.Cells["TypeQuestion"].Value.ToString();
                   question.IDCatalogue = Convert.ToInt32(textBox2.Text);
                   questionBL.AddQuestion(question);

                   question.IDQuestion = Convert.ToInt32(row.Cells["IDQuestion"].Value);
                   List<DO.Answer> AnswerList;
                   AnswerList = questionBL.GetAnswerByQuestionID(question);
                   if (AnswerList != null)
                   {
                       for (int i = 0; i < AnswerList.Count; i++)
                       {
                           answer.ContentAnswer = AnswerList.ElementAt(i).ContentAnswer;
                           answer.IsCorrect = AnswerList.ElementAt(i).IsCorrect;
                           answer.IDQuestion = questionBL.MaxIDQuestion();
                           questionBL.AddAnswer(answer);
                       }
                   }
               }
           }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveQuestion();
        }


    }
}
