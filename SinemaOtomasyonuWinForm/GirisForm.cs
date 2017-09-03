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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtYoneticiAdi.Text != "" && txtParola.Text != "")
            {
                string YoneticiAdi = txtYoneticiAdi.Text;
                string YoneticiParola = txtParola.Text;
                bool sonuc = YoneticiORM.YoneticiGiris(YoneticiAdi, YoneticiParola);
                if (sonuc)
                {
                    MasterForm m = new MasterForm();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Böyle bir yönetici bulunamadı.");
                }
            }
            else
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
        }

        private void lblYoneticiAdi_Click(object sender, EventArgs e)
        {
            lblYoneticiAdi.Visible = false;
            txtYoneticiAdi.Focus();
        }

        private void lblParola_Click(object sender, EventArgs e)
        {
            lblParola.Visible = false;
            txtParola.Focus();
        }

        private void txtYoneticiAdi_Enter(object sender, EventArgs e)
        {
            lblYoneticiAdi.Visible = false;
        }

        private void txtParola_Enter(object sender, EventArgs e)
        {
            lblParola.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = "Tarih: " + DateTime.Now.Date.ToShortDateString() + " Saat: " + DateTime.Now.ToLongTimeString();
        }
    }
}
