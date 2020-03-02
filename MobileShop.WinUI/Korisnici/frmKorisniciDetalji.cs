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

namespace MobileShop.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService _ulogeService = new APIService("Uloge");

        private int? _id = null;
        public frmKorisniciDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private async void FrmKorisniciDetalji_Load_1(object sender, EventArgs e)
        {
            var ulogeList = await _ulogeService.Get<List<Model.Models.Uloge>>(null);

            clbRole.DataSource = ulogeList;
            clbRole.DisplayMember = "Naziv";


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

        //private async void BtnSnimi_MouseClick(object sender, MouseEventArgs e)
        //{
           

        //}

        private void btnSnimi_Click(object sender, EventArgs e)
        {
 if (ValidateChildren())
            {
                var roleList = clbRole.CheckedItems.Cast<Model.Models.Uloge>().Select(x => x.UlogaId).ToList();

                var request = new KorisniciInsertRequest
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda = txtPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text,
                    Uloge = roleList
                };

                
                if (!_id.HasValue)
                {
                    _service.Insert<Model.Models.Korisnici>(request);
                    MessageBox.Show("Uspješno dodan korisnik");
                }
                else
                {
                    _service.Update<Model.Models.Korisnici>(_id.Value, request);
                    MessageBox.Show("Uspješno izmjenjeni podaci o korisniku");
                }

                

               

            }
        }


    }
}