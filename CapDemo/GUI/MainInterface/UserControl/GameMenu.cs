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
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public event EventHandler onClick;
        public event EventHandler onClick_Start;
        //public GameMenu()
        //{
        //    InitializeComponent();
        //}

        public GameMenu(int pUserID, string pUserName,string pPass)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.userName = pUserName;
            this.userID = pUserID;
            this.pass = pPass;
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

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (this.onClick_Start != null)
                this.onClick_Start(this, e);
        }
        //Change Pass
        private void lbl_ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePass = new ChangePassword(userID,userName,pass);
            ChangePass.ShowDialog();
        }
    }
}
