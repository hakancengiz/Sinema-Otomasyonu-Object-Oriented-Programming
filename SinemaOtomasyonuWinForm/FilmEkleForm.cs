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
    public partial class FilmEkleForm : Form
    {
        public FilmEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text != "")
            {
                FilmORM fOrm = new FilmORM();
                Film f = new Film();
                f.FilmAdi = txtFilmAdi.Text;

                bool sonuc = fOrm.Insert(f);
                if (sonuc)
                {
                    MessageBox.Show("Film başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.");
                }
            }
            else
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
        }
    }
}
