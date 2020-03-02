using Microsoft.AspNetCore.Mvc;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IDobavljaciService
    {
        List<Model.Models.Dobavljaci> Get(DobavljaciSearchRequest search);

        Model.Models.Dobavljaci GetById(int id);
        void Insert(DobavljaciInsertRequest request);
        void Update(int id, [FromBody]DobavljaciInsertRequest request);

    }
}
