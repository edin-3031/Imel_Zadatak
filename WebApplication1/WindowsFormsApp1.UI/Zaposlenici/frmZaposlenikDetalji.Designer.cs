
namespace WindowsFormsApp1.UI.Zaposlenici
{
    partial class frmZaposlenikDetalji
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
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDogadjaji = new System.Windows.Forms.DataGridView();
            this.identifikacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatumDodavanja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatumIzmjene = new System.Windows.Forms.TextBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(40, 69);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(146, 50);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 3;
            this.Ime.Text = "Ime";
            this.Ime.Click += new System.EventHandler(this.Ime_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(146, 69);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(252, 69);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDogadjaji);
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Događaji LIsta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvDogadjaji
            // 
            this.dgvDogadjaji.AllowUserToAddRows = false;
            this.dgvDogadjaji.AllowUserToDeleteRows = false;
            this.dgvDogadjaji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDogadjaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogadjaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifikacija,
            this.Datum,
            this.Tekst,
            this.Uredi,
            this.Ukloni});
            this.dgvDogadjaji.Location = new System.Drawing.Point(6, 19);
            this.dgvDogadjaji.Name = "dgvDogadjaji";
            this.dgvDogadjaji.ReadOnly = true;
            this.dgvDogadjaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDogadjaji.Size = new System.Drawing.Size(521, 197);
            this.dgvDogadjaji.TabIndex = 0;
            this.dgvDogadjaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDogadjaji_CellContentClick_1);
            // 
            // identifikacija
            // 
            this.identifikacija.DataPropertyName = "Id";
            this.identifikacija.HeaderText = "ID";
            this.identifikacija.Name = "identifikacija";
            this.identifikacija.ReadOnly = true;
            this.identifikacija.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "TekstDogadjaja";
            this.Tekst.HeaderText = "Tekst";
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "Uređivanje";
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.ToolTipText = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pol";
            // 
            // txtPol
            // 
            this.txtPol.Location = new System.Drawing.Point(464, 69);
            this.txtPol.Name = "txtPol";
            this.txtPol.ReadOnly = true;
            this.txtPol.Size = new System.Drawing.Size(22, 20);
            this.txtPol.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(358, 69);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum dodavanja";
            // 
            // txtDatumDodavanja
            // 
            this.txtDatumDodavanja.Location = new System.Drawing.Point(40, 147);
            this.txtDatumDodavanja.Name = "txtDatumDodavanja";
            this.txtDatumDodavanja.ReadOnly = true;
            this.txtDatumDodavanja.Size = new System.Drawing.Size(100, 20);
            this.txtDatumDodavanja.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Datum izmjene";
            // 
            // txtDatumIzmjene
            // 
            this.txtDatumIzmjene.Location = new System.Drawing.Point(146, 147);
            this.txtDatumIzmjene.Name = "txtDatumIzmjene";
            this.txtDatumIzmjene.ReadOnly = true;
            this.txtDatumIzmjene.Size = new System.Drawing.Size(100, 20);
            this.txtDatumIzmjene.TabIndex = 13;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(463, 199);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 15;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(463, 456);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj novi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmZaposlenikDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 489);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDatumIzmjene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatumDodavanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifra);
            this.Name = "frmZaposlenikDetalji";
            this.Text = "frmZaposlenikDetalji";
            this.Load += new System.EventHandler(this.frmZaposlenikDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDogadjaji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatumDodavanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatumIzmjene;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifikacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
        private System.Windows.Forms.Button btnDodaj;
    }
}