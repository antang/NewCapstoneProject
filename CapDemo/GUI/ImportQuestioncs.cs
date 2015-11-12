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
    public partial class ImportQuestioncs : Form
    {
        public ImportQuestioncs()
        {
            InitializeComponent();
        }

        private void rad_NewQuestion_CheckedChanged(object sender, EventArgs e)
        {
            flp_ImportQuestion.Controls.Clear();
            QuestionType option_create_question = new QuestionType();
            flp_ImportQuestion.Controls.Add(option_create_question);
        }
    }
}
