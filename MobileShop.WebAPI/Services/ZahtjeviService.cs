using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MobileShop.Model;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class ZahtjeviService : BaseCRUDService<Model.Models.Zahtjevi,ZahtjeviSearchRequest,Model.Database.Zahtjevi,ZahtjeviInsertRequest,object>
    {
        public ZahtjeviService(MyContext context,IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Models.Zahtjevi> Get(ZahtjeviSearchRequest search)
        {
            var query = _context.Set<Model.Database.Zahtjevi>().Include(x=>x.Klijent).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(search.Naslov));
            }

            var list = query.ToList();

            List<Model.Models.Zahtjevi> result = new List<Model.Models.Zahtjevi>();
            foreach(var item in list)
            {
                Model.Models.Zahtjevi zahtjev = new Model.Models.Zahtjevi();
                zahtjev.DatumZahtjeva = item.DatumZahtjeva;
                zahtjev.Klijent = item.Klijent.KorisnickoIme;
                zahtjev.KlijentId = item.KlijentId;
                zahtjev.Naslov = item.Naslov;
                zahtjev.Opis = item.Opis;
                zahtjev.Id = item.Id;

                result.Add(zahtjev);

            }


            return result;
        }
    }
}
