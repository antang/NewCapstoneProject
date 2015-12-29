using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.GUI.User_Controls;

namespace CapDemo
{
    public partial class onechoice : UserControl
    {
        public onechoice()
        {
            InitializeComponent();
        }
        public event EventHandler onCheckOneChoice;
        int iD_OneChoice;
        public int ID_OneChoice
        {
            get { return iD_OneChoice; }
            set { iD_OneChoice = value; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler oncheck = onCheckOneChoice;
            if (oncheck!=null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDOneChoice = iD_OneChoice;
                oncheck(this, args);
            }
        }
    }
}
