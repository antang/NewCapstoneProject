using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapDemo.DA
{
    class FileAccess
    {
        //Read file XML
        public string FileContentXML(string NameFile)
        {
            string QuestionContent = "";
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            try
            {
                using (XmlReader reader = XmlReader.Create(NameFile, settings))
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element: // The node is an element.
                                QuestionContent += ("<" + reader.Name);

                                while (reader.MoveToNextAttribute()) // Read the attributes.
                                    QuestionContent += (" " + reader.Name + "='" + reader.Value + "'");
                                QuestionContent += (">");
                                break;
                            case XmlNodeType.Text: //Display the text in each element.
                                QuestionContent += (reader.Value);
                                break;
                            case XmlNodeType.EndElement: //Display the end of the element.
                                QuestionContent += ("</" + reader.Name);
                                QuestionContent += (">");
                                break;
                        }
                    }
                }
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
            return QuestionContent.Trim();
        }
        
    }
}
