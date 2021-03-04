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
    public partial class frmTreningDetalji : Form
    {
        private int? id = null;

        private readonly APIService _treningService = new APIService("Trening");

        public frmTreningDetalji(int? id = null)
        {
            InitializeComponent();
            this.id = id;

        }

        private async void frmTreningDetalji_Load(object sender, EventArgs e)
        {
            if (id != null) 
                await LoadTrening((int)id);

        }
        private async Task LoadTrening(int id)
        {
            try
            {
                var result = await _treningService.GetById<TreningModel>(id);
                txtNaziv.Text = result.Naziv;
                txtOpis.Text = result.Opis;
                txtSkraceniNaziv.Text = result.SkraceniNaziv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    var insertModel = new TreningModel
                    {
                        Naziv = txtNaziv.Text,
                        Opis = txtOpis.Text,
                        SkraceniNaziv = txtSkraceniNaziv.Text,
                    };
                    TreningModel result = null;
                    if (id != null)
                    {
                        result = await _treningService.Update<TreningModel>(id, insertModel);
                    }
                    else
                    {
                        result = await _treningService.Insert<TreningModel>(insertModel);
                        id = result.Id;
                    }
                    if (result != null)
                    {
                        MessageBox.Show("Operacija uspješna.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
