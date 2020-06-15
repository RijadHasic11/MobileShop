using MobileShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Mobile.Helper
{
    public class Recommender
    {
        APIService _service = new APIService("Artikli");
        APIService _serviceOcjene = new APIService("Ocjene");
        Dictionary<int, List<Ocjene>> proizvodi = new Dictionary<int, List<Ocjene>>();
        List<Ocjene> listaizbaze = new List<Ocjene>();
        List<Model.Models.Artikli> aktivniProizvodi = new List<Artikli>();
        Model.Models.Artikli Artikal = new Artikli();
        public async void GetOcjene()
        {
            listaizbaze = await _serviceOcjene.Get<List<Model.Models.Ocjene>>(null);

        }
        public async void GetArtikal(int artikalId)
        {
            Artikal = await _service.GetById<Model.Models.Artikli>(artikalId);
        }
        public List<Model.Models.Artikli> GetSlicneProizvode(int artikalID)
        {
            UcitajProizvode(artikalID);

            GetOcjene();

            List<Ocjene> ocjenePosmatranogProizvoda = new List<Ocjene>();
            foreach(var item in listaizbaze)
            {
                if (item.ArtikalId == artikalID)
                {
                    ocjenePosmatranogProizvoda.Add(item);
                }
            }

            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();
            List<Model.Models.Artikli> preporuceniProizvodi = new List<Model.Models.Artikli>();

            foreach (var item in proizvodi)
            {
                foreach (Ocjene o in ocjenePosmatranogProizvoda)
                {
                    if (item.Value.Where(x => x.KlijentId== o.KlijentId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KlijentId == o.KlijentId).First());
                    }
                }
                double slicnosti = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                GetArtikal(item.Key);
                if (slicnosti > 0.98)
                    preporuceniProizvodi.Add(Artikal);
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniProizvodi;
        }

        private double GetSlicnost(List<Ocjene> zajednickeOcjene1, List<Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik += zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 += zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 += zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;

            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        public async void UcitajProizvode(int artikalId)
        {
            aktivniProizvodi = await _service.Get<List<Model.Models.Artikli>>(null);
           
            List<Model.Models.Artikli> novalista = new List<Artikli>();

            foreach (var item in aktivniProizvodi)
            {
                if (item.ArtikalId != artikalId)
                {
                    novalista.Add(item);
                }
            }


            List<Ocjene> ocjene = new List<Ocjene>();
            foreach (Artikli a in novalista)
            {
                List<Ocjene> novalistaocjena = await _serviceOcjene.Get<List<Ocjene>>(null);

                foreach(var item in novalistaocjena)
                {
                    if (item.ArtikalId == a.ArtikalId)
                    {
                        ocjene.Add(item);
                    }
                }
                if (ocjene.Count > 0)
                    proizvodi.Add(a.ArtikalId, ocjene);
            }
        }

       
    }
}
