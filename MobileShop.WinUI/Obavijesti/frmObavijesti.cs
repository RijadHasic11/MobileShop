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

namespace MobileShop.WinUI.Obavijesti
{
    public partial class frmObavijesti : Form
    {
        private readonly APIService _service = new APIService("Obavijesti");
        public frmObavijesti()
        {
            InitializeComponent();
            dgvObavijesti.AutoGenerateColumns = false;
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {

            ObavijestiSearchRequest search = new ObavijestiSearchRequest
            {
                Naslov = txtPretraga.Text
            };

            var list = await _service.Get<List<Model.Models.Obavijesti>>(search);

            dgvObavijesti.DataSource = list;


        }

        private void DgvObavijesti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ObavijestId = int.Parse(dgvObavijesti.SelectedRows[0].Cells[0].Value.ToString());

            frmObavijestiDetalji forma = new frmObavijestiDetalji(ObavijestId);
            forma.Show();

        }
    }
}
