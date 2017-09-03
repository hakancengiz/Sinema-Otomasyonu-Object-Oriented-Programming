using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuORM
{
    public class Tools
    {
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                }
                return baglanti;
            }
        }

        public static void ParametreOlustur<T>(SqlCommand cmd, KomutTip kt, T ent)
        {   
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;
                if (kt == KomutTip.Insert && (name.ToLower() == "id" || name.ToLower() == "ıd"))
                {
                    continue;
                }
                else if (kt == KomutTip.Delete && name != "Id")
                {
                    continue; 
                }
                object value = pi.GetValue(ent); 
                cmd.Parameters.Add("@" + name, value);
            }
        }

        public static bool Exec(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }
    }
}
