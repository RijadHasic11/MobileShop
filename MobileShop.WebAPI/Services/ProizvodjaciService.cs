using AutoMapper;
using MobileShop.Model;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class ProizvodjaciService : BaseCRUDService<Model.Models.Proizvodjaci, object, Model.Database.Proizvodjaci, ProizvodjaciInsertRequest, object>
    {
        public ProizvodjaciService(MyContext context,IMapper mapper) : base(context, mapper)
        {

        }
    }

}
