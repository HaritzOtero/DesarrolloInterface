using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Kontaktua
    {
        public string nan { get; set; }
        public  string izena { get; set; }
        public  string abizena {get; set; }
        public virtual string emaila { get; set; }

        public string izenOsoa { get => izena + " " + abizena; }

        public virtual string Gorde()
        {
            string mezua = "Kontaktua ondo gorde da.";
            return mezua;
        }
    }
}
