using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje
{

    public partial class Form2 : Form
    {
        private string Ad;
        private string Soyad;
        private string Numara;
        private string SinifAdi;


        public Form2(string Ad, string Soyad, string Numara, string SinifAdi)
        {
            InitializeComponent();
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Numara = Numara;
            this.SinifAdi = SinifAdi;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_ogrenciform_Click(object sender, EventArgs e)
        {
            Form1 ogrekleme = new Form1();
            ogrekleme.Show();
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            string DersKodu = txtderskod.Text;


            if (int.TryParse(DersKodu, out int ogrenciNumara))
            {
                using (var context = new OgrenciDbContext())
                {

                    var ders = context.Dersler
                                         .FirstOrDefault(d => d.DersKod == DersKodu.ToString());

                    if (ders != null)
                    {

                        txtdersad.Text = ders.DersAd;
                    }
                    else
                    {

                        MessageBox.Show("Öğrenci bulunamadı!");
                    }
                }
            }
        }
    }
}
