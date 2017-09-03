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
    public class SeansORM:ORMBase<Seans>
    {
        public static string SecilenSeans { get; set; }

        public static int SeansIdBul()
        {
            SqlConnection bag = Tools.Baglanti;
            bag.Open();
            SqlCommand komut = new SqlCommand("prc_SeansIdBul_Select", bag);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@SeansSaati", SecilenSeans);
            int SeansId = Convert.ToInt32(komut.ExecuteScalar());
            bag.Close();
            return SeansId;
        }
    }
}
