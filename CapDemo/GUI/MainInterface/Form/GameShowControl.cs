using CapDemo.DO;
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
using System.IO;
namespace CapDemo.GUI
{
    public partial class GameShowControl : Form
    {
        private string userName;
        private int userID;
        private string pass;

        Setting st = new Setting();
        Start_Game sgFirst = new Start_Game();
        Help Help = new Help();
        Game game = new Game();
        //GameMenu gm = new GameMenu();
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public GameShowControl()
        {
            InitializeComponent();
        }

        public GameShowControl(int pUserID, string pUserName, String pPass)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.userName = pUserName;
            this.userID = pUserID;
            this.pass = pPass;
        }
        private void GameShowControl_Load(object sender, EventArgs e)
        {
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            GameMenu gm1 = new GameMenu(UserID, UserName,Pass);
            if (w == 1024 && h == 768)
            {
                gm1.BackgroundImage = Properties.Resources._1024_768;
            }
            else
            {
                if (w==1280 && h==1024)
                {
                    gm1.BackgroundImage = Properties.Resources._1280_1024;
                }
                else
                {
                    if (w==1280 && h==800)
                    {
                        gm1.BackgroundImage = Properties.Resources._1280_800;
                    }
                    else
                    {
                        if (w==1366 && h ==768)
                        {
                            gm1.BackgroundImage = Properties.Resources._1366_768;
                        }
                        else
                        {
                            if (w==1600 && h == 900)
                            {
                                gm1.BackgroundImage = Properties.Resources._1600_900;
                            }
                            else
                            {
                                if (w==1920 && h==1080)
                                {
                                    gm1.BackgroundImage = Properties.Resources._1920_1080;
                                }
                                else
                                {
                                    gm1.BackgroundImage = Properties.Resources.bg;
                                }
                            }
                        }
                    }
                }
            }
            gm1.onClick_Setting += btn_Setting_onClick;
            gm1.onClick_Start += btn_Start_onClick;
            gm1.onClick_Help += gm1_onClick_Help;
            gm1.onClick_LogOut += gm1_onClick_LogOut;

            gm1.onHover_Exit += gm1_onHover_Exit;
            gm1.onHover_Help += gm1_onHover_Help;
            gm1.onHover_Setting += gm1_onHover_Setting;
            gm1.onHover_Start += gm1_onHover_Start;

            gm1.onClick_TurnOnMusic += gm1_onClick_TurnOnMusic;
            gm1.onClick_TurnOffMusic += gm1_onClick_TurnOffMusic;
            gm1.onClick_ImportMusic += gm1_onClick_ImportMusic;
            gm1.onClick_DefaultMusic += gm1_onClick_DefaultMusic;
            this.Controls.Add(gm1);
            try
            {
                axWindowsMediaPlayer1.URL = Directory.GetCurrentDirectory() + "\\Sound\\NhacNen.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.settings.setMode("Loop", true);
            }
            catch (Exception)
            {
            }
            
        }
        //hover start
        void gm1_onHover_Start(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Hover.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
        }
        //Hover setting
        void gm1_onHover_Setting(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Hover.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
        }
        //hover help
        void gm1_onHover_Help(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Hover.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
        }
        //hover exit
        void gm1_onHover_Exit(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Hover.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
        }


