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
    public partial class SeansEkleForm : Form
    {
        public SeansEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSeans.Text != "")
            {
                SeansORM sOrm = new SeansORM();
                Seans s = new Seans();
                s.SeansSaati = txtSeans.Text;

                bool sonuc = sOrm.Insert(s);
                if (sonuc)
                {
                    MessageBox.Show("Seans başarıyla eklendi.");
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
