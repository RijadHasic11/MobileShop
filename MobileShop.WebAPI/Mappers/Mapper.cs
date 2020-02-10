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
        }
    }
}