        //Default music
        void gm1_onClick_DefaultMusic(object sender, EventArgs e)
        {
            ImportMusic.axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        ImportMusic ImportMusic = new ImportMusic();
        //Import music
        void gm1_onClick_ImportMusic(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            ImportMusic.ShowDialog();
            ImportMusic.listBox1.Items.Clear();
            DialogResult rs = ImportMusic.DialogResult;
            if (rs== DialogResult.OK)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        //Turn off music
        void gm1_onClick_TurnOffMusic(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        //Turn on music
        void gm1_onClick_TurnOnMusic(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        // click log out to show login screen
        void gm1_onClick_LogOut(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
                try
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
                catch (Exception)
                {
                }
                
            }
        }
        //log up event help
        void gm1_onClick_Help(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Click.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }

            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\GSC_UserGuide.pdf");
            //this.Controls.Clear();
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            if (w == 1024 && h == 768)
            {
                Help.BackgroundImage = Properties.Resources._1024_768_setting;
            }
            else
            {
                if (w == 1280 && h == 1024)
                {
                    Help.BackgroundImage = Properties.Resources._1280_1024_setting;
                }
                else
                {
                    if (w == 1280 && h == 800)
                    {
                        Help.BackgroundImage = Properties.Resources._1280_800_setting;
                    }
                    else
                    {
                        if (w == 1366 && h == 768)
                        {
                            Help.BackgroundImage = Properties.Resources._1366_768_setting;
                        }
                        else
                        {
                            if (w == 1600 && h == 900)
                            {
                                Help.BackgroundImage = Properties.Resources._1600_900_setting;
                            }
                            else
                            {
                                if (w == 1920 && h == 1080)
                                {
                                    Help.BackgroundImage = Properties.Resources._1920_1080_setting;
                                }
                                else
                                {
                                    Help.BackgroundImage = Properties.Resources.bg;
                                }
                            }
                        }
                    }
                }
            }
            //this.st.onExit += Exit_Setting;
            //this.Help.onExit += Help_onExit;
            //this.Controls.Add(Help);
        }
        //exit help Control
        void Help_onExit(object sender, EventArgs e)
        {
            GameMenu gm1 = new GameMenu(UserID, UserName, Pass);
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            if (w == 1024 && h == 768)
            {
                gm1.BackgroundImage = Properties.Resources._1024_768;
            }
            else
            {
                if (w == 1280 && h == 1024)
                {
                    gm1.BackgroundImage = Properties.Resources._1280_1024;
                }
                else
                {
                    if (w == 1280 && h == 800)
                    {
                        gm1.BackgroundImage = Properties.Resources._1280_800;
                    }
                    else
                    {
                        if (w == 1366 && h == 768)
                        {
                            gm1.BackgroundImage = Properties.Resources._1366_768;
                        }
                        else
                        {
                            if (w == 1600 && h == 900)
                            {
                                gm1.BackgroundImage = Properties.Resources._1600_900;
                            }
                            else
                            {
                                if (w == 1920 && h == 1080)
                                {
                                    gm1.BackgroundImage = Properties.Resources._1920_1080;
                                }
                                else
                                {
                                    gm1.BackgroundImage = Properties.Resources.bg;
                                }
                            }
                        }
                    }
                }
            }
            gm1.onClick_Setting += btn_Setting_onClick;
            gm1.onClick_Start += btn_Start_onClick;
            gm1.onClick_Help += gm1_onClick_Help;
            gm1.onClick_LogOut += gm1_onClick_LogOut;

            gm1.onHover_Exit += gm1_onHover_Exit;
            gm1.onHover_Help += gm1_onHover_Help;
            gm1.onHover_Setting += gm1_onHover_Setting;
            gm1.onHover_Start += gm1_onHover_Start;

            this.Controls.Clear();
            this.Controls.Add(gm1);
        }

        //Click to show Start Game GUI
        void btn_Start_onClick(object sender, EventArgs e)
        {
            Start_Game sg = new Start_Game();
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Click.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
            //auto fix screen start game
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            if (w == 1024 && h == 768)
            {
                sg.BackgroundImage = Properties.Resources._1024_768_start;
            }
            else
            {
                if (w == 1280 && h == 1024)
                {
                    sg.BackgroundImage = Properties.Resources._1280_1024_start;
                }
                else
                {
                    if (w == 1280 && h == 800)
                    {
                        sg.BackgroundImage = Properties.Resources._1280_800_start;
                    }
                    else
                    {
                        if (w == 1366 && h == 768)
                        {
                            sg.BackgroundImage = Properties.Resources._1366_768_start;
                        }
                        else
                        {
                            if (w == 1600 && h == 900)
                            {
                                sg.BackgroundImage = Properties.Resources._1600_900_start;
                            }
                            else
                            {
                                if (w == 1920 && h == 1080)
                                {
                                    sg.BackgroundImage = Properties.Resources._1920_1080_start;
                                }
                                else
                                {
                                    sg.BackgroundImage = Properties.Resources.bg;
                                }
                            }
                        }
                    }
                }
            }

            sg.onExit += Exit_StartGame;
            //sg.Doubleclick += sg_DoubleClick;
            sg.doubleClick += sg_doubleClick;
            this.Controls.Clear();
            this.Controls.Add(sg);
        }
        // double game user control click to pause sound
        void sg_doubleClick(object sender, EventArgs e)
        {
            try
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            catch (Exception)
            {
            }
            
        }

        //Click to show Setting Game GUI
        void btn_Setting_onClick(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Click.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
            this.Controls.Clear();
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            if (w == 1024 && h == 768)
            {
                st.BackgroundImage = Properties.Resources._1024_768_setting;
            }
            else
            {
                if (w == 1280 && h == 1024)
                {
                    st.BackgroundImage = Properties.Resources._1280_1024_setting;
                }
                else
                {
                    if (w == 1280 && h == 800)
                    {
                        st.BackgroundImage = Properties.Resources._1280_800_setting;
                    }
                    else
                    {
                        if (w == 1366 && h == 768)
                        {
                            st.BackgroundImage = Properties.Resources._1366_768_setting;
                        }
                        else
                        {
                            if (w == 1600 && h == 900)
                            {
                                st.BackgroundImage = Properties.Resources._1600_900_setting;
                            }
                            else
                            {
                                if (w == 1920 && h == 1080)
                                {
                                    st.BackgroundImage = Properties.Resources._1920_1080_setting;
                                }
                                else
                                {
                                    st.BackgroundImage = Properties.Resources.bg;
                                }
                            }
                        }
                    }
                }
            }
            this.st.onExit += Exit_Setting;
            this.Controls.Add(st);
        }
        //Exit Setting GUI
        void Exit_Setting(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Click.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
            this.Controls.Clear();
            GameMenu gm1 = new GameMenu(UserID, UserName,Pass);
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            if (w == 1024 && h == 768)
            {
                gm1.BackgroundImage = Properties.Resources._1024_768;
            }
            else
            {
                if (w == 1280 && h == 1024)
                {
                    gm1.BackgroundImage = Properties.Resources._1280_1024;
                }
                else
                {
                    if (w == 1280 && h == 800)
                    {
                        gm1.BackgroundImage = Properties.Resources._1280_800;
                    }
                    else
                    {
                        if (w == 1366 && h == 768)
                        {
                            gm1.BackgroundImage = Properties.Resources._1366_768;
                        }
                        else
                        {
                            if (w == 1600 && h == 900)
                            {
                                gm1.BackgroundImage = Properties.Resources._1600_900;
                            }
                            else
                            {
                                if (w == 1920 && h == 1080)
                                {
                                    gm1.BackgroundImage = Properties.Resources._1920_1080;
                                }
                                else
                                {
                                    gm1.BackgroundImage = Properties.Resources.bg;
                                }
                            }
                        }
                    }
                }
            }
            gm1.onClick_Setting += btn_Setting_onClick;
            gm1.onClick_Start += btn_Start_onClick;
            gm1.onClick_Help += gm1_onClick_Help;
            gm1.onClick_LogOut += gm1_onClick_LogOut;

            gm1.onHover_Exit += gm1_onHover_Exit;
            gm1.onHover_Help += gm1_onHover_Help;
            gm1.onHover_Setting += gm1_onHover_Setting;
            gm1.onHover_Start += gm1_onHover_Start;

            gm1.onClick_TurnOnMusic += gm1_onClick_TurnOnMusic;
            gm1.onClick_TurnOffMusic += gm1_onClick_TurnOffMusic;
            gm1.onClick_ImportMusic += gm1_onClick_ImportMusic;
            gm1.onClick_DefaultMusic += gm1_onClick_DefaultMusic;
            this.Controls.Add(gm1);
        }
        //Exit start Game
        void Exit_StartGame(object sender, EventArgs e)
        {
            try
            {
                //axWindowsMediaPlayer2.URL = (Directory.GetCurrentDirectory()) + "\\Sound\\Click.wav";
                //axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
            try
            {
                //this.axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception)
            {
            }
            GameMenu gm1 = new GameMenu(UserID, UserName, Pass);          
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            if (w == 1024 && h == 768)
            {
                gm1.BackgroundImage = Properties.Resources._1024_768;
            }
            else
            {
                if (w == 1280 && h == 1024)
                {
                    gm1.BackgroundImage = Properties.Resources._1280_1024;
                }
                else
                {
                    if (w == 1280 && h == 800)
                    {
                        gm1.BackgroundImage = Properties.Resources._1280_800;
                    }
                    else
                    {
                        if (w == 1366 && h == 768)
                        {
                            gm1.BackgroundImage = Properties.Resources._1366_768;
                        }
                        else
                        {
                            if (w == 1600 && h == 900)
                            {
                                gm1.BackgroundImage = Properties.Resources._1600_900;
                            }
                            else
                            {
                                if (w == 1920 && h == 1080)
                                {
                                    gm1.BackgroundImage = Properties.Resources._1920_1080;
                                }
                                else
                                {
                                    gm1.BackgroundImage = Properties.Resources.bg;
                                }
                            }
                        }
                    }
                }
            }
            gm1.onClick_Setting += btn_Setting_onClick;
            gm1.onClick_Start += btn_Start_onClick;
            gm1.onClick_Help += gm1_onClick_Help;
            gm1.onClick_LogOut += gm1_onClick_LogOut;

            gm1.onHover_Exit += gm1_onHover_Exit;
            gm1.onHover_Help += gm1_onHover_Help;
            gm1.onHover_Setting += gm1_onHover_Setting;
            gm1.onHover_Start += gm1_onHover_Start;

            gm1.onClick_TurnOnMusic += gm1_onClick_TurnOnMusic;
            gm1.onClick_TurnOffMusic += gm1_onClick_TurnOffMusic;
            gm1.onClick_ImportMusic += gm1_onClick_ImportMusic;
            gm1.onClick_DefaultMusic += gm1_onClick_DefaultMusic;
            this.Controls.Clear();
            this.Controls.Add(gm1);
        }

    }
}
