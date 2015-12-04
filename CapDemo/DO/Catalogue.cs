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
        string catName;
        int sequence;

        public int Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        public int IDCatalogue
        {
            get { return IDcatalogue; }
            set { IDcatalogue = value; }
        }

        public string NameCatalogue
        {
            get { return catName; }
            set { catName = value; }
        }
    }
}
