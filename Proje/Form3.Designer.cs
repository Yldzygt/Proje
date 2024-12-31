namespace Proje
{
    partial class Form3
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
            table = new DataGridView();
            lbl_ogrenci = new Label();
            btn_ogrenciders = new Button();
            lbldersler = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(77, 174);
            table.Name = "table";
            table.RowHeadersWidth = 62;
            table.Size = new Size(633, 250);
            table.TabIndex = 0;
            // 
            // lbl_ogrenci
            // 
            lbl_ogrenci.AutoSize = true;
            lbl_ogrenci.Location = new Point(77, 63);
            lbl_ogrenci.Name = "lbl_ogrenci";
            lbl_ogrenci.Size = new Size(59, 25);
            lbl_ogrenci.TabIndex = 1;
            lbl_ogrenci.Text = "label1";
            lbl_ogrenci.Click += lbl_ogrenci_Click;
            // 
            // btn_ogrenciders
            // 
            btn_ogrenciders.Location = new Point(238, 444);
            btn_ogrenciders.Name = "btn_ogrenciders";
            btn_ogrenciders.Size = new Size(321, 34);
            btn_ogrenciders.TabIndex = 2;
            btn_ogrenciders.Text = "Öğrencinin Derslerini Kaydet";
            btn_ogrenciders.UseVisualStyleBackColor = true;
            btn_ogrenciders.Click += btn_ogrenciders_Click;
            // 
            // lbldersler
            // 
            lbldersler.AutoSize = true;
            lbldersler.Location = new Point(77, 89);
            lbldersler.Name = "lbldersler";
            lbldersler.Size = new Size(59, 25);
            lbldersler.TabIndex = 3;
            lbldersler.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(lbldersler);
            Controls.Add(btn_ogrenciders);
            Controls.Add(lbl_ogrenci);
            Controls.Add(table);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table;
        private Label lbl_ogrenci;
        private Button btn_ogrenciders;
        private Label lbldersler;
    }
}