using CapDemo.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new Login());
=======
            Application.Run(new GameShowControl());
>>>>>>> 85477b59fc6ba4c28335e8d05821ce9c4852401e
=======
            Application.Run(new GameShowControl());
>>>>>>> 85477b59fc6ba4c28335e8d05821ce9c4852401e
        }
    }
}
