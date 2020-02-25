using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Model.Database.Klijenti, Model.Models.Klijenti>();
            CreateMap<Model.Database.Zahtjevi, Model.Models.Zahtjevi>();
            CreateMap<Model.Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Model.Database.Korisnici, Model.Models.Korisnici>();
            
            CreateMap<Model.Database.Uloge, Model.Models.Uloge>();
            CreateMap<Model.Database.Skladista, Model.Models.Skladista>();

            CreateMap<Model.Database.Dobavljaci, Model.Models.Dobavljaci>();
            CreateMap<Model.Database.Artikli, Model.Models.Artikli>();
            CreateMap<Model.Database.Obavijesti, Model.Models.Obavijesti>();
            CreateMap<Model.Database.Obavijesti, Model.Requests.ObavijestInsertRequest>().ReverseMap();



        }
    }
}
