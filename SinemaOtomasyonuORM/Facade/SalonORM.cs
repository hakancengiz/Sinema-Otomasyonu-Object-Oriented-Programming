using SinemaOtomasyonuORM.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuORM.Facade
{
    public class SalonORM:ORMBase<Salon>
    {
        public static string SecilenSalon { get; set; }

        public static int KontenjanBul()
        {
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_KontenjanBul_Select", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@SalonAdi", SecilenSalon);
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            int salon_kontenjan = Convert.ToInt32(oku[0].ToString());
            oku.Close();
            bag.Close();
            return salon_kontenjan;
        }

        public static int SalonIdBul()
        {
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_SalonIdBul_Select", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@SalonAdi", SecilenSalon);
            int SalonId = Convert.ToInt32(komut.ExecuteScalar());
            bag.Close();
            return SalonId;
        }
    }
}
