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
        Setting st = new Setting();
        GameMenu gm = new GameMenu();
        public GameShowControl()
        {
            InitializeComponent();
        }
        private void GameShowControl_Load(object sender, EventArgs e)
        {
            this.Controls.Add(gm);
            this.gm.btn_Setting.Click += new EventHandler(btn_Setting_onClick);
            this.st.btn_Exit.Click += new EventHandler(Exit_Setting);
        }

        private void btn_Setting_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(st);
        }

        void Exit_Setting(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(gm);
        }
        
    }
}
