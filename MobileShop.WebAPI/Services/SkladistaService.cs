using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MobileShop.Model;
using MobileShop.Model.Models;
using MobileShop.Model.Requests;

namespace MobileShop.WebAPI.Services
{
    public class SkladistaService : ISkladistaService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public SkladistaService(MyContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Skladista> Get()
        {
            var list = _context.Skladista.ToList();

            var lista = new List<Skladista>();

            foreach (var item in list)
            {


                Skladista skladiste = new Skladista();

                skladiste.Naziv = item.Naziv;
                skladiste.Adresa = item.Adresa;
                skladiste.Opis = item.Opis;

                
                lista.Add(skladiste);

            }

            return lista;
        }

        public Skladista GetById(int id)
        {
            var entity = _context.Skladista.Find(id);

            return _mapper.Map<Model.Models.Skladista>(entity);
           
        }
       

       


    }
}
