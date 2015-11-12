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
    public partial class Question_OnlyOneSelect : UserControl
    {
        public Question_OnlyOneSelect()
        {
            InitializeComponent();
        }

        private void Question_OnlyOneSelect_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_addAnswer_Click(object sender, EventArgs e)
        {
            Answer_OnlyOneSelect aoos = new Answer_OnlyOneSelect();
            flp_addAnswer.Controls.Add(aoos);
        }
    }
}
