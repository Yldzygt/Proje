using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersKod { get; set; }
        public string DersAd { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; } = new List<OgrenciDers>();
    }
}
