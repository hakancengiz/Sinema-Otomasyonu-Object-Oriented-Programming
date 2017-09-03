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
    public partial class SalonEkleForm : Form
    {
        public SalonEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSalon.Text != "" && txtKontenjan.Text != "")
            {
                SalonORM sOrm = new SalonORM();
                Salon s = new Salon();
                s.SalonAdi = txtSalon.Text;
                s.Kontenjan = Convert.ToInt32(txtKontenjan.Text);

                bool sonuc = sOrm.Insert(s);
                if (sonuc)
                {
                    MessageBox.Show("Salon başarıyla eklendi.");
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
