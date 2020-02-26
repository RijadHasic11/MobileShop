﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobileShop.Model;
using MobileShop.Model.Models;
using MobileShop.Model.Requests;

namespace MobileShop.WebAPI.Services
{
    public class NarudzbeService : INarudzbeService
    {
        private readonly MyContext _context;

        public NarudzbeService(MyContext context)
        {
            _context = context;
        }
        public List<Narudzbe> Get(NarudzbeSearchRequest search)
        {

            var query = _context.Narudzba
                .Include(y => y.Klijent).Include(z => z.Korisnik).Include(p => p.Skladiste)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.BrojNarudzbe))
            {
                query = query.Where(x => x.BrojNarudzbe.StartsWith(search.BrojNarudzbe));
                  
                    
            }

            var lista = query.ToList();

            List<Narudzbe> result = new List<Narudzbe>();

            foreach(var item in lista)
            {

                    Narudzbe nova = new Narudzbe();

                    nova.BrojNarudzbe = item.BrojNarudzbe;
                    nova.Datum = item.Datum;
                    nova.IznosBezPdv = item.IznosBezPdv;
                    nova.IznosSaPdv = item.IznosSaPdv;
                    nova.KlijentId = item.KlijentId;
                    nova.KlijentKorisnickoIme = item.Klijent.KorisnickoIme;
                    nova.KorisnikId = item.Korisnik.KorisnikId;
                    nova.KorisnikKorisnickoIme = item.Korisnik.KorisnickoIme;
                    nova.NarudzbaId = item.NarudzbaId;
                    nova.NazivSkladista = item.Skladiste.Naziv;
                    nova.Otkazano = item.Otkazano;
                    nova.SkladisteId = item.SkladisteId;
                    nova.Status = item.Status;

                
                    result.Add(nova);
                

            }

            return result;
        }

        public Narudzbe GetById(int id)
        {
            var item = _context.Narudzba.Where(z => z.NarudzbaId == id)
                .Include(x => x.Klijent).Include(y => y.Korisnik).Include(p => p.Skladiste)
                .SingleOrDefault();

            Narudzbe nova = new Narudzbe();

            nova.BrojNarudzbe = item.BrojNarudzbe;
            nova.Datum = item.Datum;
            nova.IznosBezPdv = item.IznosBezPdv;
            nova.IznosSaPdv = item.IznosSaPdv;
            nova.KlijentId = item.KlijentId;
            nova.KlijentKorisnickoIme = item.Klijent.KorisnickoIme;
            nova.KorisnikId = item.Korisnik.KorisnikId;
            nova.KorisnikKorisnickoIme = item.Korisnik.KorisnickoIme;
            nova.NarudzbaId = item.NarudzbaId;
            nova.NazivSkladista = item.Skladiste.Naziv;
            nova.Otkazano = item.Otkazano;
            nova.SkladisteId = item.SkladisteId;
            nova.Status = item.Status;

            return nova;
        }
    }
}