using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Round
    {
        int iDRound;

        public int IDRound
        {
            get { return iDRound; }
            set { iDRound = value; }
        }
        string nameRound;

        public string NameRound
        {
            get { return nameRound; }
            set { nameRound = value; }
        }
        int iDCompetition;

        public int IDCompetition
        {
            get { return iDCompetition; }
            set { iDCompetition = value; }
        }

        public int Sequence { get; set; }
    }
}
