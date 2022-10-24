using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookpadForm.models
{
    internal class Erabiltzailea
    {
        [Key]
        public string Id { get; set; }
        public string Izena {
                get => this.Izena;

                set
            {
                    if (value.Length > 0)
                    {
                        this.Izena = value;
                    }
                    else
                    {
                        Exception ex = new Exception("izena bete");
                        throw ex;

                    }
                }
            }
        public string Emaila {
            get => this.Emaila;

            set
            {
                if (value.Length > 9 && value.Contains("@"))
                {
                   this.Emaila = value;
                }
                else
                {
                    Exception ex = new Exception("email baliogarria izan behar da.");
                    throw ex;

                }
            }
        }
        public string Ezizena
        {
            get => this.Izena;

            set
            {
                if (value.Length > 0)
                {
                    this.Izena = value;
                }
                else
                {
                    Exception ex = new Exception("ezizena bete");
                    throw ex;

                }
            }
        }
        public virtual List<Botoa> Botoa { get; set; }

    }
}
