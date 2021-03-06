﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Question
    {
        int questionID;
        string questionName;
        string typeQuestion;
        Catalogue catalogue;
        List<Answer> answerList;
        int iDCatalogue;
        int sequence;
        string answerContent;
        DateTime date;
        string questionTitle;

        

        public Question()
        {
            catalogue = new Catalogue();
        }
        
        public string AnswerContent
        {
            get { return answerContent; }
            set { answerContent = value; }
        }

        public int Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }
        
        public int IDQuestion
        {
            get { return questionID; }
            set { questionID = value; }
        }

        public string QuestionTitle
        {
            get { return questionTitle; }
            set { questionTitle = value; }
        }
        public string NameQuestion
        {
            get { return questionName; }
            set { questionName = value; }
        }

        
        public string TypeQuestion
        {
            get { return typeQuestion; }
            set { typeQuestion = value; }
        }

        public string NameCatalogue
        {
            get { return catalogue.NameCatalogue; }
            set { catalogue.NameCatalogue = value; }
        }


        public Catalogue Catalogue
        {
            get { return catalogue; }
            set { catalogue = value; }
        }
        public int IDCatalogue
        {
            get { return iDCatalogue; }
            set { iDCatalogue = value; }
        }


        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public List<Answer> AnswerList
        {
            get { return answerList; }
            set { answerList = value; }
        }
    }
}
