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


            // TextBox'lardan veriyi al
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            int numara = int.Parse(txt_numara.Text);
            var selectedItem = cmb_sinifsec.SelectedItem as Sinif;
            Sinif sinif = selectedItem;
            // Yeni bir Kisi nesnesi oluþtur
            Ogrenci Ogr = new Ogrenci
            {
                Ad = ad,
                Soyad = soyad,
                Numara = numara,
                SinifId = sinif.SinifId
            };

            // DbContext kullanarak veriyi ekle
            using (var context = new OgrenciDbContext())
            {
                context.tblOgrenciler.Add(Ogr); // Yeni kiþiyi Kisiler tablosuna ekle
                context.SaveChanges(); // Deðiþiklikleri kaydet
                this.ogr = Ogr;
            }

            // Kullanýcýya baþarý mesajý göster
            MessageBox.Show("Kiþi baþarýyla kaydedildi.");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    // Siniflar tablosundaki tüm sýnýf adlarýný alýyoruz
                    var siniflar = context.tblSiniflar.ToList();

                    // ComboBox’a sýnýf adlarýný ekliyoruz
                    cmb_sinifsec.DataSource = siniflar;
                    cmb_sinifsec.DisplayMember = "SinifAd"; // ComboBox'ta görünen sýnýf adý
                    cmb_sinifsec.ValueMember = "SinifId"; // Seçilen deðerin SinifId olduðunu belirtiyoruz
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
                MessageBox.Show("Numara tanýnmadý");
                return;
            }

            // Veritabaný baðlantýsýný açýyoruz ve gerekli iþlemi yapýyoruz
            using (var context = new OgrenciDbContext())
            {
                // Öðrencinin adý ve soyadýna göre sorgulama
                var ogrenci = context.tblOgrenciler.FirstOrDefault(o => o.Numara == num); // Ad ve Soyad eþleþtirme

                if (ogrenci != null)
                {
                    txt_ad.Text = ogrenci.Ad;
                    txt_soyad.Text = ogrenci.Soyad;
                    // Öðrenci bulunduysa, SinifId'sine baðlý olarak SinifAd'ý çekiyoruz
                    var Sinif = context.tblSiniflar.FirstOrDefault(s => s.SinifId == ogrenci.SinifId); // SinifAd bilgisi
                    if (Sinif != null)
                        cmb_sinifsec.SelectedItem = Sinif; // ComboBox'a SinifAd'ý set ediyoruz
                    this.ogr=ogrenci;
                }
                else
                {
                    MessageBox.Show("Öðrenci bulunamadý.");
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
