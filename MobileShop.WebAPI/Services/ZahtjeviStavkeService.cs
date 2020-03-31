using AutoMapper;
using MobileShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class ZahtjeviStavkeService :BaseCRUDService<Model.Models.ZahtjeviStavke,object,Model.Database.ZahtjeviStavke,Model.Requests.ZahtjeviStavkeInsertRequest,object>
    {
        public ZahtjeviStavkeService(MyContext context,IMapper mapper) : base(context, mapper)
        {

        }
    }
}
