using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.WinUI.Izvjestaji
{
    public partial class frmIzvjestajiIndex : Form
    {
        private readonly APIService _serviceArtikli = new APIService("Artikli");
        private readonly APIService _serviceNarudzbeStavke = new APIService("StavkeNarudzbe");
        private readonly APIService _serviceObavijesti = new APIService("Obavijesti");
        private readonly APIService _serviceNarudzbe = new APIService("Narudzbe");
        public frmIzvjestajiIndex()
        {
            InitializeComponent();
        }

        private async void BtnArtikli_Click(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = false;
            dtpDatumOd.Enabled = false;
            txtPretraga.Enabled = false;
            btnPretraga.Enabled = false;

            List<Model.Models.ProdaniArtikli> prodani = new List<Model.Models.ProdaniArtikli>();

            List<Model.Models.Artikli> listaArtikala = await _serviceArtikli.Get<List<Model.Models.Artikli>>(null);

            List<Model.Models.StavkeNarudzbe> listaNarudzbi = await _serviceNarudzbeStavke.Get<List<Model.Models.StavkeNarudzbe>>(null);

            foreach (var item1 in listaNarudzbi)
            { 

                foreach(var item2 in listaArtikala)
                {
                    if (item1.ArtikalId == item2.ArtikalId)
                    {
                        prodani.Add(new Model.Models.ProdaniArtikli
                        {
                            
                            Cijena = item1.Cijena,
                            Kolicina = item1.Kolicina,
                            Naziv = item2.Naziv,
                            Sifra = item2.Sifra,
                            Ukupno = item1.Kolicina * item1.Cijena
                        });
                    }
                   
                }
            }

            dataGridView1.DataSource = prodani;


           
        }

        private void BtnObavijesti_Click(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = false;
            dtpDatumOd.Enabled = false;

            txtPretraga.Enabled = true;
            btnPretraga.Enabled = true;
         

        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            if(dtpDatumDo.Enabled==false && dtpDatumOd.Enabled==false && txtPretraga.Enabled == true)
            {
                var search = new ObavijestiSearchRequest()
                {
                    Naslov = txtPretraga.Text
                };

                var listaObavijesti = await _serviceObavijesti.Get<List<Model.Models.Obavijesti>>(search);

                List<Model.Models.ObavijestiIzvjestaj> result = new List<Model.Models.ObavijestiIzvjestaj>();
                foreach(var item in listaObavijesti)
                {
                    result.Add(new Model.Models.ObavijestiIzvjestaj
                    {
                        Naslov = item.Naslov,
                        Tekst = item.Text
                    });

                }
                

                dataGridView1.DataSource = result;
                dataGridView1.Columns[1].Width = 400;
                
            }
            if(dtpDatumDo.Enabled == true && dtpDatumOd.Enabled == true && txtPretraga.Enabled == true)
            {
                var search = new NarudzbeSearchRequest()
                {
                    BrojNarudzbe = txtPretraga.Text
                };

                var listaNarudzbi = await _serviceNarudzbe.Get<List<Model.Models.Narudzbe>>(search);
                List<Model.Models.NarudzbeIzvjestaj> result = new List<Model.Models.NarudzbeIzvjestaj>();

                foreach(var item in listaNarudzbi)
                {
                    if(dtpDatumOd.Value<item.Datum && item.Datum < dtpDatumDo.Value)
                    {
                        result.Add(new Model.Models.NarudzbeIzvjestaj
                        {
                            BrojNarudzbe = item.BrojNarudzbe,
                            Datum = item.Datum,
                            IznosBezPdv = item.IznosBezPdv,
                            IznosSaPdv = item.IznosSaPdv
                        });
                    }
                }
                dataGridView1.DataSource = result;
            }
        }

        private void BtnNarudzbe_Click(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = true;
            dtpDatumOd.Enabled = true;

            txtPretraga.Enabled = true;
            btnPretraga.Enabled = true;


        }
    }
}
