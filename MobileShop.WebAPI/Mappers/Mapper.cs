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
            CreateMap<Model.Database.Klijenti, Model.Requests.KlijentiInsertRequest>().ReverseMap();

            CreateMap<Model.Database.Zahtjevi, Model.Models.Zahtjevi>();
            CreateMap<Model.Database.Zahtjevi, Model.Requests.ZahtjeviInsertRequest>().ReverseMap();
            CreateMap<Model.Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Model.Database.Korisnici, Model.Models.Korisnici>();
            
            CreateMap<Model.Database.Uloge, Model.Models.Uloge>();
            CreateMap<Model.Database.Skladista, Model.Models.Skladista>();

            CreateMap<Model.Database.Dobavljaci, Model.Models.Dobavljaci>();

            CreateMap<Model.Database.Artikli, Model.Models.Artikli>();
            CreateMap<Model.Database.Artikli, Model.Requests.ArtikliInsertRequest>().ReverseMap();

            CreateMap<Model.Database.Obavijesti, Model.Models.Obavijesti>();
            CreateMap<Model.Database.Obavijesti, Model.Requests.ObavijestInsertRequest>().ReverseMap();
            CreateMap<Model.Database.PoslanaNarudzba, Model.Models.PoslanaNarudzba>();
            CreateMap<Model.Database.PoslanaNarudzba, Model.Requests.PoslanaNarudzbaUpdateRequest>().ReverseMap();

            CreateMap<Model.Database.Proizvodjaci, Model.Models.Proizvodjaci>();
            CreateMap<Model.Database.Proizvodjaci, Model.Requests.ProizvodjaciInsertRequest>().ReverseMap();

            CreateMap<Model.Database.Modeli, Model.Models.Modeli>();
            CreateMap<Model.Database.Modeli, Model.Requests.ModeliInsertRequest>().ReverseMap();

            CreateMap<Model.Database.Karakteristike, Model.Models.Karakteristike>();
            CreateMap<Model.Database.Karakteristike, Model.Requests.KarakteristikeInsertRequest>().ReverseMap();

            CreateMap<Model.Database.ZahtjeviStavke, Model.Models.ZahtjeviStavke>();


            CreateMap<Model.Database.Ocjene, Model.Models.Ocjene>();
            CreateMap<Model.Database.Ocjene, Model.Requests.OcjeneInsertRequest>().ReverseMap();


        }
    }
}
