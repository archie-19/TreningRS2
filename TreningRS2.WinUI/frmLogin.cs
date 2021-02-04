using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreningRS2.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Opcina");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
           
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtLozinka.Text;
                await _service.Get<dynamic>(null);
                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception )
            {
                MessageBox.Show("Ne radiyiyiyiyi");
            }
        }
    }
}
//dosla do 45 min na yt, nece da se auth kako treba, nece da update radi