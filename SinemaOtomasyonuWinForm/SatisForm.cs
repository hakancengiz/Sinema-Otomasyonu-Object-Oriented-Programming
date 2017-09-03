using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaOtomasyonuORM.Facade;
using System.Collections;
using System.Data.SqlClient;
using SinemaOtomasyonuORM.Entity;

namespace SinemaOtomasyonuWinForm
{
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }

        int btn_x = 233, btn_y = 95;

        ArrayList koltuklar = new ArrayList();
        ArrayList iptalKoltuk = new ArrayList();

        int salon_kontenjan = 0;
        decimal ucret = 0, tam_bilet_fiyat = 0, indirimli_bilet_fiyat = 0;

        List<Button> tum_koltuklar = new List<Button>();

        private void SatisForm_Load(object sender, EventArgs e)
        {
            string FilmAdi = FilmORM.SecilenFilm;
            lblFilmAdi.Text = FilmAdi.Length > 12 ? FilmAdi.Substring(0, 12) + "..." : FilmAdi;
            lblSeans.Text = SeansORM.SecilenSeans;
            lblSalon.Text = SalonORM.SecilenSalon;

            txtBiletler.Enabled = false;
            txtIptalBiletler.Enabled = false;

            salon_kontenjan = Convert.ToInt32(SalonORM.KontenjanBul());

            for (int i = 1; i <= salon_kontenjan; i++)
            {
                Button btn = new Button();
                btn.Width = 35;
                btn.Height = 35;
                btn.Text = i.ToString();
                btn.Name = "btn" + i.ToString();
                Point yer = new Point(btn_x, btn_y);
                btn.Location = yer;
                btn.Cursor = Cursors.Hand;
                btn.Click += new EventHandler(KoltukClickOlayi);
                btn.BackColor = Color.White;
                tum_koltuklar.Add(btn);
                this.Controls.Add(btn);

                btn_x += 51;
                if (i % 10 == 0)
                {
                    btn_y += 45;
                    btn_x = 233;
                }
            }

            decimal[] BiletFiyatlari = BiletFiyatORM.BiletFiyatlariBul();
            tam_bilet_fiyat = BiletFiyatlari[0];
            indirimli_bilet_fiyat = BiletFiyatlari[1];

            kayitli_bilet_bul();
            salon_doluluk();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (txtAlici.Text != "" && txtBiletler.Text != "" && txtIndirimli.Text != "")
            {
                string AdSoyad = txtAlici.Text;
                decimal koltuksayisi = koltuklar.Count;
                int indirimli_bilet_sayisi = Convert.ToInt32(txtIndirimli.Text);
                decimal tam_fiyat = (koltuksayisi - indirimli_bilet_sayisi) * tam_bilet_fiyat;
                decimal indirimli_fiyat = indirimli_bilet_sayisi * indirimli_bilet_fiyat;
                ucret = tam_fiyat + indirimli_fiyat;

                int FilmId = FilmORM.FilmIdBul();
                int SalonId = SalonORM.SalonIdBul();
                int SeansId = SeansORM.SeansIdBul();
                bool sonuc = false;

                for (int i = 0; i < koltuklar.Count; i++)
                {
                    SatisORM sOrm = new SatisORM();
                    Satis s = new Satis();
                    s.FilmID = FilmId;
                    s.SalonID = SalonId;
                    s.SeansID = SeansId;
                    s.YoneticiID = YoneticiORM.AktifYoneticiId;
                    s.AdSoyad = AdSoyad;
                    s.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    s.KoltukNo = Convert.ToInt32(koltuklar[i]);
                    s.Ucret = ucret;
                    sonuc = sOrm.Insert(s);

                    this.Controls.Find("btn" + koltuklar[i].ToString(), true)[0].BackColor = Color.Crimson;
                    this.Controls.Find("btn" + koltuklar[i].ToString(), true)[0].ForeColor = Color.White;
                }

                if (sonuc)
                {
                    MessageBox.Show("Bilet satışı başarıyla kaydedildi.");

                    DialogResult pdr = printDialog1.ShowDialog();
                    if (pdr == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                else
                    MessageBox.Show("Bir sorun oluştu.");

                txtAlici.Text = "";
                txtBiletler.Text = "";
                txtIndirimli.Text = "";
                txtIptalBiletler.Text = "";

                koltuklar.Clear();
                iptalKoltuk.Clear();

                kayitli_bilet_bul();
                salon_doluluk();
            }
            else
                MessageBox.Show("Lütfen 'Alıcı, Biletler ve İndirimli' alanlarını doldurun.", "Uyarı!");

        }

        private void KoltukClickOlayi(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.Orange;
                if (!koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Add(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else if (((Button)sender).BackColor == Color.Orange)
            {
                ((Button)sender).BackColor = Color.White;
                if (koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Remove(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else
            {
                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {
                    iptalKoltuk.Add(((Button)sender).Text);
                }
                else
                {
                    iptalKoltuk.Remove(((Button)sender).Text);
                }
                iptalKoltukYazdir();
            }
        }

        void koltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                koltuk += koltuklar[i].ToString() + ",";
            }
            if (koltuklar.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);
            }
            txtBiletler.Text = koltuk;
        }

        void iptalKoltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < iptalKoltuk.Count; i++)
            {
                koltuk += iptalKoltuk[i].ToString() + ",";
            }
            if (iptalKoltuk.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);
            }
            txtIptalBiletler.Text = koltuk;
        }

        void salon_doluluk()
        {
            int dolu_koltuk_sayisi = 0;
            foreach (Button koltuk in tum_koltuklar)
            {
                if (koltuk.BackColor == Color.Crimson)
                    dolu_koltuk_sayisi++;
            }

            int doluluk_orani = (dolu_koltuk_sayisi * 100) / salon_kontenjan;
            progressBar1.Value = doluluk_orani;
            label14.Text = "%" + doluluk_orani + " (" + dolu_koltuk_sayisi + "/" + salon_kontenjan + ")";
        }

        void kayitli_bilet_bul()
        {
            int FilmId = FilmORM.FilmIdBul();
            int SalonId = SalonORM.SalonIdBul();
            int SeansId = SeansORM.SeansIdBul();

            List<string> DoluKoltukNumaralari = SatisORM.KayitliBiletBul(FilmId, SalonId, SeansId);
            for (int i = 0; i < DoluKoltukNumaralari.Count; i++)
            {
                string koltuk_No = DoluKoltukNumaralari[i].ToString();
                this.Controls.Find("btn" + koltuk_No, true)[0].BackColor = Color.Crimson;
                this.Controls.Find("btn" + koltuk_No, true)[0].ForeColor = Color.White;
            }
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            if (txtIptalBiletler.Text != "")
            {
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    SatisORM.BiletIptal(Convert.ToInt32(iptalKoltuk[i]));
                    this.Controls.Find("btn" + iptalKoltuk[i].ToString(), true)[0].BackColor = Color.White;
                    this.Controls.Find("btn" + iptalKoltuk[i].ToString(), true)[0].ForeColor = Color.Black;
                }

                iptalKoltuk.Clear();
                MessageBox.Show(txtIptalBiletler.Text + " numaralı koltuk(lar) iptal edilmiştir.");
                txtIptalBiletler.Text = "";

                kayitli_bilet_bul();
                salon_doluluk();
            }
            else
                MessageBox.Show("İptal edilecek koltuk(ları) seçin.", "Uyarı!");
        }

        private void btnBiletAyar_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 24);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            myFont = new Font("Verdana", 17, FontStyle.Regular);
            e.Graphics.DrawString("Hcengiz Sinemaları", myFont, sbrush, 10, 10);

            myFont = new Font("Calibri", 10, FontStyle.Regular);
            e.Graphics.DrawString("-----------------------------------------------------------------", myFont, sbrush, 10, 50);
            e.Graphics.DrawString("Programlama ve Tasarım", myFont, sbrush, 10, 70);
            e.Graphics.DrawString("Kadıköy/İstanbul", myFont, sbrush, 10, 90);
            e.Graphics.DrawString("İletişim: (0216) 016 07 16", myFont, sbrush, 10, 110);
            e.Graphics.DrawString("-----------------------------------------------------------------", myFont, sbrush, 10, 130);

            myFont = new Font("Calibri", 15, FontStyle.Regular);

            e.Graphics.DrawString("Film:", myFont, sbrush, 10, 180);
            e.Graphics.DrawString(FilmORM.SecilenFilm, myFont, sbrush, 145, 180);

            e.Graphics.DrawString("Seans:", myFont, sbrush, 10, 205);
            e.Graphics.DrawString(SeansORM.SecilenSeans, myFont, sbrush, 145, 205);

            e.Graphics.DrawString("Salon:", myFont, sbrush, 10, 230);
            e.Graphics.DrawString(SalonORM.SecilenSalon, myFont, sbrush, 145, 230);

            e.Graphics.DrawString("Ad Soyad:", myFont, sbrush, 10, 255);
            e.Graphics.DrawString(txtAlici.Text, myFont, sbrush, 145, 255);

            e.Graphics.DrawString("Koltuklar:", myFont, sbrush, 10, 280);
            e.Graphics.DrawString(txtBiletler.Text, myFont, sbrush, 145, 280);

            e.Graphics.DrawString("Ücret:", myFont, sbrush, 10, 305);
            e.Graphics.DrawString(ucret + " TL", myFont, sbrush, 145, 305);

            e.Graphics.DrawString("Tarih:", myFont, sbrush, 10, 330);
            e.Graphics.DrawString(DateTime.Now.Date.ToShortDateString(), myFont, sbrush, 145, 330);
        }
    }
}
