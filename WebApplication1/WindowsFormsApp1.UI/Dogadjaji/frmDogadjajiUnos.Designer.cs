
namespace WindowsFormsApp1.UI.Dogadjaji
{
    partial class frmDogadjajiUnos
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
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.Datum = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDatum
            // 
            this.dateDatum.Location = new System.Drawing.Point(518, 86);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(200, 20);
            this.dateDatum.TabIndex = 0;
            this.dateDatum.Value = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(12, 12);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(500, 330);
            this.rtbTekst.TabIndex = 1;
            this.rtbTekst.Text = "";
            this.rtbTekst.Validating += new System.ComponentModel.CancelEventHandler(this.rtbTekst_Validating_1);
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(518, 67);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 2;
            this.Datum.Text = "Datum";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(643, 319);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            this.btnSacuvaj.Enter += new System.EventHandler(this.btnSacuvaj_Enter);
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(518, 37);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(200, 20);
            this.txtZaposlenik.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zaposlenik";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmDogadjajiUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.rtbTekst);
            this.Controls.Add(this.dateDatum);
            this.Name = "frmDogadjajiUnos";
            this.Text = "frmDogadjajiUnos";
            this.Load += new System.EventHandler(this.frmDogadjajiUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider err;
    }
}