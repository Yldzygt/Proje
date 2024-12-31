namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpb_Ogrenciekle = new GroupBox();
            cmb_sinifsec = new ComboBox();
            btn_derssec = new Button();
            btn_bul = new Button();
            btn_kaydet = new Button();
            btn_güncelle = new Button();
            lbl_sinifsec = new Label();
            lbl_numara = new Label();
            lbl_soyad = new Label();
            lbl_ad = new Label();
            txt_numara = new TextBox();
            txt_soyad = new TextBox();
            txt_ad = new TextBox();
            grpb_Ogrenciekle.SuspendLayout();
            SuspendLayout();
            // 
            // grpb_Ogrenciekle
            // 
            grpb_Ogrenciekle.Controls.Add(cmb_sinifsec);
            grpb_Ogrenciekle.Controls.Add(btn_derssec);
            grpb_Ogrenciekle.Controls.Add(btn_bul);
            grpb_Ogrenciekle.Controls.Add(btn_kaydet);
            grpb_Ogrenciekle.Controls.Add(btn_güncelle);
            grpb_Ogrenciekle.Controls.Add(lbl_sinifsec);
            grpb_Ogrenciekle.Controls.Add(lbl_numara);
            grpb_Ogrenciekle.Controls.Add(lbl_soyad);
            grpb_Ogrenciekle.Controls.Add(lbl_ad);
            grpb_Ogrenciekle.Controls.Add(txt_numara);
            grpb_Ogrenciekle.Controls.Add(txt_soyad);
            grpb_Ogrenciekle.Controls.Add(txt_ad);
            grpb_Ogrenciekle.Location = new Point(111, 30);
            grpb_Ogrenciekle.Name = "grpb_Ogrenciekle";
            grpb_Ogrenciekle.Size = new Size(576, 390);
            grpb_Ogrenciekle.TabIndex = 0;
            grpb_Ogrenciekle.TabStop = false;
            grpb_Ogrenciekle.Text = "Öğrenci Ekleme";
            // 
            // cmb_sinifsec
            // 
            cmb_sinifsec.FormattingEnabled = true;
            cmb_sinifsec.Location = new Point(221, 174);
            cmb_sinifsec.Name = "cmb_sinifsec";
            cmb_sinifsec.Size = new Size(207, 33);
            cmb_sinifsec.TabIndex = 12;
            // 
            // btn_derssec
            // 
            btn_derssec.Location = new Point(97, 285);
            btn_derssec.Name = "btn_derssec";
            btn_derssec.Size = new Size(361, 34);
            btn_derssec.TabIndex = 11;
            btn_derssec.Text = "Ders Seçiniz";
            btn_derssec.UseVisualStyleBackColor = true;
            btn_derssec.Click += btn_derssec_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(339, 217);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(119, 62);
            btn_bul.TabIndex = 10;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(221, 217);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(112, 62);
            btn_kaydet.TabIndex = 9;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // btn_güncelle
            // 
            btn_güncelle.Location = new Point(97, 217);
            btn_güncelle.Name = "btn_güncelle";
            btn_güncelle.Size = new Size(118, 62);
            btn_güncelle.TabIndex = 8;
            btn_güncelle.Text = "Güncelle";
            btn_güncelle.UseVisualStyleBackColor = true;
            // 
            // lbl_sinifsec
            // 
            lbl_sinifsec.AutoSize = true;
            lbl_sinifsec.Location = new Point(111, 177);
            lbl_sinifsec.Name = "lbl_sinifsec";
            lbl_sinifsec.Size = new Size(104, 25);
            lbl_sinifsec.TabIndex = 7;
            lbl_sinifsec.Text = "Sınıf Seçiniz";
            // 
            // lbl_numara
            // 
            lbl_numara.AutoSize = true;
            lbl_numara.Location = new Point(166, 135);
            lbl_numara.Name = "lbl_numara";
            lbl_numara.Size = new Size(75, 25);
            lbl_numara.TabIndex = 6;
            lbl_numara.Text = "Numara";
            // 
            // lbl_soyad
            // 
            lbl_soyad.AutoSize = true;
            lbl_soyad.Location = new Point(161, 95);
            lbl_soyad.Name = "lbl_soyad";
            lbl_soyad.Size = new Size(80, 25);
            lbl_soyad.TabIndex = 5;
            lbl_soyad.Text = "Soy İsim";
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Location = new Point(196, 58);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(45, 25);
            lbl_ad.TabIndex = 4;
            lbl_ad.Text = "İsim";
            // 
            // txt_numara
            // 
            txt_numara.Location = new Point(247, 132);
            txt_numara.Name = "txt_numara";
            txt_numara.Size = new Size(150, 31);
            txt_numara.TabIndex = 2;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(247, 95);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(150, 31);
            txt_soyad.TabIndex = 1;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(247, 58);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(150, 31);
            txt_ad.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpb_Ogrenciekle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpb_Ogrenciekle.ResumeLayout(false);
            grpb_Ogrenciekle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpb_Ogrenciekle;
        private Button btn_derssec;
        private Button btn_bul;
        private Button btn_kaydet;
        private Button btn_güncelle;
        private Label lbl_sinifsec;
        private Label lbl_numara;
        private Label lbl_soyad;
        private TextBox txt_numara;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private RadioButton radioButton1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_ad;
        private ComboBox cmb_sinifsec;
    }
}
