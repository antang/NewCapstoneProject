using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.BL;
using CapDemo.DO;
using System.Reflection;

namespace CapDemo.GUI.User_Controls
{
    public partial class DataManagement : UserControl
    {
        public DataManagement()
        {
            InitializeComponent();
        }
        //ADD Catalogue
        private void lbl_CreateCatalogue_Click(object sender, EventArgs e)
        {
            CreateCatalogueNew CreateCat = new CreateCatalogueNew();
            CreateCat.ShowDialog();
            LoadCat();
        }

        //LOAD Form
        private void DataManagement_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadCat();
            loadQuestion();
        }
        //LOAD Catalogue table from database
        public void LoadCat()
        {
            CatalogueBL CatBL = new CatalogueBL();
            List<DO.Catalogue> CatList;
            CatList = CatBL.GetCatalogue();
            if (CatList != null)
                dgv_Catalogue.DataSource = CatList;

            dgv_Catalogue.Columns["IDCatalogue"].Visible = false;
            dgv_Catalogue.Columns["Sequence"].HeaderText = "STT";
            dgv_Catalogue.Columns["NameCatalogue"].HeaderText = "Tên Chủ Đề";
            dgv_Catalogue.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //LOAD QUESTION TABLE FROM DATABASE
        public void loadQuestion()
        {
            QuestionBL QuestionBL = new QuestionBL();
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestion();
            if (QuestionList != null)
                dgv_Question.DataSource = QuestionList;

            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["IDQuestion"].Visible = false;
            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["AnswerContent"].Visible = false;
            dgv_Question.Columns["Date"].Visible = false;

            dgv_Question.Columns["Sequence"].HeaderText= "STT";
            dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question.Columns["NameCatalogue"].HeaderText = "Tên chủ Đề";
            dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu hỏi";

            dgv_Question.Columns["Sequence"].ReadOnly = true;
            dgv_Question.Columns["NameQuestion"].ReadOnly = false;
            dgv_Question.Columns["NameCatalogue"].ReadOnly = true;
            dgv_Question.Columns["TypeQuestion"].ReadOnly = true;


            dgv_Question.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["NameCatalogue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //ADD NEW QUESTION
        private void lbl_CreateQuestion_Click(object sender, EventArgs e)
        {
            CreateQuestionNew CreateNewQuestion = new CreateQuestionNew();
            CreateNewQuestion.ShowDialog();
            loadQuestion();
        }

        private void lbl_ImportQuestion_Click(object sender, EventArgs e)
        {
            ImportQuestion iq = new ImportQuestion();
            iq.ShowDialog();
            loadQuestion();
        }

        private void btn_CopyQuestion_Click(object sender, EventArgs e)
        {
            if (dgv_Question.SelectedRows.Count > 0)
            {
                string IDCatIDQuestion = "";
                foreach (DataGridViewRow item in this.dgv_Question.SelectedRows)
                {
                    IDCatIDQuestion += (item.Cells["IDCatalogue"].Value.ToString()) + "+" + (item.Cells["IDQuestion"].Value.ToString()) + " ";

                }
                CopyQuestion cq = new CopyQuestion(IDCatIDQuestion);
                cq.ShowDialog();
                loadQuestion();
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Warning;
                notifyIcon1.BalloonTipText = "Vui lòng chọn câu hỏi để di chuyển.";
                notifyIcon1.ShowBalloonTip(2000);
            }
        }
        //MOVE QUESTION
        private void btn_MoveQuestion_Click(object sender, EventArgs e)
        {
            if (dgv_Question.SelectedRows.Count > 0)
            {
                string IDCatIDQuestion="";
                foreach (DataGridViewRow item in this.dgv_Question.SelectedRows)
                {
                    IDCatIDQuestion += (item.Cells["IDCatalogue"].Value.ToString())+"+"+(item.Cells["IDQuestion"].Value.ToString()) + " ";

                }
                MoveQuestion mq = new MoveQuestion(IDCatIDQuestion);
                mq.ShowDialog();
                loadQuestion();
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Warning;
                notifyIcon1.BalloonTipText = "Vui lòng chọn câu hỏi để sao chép.";
                notifyIcon1.ShowBalloonTip(2000);
            }
        }
        //EDIT QUESTION INFORMATION
        private void btn_EditQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int IDQuestion = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDQuestion"].Value);
                int IDCatalogue = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDCatalogue"].Value);
                string TypeQuestion = dgv_Question.CurrentRow.Cells["TypeQuestion"].Value.ToString();
                string OneSelect = "onechoice";
                string MultiSelect = "multichoice";
                string ShortAnswer = "shortanswer";
                if (TypeQuestion.ToLower() == OneSelect)
                {
                    EditQuestion_OnlyOneSelect eqms = new EditQuestion_OnlyOneSelect(IDQuestion, IDCatalogue);
                    eqms.ShowDialog();
                }
                if (TypeQuestion.ToLower() == MultiSelect)
                {
                    EditQuestion_MultiSelect eqms = new EditQuestion_MultiSelect(IDQuestion, IDCatalogue);
                    eqms.ShowDialog();
                }
                if (TypeQuestion.ToLower() == ShortAnswer)
                {
                    EditQuestion_ShortAnswer eqms = new EditQuestion_ShortAnswer(IDQuestion, IDCatalogue);
                    eqms.ShowDialog();
                }
                loadQuestion();
            }
            catch (Exception)
            {
            }
            
        }

        private void btn_ImportQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
                string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
                ImportQuestionForCatalogue iqc = new ImportQuestionForCatalogue(IDCat, NameCat);
                iqc.ShowDialog();
                loadQuestion();
            }
            catch (Exception)
            {
                
            }
            
        }

        //VIEW Question
        private void btn_ViewQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
                string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
                ViewQuestionInCatalogue ViewQuestion = new ViewQuestionInCatalogue(IDCat, NameCat);
                ViewQuestion.ShowDialog();
            }
            catch (Exception)
            {

            }
            
        }
        //EDIT Catalogue
        private void btn_EditCatalogue_Click(object sender, EventArgs e)
        {
            try
            {
                int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
                string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
                if (NameCat.ToLower() == "unknow")
                {
                    MessageBox.Show("Không được chỉnh sửa chủ đề " + "\"" + NameCat + "\"", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    EditCatalogue EditCat = new EditCatalogue(IDCat, NameCat);
                    EditCat.ShowDialog();
                    LoadCat();
                    loadQuestion();
                }      
            }
            catch (Exception)
            {
                
            }
        }
        //DELETE Catalogue
        private void btn_DeleteCatalogue_Click(object sender, EventArgs e)
        {
            try
            {
                int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
                string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();

                if (NameCat.ToLower() == "unknow")
                {
                    MessageBox.Show("Không được xóa chủ đề " + "\"" + NameCat + "\"", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DeleteCatalogue DelCat = new DeleteCatalogue(IDCat, NameCat);
                    DelCat.ShowDialog();
                    LoadCat();
                    loadQuestion();
                }
            }
            catch (Exception)
            {
            }
           
        }
        //CLICK CELL IN DATAGRIDVIEW TO SHOW GROUP CATALOGUE FUNCTION
        private void dgv_Catalogue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gb_CatalogueFunction.Visible = true;
        }
        //CLICK FORM TO HIDE GROUP CATALOGUE FUNCTION
        private void tbp_CatalogueManagement_MouseClick(object sender, MouseEventArgs e)
        {
            gb_CatalogueFunction.Visible = false;
        }
        //CLICK CELL IN DATAGRIDVIEW TO SHOW GROUP QUESTION FUNCTION
        private void dgv_Question_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gb_QuestionFunction.Visible = true;
        }
        //CLICK FORM TO HIDE GROUP QUESTION FUNCTION
        private void tbp_QuestionManagement_MouseClick(object sender, MouseEventArgs e)
        {
            gb_QuestionFunction.Visible = false;
        }
        //DELETE Question
        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            int RowSelect = dgv_Question.SelectedRows.Count;
            if (RowSelect>0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muôn xóa câu hỏi này không?", "Xóa câu hỏi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgv_Question.SelectedRows)
                    {
                        Question Question = new Question();
                        QuestionBL QuestionBL = new QuestionBL();
                        Question.IDQuestion = Convert.ToInt32(item.Cells["IDQuestion"].Value.ToString());
                        QuestionBL.DeleteAnswerByIDQuestion(Question);
                        QuestionBL.DeleteQuestionByID(Question);
                    }
                    //Show notify
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Xóa Câu Hỏi Thành Công";
                    notifyIcon1.ShowBalloonTip(2000);
                    //Load question table
                    loadQuestion();
                }
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Warning;
                notifyIcon1.BalloonTipText = "Vui lòng chọn câu hỏi để xóa.";
                notifyIcon1.ShowBalloonTip(2000);
            }
            
        }
        //SWITCH TAB TO HIDE GROUP FUNCTION
        private void tbc_DataManagement_Click(object sender, EventArgs e)
        {
            gb_QuestionFunction.Visible = false;
            gb_CatalogueFunction.Visible = false;
        }
        //DOUBLE CLICK IN CATALOGUE DATAGRIDVIEW TO VIEW QUESTION
        private void dgv_Catalogue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int IDCat = Convert.ToInt32(dgv_Catalogue.CurrentRow.Cells["IDCatalogue"].Value);
                string NameCat = dgv_Catalogue.CurrentRow.Cells["NameCatalogue"].Value.ToString();
                ViewQuestionInCatalogue ViewQuestion = new ViewQuestionInCatalogue(IDCat, NameCat);
                ViewQuestion.ShowDialog();
                loadQuestion();
            }
            catch (Exception)
            {
            }
            
        }
        //Search Question
        private void txt_SearchQuestion_TextChanged(object sender, EventArgs e)
        {
            QuestionBL questionBL = new QuestionBL();
            List<DO.Question> ListQuestion = questionBL.GetQuestion();
            //loadQuestion();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(ListQuestion);

            dgv_Question.DataSource = dt;
            dt.DefaultView.RowFilter = string.Format("NameQuestion LIKE '%{0}%' or TypeQuestion LIKE '%{0}%' or NameCatalogue LIKE '%{0}%' or Sequence LIKE '%{0}%'", txt_SearchQuestion.Text);

            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["IDQuestion"].Visible = false;
            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["AnswerContent"].Visible = false;
            dgv_Question.Columns["AnswerList"].Visible = false;
            dgv_Question.Columns["Date"].Visible = false;

            dgv_Question.Columns["Sequence"].HeaderText = "STT";
            dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question.Columns["NameCatalogue"].HeaderText = "Tên chủ Đề";
            dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu hỏi";

            dgv_Question.Columns["Sequence"].ReadOnly = true;
            dgv_Question.Columns["NameQuestion"].ReadOnly = false;
            dgv_Question.Columns["NameCatalogue"].ReadOnly = true;
            dgv_Question.Columns["TypeQuestion"].ReadOnly = true;

            dgv_Question.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["NameCatalogue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
        }
        //Search Catalogue
        private void txt_SearchCatalogue_TextChanged(object sender, EventArgs e)
        {
            CatalogueBL catalogueBL = new CatalogueBL();
            List<DO.Catalogue> ListCatalogue = catalogueBL.GetCatalogue();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(ListCatalogue);

            dgv_Catalogue.DataSource = dt;
            dt.DefaultView.RowFilter = string.Format("NameCatalogue LIKE '%{0}%' or Sequence LIKE '%{0}%'", txt_SearchCatalogue.Text);

            dgv_Catalogue.Columns["IDCatalogue"].Visible = false;
            dgv_Catalogue.Columns["Sequence"].HeaderText = "STT";
            dgv_Catalogue.Columns["NameCatalogue"].HeaderText = "Tên Chủ Đề";
            dgv_Catalogue.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //VIEW DETAIL QUESTION BY DOUBLE CLICK CELL
        private void dgv_Question_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDQuestion = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDQuestion"].Value);
            int IDCatalogue = Convert.ToInt32(dgv_Question.CurrentRow.Cells["IDCatalogue"].Value);
            string TypeQuestion = dgv_Question.CurrentRow.Cells["TypeQuestion"].Value.ToString();
            string OneSelect = "onechoice";
            string MultiSelect = "multichoice";
            string ShortAnswer = "shortanswer";
            if (TypeQuestion.ToLower() == OneSelect)
            {
                ViewQuestion eqms = new ViewQuestion(IDQuestion, IDCatalogue);
                eqms.ShowDialog();
            }
            if (TypeQuestion.ToLower() == MultiSelect)
            {
                ViewQuestionMultiple eqms = new ViewQuestionMultiple(IDQuestion, IDCatalogue);
                eqms.ShowDialog();
            }
            if (TypeQuestion.ToLower() == ShortAnswer)
            {
                ViewQuestionShortAnswer eqms = new ViewQuestionShortAnswer(IDQuestion, IDCatalogue);
                eqms.ShowDialog();
            }
            loadQuestion();
        }
        //Click search
        private void btn_SearchQuestion_Click(object sender, EventArgs e)
        {
            //if (dgv_Question.SelectedRows.Count >0)
            //{
            //    int[] RowSelected = new int[dgv_Question.SelectedRows.Count];
            //    int i = 0;
            //    foreach (DataGridViewRow item in this.dgv_Question.SelectedRows)
            //    {
            //        RowSelected[i] = Convert.ToInt32(item.Cells["IDQuestion"].Value.ToString());
            //        i++;
            //    }

            //    for (int j = 0; j < RowSelected.Length; j++)
            //    {
            //        MessageBox.Show("" + RowSelected[j]);
            //    }
            //}
            
        } 
    }
}
