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
        Question_OnlyOneSelect qoos = new Question_OnlyOneSelect();
        Question_MultiSelect qms = new Question_MultiSelect();
        Question_ShortAnswer qsa = new Question_ShortAnswer();
        private void rdo_OnlyOneAnswer_CheckedChanged(object sender, EventArgs e)
        {
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(qoos);
        }

        private void rdo_MultiSelect_CheckedChanged(object sender, EventArgs e)
        {
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(qms);
        }

        private void rdo_ShortAnswer_CheckedChanged(object sender, EventArgs e)
        {
            pnl_LoadQuestion.Controls.Clear();
            pnl_LoadQuestion.Controls.Add(qsa);
        }

        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            pnl_LoadQuestion.Controls.Add(qoos);
        }
    }
}
