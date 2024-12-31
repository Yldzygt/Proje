namespace Proje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_güncelle = new Button();
            button3 = new Button();
            btn_ogrenciform = new Button();
            btn_bul = new Button();
            btn_ekle = new Button();
            txtderskod = new TextBox();
            txtdersad = new TextBox();
            lbldersad = new Label();
            lblderskod = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_güncelle);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btn_ogrenciform);
            groupBox1.Controls.Add(btn_bul);
            groupBox1.Controls.Add(btn_ekle);
            groupBox1.Controls.Add(txtderskod);
            groupBox1.Controls.Add(txtdersad);
            groupBox1.Controls.Add(lbldersad);
            groupBox1.Controls.Add(lblderskod);
            groupBox1.Location = new Point(162, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Ekleme";
            // 
            // btn_güncelle
            // 
            btn_güncelle.Location = new Point(18, 200);
            btn_güncelle.Name = "btn_güncelle";
            btn_güncelle.Size = new Size(112, 34);
            btn_güncelle.TabIndex = 9;
            btn_güncelle.Text = "Güncelle";
            btn_güncelle.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(63, 200);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_ogrenciform
            // 
            btn_ogrenciform.Location = new Point(136, 200);
            btn_ogrenciform.Name = "btn_ogrenciform";
            btn_ogrenciform.Size = new Size(112, 34);
            btn_ogrenciform.TabIndex = 7;
            btn_ogrenciform.Text = "Öğrenci Formu";
            btn_ogrenciform.UseVisualStyleBackColor = true;
            btn_ogrenciform.Click += btn_ogrenciform_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(254, 200);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(112, 34);
            btn_bul.TabIndex = 6;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(155, 148);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(58, 34);
            btn_ekle.TabIndex = 5;
            btn_ekle.Text = "Ekle";
            btn_ekle.TextAlign = ContentAlignment.MiddleRight;
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // txtderskod
            // 
            txtderskod.Location = new Point(109, 102);
            txtderskod.Name = "txtderskod";
            txtderskod.Size = new Size(150, 31);
            txtderskod.TabIndex = 4;
            // 
            // txtdersad
            // 
            txtdersad.Location = new Point(109, 56);
            txtdersad.Name = "txtdersad";
            txtdersad.Size = new Size(150, 31);
            txtdersad.TabIndex = 3;
            // 
            // lbldersad
            // 
            lbldersad.AutoSize = true;
            lbldersad.Location = new Point(18, 62);
            lbldersad.Name = "lbldersad";
            lbldersad.Size = new Size(76, 25);
            lbldersad.TabIndex = 1;
            lbldersad.Text = "Ders Ad";
            // 
            // lblderskod
            // 
            lblderskod.AutoSize = true;
            lblderskod.Location = new Point(9, 102);
            lblderskod.Name = "lblderskod";
            lblderskod.Size = new Size(85, 25);
            lblderskod.TabIndex = 2;
            lblderskod.Text = "Ders Kod";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbldersad;
        private Label lblderskod;
        private Button btn_ekle;
        private TextBox txtderskod;
        private TextBox txtdersad;
        private Button btn_güncelle;
        private Button button3;
        private Button btn_ogrenciform;
        private Button btn_bul;
    }
}