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
    public partial class frmKlijenti : Form
    {
        
            APIService _service = new APIService("klijenti");
            public frmKlijenti()
            {
                InitializeComponent();
            }




        private async void btnPretraga_Click_1(object sender, EventArgs e)
        {
                var search = new KlijentiSearchRequest()
                {
                    Ime = txtPretraga.Text,


                };

                var result = await _service.Get<List<Model.Models.Klijenti>>(search);
                dgvKlijenti.DataSource = result;
        }

        private void DgvKlijenti_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)

        {

            var korisnikId = dgvKlijenti.Rows[e.RowIndex].Cells[0].Value;

            frmKlijentiDetalji frm = new frmKlijentiDetalji(int.Parse(korisnikId.ToString()));
                frm.Show();
        }
    }
    }
