using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreningRS2.Models.Trening;

namespace TreningRS2.WinUI.Trening
{
    public partial class frmTreninzi : Form
    {

      //  private readonly APIService _treningService = new APIService("Trening/Get");
        private readonly APIService _apiService = new APIService("Trening");

        public frmTreninzi()
        {
            InitializeComponent();
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {

            //pozivamo api
            //var result = await "https://localhost:44377/api/ApplicationUser".GetJsonAsync<List<Models.ApplicationUser.ApplicationUser>>();
            var search = new TreningModelSearch()
            {
                Naziv = txtPretraga.Text
            };

            var result = await _apiService.Get<List<TreningModel>>(search);
            // dgvKorisnici.AutoGenerateColumns = false;//da ne generise samo sve nego samo sto je tamo stavljeno u grid
            gridTreninzi.DataSource = result;
        }
        private void gridTreninzi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = gridTreninzi.SelectedRows[0].Cells[2].Value;
            frmTreningDetalji frm = new frmTreningDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void btnPrikazi_Click_1(object sender, EventArgs e)
        {
            var search = new TreningModelSearch()
            {
                Naziv = txtPretraga.Text
            };

            var result = await _apiService.Get<List<TreningModel>>(search);
            // dgvKorisnici.AutoGenerateColumns = false;//da ne generise samo sve nego samo sto je tamo stavljeno u grid
            gridTreninzi.DataSource = result;
        }
    }
}
