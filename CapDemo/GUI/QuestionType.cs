using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI
{
    public partial class QuestionType : UserControl
    {
        public QuestionType()
        {
            InitializeComponent();
        }

        private void rad_OneChoice_CheckedChanged(object sender, EventArgs e)
        {
            flp_ContentQuestion.Controls.Clear();
            OncChoiceContent one_choice_content = new OncChoiceContent(rad_OneChoice.Text);
            flp_ContentQuestion.Controls.Add(one_choice_content);
        }
    }
}
