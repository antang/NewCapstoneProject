using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI.User_Controls
{
    public partial class CreateQuestion : UserControl
    {
        public CreateQuestion()
        {
            InitializeComponent();
        }
        //Declare parameter
        private int iDCat;
        private string nameCat;
        //GET SET ID CAT
        public int IDCat
        {
            get { return iDCat; }
            set { iDCat = value; }
        }
        //GET SET NAME CAT
        public string NameCat
        {
            get { return nameCat; }
            set { nameCat = value; }
        }
        //Constructor
        public CreateQuestion(int IDCat, string NameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = IDCat;
            this.NameCat = NameCat;
        }
        //FORM LOAD
        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Question_OnlyOneSelect QuestionOneSelect = new Question_OnlyOneSelect(IDCat, NameCat);
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(QuestionOneSelect);
        }
        //CHECK ONLY ONE SELECT QUESTION
        private void rad_OnlyOneAnswer_CheckedChanged(object sender, EventArgs e)
        {
            Question_OnlyOneSelect QuestionOneSelect = new Question_OnlyOneSelect(IDCat, NameCat);
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(QuestionOneSelect);
        }
        //CHECK MULTYPLE SELECT QUESTION
        private void rad_MultiSelect_CheckedChanged(object sender, EventArgs e)
        {
            Question_MultiSelect QuestionMultiSelect = new Question_MultiSelect(IDCat, NameCat);
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(QuestionMultiSelect);
        }
        //CHECK SHORT ANSWER QUESTION
        private void rad_ShortAnswer_CheckedChanged(object sender, EventArgs e)
        {
            Question_ShortAnswer QuestionShortAnswer = new Question_ShortAnswer(IDCat, NameCat);
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(QuestionShortAnswer);
        }

    }
}
