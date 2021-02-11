using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UI.Zaposlenici;

namespace WindowsFormsApp1.UI.Dogadjaji
{
    public partial class frmDogadjajiUnos : Form
    {
        private readonly int? id=null;

        private readonly APIService service = new APIService("Zaposlenici");
        private readonly APIService service_dogadjaji = new APIService("Dogadjaji");

        public frmDogadjajiUnos(int? _id)
        {
            id = _id;

            InitializeComponent();
        }

        private async void frmDogadjajiUnos_Load(object sender, EventArgs e)
        {
            var t = await service.GetById<Models.zaposlenici>(id);

            txtZaposlenik.Text = t.Ime.ToString() + "." + t.Prezime.ToString();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbTekst.Text))
            {
                MessageBox.Show("Polje sa tekstom događaja ne može biti prazno", "Upozorenje", MessageBoxButtons.OK);
            }
            else
            {
                Models.dogadjaji temp = new Models.dogadjaji
                {
                    Datum = dateDatum.Value,
                    TekstDogadjaja = rtbTekst.Text,
                    ZaposleniciId = (short)id
                };

                await service_dogadjaji.InsertNewDogadjaj<Models.dogadjaji>(temp);

                Form.ActiveForm.Close();
            }

        }

        private void rtbTekst_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dateDatum_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnSacuvaj_Enter(object sender, EventArgs e)
        {

        }

        private void rtbTekst_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbTekst.Text))
            {
                e.Cancel = true;
                err.SetError(rtbTekst, "Obavezno polje");
            }
            else
            {
                err.SetError(rtbTekst, null);
            }
        }
    }
}
