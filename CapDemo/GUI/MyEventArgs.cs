using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.GUI
{
    class MyEventArgs: EventArgs
    {
        int iDAnswer;

        public int IDAnswer
        {
            get { return iDAnswer; }
            set { iDAnswer = value; }
        }
    }
}
