using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Record
    {
        int iDPlayer;
        int iDPhase;
        int iDContest;
        int numPass;
        int numFail;
        int phaseIndex;
        int teamScore;
        int totalPass;
        int sequencePlayer;

       

        bool exist;
        bool defy;
        bool support;
        bool pM;

        


        public Record(){
        }

        public Record(int idPlayer, int idPhase, int idContest, int numPass, int numFail,bool defy, bool support, bool exist, int phaseIndex, int teamScore, int totalPass, int sequencePlayer, bool pM)
        {
            this.iDPlayer = idPlayer;
            this.iDPhase = idPhase;
            this.iDContest = idContest;
            this.numPass = numPass;
            this.numFail = numFail;
            this.defy = defy;
            this.support = support;
            this.exist = exist;
            this.phaseIndex = phaseIndex;
            this.teamScore = teamScore;
            this.totalPass = totalPass;
            this.sequencePlayer = sequencePlayer;
            this.pM = pM;
        }

        public int IDPlayer
        {
            get { return iDPlayer; }
            set { iDPlayer = value; }
        }
        public int IDPhase
        {
            get { return iDPhase; }
            set { iDPhase = value; }
        }
        public int IDContest
        {
            get { return iDContest; }
            set { iDContest = value; }
        }
        public int NumPass
        {
            get { return numPass; }
            set { numPass = value; }
        }
        public int NumFail
        {
            get { return numFail; }
            set { numFail = value; }
        }
        public bool Defy
        {
            get { return defy; }
            set { defy = value; }
        }
        public bool Support
        {
            get { return support; }
            set { support = value; }
        }
        public bool Exist
        {
            get { return exist; }
            set { exist = value; }
        }
        public int PhaseIndex
        {
            get { return phaseIndex; }
            set { phaseIndex = value; }
        }
        public int TeamScore
        {
            get { return teamScore; }
            set { teamScore = value; }
        }
        public int TotalPass
        {
            get { return totalPass; }
            set { totalPass = value; }
        }
        public int SequecePlayer
        {
            get { return sequencePlayer; }
            set { sequencePlayer = value; }
        }
        public bool PM
        {
            get { return pM; }
            set { pM = value; }
        }
    }
}
