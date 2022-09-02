using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace EtutUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-K0C08G8;Initial Catalog=EtutUygulama;Integrated Security=True");

        // Ders Listesi
        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DERSID";
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.DataSource = dt;
        }

        // Etüt Listesi

        void etutListesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Execute Etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                bool renk = Convert.ToBoolean(dt3.Rows[i]["DURUM"]);
                if (renk == true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        // Öğretmen Getir


        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
            dersListesi2();
           
        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {


            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRTID,(AD + ' '+SOYAD) as 'ÖĞRETMEN' From TBLOGRTMEN where BRANSID=" + CmbDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "ÖĞRETMEN";
            CmbOgretmen.DataSource = dt2;
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values(@k1,@k2,@k3,@k4)", baglanti);
            komut.Parameters.AddWithValue("@k1", CmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@k2", CmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@k3", MskTarih.Text);
            komut.Parameters.AddWithValue("@k4", MskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtEtutId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLETUT set OGRENCIID=@p1,DURUM=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtOgrencid.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", TxtEtutId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void BtnFotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSinif.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void dersListesi2()
        {
            SqlDataAdapter da5 = new SqlDataAdapter("Select * From TBLDERSLER", baglanti);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            comboBox1.ValueMember = "DERSID";
            comboBox1.DisplayMember = "DERSAD";
            comboBox1.DataSource = dt5;
        }

        bool derskontrol;
        bool ogretmenkontrol;

        void kontrolDers()
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from TBLDERSLER where DERSAD = @p1", baglanti);
            cmd2.Parameters.AddWithValue("@p1", TxtDersAd.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                derskontrol = false;
            }
            else
            {
                derskontrol = true;
            }
            baglanti.Close();
        }

        void kontrolOgretmen()
        {
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select * FROM TBLOGRTMEN WHERE AD=@o1 AND SOYAD=@o2", baglanti);
            cmd3.Parameters.AddWithValue("@o1", TxtOgretmenAd.Text);
            cmd3.Parameters.AddWithValue("@o2", TxtOgretmenSoyad.Text);
            SqlDataReader dr = cmd3.ExecuteReader();
            if (dr.Read())
            {
                ogretmenkontrol = false;
            }
            else
            {
                ogretmenkontrol = true;
            }
            baglanti.Close();
        }


        private void BtnDersEkle_Click(object sender, EventArgs e)
        {
            kontrolDers();
            if (derskontrol == true)
            {
                baglanti.Open();
                SqlCommand dersekle = new SqlCommand("INSERT INTO TBLDERSLER (DERSAD) VALUES (@q1)", baglanti);
                dersekle.Parameters.AddWithValue("q1", TxtDersAd.Text);
                dersekle.ExecuteNonQuery();
                MessageBox.Show("Ders Kaydedildi");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Ders Sisteme Kayıtlı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void BtnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            kontrolOgretmen();
            if (ogretmenkontrol == true)
            {
                baglanti.Open();
                SqlCommand ogrtekle = new SqlCommand("INSERT INTO TBLOGRTMEN (AD,SOYAD,BRANSID) VALUES (@a1,@a2,@a3)", baglanti);
                ogrtekle.Parameters.AddWithValue("@a1", TxtOgretmenAd.Text);
                ogrtekle.Parameters.AddWithValue("@a2", TxtOgretmenSoyad.Text);
                ogrtekle.Parameters.AddWithValue("@a3", comboBox1.SelectedValue);
                ogrtekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğretmen Kaydedildi");
            }
            else
            {
                MessageBox.Show("Bu Öğretmen Sistemde Mevcut.Lütfen Bilgileri Kontrol Ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
