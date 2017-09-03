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
    public class FilmORM:ORMBase<Film>
    {
        public static string SecilenFilm { get; set; }

        public static int FilmIdBul()
        {
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_FilmIdBul_Select", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@FilmAdi", SecilenFilm);
            int FilmId = Convert.ToInt32(komut.ExecuteScalar());
            bag.Close();
            return FilmId;
        }
    }
}
