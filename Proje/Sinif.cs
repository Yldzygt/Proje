using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Sinif
    {
        public int SinifId { get; set; }
        public string SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }
}
