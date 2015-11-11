using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class Catalogue
    {
        int IDcatalogue;

        public int IDCatalogue
        {
            get { return IDcatalogue; }
            set { IDcatalogue = value; }
        }
        string name;

        public string NameCatalogue
        {
            get { return name; }
            set { name = value; }
        }
    }
}
