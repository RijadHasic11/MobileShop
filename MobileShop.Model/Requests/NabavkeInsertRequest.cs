using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileShop.Model.Requests
{
    public class NabavkeInsertRequest
    {
        [Required]
        [MinLength(4)]
        public string BrojNabavke { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        [Required]
        public decimal Pdv { get; set; }
        [Required]
        public string Napomena { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }


        public List<StavkeNabavkeInsertRequest> stavke { get; set; } = new List<StavkeNabavkeInsertRequest>();
        
        
    }
}
