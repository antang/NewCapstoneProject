using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI.User_Controls
{
    public partial class Competition_Setting : UserControl
    {
        public Competition_Setting()
        {
            InitializeComponent();
        }
        //LOAD USER CONTROL
        private static Competition_Setting _instance;
        public static Competition_Setting instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Competition_Setting();
                return _instance;
            }
        }
    }
}
