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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        SatisBiletSecimForm sbsf = new SatisBiletSecimForm();
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbsf.IsDisposed)
                sbsf = new SatisBiletSecimForm();
            sbsf.MdiParent = this;
            sbsf.Show();
        }

        FilmEkleForm fef = new FilmEkleForm();
        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fef.IsDisposed)
                fef = new FilmEkleForm();
            fef.MdiParent = this;
            fef.Show();
        }

        SeansEkleForm sef = new SeansEkleForm();
        private void seansEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sef.IsDisposed)
                sef = new SeansEkleForm();
            sef.MdiParent = this;
            sef.Show();
        }

        SalonEkleForm saef = new SalonEkleForm();
        private void salonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saef.IsDisposed)
                saef = new SalonEkleForm();
            saef.MdiParent = this;
            saef.Show();
        }

        FilmDuzenleForm fdf = new FilmDuzenleForm();
        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdf.IsDisposed)
                fdf = new FilmDuzenleForm();
            fdf.MdiParent = this;
            fdf.Show();
        }

        SeansDuzenle sd = new SeansDuzenle();
        private void seansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sd.IsDisposed)
                sd = new SeansDuzenle();
            sd.MdiParent = this;
            sd.Show();
        }

        SalonDuzenleForm sdf = new SalonDuzenleForm();
        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sdf.IsDisposed)
                sdf = new SalonDuzenleForm();
            sdf.MdiParent = this;
            sdf.Show();
        }

        YoneticiDuzenleForm ydf = new YoneticiDuzenleForm();
        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ydf.IsDisposed)
                ydf = new YoneticiDuzenleForm();
            ydf.MdiParent = this;
            ydf.Show();
        }

        BiletFiyatForm bff = new BiletFiyatForm();
        private void yöneticiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bff.IsDisposed)
                bff = new BiletFiyatForm();
            bff.MdiParent = this;
            bff.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisForm gf = new GirisForm();
            gf.Show();
            this.Hide();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            lblYoneticiAdi.Text = "Hoş geldin, " + YoneticiORM.AktifYoneticiAdi;
        }
    }
}
