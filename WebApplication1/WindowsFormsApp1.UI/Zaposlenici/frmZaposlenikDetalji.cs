using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UI.Dogadjaji;

namespace WindowsFormsApp1.UI.Zaposlenici
{
    public partial class frmZaposlenikDetalji : Form
    {
        private int? id;

        private readonly APIService service = new APIService("Zaposlenici");
        private readonly APIService service_dogadjaji = new APIService("Dogadjaji");

        public frmZaposlenikDetalji(int? idZaposlenika=null)
        {
            InitializeComponent();

            id = idZaposlenika;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmZaposlenikDetalji_Load(object sender, EventArgs e)
        {
            dgvDogadjaji.AutoGenerateColumns = false;

            if (id.HasValue)
            {
                dgvDogadjaji.DataSource = await service_dogadjaji.GetById<List<Models.dogadjaji>>(id);

                dgvDogadjaji.AutoGenerateColumns = false;
                var result = await service.GetById<Models.zaposlenici>(id);

                txtIme.Text = result.Ime;
                txtPrezime.Text = result.Prezime;
                txtSifra.Text = result.Sifra;
                txtAdresa.Text = result.Adresa;
                if (result.Pol == 1)
                    txtPol.Text = "M";
                else if (result.Pol == 2)
                    txtPol.Text = "Ž";
                else
                    txtPol.Text = "";

                if (result.DatumDodavanja != null)
                    txtDatumDodavanja.Text = result.DatumDodavanja.Value.Day.ToString() + "." + result.DatumDodavanja.Value.Month.ToString() + "." + result.DatumDodavanja.Value.Year.ToString() + ".";
                else
                    txtDatumDodavanja.Text = "";

                if (result.DatumIzmjene != null)
                    txtDatumIzmjene.Text = result.DatumIzmjene.Value.Day.ToString() + "." + result.DatumIzmjene.Value.Month.ToString() + "." + result.DatumIzmjene.Value.Year.ToString() + ".";
                else
                    txtDatumIzmjene.Text = "";
            }
        }

        private void Ime_Click(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDogadjaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            frmZaposleniciUredi frm = new frmZaposleniciUredi(id);

            frm.Show();
        }

        private void dgvDogadjaji_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var idDogadjaja = dgvDogadjaji.SelectedRows[0].Cells[0].Value;

                frmDogadjajiUredi frm = new frmDogadjajiUredi(int.Parse(idDogadjaja.ToString()));
                frm.Show();
            }
            if (e.ColumnIndex == 4)
            {
                var idDogadjaja = dgvDogadjaji.SelectedRows[0].Cells[0].Value;

                var dugme = MessageBox.Show("Da li ste digurni da želite obisati odabrano polje?", "Upozorenje", MessageBoxButtons.YesNo);

                if (dugme.ToString()=="Yes")
                    service_dogadjaji.Delete(int.Parse(idDogadjaja.ToString()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDogadjajiUnos frm = new frmDogadjajiUnos(id);
            frm.Show();
        }


    }
}