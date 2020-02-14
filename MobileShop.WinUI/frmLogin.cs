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
        APIService _service = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtPassword.Text;
                try
                {
                    await _service.Get<dynamic>(null);
                    frmIndex frm = new frmIndex();
                    frm.Show();
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


                

            
        }
    }
}
