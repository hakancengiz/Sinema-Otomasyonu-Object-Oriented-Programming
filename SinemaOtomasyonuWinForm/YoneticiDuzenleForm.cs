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
    public partial class YoneticiDuzenleForm : Form
    {
        public YoneticiDuzenleForm()
        {
            InitializeComponent();
        }

        YoneticiORM yOrm = new YoneticiORM();
        Yonetici y = new Yonetici();
        private void YoneticiDuzenleForm_Load(object sender, EventArgs e)
        {
            txtGuncelleYoneticiAdi.Text = YoneticiORM.AktifYoneticiAdi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGuncelleYoneticiAdi.Text != "" && txtGuncelleParola.Text != "")
            {
                y.Id = YoneticiORM.AktifYoneticiId;
                y.YoneticiAdi = txtGuncelleYoneticiAdi.Text;
                y.YoneticiParola = txtGuncelleParola.Text;
                bool sonuc = yOrm.Update(y);
                if (sonuc)
                {
                    MessageBox.Show("Güncelleme işlemi yapıldı.");
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.");
                }
            }
            else
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkleYoneticiAdi.Text != "" && txtEkleParola.Text != "")
            {
                y.YoneticiAdi = txtEkleYoneticiAdi.Text;
                y.YoneticiParola = txtEkleParola.Text;
                bool sonuc = yOrm.Insert(y);
                if (sonuc)
                {
                    MessageBox.Show("Ekleme işlemi yapıldı.");
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
            if (txtSilYoneticiAdi.Text != "" && txtSilParola.Text != "")
            {
                string YoneticiAdi = txtSilYoneticiAdi.Text;
                string YoneticiParola = txtSilParola.Text;
                bool sonuc = YoneticiORM.YoneticiSil(YoneticiAdi, YoneticiParola);
                if (sonuc)
                {
                    MessageBox.Show("Silme işlemi yapıldı.");
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
