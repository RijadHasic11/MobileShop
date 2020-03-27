using AutoMapper;
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
            var query = _context.Set<Model.Database.Zahtjevi>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(search.Naslov));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Models.Zahtjevi>>(list);
        }
    }
}
