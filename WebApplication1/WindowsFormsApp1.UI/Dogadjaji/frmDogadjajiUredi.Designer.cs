
namespace WindowsFormsApp1.UI.Dogadjaji
{
    partial class frmDogadjajiUredi
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
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(37, 59);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(180, 20);
            this.txtDatum.TabIndex = 0;
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(34, 40);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 1;
            this.Datum.Text = "Datum";
            this.Datum.Click += new System.EventHandler(this.Datum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tekst događaja";
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(37, 135);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(542, 234);
            this.rtbTekst.TabIndex = 4;
            this.rtbTekst.Text = "";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(504, 106);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(277, 59);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(180, 20);
            this.txtZaposlenik.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zaposlenik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmDogadjajiUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rtbTekst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.txtDatum);
            this.Name = "frmDogadjajiUredi";
            this.Text = "frmDogadjajiUredi";
            this.Load += new System.EventHandler(this.frmDogadjajiUredi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.Label label1;
    }
}