using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobileShop.Model;
using MobileShop.Model.Models;

namespace MobileShop.WebAPI.Services
{
    public class NabavkeService : INabavkeService
    {
        private readonly MyContext _context;
        public NabavkeService(MyContext context)
        {
            _context = context;
        }
        public List<Nabavke> Get()
        {
            var list = _context.Nabavka
                .Include(x => x.Dobavljac).Include(y => y.Skladiste)
                .ToList();

            var listanabavki = new List<Nabavke>();

            foreach (var item in list)
            {


                Nabavke nabavka = new Nabavke();

                nabavka.BrojNabavke = item.BrojNabavke;
                nabavka.Datum = item.Datum;
                nabavka.DobavljacId = item.DobavljacId;
                nabavka.IznosRacuna = item.IznosRacuna;
                nabavka.KontaktOsoba = item.Dobavljac.KontaktOsoba;
                nabavka.NabavkaId = item.NabavkaId;
                nabavka.Napomena = item.Napomena;
                nabavka.NazivDobavljaca = item.Dobavljac.Naziv;
                nabavka.NazivSkladista = item.Skladiste.Naziv;
                nabavka.Pdv = item.Pdv;
                nabavka.SkladisteId = item.SkladisteId;
                nabavka.Telefon = item.Dobavljac.Telefon;

                listanabavki.Add(nabavka);

            }

            return listanabavki;

        }

        public Nabavke GetById(int id)
        {
            Model.Database.Nabavka item = _context.Nabavka.Where(x => x.NabavkaId == id)
                .Include(y => y.Skladiste).Include(z => z.Dobavljac)
                .SingleOrDefault();


            Nabavke nabavka = new Nabavke();

            nabavka.BrojNabavke = item.BrojNabavke;
            nabavka.Datum = item.Datum;
            nabavka.DobavljacId = item.DobavljacId;
            nabavka.IznosRacuna = item.IznosRacuna;
            nabavka.KontaktOsoba = item.Dobavljac.KontaktOsoba;
            nabavka.NabavkaId = item.NabavkaId;
            nabavka.Napomena = item.Napomena;
            nabavka.NazivDobavljaca = item.Dobavljac.Naziv;
            nabavka.NazivSkladista = item.Skladiste.Naziv;
            nabavka.Pdv = item.Pdv;
            nabavka.SkladisteId = item.SkladisteId;
            nabavka.Telefon = item.Dobavljac.Telefon;

            return nabavka;
        }
    }
}
