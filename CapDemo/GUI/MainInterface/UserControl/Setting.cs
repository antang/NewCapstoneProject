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
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            pnl_Setting.Visible = false;
        }
        public event EventHandler onClick;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
            pnl_Setting.Visible = false;
        }

        private void btn_DataManagement_Click(object sender, EventArgs e)
        {
            pnl_Setting.Visible = true;
            pnl_Setting.Controls.Clear();
            DataManagement dm = new DataManagement();
            pnl_Setting.Controls.Add(dm);
        }

        private void btn_GameSetting_Click(object sender, EventArgs e)
        {
            pnl_Setting.Visible = true;
            pnl_Setting.Controls.Clear();
            Setting_Game sg = new Setting_Game();
            pnl_Setting.Controls.Add(sg);
        }

        private void btn_UserManagement_Click(object sender, EventArgs e)
        {
            pnl_Setting.Visible = true;
            pnl_Setting.Controls.Clear();
            UserManagement um = new UserManagement();
            pnl_Setting.Controls.Add(um);
        }
    }
}