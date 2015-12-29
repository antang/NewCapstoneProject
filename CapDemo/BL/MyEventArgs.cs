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

        int iDTeam;
        public int IDTeam
        {
            get { return iDTeam; }
            set { iDTeam = value; }
        }

        int iDNewGame;

        public int IDNewGame
        {
            get { return iDNewGame; }
            set { iDNewGame = value; }
        }
        int iDGame;

        public int IDGame
        {
            get { return iDGame; }
            set { iDGame = value; }
        }

        int iDPlayerUC;

        public int IDPlayerUC
        {
            get { return iDPlayerUC; }
            set { iDPlayerUC = value; }
        }

        int iDOneChoice;

        public int IDOneChoice
        {
            get { return iDOneChoice; }
            set { iDOneChoice = value; }
        }
    }
}
