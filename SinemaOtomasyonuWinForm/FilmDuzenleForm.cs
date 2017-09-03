using SinemaOtomasyonuORM.Entity;
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
    public partial class FilmDuzenleForm : Form
    {
        public FilmDuzenleForm()
        {
            InitializeComponent();
        }

        FilmORM fOrm = new FilmORM();
        Film f = new Film();
        private void FilmDuzenleForm_Load(object sender, EventArgs e)
        {          
            cmbFilm.DataSource = fOrm.Select();
            cmbFilm.DisplayMember = "FilmAdi";
            cmbFilm.ValueMember = "Id";
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilm.Text = cmbFilm.Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFilm.Text != "")
            {
                f.Id = Convert.ToInt32(cmbFilm.SelectedValue);
                f.FilmAdi = txtFilm.Text;

                bool sonuc = fOrm.Update(f);
                if (sonuc)
                {
                    MessageBox.Show("Film adı güncellendi.");
                    cmbFilm.DataSource = fOrm.Select();
                    cmbFilm.DisplayMember = "FilmAdi";
                    cmbFilm.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.");
                }
            }
            else
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            f.Id = Convert.ToInt32(cmbFilm.SelectedValue);

            bool sonuc = fOrm.Delete(f);
            if (sonuc)
            {
                MessageBox.Show("Seçilen film silindi.");
                cmbFilm.DataSource = fOrm.Select();
                cmbFilm.DisplayMember = "FilmAdi";
                cmbFilm.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.");
            }
        }
    }
}
