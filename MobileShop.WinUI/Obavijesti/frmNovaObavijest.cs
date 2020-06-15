using MobileShop.Model.Requests;
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
    public partial class frmNovaObavijest : Form
    {
        private readonly APIService _service = new APIService("Obavijesti");
      

        ObavijestInsertRequest request = new ObavijestInsertRequest();
        public frmNovaObavijest()
        {
            InitializeComponent();
        }

        private void BtnSlikaDodaj_Click(object sender, EventArgs e)
        {

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlikaInput.Text = fileName;

                Image originalimage = Image.FromFile(fileName);
               


                int resizedWidth = int.Parse(ConfigurationManager.AppSettings["resizedWidthObavijesti"]);
                int resizedHeight = int.Parse(ConfigurationManager.AppSettings["resizedHeightObavijesti"]);

                if (originalimage.Width > resizedWidth)
                {
                    Image resizedImage = Helper.SlikaHelper.ResizeImage(originalimage, new Size(resizedWidth, resizedHeight));

                    pbSlika.Image = resizedImage;
                }
            }
            


        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (request.Slika != null)
                {
                    request.KorisnikId = Global.PrijavljeniKorisnik.KorisnikId;
                    request.Naslov = txtNaslov.Text;
                    request.Text = rtxtTekst.Text;


                    _service.Insert<Model.Models.Obavijesti>(request);
                    MessageBox.Show("Uspjesno objavljena nova obavijest!");

                }
                else
                {
                    MessageBox.Show("Potrebno unijeti sliku!");
                }
            }
        }

        private void TxtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                errorProvider.SetError(txtNaslov, "Obavezno polje");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtNaslov, null);
            }
        }

        private void RtxtTekst_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtTekst.Text) || rtxtTekst.Text.Length < 20)
            {
                errorProvider.SetError(rtxtTekst, "Minimalno 20 karaktera");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(rtxtTekst, null);
            }
        }
    }

}
