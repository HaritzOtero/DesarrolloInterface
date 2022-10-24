using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookpadForm.models
{
    internal class Errezeta
    {
        [Key]

        public int Id { get; set; }
        public string Izena { get; set; }   
        public string deskribapena { get; set; }

        public virtual List<Botoa> Botoa { get; set; }
    }
}
