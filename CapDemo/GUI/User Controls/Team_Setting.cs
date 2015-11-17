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
    public partial class Team_Setting : UserControl
    {
        public Team_Setting()
        {
            InitializeComponent();
        }

        private void btn_AddPhase_Click(object sender, EventArgs e)
        {
            Team t = new Team();
            flp_Team.Controls.Add(t);
        }

        private void Team_Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
