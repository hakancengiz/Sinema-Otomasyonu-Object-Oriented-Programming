using SinemaOtomasyonuORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuORM.Facade
{
    public class SatisORM : ORMBase<Satis>
    {
        public static List<string> KayitliBiletBul(int FilmID, int SalonID, int SeansID)
        {
            List<string> DoluKoltukNumaralari = new List<string>();
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_KayitliBiletBul_Select", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@FilmID", FilmID);
            komut.Parameters.AddWithValue("@SalonID", SalonID);
            komut.Parameters.AddWithValue("@SeansID", SeansID);
            komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string koltuk_No = oku[0].ToString();
                DoluKoltukNumaralari.Add(koltuk_No);
            }
            bag.Close();
            return DoluKoltukNumaralari;
        }

        public static void BiletIptal(int KoltukNo)
        {
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_BiletIptal_Delete", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@KoltukNo", KoltukNo);
            komut.ExecuteNonQuery();
            bag.Close();
        }

        //BU YÖNTEMİ KULLANMIYORUM ÇÜNKÜ ORMBASE'DEKİ INSERT METODUNU ÇALIŞTIRIYORUZ
        //public static void BiletSatis(int FilmID, int SalonID, int SeansID, string AdSoyad, int KoltukNo, decimal Ucret)
        //{
        //    SqlConnection bag = Tools.Baglanti;
        //    bag.Open();
        //    SqlCommand komut = new SqlCommand("prc_Satis_Insert", bag);
        //    komut.CommandType = CommandType.StoredProcedure;
        //    komut.Parameters.AddWithValue("@FilmID", FilmID);
        //    komut.Parameters.AddWithValue("@SalonID", SalonID);
        //    komut.Parameters.AddWithValue("@SeansID", SeansID);
        //    komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
        //    komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
        //    komut.Parameters.AddWithValue("@KoltukNo", KoltukNo);
        //    komut.Parameters.AddWithValue("@Ucret", Ucret);
        //    komut.ExecuteNonQuery();
        //    bag.Close();
        //}
    }
}
