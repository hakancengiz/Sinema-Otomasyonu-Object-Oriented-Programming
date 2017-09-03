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
    public partial class SeansDuzenle : Form
    {
        public SeansDuzenle()
        {
            InitializeComponent();
        }

        SeansORM sOrm = new SeansORM();
        Seans s = new Seans();
        private void SeansDuzenle_Load(object sender, EventArgs e)
        {
            cmbSeans.DataSource = sOrm.Select();
            cmbSeans.DisplayMember = "SeansSaati";
            cmbSeans.ValueMember = "Id";
        }

        private void cmbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSeans.Text = cmbSeans.Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSeans.Text != "")
            {
                s.Id = Convert.ToInt32(cmbSeans.SelectedValue);
                s.SeansSaati = txtSeans.Text;

                bool sonuc = sOrm.Update(s);
                if (sonuc)
                {
                    MessageBox.Show("Seans saati güncellendi.");
                    cmbSeans.DataSource = sOrm.Select();
                    cmbSeans.DisplayMember = "SeansSaati";
                    cmbSeans.ValueMember = "Id";
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
            s.Id = Convert.ToInt32(cmbSeans.SelectedValue);

            bool sonuc = sOrm.Delete(s);
            if (sonuc)
            {
                MessageBox.Show("Seçilen seans silindi.");
                cmbSeans.DataSource = sOrm.Select();
                cmbSeans.DisplayMember = "SeansSaati";
                cmbSeans.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.");
            }
        }
    }
}
