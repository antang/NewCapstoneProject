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
        }

        private void btn_CancelViewQuestione_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
