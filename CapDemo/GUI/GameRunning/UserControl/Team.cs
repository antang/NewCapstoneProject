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
    public partial class Team : UserControl
    {
        public Team()
        {
            InitializeComponent();
        }
        int idPlayerUC;
        public int IdPlayerUC
        {
            get { return idPlayerUC; }
            set { idPlayerUC = value; }
        }
        public event EventHandler checkSupport;
        private void lbl_ShowMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void chk_Support_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler checksupport = checkSupport;
            if (checksupport!=null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDPlayerUC = idPlayerUC;
                checksupport(this, args);
            }
        }


    }
}
