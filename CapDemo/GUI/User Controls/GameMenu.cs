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
    public partial class GameMenu : UserControl
    {
        private string UserName;
        public event EventHandler onClick;
        public event EventHandler onClick_Start;
        //public GameMenu()
        //{
        //    InitializeComponent();
        //}

        public GameMenu(string pUserName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.UserName = pUserName;
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            lbl_Name.Text = UserName;
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (this.onClick_Start != null)
                this.onClick_Start(this, e);
        }
    }
}
