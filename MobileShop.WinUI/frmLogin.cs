using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _serviceuloge = new APIService("Uloge");
        Model.Models.Uloge admin = null;
        Model.Models.Uloge prodavac = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            
               
            Model.Models.Korisnici korisnik= await _service.Authenticiraj<Model.Models.Korisnici>(txtKorisnickoIme.Text, txtPassword.Text);
            int ulogaId1 = 0;
            int ulogaId2 = 0;
           
            
            if (korisnik != null)
            {
                Global.PrijavljeniKorisnik = korisnik;

                foreach (var item in Global.PrijavljeniKorisnik.KorisniciUloge)
                {
                    ulogaId1 = item.UlogaId;
                    ulogaId2 = item.UlogaId;
                                 
                }
                admin = await _serviceuloge.ProvjeriAdmin<Model.Models.Uloge>(ulogaId1);
                prodavac = await _serviceuloge.ProvjeriProdavac<Model.Models.Uloge>(ulogaId2);

                if (admin != null)
                {
                    Global.Admin = true;
                }
                else
                {
                    Global.Admin = false;
                }
                if (prodavac != null)
                {
                    Global.Prodavac = true;
                }
                else
                {
                    Global.Prodavac = false;
                }


                MessageBox.Show("Dobrodosli "+ korisnik.Ime + " " + korisnik.Prezime );
                DialogResult = DialogResult.OK;
                Close();
            }
                   
            else   
            {
                MessageBox.Show("Pogresan username ili password", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


                

            
        }
    }
}
