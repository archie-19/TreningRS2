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
using TreningRS2.Models.ApplicationUser;

namespace TreningRS2.WinUI.ApplicationUser
{
    public partial class frmApplicationUser : Form
    {

        private readonly APIService _apiService = new APIService("ApplicationUser");
        public frmApplicationUser()
        {
            InitializeComponent();
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {

            //pozivamo api
            //var result = await "https://localhost:44377/api/ApplicationUser".GetJsonAsync<List<Models.ApplicationUser.ApplicationUser>>();
            var search = new ApplicationUserSearch()
            {
                Ime = txtPretraga.Text
            };

            var result =await _apiService.Get < List<Models.ApplicationUser.ApplicationUser>>(search);
           // dgvKorisnici.AutoGenerateColumns = false;//da ne generise samo sve nego samo sto je tamo stavljeno u grid
            dgvKorisnici.DataSource = result;
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[2].Value;
            frmApplicationUserDetalji frm = new frmApplicationUserDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
