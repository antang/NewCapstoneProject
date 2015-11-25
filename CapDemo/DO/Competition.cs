using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Competition
    {
        int iDCompetition;
        string nameCompetition;

        public int IDCompetition
        {
            get { return iDCompetition; }
            set { iDCompetition = value; }
        }

        public string NameCompetition
        {
            get { return nameCompetition; }
            set { nameCompetition = value; }
        }
    }
}
