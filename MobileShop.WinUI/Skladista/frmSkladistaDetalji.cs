using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShop.Model.Requests;


namespace MobileShop.WinUI.Skladista
{
    public partial class frmSkladistaDetalji : Form
    {
        APIService _service = new APIService("skladista");
        private int? _id = null;



        public frmSkladistaDetalji(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
              var request = new SkladistaInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    Adresa = txtAdresa.Text,
                    Opis = txtOpis.Text
                };
            _service.Insert<Model.Models.Skladista>(request);
            MessageBox.Show("Uspješno dodano skladište");

        }
    }
  
}
