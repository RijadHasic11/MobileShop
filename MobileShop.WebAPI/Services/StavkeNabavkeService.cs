using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobileShop.Model;
using MobileShop.Model.Models;

namespace MobileShop.WebAPI.Services
{
    public class StavkeNabavkeService : IStavkeNabavke
    {
        private readonly MyContext _context;

        public StavkeNabavkeService(MyContext context)
        {
            _context = context;
        }
        public List<StavkeNabavke> Get()
        {
            var list = _context.NabavkaStavke.Include(x => x.Artikal).ToList();

            var StavkeNabavkeList = new List<StavkeNabavke>();

            foreach(var item in list)
            {
                Model.Database.Artikli artikal = _context.Artikli
                    .Where(x => x.ArtikalId == item.ArtikalId)
                    .Include(y => y.Karakteristike).Include(p=>p.Modeli).Include(z=>z.Proizvodjaci)
                    .SingleOrDefault();

                StavkeNabavke stavka = new StavkeNabavke();

                stavka.ArtikalId = item.ArtikalId;
                stavka.Cijena = item.Cijena;
                stavka.NabavkaId = item.NabavkaId;
                stavka.Kolicina = item.Kolicina;
                stavka.StavkeNabavkeId = item.NabavkaStavkeId;
                stavka.Artikal = artikal.Naziv;
                stavka.Model = artikal.Modeli.Naziv;
                stavka.Proizvodjac = artikal.Proizvodjaci.Naziv;
                stavka.Slika = artikal.Slika;

                StavkeNabavkeList.Add(stavka);
                
            }

            return StavkeNabavkeList;
           
        }



       
    }
}
