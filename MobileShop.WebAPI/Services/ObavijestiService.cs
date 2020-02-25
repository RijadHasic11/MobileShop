using AutoMapper;
using MobileShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileShop.Model.Requests;

namespace MobileShop.WebAPI.Services
{
    public class ObavijestiService :BaseCRUDService<Model.Models.Obavijesti,ObavijestiSearchRequest
        ,Model.Database.Obavijesti,ObavijestInsertRequest,ObavijestInsertRequest>
    {
        public ObavijestiService(MyContext context,IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Models.Obavijesti> Get(ObavijestiSearchRequest search)
        {
            var query = _context.Set<Model.Database.Obavijesti>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(search.Naslov));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Models.Obavijesti>>(list);
        }
    }
}
