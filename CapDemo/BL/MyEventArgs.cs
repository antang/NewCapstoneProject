using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.GUI.User_Controls
{
    class MyEventArgs: EventArgs
    {
        int iDAnswer;
        public int IDAnswer
        {
            get { return iDAnswer; }
            set { iDAnswer = value; }
        }

        int iDPhase;

        public int IDPhase
        {
            get { return iDPhase; }
            set { iDPhase = value; }
        }
    }
}
