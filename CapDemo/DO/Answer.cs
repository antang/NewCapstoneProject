using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Answer
    {
        int answerID;

        public int IDAnswer
        {
            get { return answerID; }
            set { answerID = value; }
        }
        string answerContent;

        public string ContentAnswer
        {
            get { return answerContent; }
            set { answerContent = value; }
        }
        bool isCorrect;

        public bool IsCorrect
        {
            get { return isCorrect; }
            set { isCorrect = value; }
        }
        int sequence;

        public int Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        int iDQuestion;

        public int IDQuestion
        {
            get { return iDQuestion; }
            set { iDQuestion = value; }
        }

        int iDCatalogue;

        public int IDCatalogue
        {
            get { return iDCatalogue; }
            set { iDCatalogue = value; }
        }
        int check;

        public int Check
        {
            get { return check; }
            set { check = value; }
        }
        //private Question question;

        //public Question Question
        //{
        //    get { return question; }
        //    set { question = value; }
        //}

    }
}
