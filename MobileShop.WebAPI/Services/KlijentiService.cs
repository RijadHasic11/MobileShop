using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MobileShop.Model;
using MobileShop.Model.Models;

namespace MobileShop.WebAPI.Services
{
    public class KlijentiService : IKlijentiService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public KlijentiService(MyContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public List<Model.Models.Klijenti> Get()
        {

            var list = _context.Klijenti.ToList();

            return _mapper.Map<List<Model.Models.Klijenti>>(list);
        }
    }
}
