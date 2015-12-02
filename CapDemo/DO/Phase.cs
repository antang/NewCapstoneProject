using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Phase
    {
        int iDContest;
        int iDPhase;
        string namePhase;
        int scorePhase;
        int minusPhase;
        int timePhase;
        int sequence;
        int iDQuestion;

        public int IDQuestion
        {
            get { return iDQuestion; }
            set { iDQuestion = value; }
        }

        public int Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        public int IDContest
        {
            get { return iDContest; }
            set { iDContest = value; }
        }

        public int IDPhase
        {
            get { return iDPhase; }
            set { iDPhase = value; }
        }

        public string NamePhase
        {
            get { return namePhase; }
            set { namePhase = value; }
        }

        public int ScorePhase
        {
            get { return scorePhase; }
            set { scorePhase = value; }
        }
        public int MinusPhase
        {
            get { return minusPhase; }
            set { minusPhase = value; }
        }
        public int TimePhase
        {
            get { return timePhase; }
            set { timePhase = value; }
        }

    }
}
