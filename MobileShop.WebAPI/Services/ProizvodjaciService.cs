using AutoMapper;
using MobileShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class ProizvodjaciService :BaseService<Model.Models.Proizvodjaci,object,Model.Database.Proizvodjaci>
    {
        public ProizvodjaciService(MyContext context,IMapper mapper) : base(context, mapper)
        {

        }
    }
}
