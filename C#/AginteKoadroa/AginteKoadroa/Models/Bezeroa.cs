﻿using System.ComponentModel.DataAnnotations;

namespace AginteKoadroa.Models
{
    public class Bezeroa
    {
        [Key]
        public string Nan { get; set; }
        public string Izena { get; set; }
        public string Helbidea { get; set; }
        public string Telf { get; set; }
        public string Emaila { get; set; }
        public string NanSaltzailea { get; set; }
    }
}