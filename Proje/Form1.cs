using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        private OgrenciDbContext DbContext;
        Ogrenci ogr;
        public Form1()
        {
            InitializeComponent();
            DbContext = new OgrenciDbContext();
        }

        private List<Sinif> tblSiniflar = new List<Sinif>();



        private void btn_kaydet_Click(object sender, EventArgs e)
        {


            
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            int numara = int.Parse(txt_numara.Text);
            var selectedItem = cmb_sinifsec.SelectedItem as Sinif;
            Sinif sinif = selectedItem;
            
            Ogrenci Ogr = new Ogrenci
            {
                Ad = ad,
                Soyad = soyad,
                Numara = numara,
                SinifId = sinif.SinifId
            };

            
            using (var context = new OgrenciDbContext())
            {
                context.tblOgrenciler.Add(Ogr); // Yeni kişiyi Kisiler tablosuna ekle
                context.SaveChanges(); // Değişiklikleri kaydet
                this.ogr = Ogr;
            }

            
            MessageBox.Show("Kişi başarıyla kaydedildi.");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    
                    var siniflar = context.tblSiniflar.ToList();

                    
                    cmb_sinifsec.DataSource = siniflar;
                    cmb_sinifsec.DisplayMember = "SinifAd";
                    cmb_sinifsec.ValueMember = "SinifId"; 
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (txt_numara.Text != string.Empty) num = int.Parse(txt_numara.Text);


            if (num <= 0)
            {
                MessageBox.Show("Numara tanınmadı");
                return;
            }

            //Veritabanı bağlantısı
            using (var context = new OgrenciDbContext())
            {
                
                var ogrenci = context.tblOgrenciler.FirstOrDefault(o => o.Numara == num); 

                if (ogrenci != null)
                {
                    txt_ad.Text = ogrenci.Ad;
                    txt_soyad.Text = ogrenci.Soyad;
                    
                    var Sinif = context.tblSiniflar.FirstOrDefault(s => s.SinifId == ogrenci.SinifId); 
                    if (Sinif != null)
                        cmb_sinifsec.SelectedItem = Sinif; 
                    this.ogr=ogrenci;
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                }
            }

        }

        private void btn_derssec_Click(object sender, EventArgs e)
        {
            if (ogr!=null)
            {
                Form3 frm3 = new Form3(ogr);
                frm3.Show();
                
            }
            
        }
    }
}
