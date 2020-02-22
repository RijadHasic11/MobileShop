namespace MobileShop.WinUI
{
    partial class frmIndexAdmin
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
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSkladistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoSkladisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.korisniciToolStripMenuItem,
            this.skladistaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListaKorisnikaToolStripMenuItem,
            this.NoviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListaKorisnikaToolStripMenuItem
            // 
            this.ListaKorisnikaToolStripMenuItem.Name = "ListaKorisnikaToolStripMenuItem";
            this.ListaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ListaKorisnikaToolStripMenuItem.Text = "Lista korisnika";
            this.ListaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.ListaKorisnikaToolStripMenuItem_Click);
            // 
            // NoviKorisnikToolStripMenuItem
            // 
            this.NoviKorisnikToolStripMenuItem.Name = "NoviKorisnikToolStripMenuItem";
            this.NoviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.NoviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.NoviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.NoviKorisnikToolStripMenuItem_Click);
            // 
            // skladistaToolStripMenuItem
            // 
            this.skladistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSkladistaToolStripMenuItem,
            this.novoSkladisteToolStripMenuItem});
            this.skladistaToolStripMenuItem.Name = "skladistaToolStripMenuItem";
            this.skladistaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.skladistaToolStripMenuItem.Text = "Skladista";
            // 
            // listaSkladistaToolStripMenuItem
            // 
            this.listaSkladistaToolStripMenuItem.Name = "listaSkladistaToolStripMenuItem";
            this.listaSkladistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaSkladistaToolStripMenuItem.Text = "Lista skladista";
            this.listaSkladistaToolStripMenuItem.Click += new System.EventHandler(this.listaSkladistaToolStripMenuItem_Click_1);
            // 
            // novoSkladisteToolStripMenuItem
            // 
            this.novoSkladisteToolStripMenuItem.Name = "novoSkladisteToolStripMenuItem";
            this.novoSkladisteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoSkladisteToolStripMenuItem.Text = "Novo skladiste";
            this.novoSkladisteToolStripMenuItem.Click += new System.EventHandler(this.NovoSkladisteToolStripMenuItem_Click);
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
            // frmIndexAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndexAdmin";
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
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skladistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSkladistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoSkladisteToolStripMenuItem;
    }
}



