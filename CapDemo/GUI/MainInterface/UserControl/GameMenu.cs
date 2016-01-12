using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
        public event EventHandler onClick_Setting;
        public event EventHandler onClick_Start;
        public event EventHandler onClick_Help;
        public event EventHandler onClick_LogOut;
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
        SoundPlayer sound = new SoundPlayer(Properties.Resources.hover);
        SoundPlayer sound_Click = new SoundPlayer(Properties.Resources.Click);
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            if (this.onClick_Setting != null)
                this.onClick_Setting(this, e);
        }
        //load form
        private void GameMenu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            lbl_Name.Text = "Name: "+UserName;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            if (this.onClick_Start != null)
                this.onClick_Start(this, e);
        }
        
        //start
        private void btn_Start_MouseHover(object sender, EventArgs e)
        {
            btn_Start.BackgroundImage = CapDemo.Properties.Resources.BD_menu_hover;
            sound.PlaySync();
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            btn_Start.BackgroundImage = CapDemo.Properties.Resources.BD_menu;
        }

        //setting
        private void btn_Setting_MouseHover(object sender, EventArgs e)
        {
            btn_Setting.BackgroundImage = CapDemo.Properties.Resources.CD_menu_hover;
            sound.PlaySync();
        }

        private void btn_Setting_MouseLeave(object sender, EventArgs e)
        {
            btn_Setting.BackgroundImage = CapDemo.Properties.Resources.CD_menu;
        }

        //help
        private void btn_Help_MouseHover(object sender, EventArgs e)
        {
            btn_Help.BackgroundImage = CapDemo.Properties.Resources.HD_menu_hover;
            sound.PlaySync();
        }

        private void btn_Help_MouseLeave(object sender, EventArgs e)
        {
            btn_Help.BackgroundImage = CapDemo.Properties.Resources.HD_menu;
        }

        //exit
        private void btn_ExitMenu_MouseHover(object sender, EventArgs e)
        {
            btn_ExitMenu.BackgroundImage = CapDemo.Properties.Resources.T_menu_hover;
            sound.PlaySync();
        }

        private void btn_ExitMenu_MouseLeave(object sender, EventArgs e)
        {
            btn_ExitMenu.BackgroundImage = CapDemo.Properties.Resources.T_menu;
        }

        //Exit program
        private void btn_ExitMenu_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            DialogResult dr = MessageBox.Show("Bạn muốn thoát khỏi chương trình không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            if (this.onClick_Help != null)
                this.onClick_Help(this, e);
            
        }
        //change password
        private void tsmi_ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePass = new ChangePassword(userID, userName, pass);
            ChangePass.ShowDialog();
        }
        //log out
        private void tsmi_LogOut_Click(object sender, EventArgs e)
        {
            if (onClick_LogOut != null)
            {
                this.onClick_LogOut(this, e);
            }
        }

        private void pb_UserSetting_Click(object sender, EventArgs e)
        {
            Point ptLowerLeft = new Point(0, pb_UserSetting.Height);
            ptLowerLeft = pb_UserSetting.PointToScreen(ptLowerLeft);
            cms_UserSetting.Show(ptLowerLeft);
        }
    }
}
