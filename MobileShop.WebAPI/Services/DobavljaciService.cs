using AutoMapper;
using MobileShop.Model;
using MobileShop.Model.Models;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class DobavljaciService : IDobavljaciService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public DobavljaciService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Dobavljaci> Get(DobavljaciSearchRequest search)
        {
            {
                var query = _context.Dobavljaci.AsQueryable();

                if (!string.IsNullOrWhiteSpace(search?.Naziv))
                {
                    query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
                }

           

                var list = query.ToList();

                return _mapper.Map<List<Model.Models.Dobavljaci>>(list);

            }
        }
        public Dobavljaci GetById(int id)
        {
            var entity = _context.Dobavljaci.Find(id);

            return _mapper.Map<Model.Models.Dobavljaci>(entity);

        }
    }
}
