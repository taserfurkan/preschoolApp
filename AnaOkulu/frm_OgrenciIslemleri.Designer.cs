
namespace AnaOkulu
{
    partial class frm_OgrenciIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.cmb_sinif = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_KayitTarihi = new System.Windows.Forms.Label();
            this.lbl_DogumTarihi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_KullaniciAdi = new System.Windows.Forms.GroupBox();
            this.txt_OgretmenTC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btb_geri = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rich_adres = new System.Windows.Forms.RichTextBox();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_VeliTC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_OgrenciTCAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sill = new System.Windows.Forms.Button();
            this.txt_OgrTCSil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anaOkuluDataSet1 = new AnaOkulu.AnaOkuluDataSet1();
            this.anaOkuluDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.txt_KullaniciAdi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anaOkuluDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaOkuluDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_sinif
            // 
            this.cmb_sinif.FormattingEnabled = true;
            this.cmb_sinif.Location = new System.Drawing.Point(162, 235);
            this.cmb_sinif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_sinif.Name = "cmb_sinif";
            this.cmb_sinif.Size = new System.Drawing.Size(199, 30);
            this.cmb_sinif.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sınıfı";
            // 
            // lbl_KayitTarihi
            // 
            this.lbl_KayitTarihi.AutoSize = true;
            this.lbl_KayitTarihi.Location = new System.Drawing.Point(46, 202);
            this.lbl_KayitTarihi.Name = "lbl_KayitTarihi";
            this.lbl_KayitTarihi.Size = new System.Drawing.Size(101, 22);
            this.lbl_KayitTarihi.TabIndex = 5;
            this.lbl_KayitTarihi.Text = "Kayıt Tarihi";
            // 
            // lbl_DogumTarihi
            // 
            this.lbl_DogumTarihi.AutoSize = true;
            this.lbl_DogumTarihi.Location = new System.Drawing.Point(46, 166);
            this.lbl_DogumTarihi.Name = "lbl_DogumTarihi";
            this.lbl_DogumTarihi.Size = new System.Drawing.Size(118, 22);
            this.lbl_DogumTarihi.TabIndex = 3;
            this.lbl_DogumTarihi.Text = "Doğum Tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 374);
            this.dataGridView1.TabIndex = 4;
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Controls.Add(this.txt_OgretmenTC);
            this.txt_KullaniciAdi.Controls.Add(this.txt_VeliTC);
            this.txt_KullaniciAdi.Controls.Add(this.label7);
            this.txt_KullaniciAdi.Controls.Add(this.label6);
            this.txt_KullaniciAdi.Controls.Add(this.btb_geri);
            this.txt_KullaniciAdi.Controls.Add(this.dateTimePicker2);
            this.txt_KullaniciAdi.Controls.Add(this.dateTimePicker1);
            this.txt_KullaniciAdi.Controls.Add(this.cmb_sinif);
            this.txt_KullaniciAdi.Controls.Add(this.label2);
            this.txt_KullaniciAdi.Controls.Add(this.txt_TC);
            this.txt_KullaniciAdi.Controls.Add(this.label3);
            this.txt_KullaniciAdi.Controls.Add(this.rich_adres);
            this.txt_KullaniciAdi.Controls.Add(this.lbl_Adres);
            this.txt_KullaniciAdi.Controls.Add(this.btn_kaydet);
            this.txt_KullaniciAdi.Controls.Add(this.txt_Soyad);
            this.txt_KullaniciAdi.Controls.Add(this.txt_Ad);
            this.txt_KullaniciAdi.Controls.Add(this.label4);
            this.txt_KullaniciAdi.Controls.Add(this.lbl_KayitTarihi);
            this.txt_KullaniciAdi.Controls.Add(this.label5);
            this.txt_KullaniciAdi.Controls.Add(this.lbl_DogumTarihi);
            this.txt_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(14, 15);
            this.txt_KullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(411, 636);
            this.txt_KullaniciAdi.TabIndex = 6;
            this.txt_KullaniciAdi.TabStop = false;
            this.txt_KullaniciAdi.Text = "ÖĞRENCİ ";
            // 
            // txt_OgretmenTC
            // 
            this.txt_OgretmenTC.Location = new System.Drawing.Point(163, 436);
            this.txt_OgretmenTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OgretmenTC.Name = "txt_OgretmenTC";
            this.txt_OgretmenTC.Size = new System.Drawing.Size(199, 28);
            this.txt_OgretmenTC.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Öğretmen TC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Veli TC";
            // 
            // btb_geri
            // 
            this.btb_geri.Location = new System.Drawing.Point(46, 568);
            this.btb_geri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btb_geri.Name = "btb_geri";
            this.btb_geri.Size = new System.Drawing.Size(315, 48);
            this.btb_geri.TabIndex = 34;
            this.btb_geri.Text = "GERİ";
            this.btb_geri.UseVisualStyleBackColor = true;
            this.btb_geri.Click += new System.EventHandler(this.btb_geri_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(162, 198);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 28);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 28);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(162, 48);
            this.txt_TC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(199, 28);
            this.txt_TC.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "TC";
            // 
            // rich_adres
            // 
            this.rich_adres.Location = new System.Drawing.Point(162, 275);
            this.rich_adres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rich_adres.Name = "rich_adres";
            this.rich_adres.Size = new System.Drawing.Size(199, 115);
            this.rich_adres.TabIndex = 17;
            this.rich_adres.Text = "";
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Location = new System.Drawing.Point(46, 278);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(57, 22);
            this.lbl_Adres.TabIndex = 16;
            this.lbl_Adres.Text = "Adres";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(46, 501);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(315, 48);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(162, 122);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(199, 28);
            this.txt_Soyad.TabIndex = 8;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(162, 85);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(199, 28);
            this.txt_Ad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ad";
            // 
            // txt_VeliTC
            // 
            this.txt_VeliTC.Location = new System.Drawing.Point(162, 402);
            this.txt_VeliTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_VeliTC.Name = "txt_VeliTC";
            this.txt_VeliTC.Size = new System.Drawing.Size(199, 28);
            this.txt_VeliTC.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ara);
            this.groupBox2.Controls.Add(this.txt_OgrenciTCAra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_güncelle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(431, 659);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(435, 204);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Güncelle Penceresi";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(36, 111);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(168, 56);
            this.btn_ara.TabIndex = 3;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_OgrenciTCAra
            // 
            this.txt_OgrenciTCAra.Location = new System.Drawing.Point(200, 44);
            this.txt_OgrenciTCAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OgrenciTCAra.Name = "txt_OgrenciTCAra";
            this.txt_OgrenciTCAra.Size = new System.Drawing.Size(177, 31);
            this.txt_OgrenciTCAra.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "ÖĞRENCİ TC : ";
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(230, 111);
            this.btn_güncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(171, 56);
            this.btn_güncelle.TabIndex = 14;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sill);
            this.groupBox1.Controls.Add(this.txt_OgrTCSil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 659);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(411, 204);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Silme Penceresi";
            // 
            // btn_sill
            // 
            this.btn_sill.Location = new System.Drawing.Point(46, 128);
            this.btn_sill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sill.Name = "btn_sill";
            this.btn_sill.Size = new System.Drawing.Size(236, 40);
            this.btn_sill.TabIndex = 2;
            this.btn_sill.Text = "SİL";
            this.btn_sill.UseVisualStyleBackColor = true;
            this.btn_sill.Click += new System.EventHandler(this.btn_sill_Click);
            // 
            // txt_OgrTCSil
            // 
            this.txt_OgrTCSil.Location = new System.Drawing.Point(208, 48);
            this.txt_OgrTCSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OgrTCSil.Name = "txt_OgrTCSil";
            this.txt_OgrTCSil.Size = new System.Drawing.Size(173, 31);
            this.txt_OgrTCSil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ TC : ";
            // 
            // anaOkuluDataSet1
            // 
            this.anaOkuluDataSet1.DataSetName = "AnaOkuluDataSet1";
            this.anaOkuluDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anaOkuluDataSet1BindingSource
            // 
            this.anaOkuluDataSet1BindingSource.DataSource = this.anaOkuluDataSet1;
            this.anaOkuluDataSet1BindingSource.Position = 0;
            // 
            // frm_OgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 892);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_OgrenciIslemleri";
            this.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frm_OgrenciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.txt_KullaniciAdi.ResumeLayout(false);
            this.txt_KullaniciAdi.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anaOkuluDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaOkuluDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_KayitTarihi;
        private System.Windows.Forms.Label lbl_DogumTarihi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_sinif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rich_adres;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_OgrenciTCAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sill;
        private System.Windows.Forms.TextBox txt_OgrTCSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btb_geri;
        private System.Windows.Forms.BindingSource anaOkuluDataSet1BindingSource;
        private AnaOkuluDataSet1 anaOkuluDataSet1;
        private System.Windows.Forms.TextBox txt_OgretmenTC;
        private System.Windows.Forms.TextBox txt_VeliTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}