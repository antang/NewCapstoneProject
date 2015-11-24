using CapDemo.BL;
using CapDemo.GUI.User_Controls;
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
    public partial class CreateQuestionNew : Form
    {
        public CreateQuestionNew()
        {
            InitializeComponent();
        }

        private void CreateQuestionNew_Load(object sender, EventArgs e)
        {     
            this.Dock = DockStyle.Fill;
        }
        //CHECK QUESTION TYPE ONLY ONE SELECT ANSWER
        private void rad_OnlyOneAnswer_CheckedChanged_1(object sender, EventArgs e)
        {
            if(!pnl_LoadQuestion.Controls.Contains(Question_OnlyOneSelect_1.instance))
            {
                pnl_LoadQuestion.Controls.Add(Question_OnlyOneSelect_1.instance);
                Question_OnlyOneSelect_1.instance.Dock= DockStyle.Fill;
                Question_OnlyOneSelect_1.instance.BringToFront();
            }else
                Question_OnlyOneSelect_1.instance.BringToFront();
        }
        //CHECK QUESTION TYPE MULTI SELECT ANSWER
        private void rad_MultiSelect_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!pnl_LoadQuestion.Controls.Contains(Question_MultiSelect_1.instance))
            {
                pnl_LoadQuestion.Controls.Add(Question_MultiSelect_1.instance);
                Question_MultiSelect_1.instance.Dock = DockStyle.Fill;
                Question_MultiSelect_1.instance.BringToFront();
            }
            else
                Question_MultiSelect_1.instance.BringToFront();
        }
        //CHECK QUESTION TYPE SHORT ANSWER
        private void rad_ShortAnswer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!pnl_LoadQuestion.Controls.Contains(Question_ShortAnswer_1.instance))
            {
                pnl_LoadQuestion.Controls.Add(Question_ShortAnswer_1.instance);
                Question_ShortAnswer_1.instance.Dock = DockStyle.Fill;
                Question_ShortAnswer_1.instance.BringToFront();
            }
            else
                Question_ShortAnswer_1.instance.BringToFront();
        }
    }
}
