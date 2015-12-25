﻿using System;
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

        bool defy;
        bool support;

        public Record(){
        }

        public Record(int idPlayer, int idPhase, int idContest, int numPass, int numFail)
        {
            this.iDPlayer = idPlayer;
            this.iDPhase = idPhase;
            this.iDContest = idContest;
            this.numPass = numPass;
            this.numFail = numFail;
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

    }
}
