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

namespace CapDemo.GUI
{
    public partial class GameShowControl : Form
    {
        private string userName;
        private int userID;
        private string pass;

        Setting st = new Setting();
        Start_Game sgFirst = new Start_Game();
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
            GameMenu gm1 = new GameMenu(UserID, UserName,Pass);
            gm1.onClick_Setting += btn_Setting_onClick;
            gm1.onClick_Start += btn_Start_onClick;
            this.Controls.Add(gm1);
        }

        //Click to show Start Game GUI
        void btn_Start_onClick(object sender, EventArgs e)
        {
            Start_Game sg = new Start_Game();
            sg.onExit += Exit_StartGame;
            //sg.Doubleclick += sg_DoubleClick;
            this.Controls.Clear();
            this.Controls.Add(sg);
        }

        //void sg_DoubleClick(object sender, EventArgs e)
        //{
        //    Start_Game sg = new Start_Game();
        //    this.cg.onExit += Exit_ControlGame;
        //    //cg.Idcontest = sg.Idcontest;
        //    this.Controls.Clear();
        //    this.Controls.Add(cg); 
        //}
        //Exit Control game
        //void Exit_ControlGame(object sender, EventArgs e)
        //{
        //    Start_Game sg = new Start_Game();
        //    sg.onExit += Exit_StartGame;
        //    //sg.Doubleclick += sg_DoubleClick;
        //    this.Controls.Clear();
        //    this.Controls.Add(sg);
        //}
        //Click to show Setting Game GUI
        void btn_Setting_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.st.onExit += Exit_Setting;
            this.Controls.Add(st);
        }
        //Exit Setting GUI
        void Exit_Setting(object sender, EventArgs e)
        {
            this.Controls.Clear();
            GameMenu gm1 = new GameMenu(UserID, UserName,Pass);
            gm1.onClick_Setting += btn_Setting_onClick;
            gm1.onClick_Start += btn_Start_onClick;
            this.Controls.Add(gm1);
        }
        //Exit start Game
        void Exit_StartGame(object sender, EventArgs e)
        {
            GameMenu gm1 = new GameMenu(UserID, UserName, Pass);
            gm1.onClick_Setting += btn_Setting_onClick;
            gm1.onClick_Start += btn_Start_onClick;
            this.Controls.Clear();
            this.Controls.Add(gm1);
        }
    }
}
