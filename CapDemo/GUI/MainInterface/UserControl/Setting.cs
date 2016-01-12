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
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }
        SoundPlayer sound = new SoundPlayer(Properties.Resources.hover);
        SoundPlayer sound_Click = new SoundPlayer(Properties.Resources.Click);
        private void Setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            pnl_Setting.Visible = false;
        }
        public event EventHandler onExit;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            if (this.onExit != null)
                this.onExit(this, e);
            pnl_Setting.Visible = false;
        }

        private void btn_DataManagement_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            pnl_Setting.Visible = true;
            pnl_Setting.Controls.Clear();
            DataManagement dm = new DataManagement();
            pnl_Setting.Controls.Add(dm);
        }

        private void btn_GameSetting_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            pnl_Setting.Visible = true;
            pnl_Setting.Controls.Clear();
            Setting_Game sg = new Setting_Game();
            pnl_Setting.Controls.Add(sg);
        }

        private void btn_UserManagement_Click(object sender, EventArgs e)
        {
            sound_Click.Play();
            pnl_Setting.Visible = true;
            pnl_Setting.Controls.Clear();
            UserManagement um = new UserManagement();
            pnl_Setting.Controls.Add(um);
        }
        //question managment hover
        private void btn_DataManagement_MouseHover(object sender, EventArgs e)
        {
            btn_DataManagement.BackgroundImage = CapDemo.Properties.Resources.QLDL_Setting_hover;
            sound.PlaySync();
        }
        //question management leave
        private void btn_DataManagement_MouseLeave(object sender, EventArgs e)
        {
            btn_DataManagement.BackgroundImage = CapDemo.Properties.Resources.QLDL_Setting;
        }

        //Game setting hover
        private void btn_GameSetting_MouseHover(object sender, EventArgs e)
        {
            btn_GameSetting.BackgroundImage = CapDemo.Properties.Resources.TLG_Setting_hover;
            sound.PlaySync();
        }
        //Game Setting leave
        private void btn_GameSetting_MouseLeave(object sender, EventArgs e)
        {
            btn_GameSetting.BackgroundImage = CapDemo.Properties.Resources.TLG_Setting;
        }
        //User management hover
        private void btn_UserManagement_MouseHover(object sender, EventArgs e)
        {
            btn_UserManagement.BackgroundImage = CapDemo.Properties.Resources.QLTK_Setting_hover;
            sound.PlaySync();
        }
        //User manangement leave
        private void btn_UserManagement_MouseLeave(object sender, EventArgs e)
        {
            btn_UserManagement.BackgroundImage = CapDemo.Properties.Resources.QLTK_Setting;
        }
        //Exit hover
        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.BackgroundImage = CapDemo.Properties.Resources.Thoat_Setting_hover;
            sound.PlaySync();
        }
        //Exit leave
        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackgroundImage = CapDemo.Properties.Resources.Thoat_Setting;
        }
    }
}