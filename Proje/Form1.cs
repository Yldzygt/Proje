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
            // Yeni bir Kisi nesnesi olu�tur
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
                context.tblOgrenciler.Add(Ogr); // Yeni ki�iyi Kisiler tablosuna ekle
                context.SaveChanges(); // De�i�iklikleri kaydet
                this.ogr = Ogr;
            }

            // Kullan�c�ya ba�ar� mesaj� g�ster
            MessageBox.Show("Ki�i ba�ar�yla kaydedildi.");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    // Siniflar tablosundaki t�m s�n�f adlar�n� al�yoruz
                    var siniflar = context.tblSiniflar.ToList();

                    // ComboBox�a s�n�f adlar�n� ekliyoruz
                    cmb_sinifsec.DataSource = siniflar;
                    cmb_sinifsec.DisplayMember = "SinifAd"; // ComboBox'ta g�r�nen s�n�f ad�
                    cmb_sinifsec.ValueMember = "SinifId"; // Se�ilen de�erin SinifId oldu�unu belirtiyoruz
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
                MessageBox.Show("Numara tan�nmad�");
                return;
            }

            // Veritaban� ba�lant�s�n� a��yoruz ve gerekli i�lemi yap�yoruz
            using (var context = new OgrenciDbContext())
            {
                // ��rencinin ad� ve soyad�na g�re sorgulama
                var ogrenci = context.tblOgrenciler.FirstOrDefault(o => o.Numara == num); // Ad ve Soyad e�le�tirme

                if (ogrenci != null)
                {
                    txt_ad.Text = ogrenci.Ad;
                    txt_soyad.Text = ogrenci.Soyad;
                    // ��renci bulunduysa, SinifId'sine ba�l� olarak SinifAd'� �ekiyoruz
                    var Sinif = context.tblSiniflar.FirstOrDefault(s => s.SinifId == ogrenci.SinifId); // SinifAd bilgisi
                    if (Sinif != null)
                        cmb_sinifsec.SelectedItem = Sinif; // ComboBox'a SinifAd'� set ediyoruz
                    this.ogr=ogrenci;
                }
                else
                {
                    MessageBox.Show("��renci bulunamad�.");
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
