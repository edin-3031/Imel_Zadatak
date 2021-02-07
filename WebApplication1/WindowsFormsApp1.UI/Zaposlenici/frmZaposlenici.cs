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
    }
}