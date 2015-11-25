﻿using CapDemo.GUI.User_Controls;
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
        Start_Game sg = new Start_Game();
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
            this.Controls.Add(gm1);
            gm1.btn_Setting.Click += new EventHandler(btn_Setting_onClick);
            this.st.btn_Exit.Click += new EventHandler(Exit_Setting);
            gm1.btn_Start.Click += new EventHandler(btn_Start_onClick);
            this.sg.btn_Exit.Click += new EventHandler(btn_Exit_onlick);
        }
        //Exit Start Game GUI
        void btn_Exit_onlick(object sender, EventArgs e)
        {
            GameMenu gm1 = new GameMenu(UserID, UserName,Pass);
            gm1.btn_Setting.Click += new EventHandler(btn_Setting_onClick);
            this.st.btn_Exit.Click += new EventHandler(Exit_Setting);
            gm1.btn_Start.Click += new EventHandler(btn_Start_onClick);
            //this.sg.btn_Exit.Click += new EventHandler(btn_Exit_onlick);

            this.Controls.Clear();
            this.Controls.Add(gm1);
        }

        //Click to show Start Game GUI
        void btn_Start_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(sg);
        }
        //Click to show Setting Game GUI
        void btn_Setting_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(st);
        }
        //Exit Setting GUI
        void Exit_Setting(object sender, EventArgs e)
        {
            GameMenu gm1 = new GameMenu(UserID, UserName,Pass);
            gm1.btn_Setting.Click += new EventHandler(btn_Setting_onClick);
            //this.st.btn_Exit.Click += new EventHandler(Exit_Setting);
            gm1.btn_Start.Click += new EventHandler(btn_Start_onClick);
            this.sg.btn_Exit.Click += new EventHandler(btn_Exit_onlick);

            this.Controls.Clear();
            this.Controls.Add(gm1);
        }
        
    }
}