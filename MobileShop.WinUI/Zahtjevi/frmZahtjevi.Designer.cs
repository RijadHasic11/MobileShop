namespace MobileShop.WinUI.Zahtjevi
{
    partial class frmZahtjevi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ZahtjevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(140, 31);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(328, 20);
            this.txtPretraga.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(520, 31);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(86, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvZahtjevi);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 362);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zahtjevi";
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.AllowUserToAddRows = false;
            this.dgvZahtjevi.AllowUserToDeleteRows = false;
            this.dgvZahtjevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZahtjevi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZahtjevId,
            this.KlijentId,
            this.Datum,
            this.Naslov,
            this.Opis,
            this.Akcija});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZahtjevi.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvZahtjevi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZahtjevi.Location = new System.Drawing.Point(3, 16);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZahtjevi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvZahtjevi.Size = new System.Drawing.Size(588, 343);
            this.dgvZahtjevi.TabIndex = 0;
            this.dgvZahtjevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvZahtjevi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga po naslovu:";
            // 
            // ZahtjevId
            // 
            this.ZahtjevId.DataPropertyName = "Id";
            this.ZahtjevId.HeaderText = "ZahtjevId";
            this.ZahtjevId.Name = "ZahtjevId";
            this.ZahtjevId.ReadOnly = true;
            this.ZahtjevId.Visible = false;
            // 
            // KlijentId
            // 
            this.KlijentId.DataPropertyName = "Klijent";
            this.KlijentId.HeaderText = "Klijent";
            this.KlijentId.Name = "KlijentId";
            this.KlijentId.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumZahtjeva";
            this.Datum.HeaderText = "Datum zahtjeva";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Akcija
            // 
            this.Akcija.HeaderText = "Akcija";
            this.Akcija.Name = "Akcija";
            this.Akcija.ReadOnly = true;
            this.Akcija.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Akcija.Text = "Odgovori";
            this.Akcija.UseColumnTextForButtonValue = true;
            // 
            // frmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmZahtjevi";
            this.Text = "frmZahtjevi";
          
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZahtjevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}