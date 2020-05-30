using AutoMapper;
using MobileShop.Model;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MobileShop.WebAPI.Services
{
    public class OcjeneService : BaseCRUDService<Model.Models.Ocjene, object, Model.Database.Ocjene, Model.Requests.OcjeneInsertRequest, object>
    {
        public OcjeneService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}