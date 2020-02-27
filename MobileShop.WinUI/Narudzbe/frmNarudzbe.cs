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

namespace MobileShop.WinUI.Narudzbe
{
    public partial class frmNarudzbe : Form
    {
        private readonly APIService _service = new APIService("Narudzbe");
        public frmNarudzbe()
        {
            InitializeComponent();
        }

        private void FrmNarudzbe_Load(object sender, EventArgs e)
        {
            dgvNarudzbe.AutoGenerateColumns = false;
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            
            var search = new NarudzbeSearchRequest()
            {
                 BrojNarudzbe = txtPretraga.Text

            };
            

            var result =await _service.Get<List<Model.Models.Narudzbe>>(search);

            dgvNarudzbe.DataSource = result;
        }

        private void DgvNarudzbe_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var NarudzbaId = int.Parse(dgvNarudzbe.SelectedRows[0].Cells[0].Value.ToString());

            frmNarudzbeDetalji forma = new frmNarudzbeDetalji(NarudzbaId);
            forma.Show();
        }
    }
}
