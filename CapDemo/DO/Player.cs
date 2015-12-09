using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Player
    {
        int iDPlayer;
        int iDContest;
        //int iDRound;
        string playerName;
        int playerScore;
        string color;
        int sequence;

        public int Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        public int IDPlayer
        {
            get { return iDPlayer; }
            set { iDPlayer = value; }
        }

        public int IDContest
        {
            get { return iDContest; }
            set { iDContest = value; }
        }

        //public int IDRound
        //{
        //    get { return iDRound; }
        //    set { iDRound = value; }
        //}

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int PlayerScore
        {
            get { return playerScore; }
            set { playerScore = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
