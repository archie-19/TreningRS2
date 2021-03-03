using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreningRS2.Models.ApplicationUser;
using TreningRS2.Models.Općina;

namespace TreningRS2.WinUI.ApplicationUser
{
    public partial class frmApplicationUserDetalji : Form
    {
        private readonly APIService _serviceOpcine = new APIService("Opcina");

        private readonly APIService _service = new APIService("ApplicationUser");
        private int? _id = null;
        private byte[] img = null;
        public frmApplicationUserDetalji(int? ApplicationUserId=null )
        {
            InitializeComponent();
            _id = ApplicationUserId;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() && int.TryParse(comboOpcine.SelectedValue.ToString(), out int idOpcina))
            {
                string spol = "Not specified";
                if (btnZ.Checked)
                {
                    spol = "Z";
                }
                else if (btnM.Checked)
                {
                    spol = "M";
                }
                
                var insert = new ApplicationUserInsert()
                {

                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Password = txtPassword.Text,
                    PasswordConfirm = txtPotvrda.Text,
                    Username = txtUsername.Text,
                    OpcinaId = idOpcina,
                    JMBG = txtJMBG.Text,
                    Spol = spol,
                    DatumRodjenja = dateRodjenje.Value

                };
                if (img != null)
                {
                    insert.Slika = img;
                }

                if (_id.HasValue)
                {
                    //ovo baguje
                    await _service.Update<Models.ApplicationUser.ApplicationUser>(_id, insert);
                }
                else
                {
                    await _service.Insert<Models.ApplicationUser.ApplicationUser>(insert);
                }
                MessageBox.Show("Uspješno obavljeno.");
            }
        }
        private async void frmApplicationUserDetalji_Load(object sender, EventArgs e)
        {
            await LoadOpcina();
           
            if(_id.HasValue)
            {
                var appuser = await _service.GetById<Models.ApplicationUser.ApplicationUser>(_id);

                txtEmail.Text = appuser.Email;
                txtIme.Text = appuser.Ime;
                txtPrezime.Text = appuser.Prezime;
                txtUsername.Text = appuser.Username;
                txtJMBG.Text = appuser.JMBG;
                dateRodjenje.Value = appuser.DatumRodjenja;
                if (appuser.Spol == "M")
                {
                    btnM.Checked = true;
                    btnZ.Checked = false;
                }
                else
                {
                    btnM.Checked = false;
                    btnZ.Checked = true;
                }
                comboOpcine.SelectedValue = appuser.OpcinaId;
                if (appuser.Slika != null && appuser.Slika.Length > 0)
                {
                    Image i = null;
                    using (var ms = new MemoryStream(appuser.Slika))
                    {
                        i = Image.FromStream(ms);
                    }
                    if (i != null)
                    {
                        pictureSlika.Image = i;
                    }
                }

            }
        }
        private async Task LoadOpcina()
        {
            //lista opcina
            try
            {
                var result = await _serviceOpcine.Get<List<OpcinaModel>>(null);
                //result.Insert(0, new OpcinaModel()); //prva vrijednost prazno
                comboOpcine.DisplayMember = "Naziv";//iz modela naziv i opcina id
                comboOpcine.ValueMember = "Id";
                comboOpcine.DataSource = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Ne moze");
            }

        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, "Obavezno polje");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, "Obavezno polje");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Obavezno polje");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Obavezno polje");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void comboOpcine_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var idObj = comboOpcine.SelectedValue;
            //if(int.TryParse(idObj.ToString(),out int id))
            //{

            //}
        }

     
        private void btnSlika_Click(object sender, EventArgs e)
        {
            try
            {
                var result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = openFileDialog1.FileName;
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        var file = File.ReadAllBytes(fileName);
                        txtSlika.Text = fileName;

                        Image image = Image.FromFile(fileName);
                        Image thumb = image.GetThumbnailImage(100, 100, null, new System.IntPtr());
                        pictureSlika.Image = thumb;

                        //convert thumb to byte so you upload thumbs only
                        ImageConverter _imageConverter = new ImageConverter();
                        byte[] xByte = (byte[])_imageConverter.ConvertTo(thumb, typeof(byte[]));

                        img = xByte;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Neispravna slika odabrana.");
            }
        }
    }
}
