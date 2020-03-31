using MobileShop.Model.Models;
using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IKlijentiService
    {
        List<Model.Models.Klijenti> Get(KlijentiSearchRequest search);
        Klijenti GetById(int id);
        void Insert(KlijentiInsertRequest request);

        void Update(int id, KlijentiInsertRequest request);

        Model.Models.Klijenti Authenticiraj(string username, string pass);
    }
}
