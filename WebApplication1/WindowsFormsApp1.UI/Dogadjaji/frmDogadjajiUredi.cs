using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UI.Dogadjaji
{
    public partial class frmDogadjajiUredi : Form
    {
        int? id = null;
        APIService service_dogadjaji = new APIService("Dogadjaji");
        APIService service_dogadjaj = new APIService("Dogadjaji/dogadjaji");
        APIService service_zaposlenik = new APIService("Zaposlenici");
        public frmDogadjajiUredi(int? _id)
        {
            id = _id;

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Datum_Click(object sender, EventArgs e)
        {

        }

        private async void frmDogadjajiUredi_Load(object sender, EventArgs e)
        {
            var dogadjaj = await service_dogadjaj.GetById<Models.dogadjaji>(id);

            var zaposlenik = await service_zaposlenik.GetById<Models.zaposlenici>(dogadjaj.ZaposleniciId);

            txtDatum.Text = dogadjaj.Datum.Value.Day.ToString()+"."+ dogadjaj.Datum.Value.Month.ToString() + "." + dogadjaj.Datum.Value.Year.ToString() + ".";

            txtZaposlenik.Text = zaposlenik.Ime.ToString() + "." + zaposlenik.Prezime.ToString();

            rtbTekst.Text = dogadjaj.TekstDogadjaja.ToString();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbTekst.Text))
            {
                MessageBox.Show("Polje \"Tekst događaja\" ne smije biti prazno", "Upozorenje", MessageBoxButtons.OK);
            }
            else
            {
                var dogadjaj = await service_dogadjaj.GetById<Models.dogadjaji>(id);


                dogadjaj.TekstDogadjaja = rtbTekst.Text;

                await service_dogadjaji.Update<Models.dogadjaji>(id, dogadjaj);

                Form.ActiveForm.Close();
            }
        }

        private void rtbTekst_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
