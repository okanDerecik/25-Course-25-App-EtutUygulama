namespace EtutUygulama
{
    partial class Form1
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
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.CmbOgretmen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEtutId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOgrencid = new System.Windows.Forms.TextBox();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnDersEkle = new System.Windows.Forms.Button();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnFotograf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbBrans = new System.Windows.Forms.GroupBox();
            this.BtnOgretmenKaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CmbBrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnOlustur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.CmbOgretmen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.CmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(378, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(163, 205);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(148, 29);
            this.BtnOlustur.TabIndex = 5;
            this.BtnOlustur.Text = "Etüt Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(130, 155);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(63, 29);
            this.MskSaat.TabIndex = 4;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // CmbOgretmen
            // 
            this.CmbOgretmen.FormattingEnabled = true;
            this.CmbOgretmen.Location = new System.Drawing.Point(130, 78);
            this.CmbOgretmen.Name = "CmbOgretmen";
            this.CmbOgretmen.Size = new System.Drawing.Size(223, 30);
            this.CmbOgretmen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(130, 117);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(113, 29);
            this.MskTarih.TabIndex = 3;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(130, 39);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(223, 30);
            this.CmbDers.TabIndex = 1;
            this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEtutId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtOgrencid);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(411, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TxtEtutId
            // 
            this.TxtEtutId.Location = new System.Drawing.Point(116, 27);
            this.TxtEtutId.Name = "TxtEtutId";
            this.TxtEtutId.Size = new System.Drawing.Size(148, 29);
            this.TxtEtutId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Etüt id:";
            // 
            // TxtOgrencid
            // 
            this.TxtOgrencid.Location = new System.Drawing.Point(116, 73);
            this.TxtOgrencid.Name = "TxtOgrencid";
            this.TxtOgrencid.Size = new System.Drawing.Size(148, 29);
            this.TxtOgrencid.TabIndex = 7;
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.BackColor = System.Drawing.Color.Cyan;
            this.BtnEtutVer.Location = new System.Drawing.Point(116, 120);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(148, 29);
            this.BtnEtutVer.TabIndex = 8;
            this.BtnEtutVer.Text = "Etüt Ver";
            this.BtnEtutVer.UseVisualStyleBackColor = false;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(16, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDersEkle);
            this.groupBox4.Controls.Add(this.TxtDersAd);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(408, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 102);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // BtnDersEkle
            // 
            this.BtnDersEkle.BackColor = System.Drawing.Color.Cyan;
            this.BtnDersEkle.Location = new System.Drawing.Point(103, 53);
            this.BtnDersEkle.Name = "BtnDersEkle";
            this.BtnDersEkle.Size = new System.Drawing.Size(148, 32);
            this.BtnDersEkle.TabIndex = 10;
            this.BtnDersEkle.Text = "Ders Ekle";
            this.BtnDersEkle.UseVisualStyleBackColor = false;
            this.BtnDersEkle.Click += new System.EventHandler(this.BtnDersEkle_Click);
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(103, 18);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(148, 29);
            this.TxtDersAd.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ders Adı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MskTelefon);
            this.groupBox5.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox5.Controls.Add(this.TxtMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TxtSinif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TxtSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(719, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 269);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(90, 133);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(148, 29);
            this.MskTelefon.TabIndex = 14;
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.BackColor = System.Drawing.Color.Cyan;
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(90, 205);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(148, 32);
            this.BtnOgrenciEkle.TabIndex = 16;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = false;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(90, 170);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(148, 29);
            this.TxtMail.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefon:";
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(90, 98);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(148, 29);
            this.TxtSinif.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sınıf:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(90, 63);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(148, 29);
            this.TxtSoyad.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(90, 28);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(148, 29);
            this.TxtAd.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnFotograf);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(989, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 269);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // BtnFotograf
            // 
            this.BtnFotograf.BackColor = System.Drawing.Color.Cyan;
            this.BtnFotograf.Location = new System.Drawing.Point(42, 185);
            this.BtnFotograf.Name = "BtnFotograf";
            this.BtnFotograf.Size = new System.Drawing.Size(158, 49);
            this.BtnFotograf.TabIndex = 17;
            this.BtnFotograf.Text = "Fotoğraf Yükle";
            this.BtnFotograf.UseVisualStyleBackColor = false;
            this.BtnFotograf.Click += new System.EventHandler(this.BtnFotograf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CmbBrans
            // 
            this.CmbBrans.Controls.Add(this.BtnOgretmenKaydet);
            this.CmbBrans.Controls.Add(this.comboBox1);
            this.CmbBrans.Controls.Add(this.label13);
            this.CmbBrans.Controls.Add(this.TxtOgretmenSoyad);
            this.CmbBrans.Controls.Add(this.label14);
            this.CmbBrans.Controls.Add(this.TxtOgretmenAd);
            this.CmbBrans.Controls.Add(this.label15);
            this.CmbBrans.Location = new System.Drawing.Point(986, 290);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(238, 255);
            this.CmbBrans.TabIndex = 6;
            this.CmbBrans.TabStop = false;
            // 
            // BtnOgretmenKaydet
            // 
            this.BtnOgretmenKaydet.BackColor = System.Drawing.Color.Cyan;
            this.BtnOgretmenKaydet.Location = new System.Drawing.Point(77, 144);
            this.BtnOgretmenKaydet.Name = "BtnOgretmenKaydet";
            this.BtnOgretmenKaydet.Size = new System.Drawing.Size(148, 32);
            this.BtnOgretmenKaydet.TabIndex = 21;
            this.BtnOgretmenKaydet.Text = "Öğretmen Ekle";
            this.BtnOgretmenKaydet.UseVisualStyleBackColor = false;
            this.BtnOgretmenKaydet.Click += new System.EventHandler(this.BtnOgretmenKaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 30);
            this.comboBox1.TabIndex = 20;
         //  this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(10, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Branş:";
            // 
            // TxtOgretmenSoyad
            // 
            this.TxtOgretmenSoyad.Location = new System.Drawing.Point(77, 63);
            this.TxtOgretmenSoyad.Name = "TxtOgretmenSoyad";
            this.TxtOgretmenSoyad.Size = new System.Drawing.Size(148, 29);
            this.TxtOgretmenSoyad.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 22);
            this.label14.TabIndex = 22;
            this.label14.Text = "Soyad:";
            // 
            // TxtOgretmenAd
            // 
            this.TxtOgretmenAd.Location = new System.Drawing.Point(77, 28);
            this.TxtOgretmenAd.Name = "TxtOgretmenAd";
            this.TxtOgretmenAd.Size = new System.Drawing.Size(148, 29);
            this.TxtOgretmenAd.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(30, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 22);
            this.label15.TabIndex = 20;
            this.label15.Text = "Ad:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1233, 570);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CmbBrans.ResumeLayout(false);
            this.CmbBrans.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtOgrencid;
        private System.Windows.Forms.TextBox TxtEtutId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox CmbBrans;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOgretmenSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtOgretmenAd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnOgretmenKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

