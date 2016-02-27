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
using System.IO;

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
        public event EventHandler onClick_Exit;
        public event EventHandler onClick_LogOut;

        public event EventHandler onHover_Setting;
        public event EventHandler onHover_Start;
        public event EventHandler onHover_Help;
        public event EventHandler onHover_Exit;

        public event EventHandler onClick_TurnOnMusic;
        public event EventHandler onClick_TurnOffMusic;
        public event EventHandler onClick_ImportMusic;
        public event EventHandler onClick_DefaultMusic;
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
        //SoundPlayer sound = new SoundPlayer(Properties.Resources.hover);
        //SoundPlayer sound_Click = new SoundPlayer(Properties.Resources.Click);
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            if (this.onClick_Setting != null)
                this.onClick_Setting(this, e);
        }
        //load form
        private void GameMenu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            lbl_Name.Text = "Tên Người Dùng: "+UserName;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        { 
            if (this.onClick_Start != null)
                this.onClick_Start(this, e);
        }
        
        //start
        private void btn_Start_MouseHover(object sender, EventArgs e)
        {
            btn_Start.BackgroundImage = CapDemo.Properties.Resources.BD_menu_hover;
            if (this.onHover_Start != null)
                this.onHover_Start(this, e);
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            btn_Start.BackgroundImage = CapDemo.Properties.Resources.BD_menu;
        }

        //setting
        private void btn_Setting_MouseHover(object sender, EventArgs e)
        {
            btn_Setting.BackgroundImage = CapDemo.Properties.Resources.CD_menu_hover;
            if (this.onHover_Setting != null)
                this.onHover_Setting(this, e);
        }

        private void btn_Setting_MouseLeave(object sender, EventArgs e)
        {
            btn_Setting.BackgroundImage = CapDemo.Properties.Resources.CD_menu;
        }

        //help
        private void btn_Help_MouseHover(object sender, EventArgs e)
        {
            btn_Help.BackgroundImage = CapDemo.Properties.Resources.HD_menu_hover;
            if (this.onHover_Help != null)
                this.onHover_Help(this, e);
        }

        private void btn_Help_MouseLeave(object sender, EventArgs e)
        {
            btn_Help.BackgroundImage = CapDemo.Properties.Resources.HD_menu;
        }

        //exit
        private void btn_ExitMenu_MouseHover(object sender, EventArgs e)
        {
            btn_ExitMenu.BackgroundImage = CapDemo.Properties.Resources.T_menu_hover;
            if (this.onHover_Exit != null)
                this.onHover_Exit(this, e);
        }

        private void btn_ExitMenu_MouseLeave(object sender, EventArgs e)
        {
            btn_ExitMenu.BackgroundImage = CapDemo.Properties.Resources.T_menu;
        }

        //Exit program
        private void btn_ExitMenu_Click(object sender, EventArgs e)
        {
            if (this.onClick_Exit != null)
                this.onClick_Exit(this, e);

            DialogResult dr = MessageBox.Show("Bạn muốn thoát khỏi chương trình không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btn_Help_Click(object sender, EventArgs e)
        { 
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
        //Turn on music
        private void tsmi_On_Click(object sender, EventArgs e)
        {
            if (onClick_TurnOnMusic != null)
            {
                this.onClick_TurnOnMusic(this, e);
            }
        }
        //Turn off music
        private void tsmi_Off_Click(object sender, EventArgs e)
        {
            if (onClick_TurnOffMusic != null)
            {
                this.onClick_TurnOffMusic(this, e);
            }
        }
        //Import Music
        private void tsmi_ImportMusic_Click(object sender, EventArgs e)
        {
            if (onClick_TurnOffMusic != null)
            {
                this.onClick_ImportMusic(this, e);
            }
        }
        //Default Music
        private void nhạcMặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onClick_DefaultMusic != null)
            {
                this.onClick_DefaultMusic(this, e);
            }
        }
    }
}
