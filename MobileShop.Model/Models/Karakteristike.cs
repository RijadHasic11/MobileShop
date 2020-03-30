using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Model.Models
{
    public class Karakteristike
    {
        public int KarakteristikeId { get; set; }
        public bool Novo { get; set; }
        public string OperativniSistem { get; set; }
        public decimal Kamera { get; set; }
        public decimal Ram { get; set; }
        public decimal Memorija { get; set; }
        public decimal Procesor { get; set; }
    }
}
