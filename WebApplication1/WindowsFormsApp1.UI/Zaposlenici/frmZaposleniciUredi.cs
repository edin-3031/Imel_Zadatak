using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UI.Zaposlenici
{
    public partial class frmZaposleniciUredi : Form
    {
        private readonly APIService service = new APIService("Zaposlenici");

        int? id=null;
        public frmZaposleniciUredi(int? _id)
        {
            InitializeComponent();

            id = _id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtAdresa.Text) ||
                string.IsNullOrWhiteSpace(txtGrad.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text)
            )
            {
                MessageBox.Show("Sva polja moraju biti popunjena", "Upozorenje", MessageBoxButtons.OK);
            }
            else
            {
                var zaposlenik = await service.GetById<Models.zaposlenici>(id);

                zaposlenik.Grad = txtGrad.Text;
                zaposlenik.Adresa = txtAdresa.Text;
                zaposlenik.DatumIzmjene = DateTime.Now;
                zaposlenik.Ime = txtIme.Text;
                zaposlenik.Prezime = txtPrezime.Text;
                zaposlenik.Sifra = txtSifra.Text;
                if (rbtnM.Checked)
                    zaposlenik.Pol = 1;
                else if (rbtnZ.Checked)
                    zaposlenik.Pol = 2;

                await service.Update<Models.zaposlenici>(id, zaposlenik);

                Form.ActiveForm.Close();
            }
        }

        private async void frmZaposleniciUredi_Load(object sender, EventArgs e)
        {
            var zaposlenik = await service.GetById<Models.zaposlenici>(id);

            txtSifra.Text = zaposlenik.Sifra;
            txtIme.Text = zaposlenik.Ime;
            txtPrezime.Text = zaposlenik.Prezime;
            txtGrad.Text = zaposlenik.Grad;
            txtAdresa.Text = zaposlenik.Adresa;

            if (zaposlenik.Pol == 1)
                rbtnM.Checked = true;
            else if (zaposlenik.Pol == 2)
                rbtnZ.Checked = true;
        }
    }
}