﻿using System;
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
    public partial class ImportQuestions : UserControl
    {
        public ImportQuestions()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ImportQuestions_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}