
namespace WindowsFormsApp1.UI.Zaposlenici
{
    partial class frmZaposleniciUredi
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.Spol = new System.Windows.Forms.GroupBox();
            this.rbtnZ = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.Spol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(351, 394);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 21;
            this.btnSacuvaj.Text = "Saćuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // Spol
            // 
            this.Spol.Controls.Add(this.rbtnZ);
            this.Spol.Controls.Add(this.rbtnM);
            this.Spol.Location = new System.Drawing.Point(300, 301);
            this.Spol.Name = "Spol";
            this.Spol.Size = new System.Drawing.Size(200, 68);
            this.Spol.TabIndex = 20;
            this.Spol.TabStop = false;
            this.Spol.Text = "Spol";
            // 
            // rbtnZ
            // 
            this.rbtnZ.AutoSize = true;
            this.rbtnZ.Location = new System.Drawing.Point(109, 35);
            this.rbtnZ.Name = "rbtnZ";
            this.rbtnZ.Size = new System.Drawing.Size(61, 17);
            this.rbtnZ.TabIndex = 1;
            this.rbtnZ.TabStop = true;
            this.rbtnZ.Text = "Žensko";
            this.rbtnZ.UseVisualStyleBackColor = true;
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(15, 35);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(57, 17);
            this.rbtnM.TabIndex = 0;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "Muško";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Grad";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(300, 262);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(194, 20);
            this.txtGrad.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Adresa";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(300, 158);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(194, 20);
            this.txtPrezime.TabIndex = 14;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(300, 210);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(194, 20);
            this.txtAdresa.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(300, 105);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(194, 20);
            this.txtIme.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Šifra";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(300, 53);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(194, 20);
            this.txtSifra.TabIndex = 10;
            // 
            // frmZaposleniciUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.Spol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifra);
            this.Name = "frmZaposleniciUredi";
            this.Text = "frmZaposleniciUredi";
            this.Load += new System.EventHandler(this.frmZaposleniciUredi_Load);
            this.Spol.ResumeLayout(false);
            this.Spol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox Spol;
        private System.Windows.Forms.RadioButton rbtnZ;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifra;
    }
}