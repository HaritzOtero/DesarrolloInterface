using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Langilea: Kontaktua
    {
        public float soldata { get; set; }
        public string segurtasunSoziala { get; set; }

        public override string emaila {
            
            get => base.emaila; 
            
            set
            {
                if (value.Length>8 && value.Substring((value.Length)-8)=="@uni.eus")
                {
                    base.emaila = value;
                }
                else
                {
                    Exception ex = new Exception("@uni.eus izan behar da.");
                    throw ex;

                }
            } }
        public override string Gorde()
        {
            string mezua  = "Langilea ondo gorde da.";
            return mezua;
        }
    }
}
