using AutoMapper;
using MobileShop.Model;

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

        public List<Model.Models.Artikli> Get()
        {

            var list = _context.Artikli.ToList();

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
