using System;
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
        string nameCatalogue;
        int iDCatalogue;
        int sequence;
        string answerContent;

       
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
            get { return nameCatalogue; }
            set { nameCatalogue = value; }
        }


        //public Catalogue Catalogue
        //{
        //    get { return catalogue; }
        //    set { catalogue = value; }
        //}
        public int IDCatalogue
        {
            get { return iDCatalogue; }
            set { iDCatalogue = value; }
        }
       

        public List<Answer> AnswerList
        {
            get { return answerList; }
            set { answerList = value; }
        }
    }
}
