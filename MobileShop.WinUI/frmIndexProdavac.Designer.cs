namespace MobileShop.WinUI
{
    partial class frmIndexProdavac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndexProdavac));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.IzvjestajiSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnPregledIzvjestaja = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.NarudzbeSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnListaNarudzbi = new System.Windows.Forms.Button();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.ObavijestiSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnNovaObavijest = new System.Windows.Forms.Button();
            this.btnListaObavijesti = new System.Windows.Forms.Button();
            this.btnObavijesti = new System.Windows.Forms.Button();
            this.NabavkeSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnNovaNabavka = new System.Windows.Forms.Button();
            this.btnDetaljiNabavke = new System.Windows.Forms.Button();
            this.btnNabavke = new System.Windows.Forms.Button();
            this.ZahtjeviSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnPregledZahtjeva = new System.Windows.Forms.Button();
            this.btnZahtjevi = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SideMenuPanel.SuspendLayout();
            this.IzvjestajiSubMenuPanel.SuspendLayout();
            this.NarudzbeSubMenuPanel.SuspendLayout();
            this.ObavijestiSubMenuPanel.SuspendLayout();
            this.NabavkeSubMenuPanel.SuspendLayout();
            this.ZahtjeviSubMenuPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.Black;
            this.SideMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SideMenuPanel.Controls.Add(this.btnExit);
            this.SideMenuPanel.Controls.Add(this.IzvjestajiSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnIzvjestaji);
            this.SideMenuPanel.Controls.Add(this.NarudzbeSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnNarudzbe);
            this.SideMenuPanel.Controls.Add(this.ObavijestiSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnObavijesti);
            this.SideMenuPanel.Controls.Add(this.NabavkeSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnNabavke);
            this.SideMenuPanel.Controls.Add(this.ZahtjeviSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnZahtjevi);
            this.SideMenuPanel.Controls.Add(this.panelLogo);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(250, 600);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnExit.Location = new System.Drawing.Point(0, 608);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(229, 45);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // IzvjestajiSubMenuPanel
            // 
            this.IzvjestajiSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IzvjestajiSubMenuPanel.Controls.Add(this.btnPregledIzvjestaja);
            this.IzvjestajiSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IzvjestajiSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.IzvjestajiSubMenuPanel.Location = new System.Drawing.Point(0, 568);
            this.IzvjestajiSubMenuPanel.Name = "IzvjestajiSubMenuPanel";
            this.IzvjestajiSubMenuPanel.Size = new System.Drawing.Size(229, 40);
            this.IzvjestajiSubMenuPanel.TabIndex = 11;
            // 
            // btnPregledIzvjestaja
            // 
            this.btnPregledIzvjestaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPregledIzvjestaja.FlatAppearance.BorderSize = 0;
            this.btnPregledIzvjestaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledIzvjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledIzvjestaja.ForeColor = System.Drawing.Color.LightGray;
            this.btnPregledIzvjestaja.Location = new System.Drawing.Point(0, 0);
            this.btnPregledIzvjestaja.Name = "btnPregledIzvjestaja";
            this.btnPregledIzvjestaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPregledIzvjestaja.Size = new System.Drawing.Size(229, 40);
            this.btnPregledIzvjestaja.TabIndex = 0;
            this.btnPregledIzvjestaja.Text = "Pregled izvjestaja";
            this.btnPregledIzvjestaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregledIzvjestaja.UseVisualStyleBackColor = true;
            this.btnPregledIzvjestaja.Click += new System.EventHandler(this.BtnPregledIzvjestaja_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIzvjestaji.FlatAppearance.BorderSize = 0;
            this.btnIzvjestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestaji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnIzvjestaji.Location = new System.Drawing.Point(0, 523);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIzvjestaji.Size = new System.Drawing.Size(229, 45);
            this.btnIzvjestaji.TabIndex = 10;
            this.btnIzvjestaji.Text = "Izvjestaji";
            this.btnIzvjestaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.BtnIzvjestaji_Click);
            // 
            // NarudzbeSubMenuPanel
            // 
            this.NarudzbeSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NarudzbeSubMenuPanel.Controls.Add(this.btnListaNarudzbi);
            this.NarudzbeSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NarudzbeSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.NarudzbeSubMenuPanel.Location = new System.Drawing.Point(0, 481);
            this.NarudzbeSubMenuPanel.Name = "NarudzbeSubMenuPanel";
            this.NarudzbeSubMenuPanel.Size = new System.Drawing.Size(229, 42);
            this.NarudzbeSubMenuPanel.TabIndex = 9;
            // 
            // btnListaNarudzbi
            // 
            this.btnListaNarudzbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaNarudzbi.FlatAppearance.BorderSize = 0;
            this.btnListaNarudzbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaNarudzbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnListaNarudzbi.ForeColor = System.Drawing.Color.LightGray;
            this.btnListaNarudzbi.Location = new System.Drawing.Point(0, 0);
            this.btnListaNarudzbi.Name = "btnListaNarudzbi";
            this.btnListaNarudzbi.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListaNarudzbi.Size = new System.Drawing.Size(229, 42);
            this.btnListaNarudzbi.TabIndex = 0;
            this.btnListaNarudzbi.Text = "Lista narudzbi";
            this.btnListaNarudzbi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaNarudzbi.UseVisualStyleBackColor = true;
            this.btnListaNarudzbi.Click += new System.EventHandler(this.BtnListaNarudzbi_Click);
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNarudzbe.FlatAppearance.BorderSize = 0;
            this.btnNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnNarudzbe.Location = new System.Drawing.Point(0, 436);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNarudzbe.Size = new System.Drawing.Size(229, 45);
            this.btnNarudzbe.TabIndex = 8;
            this.btnNarudzbe.Text = "Narudzbe";
            this.btnNarudzbe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNarudzbe.UseVisualStyleBackColor = true;
            this.btnNarudzbe.Click += new System.EventHandler(this.BtnNarudzbe_Click);
            // 
            // ObavijestiSubMenuPanel
            // 
            this.ObavijestiSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ObavijestiSubMenuPanel.Controls.Add(this.btnNovaObavijest);
            this.ObavijestiSubMenuPanel.Controls.Add(this.btnListaObavijesti);
            this.ObavijestiSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObavijestiSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.ObavijestiSubMenuPanel.Location = new System.Drawing.Point(0, 355);
            this.ObavijestiSubMenuPanel.Name = "ObavijestiSubMenuPanel";
            this.ObavijestiSubMenuPanel.Size = new System.Drawing.Size(229, 81);
            this.ObavijestiSubMenuPanel.TabIndex = 6;
            // 
            // btnNovaObavijest
            // 
            this.btnNovaObavijest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovaObavijest.FlatAppearance.BorderSize = 0;
            this.btnNovaObavijest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaObavijest.ForeColor = System.Drawing.Color.LightGray;
            this.btnNovaObavijest.Location = new System.Drawing.Point(0, 40);
            this.btnNovaObavijest.Name = "btnNovaObavijest";
            this.btnNovaObavijest.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNovaObavijest.Size = new System.Drawing.Size(229, 41);
            this.btnNovaObavijest.TabIndex = 1;
            this.btnNovaObavijest.Text = "Nova obavijest";
            this.btnNovaObavijest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaObavijest.UseVisualStyleBackColor = true;
            this.btnNovaObavijest.Click += new System.EventHandler(this.BtnNovaObavijest_Click);
            // 
            // btnListaObavijesti
            // 
            this.btnListaObavijesti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaObavijesti.FlatAppearance.BorderSize = 0;
            this.btnListaObavijesti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaObavijesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnListaObavijesti.ForeColor = System.Drawing.Color.LightGray;
            this.btnListaObavijesti.Location = new System.Drawing.Point(0, 0);
            this.btnListaObavijesti.Name = "btnListaObavijesti";
            this.btnListaObavijesti.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListaObavijesti.Size = new System.Drawing.Size(229, 40);
            this.btnListaObavijesti.TabIndex = 0;
            this.btnListaObavijesti.Text = "Lista obavijesti";
            this.btnListaObavijesti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaObavijesti.UseVisualStyleBackColor = true;
            this.btnListaObavijesti.Click += new System.EventHandler(this.BtnListaObavijesti_Click);
            // 
            // btnObavijesti
            // 
            this.btnObavijesti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObavijesti.FlatAppearance.BorderSize = 0;
            this.btnObavijesti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObavijesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObavijesti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnObavijesti.Location = new System.Drawing.Point(0, 310);
            this.btnObavijesti.Name = "btnObavijesti";
            this.btnObavijesti.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnObavijesti.Size = new System.Drawing.Size(229, 45);
            this.btnObavijesti.TabIndex = 5;
            this.btnObavijesti.Text = "Obavijesti";
            this.btnObavijesti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObavijesti.UseVisualStyleBackColor = true;
            this.btnObavijesti.Click += new System.EventHandler(this.BtnObavijesti_Click);
            // 
            // NabavkeSubMenuPanel
            // 
            this.NabavkeSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NabavkeSubMenuPanel.Controls.Add(this.btnNovaNabavka);
            this.NabavkeSubMenuPanel.Controls.Add(this.btnDetaljiNabavke);
            this.NabavkeSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NabavkeSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.NabavkeSubMenuPanel.Location = new System.Drawing.Point(0, 229);
            this.NabavkeSubMenuPanel.Name = "NabavkeSubMenuPanel";
            this.NabavkeSubMenuPanel.Size = new System.Drawing.Size(229, 81);
            this.NabavkeSubMenuPanel.TabIndex = 4;
            // 
            // btnNovaNabavka
            // 
            this.btnNovaNabavka.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovaNabavka.FlatAppearance.BorderSize = 0;
            this.btnNovaNabavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaNabavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaNabavka.ForeColor = System.Drawing.Color.LightGray;
            this.btnNovaNabavka.Location = new System.Drawing.Point(0, 40);
            this.btnNovaNabavka.Name = "btnNovaNabavka";
            this.btnNovaNabavka.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNovaNabavka.Size = new System.Drawing.Size(229, 41);
            this.btnNovaNabavka.TabIndex = 1;
            this.btnNovaNabavka.Text = "Nova nabavka";
            this.btnNovaNabavka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaNabavka.UseVisualStyleBackColor = true;
            this.btnNovaNabavka.Click += new System.EventHandler(this.BtnNovaNabavka_Click);
            // 
            // btnDetaljiNabavke
            // 
            this.btnDetaljiNabavke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetaljiNabavke.FlatAppearance.BorderSize = 0;
            this.btnDetaljiNabavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaljiNabavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetaljiNabavke.ForeColor = System.Drawing.Color.LightGray;
            this.btnDetaljiNabavke.Location = new System.Drawing.Point(0, 0);
            this.btnDetaljiNabavke.Name = "btnDetaljiNabavke";
            this.btnDetaljiNabavke.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDetaljiNabavke.Size = new System.Drawing.Size(229, 40);
            this.btnDetaljiNabavke.TabIndex = 0;
            this.btnDetaljiNabavke.Text = "Pregled detalja nabavke";
            this.btnDetaljiNabavke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetaljiNabavke.UseVisualStyleBackColor = true;
            this.btnDetaljiNabavke.Click += new System.EventHandler(this.BtnDetaljiNabavke_Click);
            // 
            // btnNabavke
            // 
            this.btnNabavke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNabavke.FlatAppearance.BorderSize = 0;
            this.btnNabavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNabavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNabavke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnNabavke.Location = new System.Drawing.Point(0, 184);
            this.btnNabavke.Name = "btnNabavke";
            this.btnNabavke.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNabavke.Size = new System.Drawing.Size(229, 45);
            this.btnNabavke.TabIndex = 3;
            this.btnNabavke.Text = "Nabavke";
            this.btnNabavke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNabavke.UseVisualStyleBackColor = true;
            this.btnNabavke.Click += new System.EventHandler(this.BtnNabavke_Click);
            // 
            // ZahtjeviSubMenuPanel
            // 
            this.ZahtjeviSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ZahtjeviSubMenuPanel.Controls.Add(this.btnPregledZahtjeva);
            this.ZahtjeviSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZahtjeviSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.ZahtjeviSubMenuPanel.Location = new System.Drawing.Point(0, 145);
            this.ZahtjeviSubMenuPanel.Name = "ZahtjeviSubMenuPanel";
            this.ZahtjeviSubMenuPanel.Size = new System.Drawing.Size(229, 39);
            this.ZahtjeviSubMenuPanel.TabIndex = 2;
            // 
            // btnPregledZahtjeva
            // 
            this.btnPregledZahtjeva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPregledZahtjeva.FlatAppearance.BorderSize = 0;
            this.btnPregledZahtjeva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledZahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledZahtjeva.ForeColor = System.Drawing.Color.LightGray;
            this.btnPregledZahtjeva.Location = new System.Drawing.Point(0, 0);
            this.btnPregledZahtjeva.Name = "btnPregledZahtjeva";
            this.btnPregledZahtjeva.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPregledZahtjeva.Size = new System.Drawing.Size(229, 39);
            this.btnPregledZahtjeva.TabIndex = 0;
            this.btnPregledZahtjeva.Text = "Pregled zahtjeva";
            this.btnPregledZahtjeva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregledZahtjeva.UseVisualStyleBackColor = true;
            this.btnPregledZahtjeva.Click += new System.EventHandler(this.BtnPregledZahtjeva_Click);
            // 
            // btnZahtjevi
            // 
            this.btnZahtjevi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZahtjevi.FlatAppearance.BorderSize = 0;
            this.btnZahtjevi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZahtjevi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnZahtjevi.Location = new System.Drawing.Point(0, 100);
            this.btnZahtjevi.Name = "btnZahtjevi";
            this.btnZahtjevi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnZahtjevi.Size = new System.Drawing.Size(229, 45);
            this.btnZahtjevi.TabIndex = 1;
            this.btnZahtjevi.Text = "Zahtjevi";
            this.btnZahtjevi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZahtjevi.UseVisualStyleBackColor = true;
            this.btnZahtjevi.Click += new System.EventHandler(this.BtnZahtjevi_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
           
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(843, 600);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 596);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // options
            // 
            this.options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaljiToolStripMenuItem,
            this.oKToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(181, 70);
            // 
            // detaljiToolStripMenuItem
            // 
            this.detaljiToolStripMenuItem.Name = "detaljiToolStripMenuItem";
            this.detaljiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detaljiToolStripMenuItem.Text = "Detalji";
            this.detaljiToolStripMenuItem.Click += new System.EventHandler(this.DetaljiToolStripMenuItem_Click);
            // 
            // oKToolStripMenuItem
            // 
            this.oKToolStripMenuItem.Name = "oKToolStripMenuItem";
            this.oKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oKToolStripMenuItem.Text = "OK";
           
            // 
            // frmIndexProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.SideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmIndexProdavac";
            this.Text = "Prodavac panel";
            this.Load += new System.EventHandler(this.FrmIndexProdavac_Load);
            this.SideMenuPanel.ResumeLayout(false);
            this.IzvjestajiSubMenuPanel.ResumeLayout(false);
            this.NarudzbeSubMenuPanel.ResumeLayout(false);
            this.ObavijestiSubMenuPanel.ResumeLayout(false);
            this.NabavkeSubMenuPanel.ResumeLayout(false);
            this.ZahtjeviSubMenuPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel ObavijestiSubMenuPanel;
        private System.Windows.Forms.Button btnNovaObavijest;
        private System.Windows.Forms.Button btnListaObavijesti;
        private System.Windows.Forms.Button btnObavijesti;
        private System.Windows.Forms.Panel NabavkeSubMenuPanel;
        private System.Windows.Forms.Button btnNovaNabavka;
        private System.Windows.Forms.Button btnDetaljiNabavke;
        private System.Windows.Forms.Button btnNabavke;
        private System.Windows.Forms.Panel ZahtjeviSubMenuPanel;
        private System.Windows.Forms.Button btnPregledZahtjeva;
        private System.Windows.Forms.Button btnZahtjevi;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Panel NarudzbeSubMenuPanel;
        private System.Windows.Forms.Button btnListaNarudzbi;
        private System.Windows.Forms.Panel IzvjestajiSubMenuPanel;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPregledIzvjestaja;
        private System.Windows.Forms.ContextMenuStrip options;
        private System.Windows.Forms.ToolStripMenuItem detaljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;
    }
}

