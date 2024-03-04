
namespace AnaOkulu
{
    partial class frm_OgretmenSayfasi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_notlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sinifbilgi = new System.Windows.Forms.Label();
            this.txt_OgrTC = new System.Windows.Forms.TextBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_kullaniciad = new System.Windows.Forms.Label();
            this.lbl_sinif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_notlar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_sinifbilgi);
            this.groupBox1.Controls.Add(this.txt_OgrTC);
            this.groupBox1.Controls.Add(this.btn_güncelle);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(592, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ İŞLEMLERİ";
            // 
            // cmb_notlar
            // 
            this.cmb_notlar.FormattingEnabled = true;
            this.cmb_notlar.Location = new System.Drawing.Point(187, 118);
            this.cmb_notlar.Name = "cmb_notlar";
            this.cmb_notlar.Size = new System.Drawing.Size(121, 24);
            this.cmb_notlar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sınıfı :";
            // 
            // lbl_sinifbilgi
            // 
            this.lbl_sinifbilgi.AutoSize = true;
            this.lbl_sinifbilgi.Location = new System.Drawing.Point(165, 47);
            this.lbl_sinifbilgi.Name = "lbl_sinifbilgi";
            this.lbl_sinifbilgi.Size = new System.Drawing.Size(99, 16);
            this.lbl_sinifbilgi.TabIndex = 18;
            this.lbl_sinifbilgi.Text = "-----------------------";
            // 
            // txt_OgrTC
            // 
            this.txt_OgrTC.Location = new System.Drawing.Point(187, 81);
            this.txt_OgrTC.Name = "txt_OgrTC";
            this.txt_OgrTC.Size = new System.Drawing.Size(121, 22);
            this.txt_OgrTC.TabIndex = 17;
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(187, 184);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(120, 52);
            this.btn_güncelle.TabIndex = 13;
            this.btn_güncelle.Text = "NOT GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(48, 185);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(132, 51);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "NOT KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sınav Notu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Kimlik Numarası:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbl_kullaniciad
            // 
            this.lbl_kullaniciad.AutoSize = true;
            this.lbl_kullaniciad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciad.Location = new System.Drawing.Point(240, 24);
            this.lbl_kullaniciad.Name = "lbl_kullaniciad";
            this.lbl_kullaniciad.Size = new System.Drawing.Size(53, 20);
            this.lbl_kullaniciad.TabIndex = 2;
            this.lbl_kullaniciad.Text = "label1";
            // 
            // lbl_sinif
            // 
            this.lbl_sinif.AutoSize = true;
            this.lbl_sinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sinif.Location = new System.Drawing.Point(557, 24);
            this.lbl_sinif.Name = "lbl_sinif";
            this.lbl_sinif.Size = new System.Drawing.Size(53, 20);
            this.lbl_sinif.TabIndex = 3;
            this.lbl_sinif.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğretmenin Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(403, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Öğretmenin Sınıfı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_OgretmenSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_sinif);
            this.Controls.Add(this.lbl_kullaniciad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_OgretmenSayfasi";
            this.Text = "ÖĞRETMEN İŞLEMLERİ SAYFASI";
            this.Load += new System.EventHandler(this.frm_OgretmenSayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OgrTC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_kullaniciad;
        private System.Windows.Forms.Label lbl_sinif;
        private System.Windows.Forms.Label lbl_sinifbilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_notlar;
    }
}