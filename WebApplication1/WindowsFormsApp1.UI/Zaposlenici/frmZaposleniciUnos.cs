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
    public partial class frmZaposleniciUnos : Form
    {

        private readonly APIService service = new APIService("Zaposlenici");

        public frmZaposleniciUnos()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Models.zaposlenici novi = new Models.zaposlenici
            {
                Adresa = txtAdresa.Text,
                DatumDodavanja = DateTime.Now,
                DatumIzmjene = null,
                Grad = txtGrad.Text,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Sifra = txtSifra.Text
            };

            if (rbtnM.Checked)
                novi.Pol = 1;
            else if (rbtnZ.Checked)
                novi.Pol = 2;

            await service.InsertNew<Models.zaposlenici>(novi);

            frmZaposlenici frm = new frmZaposlenici();
            frm.Show();
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                errorProvider.SetError(txtSifra, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSifra, null);
            }

            if (txtSifra.Text.Length>3)
            {
                errorProvider.SetError(txtSifra, "Polje može imati najviše 3 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSifra, null);
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAdresa, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtAdresa, null);
            }
        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void Spol_Validated(object sender, EventArgs e)
        {

        }

        private void Spol_Validating(object sender, CancelEventArgs e)
        {
            if(rbtnM.Checked==false && rbtnZ.Checked == false)
            {
                e.Cancel = true;
                errorProvider.SetError(Spol, "Obavezno izabrati");
            }
            else
            {
                errorProvider.SetError(Spol, null);
            }
        }

        private void txtGrad_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrad.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtGrad, "Obavezno polje");
            }
            else
            {
                errorProvider.SetError(txtGrad, null);
            }
        }

        private void rbtnM_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnM.Checked == false && rbtnZ.Checked == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(Spol, "Obavezno izabrati");
            }
            else
            {
                errorProvider1.SetError(Spol, null);
            }
        }

        private void rbtnZ_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnM.Checked == false && rbtnZ.Checked == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(Spol, "Obavezno izabrati");
            }
            else
            {
                errorProvider1.SetError(Spol, null);
            }
        }

        private void btnSacuvaj_Validating(object sender, CancelEventArgs e)
        {
            if(rbtnM.Checked == false && rbtnZ.Checked == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(Spol, "Obavezno izabrati");
            }
            else
            {
                errorProvider1.SetError(Spol, null);
            }
        }
    }
}