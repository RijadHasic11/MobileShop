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
            CreateMap<Model.Database.Korisnici, Model.Models.Korisnici>().ReverseMap();
            
            CreateMap<Model.Database.Uloge, Model.Models.Uloge>();



        }
    }
}
