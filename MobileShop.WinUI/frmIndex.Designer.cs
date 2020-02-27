namespace MobileShop.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.zahtjeviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZahtjevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nabavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledDetaljaNabavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaObavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postaviNovuObavijestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNarudzbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zahtjeviToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.nabavkeToolStripMenuItem,
            this.obavijestiToolStripMenuItem,
            this.narudzbeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // zahtjeviToolStripMenuItem
            // 
            this.zahtjeviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledZahtjevaToolStripMenuItem});
            this.zahtjeviToolStripMenuItem.Name = "zahtjeviToolStripMenuItem";
            this.zahtjeviToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.zahtjeviToolStripMenuItem.Text = "Zahtjevi";
            // 
            // pregledZahtjevaToolStripMenuItem
            // 
            this.pregledZahtjevaToolStripMenuItem.Name = "pregledZahtjevaToolStripMenuItem";
            this.pregledZahtjevaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pregledZahtjevaToolStripMenuItem.Text = "Pregled zahtjeva";
            this.pregledZahtjevaToolStripMenuItem.Click += new System.EventHandler(this.PregledZahtjevaToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaKorisnikaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // listaKorisnikaToolStripMenuItem
            // 
            this.listaKorisnikaToolStripMenuItem.Name = "listaKorisnikaToolStripMenuItem";
            this.listaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listaKorisnikaToolStripMenuItem.Text = "Lista korisnika";
            this.listaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.ListaKorisnikaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.NoviKorisnikToolStripMenuItem_Click);
            // 
            // nabavkeToolStripMenuItem
            // 
            this.nabavkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledDetaljaNabavkeToolStripMenuItem});
            this.nabavkeToolStripMenuItem.Name = "nabavkeToolStripMenuItem";
            this.nabavkeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.nabavkeToolStripMenuItem.Text = "Nabavke";
            // 
            // pregledDetaljaNabavkeToolStripMenuItem
            // 
            this.pregledDetaljaNabavkeToolStripMenuItem.Name = "pregledDetaljaNabavkeToolStripMenuItem";
            this.pregledDetaljaNabavkeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pregledDetaljaNabavkeToolStripMenuItem.Text = "Pregled detalja nabavke";
            this.pregledDetaljaNabavkeToolStripMenuItem.Click += new System.EventHandler(this.PregledDetaljaNabavkeToolStripMenuItem_Click);
            // 
            // obavijestiToolStripMenuItem
            // 
            this.obavijestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaObavijestiToolStripMenuItem,
            this.postaviNovuObavijestToolStripMenuItem});
            this.obavijestiToolStripMenuItem.Name = "obavijestiToolStripMenuItem";
            this.obavijestiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.obavijestiToolStripMenuItem.Text = "Obavijesti";
            // 
            // listaObavijestiToolStripMenuItem
            // 
            this.listaObavijestiToolStripMenuItem.Name = "listaObavijestiToolStripMenuItem";
            this.listaObavijestiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listaObavijestiToolStripMenuItem.Text = "Lista Obavijesti";
            this.listaObavijestiToolStripMenuItem.Click += new System.EventHandler(this.ListaObavijestiToolStripMenuItem_Click);
            // 
            // postaviNovuObavijestToolStripMenuItem
            // 
            this.postaviNovuObavijestToolStripMenuItem.Name = "postaviNovuObavijestToolStripMenuItem";
            this.postaviNovuObavijestToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.postaviNovuObavijestToolStripMenuItem.Text = "Postavi novu obavijest";
            this.postaviNovuObavijestToolStripMenuItem.Click += new System.EventHandler(this.PostaviNovuObavijestToolStripMenuItem_Click);
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaNarudzbiToolStripMenuItem});
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            this.narudzbeToolStripMenuItem.Click += new System.EventHandler(this.NarudzbeToolStripMenuItem_Click);
            // 
            // listaNarudzbiToolStripMenuItem
            // 
            this.listaNarudzbiToolStripMenuItem.Name = "listaNarudzbiToolStripMenuItem";
            this.listaNarudzbiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaNarudzbiToolStripMenuItem.Text = "Lista Narudzbi";
            this.listaNarudzbiToolStripMenuItem.Click += new System.EventHandler(this.ListaNarudzbiToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem zahtjeviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZahtjevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nabavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledDetaljaNabavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaObavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postaviNovuObavijestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNarudzbiToolStripMenuItem;
    }
}



