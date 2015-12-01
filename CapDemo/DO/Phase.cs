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
        int iDCatalogue;
        string namePhase;
        int scorePhase;
        int minusPhase;
        int timePhase;

        public int IDContest
        {
            get { return iDContest; }
            set { iDContest = value; }
        }

        public int IDCatalogue
        {
            get { return iDCatalogue; }
            set { iDCatalogue = value; }
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
