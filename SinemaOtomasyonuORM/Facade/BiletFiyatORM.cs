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
    public class BiletFiyatORM:ORMBase<BiletFiyat>
    {
        public static decimal[] BiletFiyatlariBul()
        {
            decimal[] BiletFiyatlari = new decimal[2];

            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_BiletFiyatlariBul_Select", bag);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            BiletFiyatlari[0] = Convert.ToDecimal(oku[0].ToString());
            BiletFiyatlari[1] = Convert.ToDecimal(oku[1].ToString());
            oku.Close();
            bag.Close();
            return BiletFiyatlari;
        }
    }
}
