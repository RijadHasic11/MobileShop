using MobileShop.WinUI.Izvjestaji;
using MobileShop.WinUI.Nabavke;
using MobileShop.WinUI.Narudzbe;
using MobileShop.WinUI.Obavijesti;
using MobileShop.WinUI.Zahtjevi;
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
    public partial class frmIndexProdavac : Form
    {
        public frmIndexProdavac()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            ZahtjeviSubMenuPanel.Visible = false;
            NabavkeSubMenuPanel.Visible = false;
            ObavijestiSubMenuPanel.Visible = false;
            NarudzbeSubMenuPanel.Visible = false;
            IzvjestajiSubMenuPanel.Visible = false;
           
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnZahtjevi_Click(object sender,EventArgs e)
        {
            showSubMenu(ZahtjeviSubMenuPanel);
        }
        #region ZahtjeviSubMenu
        private void BtnPregledZahtjeva_Click(object sender, EventArgs e)
        {
            openChildForm(new frmZahtjevi());
            
            hideSubMenu();
        }

        #endregion

        private void BtnNabavke_Click(object sender, EventArgs e)
        {
            showSubMenu(NabavkeSubMenuPanel);
        }

        #region NabavkeSubMenu
        private void BtnDetaljiNabavke_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNabavke());

            hideSubMenu();
        }
        private void BtnNovaNabavka_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNovaNabavka());

            hideSubMenu();
        }

        #endregion

        private void BtnObavijesti_Click(object sender, EventArgs e)
        {
            showSubMenu(ObavijestiSubMenuPanel);
        }
        #region ObavijestiSubMenu
        private void BtnListaObavijesti_Click(object sender, EventArgs e)
        {
            openChildForm(new frmObavijesti());

            hideSubMenu();
        }

        private void BtnNovaObavijest_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNovaObavijest());

            hideSubMenu();
        }
        #endregion
        private void BtnNarudzbe_Click(object sender, EventArgs e)
        {
            showSubMenu(NarudzbeSubMenuPanel);
        }
        #region NarudzbeSubMenu
        private void BtnListaNarudzbi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNarudzbe());

            hideSubMenu();
        }
        #endregion
        private void BtnIzvjestaji_Click(object sender, EventArgs e)
        {
            showSubMenu(IzvjestajiSubMenuPanel);
        }
        #region IzvjestajiSubMenu
        private void BtnPregledIzvjestaja_Click(object sender, EventArgs e)
        {
            openChildForm(new frmIzvjestajiIndex());

            hideSubMenu();
        }
        #endregion
        //private void BtnExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}


        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
