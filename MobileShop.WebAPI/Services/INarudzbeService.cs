using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface INarudzbeService
    {
        List<Model.Models.Narudzbe> Get(NarudzbeSearchRequest search);

        Model.Models.Narudzbe GetById(int id);

        void Insert(NarudzbeInsertRequest request);

        void Update(int id, NarudzbeInsertRequest request);
    }
}
