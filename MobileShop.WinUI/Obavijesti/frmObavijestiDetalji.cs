using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MobileShop.WinUI.Obavijesti
{
    public partial class frmObavijestiDetalji : Form
    {
        private readonly APIService _service = new APIService("Obavijesti");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private int _id;
        public frmObavijestiDetalji(int id)
        {

            InitializeComponent();
            _id = id;
        }
        
        private async void FrmObavijestiDetalji_Load(object sender, EventArgs e)
        {

            Model.Models.Obavijesti Obavijest = await _service.GetById<Model.Models.Obavijesti>(_id);

            Model.Models.Korisnici korisnik = await _serviceKorisnici.GetById<Model.Models.Korisnici>(Obavijest.KorisnikId);

            txtNaslov.Text = Obavijest.Naslov;
            rtxtText.Text = Obavijest.Text;
            txtKorisnik.Text = korisnik.KorisnickoIme;


            if (Obavijest.Slika != null)
            {
                Image originalImage = Helper.ByteToImage.byteArrayToImage(Obavijest.Slika);

                int resizedWidth = int.Parse(ConfigurationManager.AppSettings["resizedWidthObavijestiDetalji"]);
                int resizedHeight = int.Parse(ConfigurationManager.AppSettings["resizedHeightObavijestiDetalji"]);

                if (originalImage.Width > resizedWidth)
                {
                    Image resizedImage = Helper.SlikaHelper.ResizeImage(originalImage, new Size(resizedWidth, resizedHeight));

                    pbSlika.Image = resizedImage;
                }

            }


        }
    }
}
