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
    public class YoneticiORM:ORMBase<Yonetici>
    {
        public static string AktifYoneticiAdi { get; set; }
        public static int AktifYoneticiId { get; set; }

        public static bool YoneticiGiris(string YoneticiAdi, string Parola)
        {
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_YoneticiGiris_Select", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@YoneticiAdi", YoneticiAdi);
            komut.Parameters.AddWithValue("@Parola", Parola);
            int YoneticiID = Convert.ToInt32(komut.ExecuteScalar());
            bag.Close();
            bool durum = (YoneticiID == 0 || YoneticiID.ToString() == null || YoneticiID.ToString() == "") ?  false : true;
            if (durum == true)
            {
                AktifYoneticiAdi = YoneticiAdi;
                AktifYoneticiId = YoneticiID;
            }
            return durum;
        }

        public static bool YoneticiSil(string YoneticiAdi, string Parola)
        {
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_YoneticiSil_Delete", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@YoneticiAdi", YoneticiAdi);
            komut.Parameters.AddWithValue("@YoneticiParola", Parola);
            int deger = komut.ExecuteNonQuery();
            bag.Close();
            bool durum = deger > 0 ? true : false;
            return durum;
        }
    }
}
