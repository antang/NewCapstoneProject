using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DA
{
    class FileAccess
    {
        //Read file
        public string FileContent(string NameFile)
        {
            string QuestionContent = "";

            foreach (var line in File.ReadAllLines(NameFile))
            {
                QuestionContent += line;
            }
            return QuestionContent;
        }
        
    }
}
