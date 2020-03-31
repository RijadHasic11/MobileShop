using AutoMapper;
using MobileShop.Model;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{

    public class KarakteristikeService : BaseCRUDService<Model.Models.Karakteristike, object, Model.Database.Karakteristike, KarakteristikeInsertRequest, object>
    {
        public KarakteristikeService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
