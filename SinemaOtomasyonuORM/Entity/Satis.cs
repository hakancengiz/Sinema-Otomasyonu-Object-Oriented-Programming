using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuORM.Entity
{
    public class Satis
    {
        public int Id { get; set; }
        public int FilmID { get; set; }
        public int SalonID { get; set; }
        public int SeansID { get; set; }
        public int YoneticiID { get; set; }
        public string AdSoyad { get; set; }
        public DateTime Tarih { get; set; }
        public int KoltukNo { get; set; }
        public decimal Ucret { get; set; }
    }
}
