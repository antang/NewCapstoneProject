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
using System.Media;
using NAudio.Wave;
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
            Sound();
            
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
            this.Controls.Add(gm1);
        }
        //log up event help
        void gm1_onClick_Help(object sender, EventArgs e)
        {
            s.Stop();
            this.Controls.Clear();
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
            this.Help.onExit += Help_onExit;
            this.Controls.Add(Help);
        }
        //exit help Control
        void Help_onExit(object sender, EventArgs e)
        {
            Sound();

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
            this.Controls.Clear();
            this.Controls.Add(gm1);
        }

        //Click to show Start Game GUI
        void btn_Start_onClick(object sender, EventArgs e)
        {
            Start_Game sg = new Start_Game();
           // s.Stop();
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
            this.Controls.Clear();
            this.Controls.Add(sg);
        }

        //Click to show Setting Game GUI
        void btn_Setting_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            s.Stop();
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
            this.Controls.Clear();
            Sound();
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
            this.Controls.Add(gm1);
        }
        //Exit start Game
        void Exit_StartGame(object sender, EventArgs e)
        {
            GameMenu gm1 = new GameMenu(UserID, UserName, Pass);
            Sound();
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
            this.Controls.Clear();
            this.Controls.Add(gm1);
        }

        //show sound
        SoundPlayer s;
        public void Sound()
        {
            using (Mp3FileReader mp3 = new Mp3FileReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\Ai_Se_Eu_Pego.mp3"))
            {
                using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                {
                    WaveFileWriter.CreateWaveFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\Ai_Se_Eu_Pego.wav", pcm);
                }
            }
            s = new SoundPlayer();
            s.SoundLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Sound\\Ai_Se_Eu_Pego.wav";
            s.Play();
            s.PlayLooping();
        }
    }
}
