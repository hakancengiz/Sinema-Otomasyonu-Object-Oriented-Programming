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
    public partial class SalonDuzenleForm : Form
    {
        public SalonDuzenleForm()
        {
            InitializeComponent();
        }

        SalonORM sOrm = new SalonORM();
        Salon s = new Salon();
        private void SalonDuzenleForm_Load(object sender, EventArgs e)
        {
            cmbSalon.DisplayMember = "SalonAdi";
            cmbSalon.ValueMember = "Id";
            cmbSalon.DataSource = sOrm.Select();         
        }

        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalonAdi.Text = cmbSalon.Text.ToString();
            SalonORM.SecilenSalon = (string)txtSalonAdi.Text;
            int Kontenjan = SalonORM.KontenjanBul();
            txtKontenjan.Text = Kontenjan.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && txtKontenjan.Text != "")
            {
                s.Id = Convert.ToInt32(cmbSalon.SelectedValue);
                s.SalonAdi = txtSalonAdi.Text;
                s.Kontenjan = Convert.ToInt32(txtKontenjan.Text);

                bool sonuc = sOrm.Update(s);
                if (sonuc)
                {
                    MessageBox.Show("Salon adı ve kontenjanı güncellendi.");
                    cmbSalon.DataSource = sOrm.Select();
                    cmbSalon.DisplayMember = "SalonAdi";
                    cmbSalon.ValueMember = "Id";
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
            s.Id = Convert.ToInt32(cmbSalon.SelectedValue);

            bool sonuc = sOrm.Delete(s);
            if (sonuc)
            {
                MessageBox.Show("Seçilen salon silindi.");
                cmbSalon.DataSource = sOrm.Select();
                cmbSalon.DisplayMember = "SalonAdi";
                cmbSalon.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.");
            }
        }
    }
}
