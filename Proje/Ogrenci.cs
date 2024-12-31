using Microsoft.EntityFrameworkCore;


namespace Proje
{
   

    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public int Numara { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; } = new List<OgrenciDers>();
    }
}