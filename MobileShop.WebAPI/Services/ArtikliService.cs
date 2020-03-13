using AutoMapper;
using MobileShop.Model;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class ArtikliService :IArtikliService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;
        public ArtikliService(MyContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Models.Artikli> Get(ArtikliSearchRequest search)
        {
            var query = _context.Set<Model.Database.Artikli>().AsQueryable();

            if (search?.ProizvodjacId.HasValue == true)
            {
                query = query.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }
            query = query.OrderBy(x => x.Naziv);


            var list = query.ToList();

            return _mapper.Map<List<Model.Models.Artikli>>(list);
        }

        public Model.Models.Artikli GetById(int id)
        {
            var entity = _context.Artikli.Find(id);

            return _mapper.Map<Model.Models.Artikli>(entity);
        }
        public Model.Models.Artikli GetBySifra(string sifra)
        {
            var entity = _context.Artikli.Where(x => x.Sifra.Equals(sifra)).FirstOrDefault();

            return _mapper.Map<Model.Models.Artikli>(entity);
        }

        
    }
}
