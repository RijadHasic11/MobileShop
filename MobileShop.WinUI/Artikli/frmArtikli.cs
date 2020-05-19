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

namespace MobileShop.WinUI.Artikli
{
    public partial class frmArtikli : Form
    {
        private readonly APIService _modeli = new APIService("Modeli");
        private readonly APIService _karakteristike = new APIService("Karakteristike");
        private readonly APIService _proizvodjaci = new APIService("Proizvodjaci");
        private readonly APIService _artikli = new APIService("Artikli");
        public frmArtikli()
        {
            InitializeComponent();
        }

        private async void frmArtikli_Load(object sender, EventArgs e)
        {
            dgvArtikli.AutoGenerateColumns = false;


            var result = await _artikli.Get<List<Model.Models.Artikli>>(null);
            dgvArtikli.DataSource = result;
            
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var search = new ArtikliSearchRequest()
            {
                Naziv = txtPretraga.Text


            };

            var result = await _artikli.Get<List<Model.Models.Artikli>>(search);
            dgvArtikli.DataSource = result;

        }
        private void DgvArtikli_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //var korisnikId = int.Parse(dgvKorisnici.SelectedRows[e.RowIndex].Cells[1].Value.ToString());
            var artikalId = dgvArtikli.Rows[e.RowIndex].Cells[0].Value;

            frmArtikliDetalji frm = new frmArtikliDetalji(int.Parse(artikalId.ToString()));
            frm.Show();
        }
    }
}
