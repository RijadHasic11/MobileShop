using MobileShop.Model;
using MobileShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class UlogeService :IUlogeService
    {
        private readonly MyContext _context;

        public UlogeService(MyContext context)
        {
            _context = context;
        }

        public List<Uloge> Get()
        {
            List<Uloge> result = new List<Uloge>();
            var lista = _context.Uloge.ToList();

            foreach(var item in lista)
            {
                Uloge uloga = new Uloge();
                uloga.Naziv = item.Naziv;
                uloga.Opis = item.Opis;
                uloga.UlogaId = item.UlogaId;

                result.Add(uloga);
            }

            return result;
        }

        public Model.Models.Uloge ProvjeriAdmin(int UlogaId)
        {
            var lista = _context.Uloge.ToList();
            Model.Models.Uloge result = new Model.Models.Uloge();

            foreach (var item in lista)
            {
                if (item.UlogaId == UlogaId)
                {
                    if (item.Naziv.Contains("Admin"))
                    {
                        result.Naziv = item.Naziv;
                        result.Opis = item.Opis;
                        result.UlogaId = item.UlogaId;

                        return result;
                    }
                   
                }
            }
            return null;
        }

    }
}
