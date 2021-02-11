
namespace WindowsFormsApp1.UI.Zaposlenici
{
    partial class frmZaposlenici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzmjene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblTrazilica = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvZaposlenici);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Zaposlenici";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposlenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sifra,
            this.Ime,
            this.Prezime,
            this.DatumDodavanja,
            this.DatumIzmjene,
            this.Detalji,
            this.Ukloni});
            this.dgvZaposlenici.Location = new System.Drawing.Point(7, 19);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposlenici.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(743, 311);
            this.dgvZaposlenici.TabIndex = 0;
            this.dgvZaposlenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumDodavanja
            // 
            this.DatumDodavanja.DataPropertyName = "DatumDodavanja";
            this.DatumDodavanja.HeaderText = "Datum dodavanja";
            this.DatumDodavanja.Name = "DatumDodavanja";
            this.DatumDodavanja.ReadOnly = true;
            // 
            // DatumIzmjene
            // 
            this.DatumIzmjene.DataPropertyName = "DatumIzmjene";
            this.DatumIzmjene.HeaderText = "Datum izmjene";
            this.DatumIzmjene.Name = "DatumIzmjene";
            this.DatumIzmjene.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.ToolTipText = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // Ukloni
            // 
            this.Ukloni.HeaderText = "Uklanjanje";
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.ReadOnly = true;
            this.Ukloni.Text = "Ukloni";
            this.Ukloni.ToolTipText = "Ukloni";
            this.Ukloni.UseColumnTextForButtonValue = true;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(325, 79);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 1;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(18, 81);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(301, 20);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblTrazilica
            // 
            this.lblTrazilica.AutoSize = true;
            this.lblTrazilica.Location = new System.Drawing.Point(15, 65);
            this.lblTrazilica.Name = "lblTrazilica";
            this.lblTrazilica.Size = new System.Drawing.Size(66, 13);
            this.lblTrazilica.TabIndex = 3;
            this.lblTrazilica.Text = "Ime/Prezime";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(687, 79);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj novi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblTrazilica);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmZaposlenici";
            this.Text = "frmZaposlenici";
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            this.MouseHover += new System.EventHandler(this.frmZaposlenici_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmZaposlenici_MouseMove);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblTrazilica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzmjene;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
    }
}