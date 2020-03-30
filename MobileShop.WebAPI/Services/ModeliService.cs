using AutoMapper;
using MobileShop.Model;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class ModeliService : BaseCRUDService<Model.Models.Modeli, object, Model.Database.Modeli, ModeliInsertRequest, object>
    {
        public ModeliService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
