using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using Models;

namespace WindowsFormsApp1.UI.Zaposlenici
{
    public partial class frmZaposlenici : Form
    {
        private readonly APIService apiService = new APIService("Zaposlenici");

        public frmZaposlenici()
        {
            InitializeComponent();

            dgvZaposlenici.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int zaposlenikId = (int)dgvZaposlenici.SelectedRows[0].Cells[0].Value;

                frmZaposlenikDetalji frm = new frmZaposlenikDetalji(zaposlenikId);
                frm.Show();
            }
            if (e.ColumnIndex == 7)
            {
                var t=MessageBox.Show("Da li ste digurni da želite obisati odabrano polje?", "Upozorenje", MessageBoxButtons.YesNo);
                int zaposlenikId = (int)dgvZaposlenici.SelectedRows[0].Cells[0].Value;

                if(t.ToString()=="Yes")
                    apiService.Delete(zaposlenikId);
            }
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var search = new ZaposleniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var result = await apiService.Get<List<Models.zaposlenici>>(search);
            
            dgvZaposlenici.DataSource = result;
        }

        //private void dgvZaposlenici_DoubleClick(object sender, EventArgs e)
        //{
        //    var id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;

        //    frmZaposlenikDetalji frm = new frmZaposlenikDetalji(int.Parse(id.ToString()));
        //    frm.Show();
        //}

        private async void frmZaposlenici_Load(object sender, EventArgs e)
        {
            var search = new ZaposleniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var result = await apiService.Get<List<Models.zaposlenici>>(search);

            dgvZaposlenici.DataSource = result;

            dgvZaposlenici.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvZaposlenici.Columns[5].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmZaposleniciUnos frm = new frmZaposleniciUnos();
            frm.Show();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}