using SinemaOtomasyonuORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonuWinForm
{
    public partial class SatisBiletSecimForm : Form
    {
        public SatisBiletSecimForm()
        {
            InitializeComponent();
        }

        private void SatisBiletSecimForm_Load(object sender, EventArgs e)
        {
            FilmORM filmOrm = new FilmORM();
            SalonORM salonOrm = new SalonORM();
            SeansORM seansOrm = new SeansORM();

            cmbFilmAdi.DataSource = filmOrm.Select();
            cmbFilmAdi.DisplayMember = "FilmAdi";
            cmbFilmAdi.ValueMember = "FilmAdi";

            cmbSalon.DataSource = salonOrm.Select();
            cmbSalon.DisplayMember = "SalonAdi";
            cmbSalon.ValueMember = "SalonAdi";

            cmbSeans.DataSource = seansOrm.Select();
            cmbSeans.DisplayMember = "SeansSaati";
            cmbSeans.ValueMember = "SeansSaati";
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            FilmORM.SecilenFilm = cmbFilmAdi.SelectedValue.ToString();
            SalonORM.SecilenSalon = cmbSalon.SelectedValue.ToString();
            SeansORM.SecilenSeans = cmbSeans.SelectedValue.ToString();

            SatisForm sf = new SatisForm();
            sf.Show();
            this.Hide();
        }
    }
}
