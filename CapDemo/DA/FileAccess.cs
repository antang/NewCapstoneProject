using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CapDemo.DA
{
    class FileAccess
    {
        //Read file XML
        public string FileContentXML(string NameFile)
        {
            string QuestionContent = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(NameFile);
                XmlElement root = doc.DocumentElement;
                XmlNodeList NodeQuestionType = root.SelectNodes("//quiz/question");
                foreach (XmlNode node in NodeQuestionType)
                {
                    QuestionContent += node.Attributes["type"].Value + "---";
                    QuestionContent += node["name"].InnerText.ToString() + "---";
                    QuestionContent += node["questiontext"].InnerText.ToString() + "---";
                    foreach (XmlNode item in node.SelectNodes("answer"))
                    {
                        QuestionContent +=  (item.Attributes["fraction"].Value).ToString() + "+++";
                        QuestionContent +=  (item["text"].InnerText);
                        QuestionContent += "</" + item.Name + ">";
                    }
                    QuestionContent += "</" + node.Name + ">";
                }
                QuestionContent = QuestionContent.Replace("<p>", "");
                QuestionContent = QuestionContent.Replace("</p>", "");
                QuestionContent = QuestionContent.Replace("<br>", Environment.NewLine);
                QuestionContent = QuestionContent.Replace("</br>", "");
                //QuestionContent = QuestionContent.Replace("'", "''");
                return QuestionContent;
            }
            catch (Exception)
            {
                return null;
            }
                
        }

        //Read File TXT
        public string FileContentTXT(string NameFile)
        {
            string QuestionContent = "";

            foreach (var line in File.ReadAllLines(NameFile))
            {

                QuestionContent += line;
            }
            //QuestionContent= QuestionContent.Replace("'", "''");
            return QuestionContent.Trim().ToString() ;
        } 

        //Read hot potatoes file
        public string FileContentHotPotato(string NameFile)
        {
            string QuestionContent = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(NameFile);
                XmlElement root = doc.DocumentElement;
                XmlNodeList NodeQuestionType = root.SelectNodes("//hotpot-jquiz-file/data/questions/question-record");
                int i = 1;
                foreach (XmlNode node in NodeQuestionType)
                {
                    QuestionContent += "multichoice" + "---";
                    QuestionContent += "Question "+i.ToString()+ "---";
                    QuestionContent += node["question"].InnerText.ToString() + "---";
                    foreach (XmlNode item in node.SelectNodes("answers/answer"))
                    {
                        //Phong Edit
                        if ((item["text"].InnerText) != "")
                        {
                            QuestionContent += (item["correct"].InnerText) + "+++";
                            QuestionContent += (item["text"].InnerText);
                            QuestionContent += "</" + item.Name + ">";
                        }
                    }
                    QuestionContent += "</" + node.Name + ">";
                    i++;
                }
                QuestionContent = QuestionContent.Replace("<p>", "");
                QuestionContent = QuestionContent.Replace("</p>", "");
                QuestionContent = QuestionContent.Replace("<br>", Environment.NewLine);
                QuestionContent = QuestionContent.Replace("</br>", "");
                //QuestionContent = QuestionContent.Replace("'", "''");
                QuestionContent = QuestionContent.Replace("&#x2022;", "\u2022");
                QuestionContent = QuestionContent.Replace("#x2022;", "\u2022");
                return QuestionContent;
                
            }
            catch (Exception)
            {
                return null;
            }
        } 
    }
}
