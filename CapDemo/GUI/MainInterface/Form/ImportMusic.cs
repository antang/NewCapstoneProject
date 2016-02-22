using CapDemo.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class ImportMusic : Form
    {
        public ImportMusic()
        {
            InitializeComponent();
        }
        string[] fileNames, filePaths;
        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDialog1.SafeFileNames;
                filePaths = openFileDialog1.FileNames;

                foreach (string fileName in fileNames)
                {
                    listBox1.Items.Add(fileName);
                }
            }
        }
        //GameShowControl gsc = new GameShowControl();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //gsc.axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.URL = filePaths[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.settings.setMode("Loop", true);
            }
            catch (Exception)
            {
            }
            
        }
        //
        private void ImportMusic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
