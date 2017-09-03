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
    public partial class BiletFiyatForm : Form
    {
        public BiletFiyatForm()
        {
            InitializeComponent();
        }

        private void BiletFiyatForm_Load(object sender, EventArgs e)
        {
            decimal[] BiletFiyatlari = BiletFiyatORM.BiletFiyatlariBul();
            decimal tam_bilet_fiyat = BiletFiyatlari[0];
            decimal indirimli_bilet_fiyat = BiletFiyatlari[1];
            txtTamBilet.Text = tam_bilet_fiyat.ToString();
            txtIndirimliBilet.Text = indirimli_bilet_fiyat.ToString();
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTamBilet.Text != "" && txtIndirimliBilet.Text != "")
            {
                BiletFiyatORM bfOrm = new BiletFiyatORM();
                BiletFiyat bf = new BiletFiyat();
                bf.TamFiyat = Convert.ToDecimal(txtTamBilet.Text);
                bf.IndirimliFiyat = Convert.ToDecimal(txtIndirimliBilet.Text);
                bool sonuc = bfOrm.Update(bf);
                if (sonuc)
                {
                    MessageBox.Show("Bilet fiyatlari güncellendi.");
                    decimal[] BiletFiyatlari = BiletFiyatORM.BiletFiyatlariBul();
                    decimal tam_bilet_fiyat = BiletFiyatlari[0];
                    decimal indirimli_bilet_fiyat = BiletFiyatlari[1];
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
