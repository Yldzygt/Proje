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
    public partial class Form3 : Form
    {
        private int ogrenciNumarasi;
        Ogrenci ogr;

        public Form3(Ogrenci ogr)
        {
            InitializeComponent();
            lbl_ogrenci.Text = $"AD:{ogr.Ad}\nSoyad: {ogr.Soyad}\n No:{ogr.Numara}";
            using (var context = new OgrenciDbContext())
            {
                table.DataSource = context.Dersler.ToList();
            }
            this.ogr = ogr; 
        }

        private void lbl_ogrenci_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {



            using (var context = new OgrenciDbContext())
            {
                var Dersler = context.Dersler.ToList();

                table.DataSource = Dersler;
            }


            table.Columns["DersKod"].HeaderText = "Ders Kod";
            table.Columns["DersAd"].HeaderText = "Ders Ad";

            table.Columns["DersId"].Visible = false;

            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.ReadOnly = true;
        }

        private void btn_ogrenciders_Click(object sender, EventArgs e)
        {
            using (var context=new OgrenciDbContext())
            {
                if (table.SelectedRows.Count > 0)
                {
                    var selectedRows = table.SelectedRows;
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        if (row != null)
                        {
                            Ders ders = row.DataBoundItem as Ders;
                            if (ders != null)
                            {
                                OgrenciDers dersKayit = new OgrenciDers()
                                {
                                    DersId = ders.DersId,
                                    OgrenciId = ogr.OgrenciId
                                };
                                context.OgrenciDers.Add(dersKayit);

                            }
                        }
                    }
                    context.SaveChanges();
                    MessageBox.Show("BAŞARILI");


                } 
            }
        }
    }
}

