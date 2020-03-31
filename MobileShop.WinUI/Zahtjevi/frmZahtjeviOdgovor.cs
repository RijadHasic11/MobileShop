using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.WinUI.Zahtjevi
{
    public partial class frmZahtjeviOdgovor : Form
    {
        private int _zahtjevId = 0;
        private readonly APIService _serviceZahtjevi = new APIService("zahtjevi");
        private readonly APIService _serviceZahtjeviStavke = new APIService("zahtjevistavke");
        public frmZahtjeviOdgovor(int ZahtjevId)
        {

            InitializeComponent();
            _zahtjevId = ZahtjevId;
        }

        private async void FrmZahtjeviOdgovor_Load(object sender, EventArgs e)
        {
            Model.Models.Zahtjevi zahtjev = await _serviceZahtjevi.GetById<Model.Models.Zahtjevi>(_zahtjevId);

            txtOpis.Text = zahtjev.Opis;


        }

        private void BtnOdgovori_Click(object sender, EventArgs e)
        {

            Model.Requests.ZahtjeviStavkeInsertRequest request = new Model.Requests.ZahtjeviStavkeInsertRequest();

            request.KorisnikId = Global.PrijavljeniKorisnik.KorisnikId;
            request.ZahtjevId = _zahtjevId;
            request.Odgovor = txtOdgovor.Text;

            _serviceZahtjeviStavke.Insert<Model.Models.ZahtjeviStavke>(request);

            MessageBox.Show("Uspjesno ste odgovorili na zahtjev");

            this.Close();
        }
    }
}
