using MobileShop.Model.Models;
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

namespace MobileShop.WinUI.Nabavke
{
    public partial class frmNovaNabavka : Form
    {
        private readonly APIService _serviceDobavljaci = new APIService("Dobavljaci");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        public frmNovaNabavka()
        {
            InitializeComponent();
        }

        private void TxtBrojNabavke_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private async void FrmNovaNabavka_Load(object sender, EventArgs e)
        {
            List<Dobavljaci> dobavljaci_result = await _serviceDobavljaci.Get<List<Dobavljaci>>(null);

            cmbDobavljaci.DataSource = dobavljaci_result;
            cmbDobavljaci.DisplayMember = "Naziv";
            cmbDobavljaci.ValueMember = "DobavljacId";

            List<Model.Models.Korisnici> korisnici_result = await _serviceKorisnici.Get<List<Model.Models.Korisnici>>(null);

            cmbKorisnici.DataSource = korisnici_result;
            cmbKorisnici.DisplayMember = "KorisnickoIme";
            cmbKorisnici.ValueMember = "KorisnikId";


            NabavkeInsertRequest request = new NabavkeInsertRequest();

            request.BrojNabavke = txtBrojNabavke.Text;
            request.Datum = dtpDatum.Value;
            request.DobavljacId = int.Parse(cmbDobavljaci.SelectedValue.ToString());
            request.KorisnikId = int.Parse(cmbKorisnici.SelectedValue.ToString());
            request.Napomena = txtNapomena.Text;
           
        }
    }
}
