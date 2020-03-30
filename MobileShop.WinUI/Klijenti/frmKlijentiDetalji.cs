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

namespace MobileShop.WinUI.Klijenti
{
    public partial class frmKlijentiDetalji : Form
    {
        APIService _service = new APIService("Klijenti");

        private int? _id = null;

        public frmKlijentiDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

       

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }


        private async void FrmKlijentDetalji_Load_1(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var entity = await _service.GetById<Model.Models.Korisnici>(_id);
                txtEmail.Text = entity.Email;
                txtIme.Text = entity.Ime;
                txtKorisnickoIme.Text = entity.KorisnickoIme;
                txtPrezime.Text = entity.Prezime;
                txtTelefon.Text = entity.Telefon;
            }
        }


        private void btnSnimi_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                
                var request = new KlijentiInsertRequest
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda = txtPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text
                };


                if (!_id.HasValue)
                {
                    _service.Insert<Model.Models.Klijenti>(request);
                    MessageBox.Show("Uspješno dodan klijent");
                }
                else
                {
                    _service.Update<Model.Models.Klijenti>(_id.Value, request);
                    MessageBox.Show("Uspješno izmjenjeni podaci o klijentu");
                }





            }
        }


    }
}
