using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.WinUI.Nabavke
{
    public partial class frmNabavke : Form
    {
        APIService _service = new APIService("Nabavke");
        public frmNabavke()
        {
       
            InitializeComponent();

            
        }

        private void Label5_Click(object sender, EventArgs e)
        {


        }

        private async void BtnLoad_Click(object sender, EventArgs e)
        {
            var list = await _service.Get<List<Model.Models.Nabavke>>(null);

            foreach(var item in list)
            {

            }

        }
    }
}
