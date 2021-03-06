﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtikliController : ControllerBase
    {
        private readonly IArtikliService _service;
        public ArtikliController(IArtikliService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Artikli> Get([FromQuery]ArtikliSearchRequest search)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public Model.Models.Artikli GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet]
        [Route("GetBySifra/{sifra}")]
        public Model.Models.Artikli GetBySifra(string sifra)
        {
            return _service.GetBySifra(sifra);
        }
        [HttpPost]
        public void Insert(ArtikliInsertRequest request)
        {
            _service.Insert(request);
        }
        [HttpPut("{id}")]
        public void Update(int id, [FromBody]ArtikliInsertRequest request)
        {
            _service.Update(id, request);
        }
    }
}