using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileShop.Model.Requests
{
    public class ObavijestInsertRequest
    {
       
        [Required]
        public string Naslov { get; set; }
        [Required]
        [MinLength(20)]
        public string Text { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }
    }
}
