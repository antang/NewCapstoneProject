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
    public partial class ViewQuestionInCatalogue : Form
    {
        private int IDCat;
        private string NameCat;

        public ViewQuestionInCatalogue()
        {
            InitializeComponent();
        }

        public ViewQuestionInCatalogue(int pIDCat, string pNameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = pIDCat;
            this.NameCat = pNameCat;
        }

        private void ViewQuestionInCatalogue_Load(object sender, EventArgs e)
        {
            this.txt_NameCatalogue.Text = NameCat;

            QuestionBL QuestionBL = new QuestionBL();
            Catalogue Cat = new Catalogue();
            Cat.IDCatalogue = IDCat;
            List<DO.Question> QuestionList;
            QuestionList = QuestionBL.GetQuestionByCatalogue(Cat);
            if (QuestionList != null)
                dgv_Question.DataSource = QuestionList;

            dgv_Question.Columns["IDCatalogue"].Visible = false;
            dgv_Question.Columns["IDQuestion"].Visible = false;
            dgv_Question.Columns["AnswerContent"].Visible = false;

            dgv_Question.Columns["Sequence"].HeaderText = "STT";
            dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu Hỏi";
            dgv_Question.Columns["NameCatalogue"].HeaderText = "Tên Chủ Đề";

            dgv_Question.Columns["Sequence"].Width = 50;
            dgv_Question.Columns["NameQuestion"].Width = 400;
            dgv_Question.Columns["TypeQuestion"].Width = 150;
            dgv_Question.Columns["NameCatalogue"].Width = 150;
        }

        private void btn_CancelViewQuestione_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
