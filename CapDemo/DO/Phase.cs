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
        int iDQuestion;
        string namePhase;
        string scorePhase;

        public int IDContest
        {
            get { return iDContest; }
            set { iDContest = value; }
        }

        public int IDQuestion
        {
            get { return iDQuestion; }
            set { iDQuestion = value; }
        }

        public string NamePhase
        {
            get { return namePhase; }
            set { namePhase = value; }
        }

        public string ScorePhase
        {
            get { return scorePhase; }
            set { scorePhase = value; }
        }
    }
}
