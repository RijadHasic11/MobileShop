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
    public partial class frmKorisnici : Form
    {
        APIService _service = new APIService("korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text,

                
            };

           var result= await _service.Get<List<Model.Models.Korisnici>>(search);
           dgvKorisnici.DataSource = result;

        }
        private void DgvKorisnici_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var korisnikId = int.Parse(dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString());

            frmKorisniciDetalji frm = new frmKorisniciDetalji(korisnikId);
            frm.Show();
        }
    }
}
