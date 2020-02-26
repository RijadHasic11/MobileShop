﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IArtikliService
    {
        List<Model.Models.Artikli> Get();

        Model.Models.Artikli GetById(int id);

        Model.Models.Artikli GetBySifra(string sifra);
       
    }
}