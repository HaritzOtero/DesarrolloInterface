using System.ComponentModel.DataAnnotations;

namespace AginteKoadroa.Models
{
    public class Saltzailea
    {
        [Key]
        public string Nan { get; set; }
        public string Izena { get; set; }
        public string Taldea { get; set; }
    }
}