﻿using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.WinUI.Narudzbe
{
    public partial class frmNarudzbeDetalji : Form
    {
        private readonly APIService _serviceNarudzbe = new APIService("Narudzbe");
        private readonly APIService _serviceStavke = new APIService("StavkeNarudzbe");
        private readonly APIService _serviceSkladiste = new APIService("Skladista");
        private int _id;
        public frmNarudzbeDetalji(int id)
        {
            
            InitializeComponent();
            _id = id;
            dataGridView1.AutoGenerateColumns = false;
        }

        private async void FrmNarudzbeDetalji_Load(object sender, EventArgs e)
        {
            Model.Models.Narudzbe narudzba =await _serviceNarudzbe.GetById<Model.Models.Narudzbe>(_id);

            txtBrojNarudzbe.Text = narudzba.BrojNarudzbe;
            dtpDatum.Value = narudzba.Datum;
            if (narudzba.Status == true)
            {
                cbStatus.Checked = narudzba.Status;
            }
            if (narudzba.Otkazano == true)
            {
                cbOtkazano.Checked = (bool)narudzba.Otkazano;
            }
            txtIznosbezPdv.Text = narudzba.IznosBezPdv.ToString();
            txtIznossaPdv.Text = narudzba.IznosSaPdv.ToString();

            txtKlijent.Text = narudzba.KlijentKorisnickoIme;

            List<Model.Models.Skladista> skladista_result = await _serviceSkladiste.Get<List<Model.Models.Skladista>>(null);

            skladista_result.Insert(0, new Model.Models.Skladista());
            cmbSkladista.DataSource = skladista_result;
            cmbSkladista.DisplayMember = "Naziv";
            cmbSkladista.ValueMember = "SkladisteId";


            List<Model.Models.StavkeNarudzbe> listastavki = await _serviceStavke.Get<List<Model.Models.StavkeNarudzbe>>(null);

            List<Model.Models.StavkeNarudzbe> result = new List<Model.Models.StavkeNarudzbe>();
            foreach(var item in listastavki)
            {
                Model.Models.StavkeNarudzbe nova = new Model.Models.StavkeNarudzbe();

                if (item.NarudzbaId == narudzba.NarudzbaId)
                {
                    nova.ArtikalId = item.ArtikalId;
                    nova.Cijena = item.Cijena;
                    nova.Kolicina = item.Kolicina;
                    nova.NarudzbaStavkaId = item.NarudzbaStavkaId;
                    nova.Naziv = item.Naziv;
                    nova.Popust = item.Popust;
                    nova.Sifra = item.Sifra;
                    nova.NarudzbaId = item.NarudzbaId;

                    result.Add(nova);
                }
            }

            dataGridView1.DataSource = result;
        }

        private async void BtnZakljuci_Click(object sender, EventArgs e)
        {
            
            Model.Models.Narudzbe narudzba = await _serviceNarudzbe.GetById<Model.Models.Narudzbe>(_id);

            if (narudzba.SkladisteId == 1 || narudzba.KorisnikId == 1)
            {
                var request = new NarudzbeInsertRequest()
                {
                    BrojNarudzbe = narudzba.BrojNarudzbe,
                    Datum = narudzba.Datum,
                    IznosBezPdv = narudzba.IznosBezPdv,
                    IznosSaPdv = narudzba.IznosSaPdv,
                    KlijentId = narudzba.KlijentId,
                    KorisnikId = Global.PrijavljeniKorisnik.KorisnikId,
                    Otkazano = narudzba.Otkazano,
                    SkladisteId = int.Parse(cmbSkladista.SelectedValue.ToString()),
                    Status = narudzba.Status
                };


                _serviceNarudzbe.Update<Model.Models.Narudzbe>(_id, request);

                MessageBox.Show("Uspjesno zakljucena narudzba");
            }
            else
            {
                MessageBox.Show("Narudzba je vec zakljucena");
            }

            
        }

       
    }
}
