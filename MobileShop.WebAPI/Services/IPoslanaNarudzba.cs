using AutoMapper;
using MobileShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class IPoslanaNarudzba :BaseCRUDService<Model.Models.PoslanaNarudzba,object,Model.Database.PoslanaNarudzba,object,Model.Requests.PoslanaNarudzbaUpdateRequest>
    {
        public IPoslanaNarudzba(MyContext context,IMapper mapper) : base(context,mapper)
        {

        }

    }
}
