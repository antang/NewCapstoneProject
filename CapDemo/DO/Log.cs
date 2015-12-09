using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Log
    {
        int contestID;
        int playerID;
        int phaseID;
        int playerScore;
        int currentNumofTrue;
        int currentNumofFalse;
        bool exist;

        public int ContestID
        {
            get { return contestID; }
            set { contestID = value; }
        }
        
        public int PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public int PhaseID
        {
            get { return phaseID; }
            set { phaseID = value; }
        }

        public int PlayerScore
        {
            get { return playerScore; }
            set { playerScore = value; }
        }

        public int CurrentNumofTrue
        {
            get { return currentNumofTrue; }
            set { currentNumofTrue = value; }
        }

        public int CurrentNumofFalse
        {
            get { return currentNumofFalse; }
            set { currentNumofFalse = value; }
        }

        public bool Exist
        {
            get { return exist; }
            set { exist = value; }
        }
    }
}
