﻿using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Models.Korisnici> Get(KorisniciSearchRequest search);

        Model.Models.Korisnici GetById(int id);

        void Insert(KorisniciInsertRequest request);

        void Update(int id, KorisniciInsertRequest request);

        Model.Models.Korisnici Authenticiraj(string username, string pass);
    }
}
