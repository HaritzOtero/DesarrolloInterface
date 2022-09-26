using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa1
{
    internal class Esaldia
    {
        public string   Hitza { get; set; }
        public string esaldiOsoa { get; set; }

        public Esaldia (string hitza) 
        {
            this.Hitza = hitza;
            this.esaldiOsoa = esaldiOsoa;
        }

        public Esaldia()
        {

        }

        public string Lotu()
        {
            esaldiOsoa = this.esaldiOsoa + Hitza;
            return esaldiOsoa;
        }

    }
}
