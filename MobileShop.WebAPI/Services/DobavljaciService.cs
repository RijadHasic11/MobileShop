using AutoMapper;
using MobileShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public class DobavljaciService : BaseService<Model.Models.Dobavljaci,object,Model.Database.Dobavljaci>
    {
        public DobavljaciService(MyContext context,IMapper mapper):base(context,mapper)
        {


        }


    }
}
