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
        int exist_I;

        public int Exist_I
        {
            get { return exist_I; }
            set { exist_I = value; }
        }
        bool defy;
        int defy_I;

        public int Defy_I
        {
            get { return defy_I; }
            set { defy_I = value; }
        }
        bool support;
        int support_I;

        public int Support_I
        {
            get { return support_I; }
            set { support_I = value; }
        }
        bool pM;
        int pM_I;

        public int PM_I
        {
            get { return pM_I; }
            set { pM_I = value; }
        }
        bool undie;
        int undie_I;

        public int Undie_I
        {
            get { return undie_I; }
            set { undie_I = value; }
        }
        bool playerTurn;

        public bool PlayerTurn
        {
            get { return playerTurn; }
            set { playerTurn = value; }
        }
        int playerTurn_I;

        public int PlayerTurn_I
        {
            get { return playerTurn_I; }
            set { playerTurn_I = value; }
        }

        int amountTeam;
        public int AmountTeam
        {
            get { return amountTeam; }
            set { amountTeam = value; }
        }
        int turn;

        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        bool done;

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        int done_I;

        public int Done_I
        {
            get { return done_I; }
            set { done_I = value; }
        }
        bool first;
        public bool First
        {
            get { return first; }
            set { first = value; }
        }
        int first_I;

        public int First_I
        {
            get { return first_I; }
            set { first_I = value; }
        }
        public Record(){
        }

        public Record(int idPlayer, int idPhase, int idContest, int numPass, int numFail,bool defy, bool support, bool exist, int phaseIndex, int teamScore, int totalPass, int sequencePlayer, bool pM, bool undie, bool done, bool first)
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
            this.undie = undie;
            //
            this.done = done;
            this.first = first;
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
        public bool Undie
        {
            get { return undie; }
            set { undie = value; }
        }

    }
}
