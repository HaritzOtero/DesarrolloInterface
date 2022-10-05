using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Bezeroa : Kontaktua
    {
        public  string izena { get => base.izena; set => base.izena = value; }
        public  string abizena { get => base.abizena; set => base.abizena = value; }

        public override string emaila { get => base.emaila; set => base.emaila = value; }

        public string kategoria { get; set; }

        public override String Gorde()
        {
            string mezua = "Bezeroa ondo gorde da.";
            return mezua;
        }
    }
}
