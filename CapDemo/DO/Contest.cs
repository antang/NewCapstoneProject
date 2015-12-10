using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Contest
    {
        int iDContest;
        string nameContest;
        int bonus;
        int requestTime;
        int challengceScore;
        int numberChallenge;
        int timeShowAnswer;
        int timeShowQuestion;
        int timesTrue;
        int timesFalse;
        int idRound;
        Round round;
        Competition competition;
        Phase phase;
        Player player;
        List<Player> playerList;

        public string NamePlayer
        {
            get { return player.PlayerName; }
            set { player.PlayerName = value; }
        }

        internal List<Player> PlayerList
        {
            get { return playerList; }
            set { playerList = value; }
        }

        public Player Player
        {
            get { return player; }
            set { player = value; }
            
        }

        public Phase Phase
        {
            get { return phase; }
            set { phase = value; }
        }

        public Competition Competition
        {
            get { return competition; }
            set { competition = value; }
        }
        public Contest()
        {
            round = new Round();
            competition = new Competition();
            phase = new Phase();
            player = new Player();
            playerList = new List<Player>();
        }
        public Round Round
        {
            get { return round; }
            set { round = value; }
        }
        public int IDContest
        {
            get { return iDContest; }
            set { iDContest = value; }
        }

        public int IDRound
        {
            get { return idRound; }
            set { idRound = value; }
        }
        public int Sequence { get; set; }
        public string NameContest
        {
            get { return nameContest; }
            set { nameContest = value; }
        }

        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public int RequestTime
        {
            get { return requestTime; }
            set { requestTime = value; }
        }

        public int ChallengceScore
        {
            get { return challengceScore; }
            set { challengceScore = value; }
        }

        public int NumberChallenge
        {
            get { return numberChallenge; }
            set { numberChallenge = value; }
        }

        public int TimeShowAnswer
        {
            get { return timeShowAnswer; }
            set { timeShowAnswer = value; }
        }

        public int TimeShowQuestion
        {
            get { return timeShowQuestion; }
            set { timeShowQuestion = value; }
        }

        public int TimesTrue
        {
            get { return timesTrue; }
            set { timesTrue = value; }
        }

        public int TimesFalse
        {
            get { return timesFalse; }
            set { timesFalse = value; }
        }



    }
}
