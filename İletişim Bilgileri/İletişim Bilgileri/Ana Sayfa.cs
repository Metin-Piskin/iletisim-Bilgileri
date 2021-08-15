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

namespace İletişim_Bilgileri
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source = DESKTOP-ATVNEGK; Initial Catalog = İletişimBilgileri; Integrated Security = True");

        void temizle()
        {
            Txtİd.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            MskTel.Clear();
            TxtŞehir.Clear();
            TxtSemt.Clear();
            TxtAd.Focus();
        }
        void kaydet()
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_İletişimBilgileri(ad,soyad,tel,sehir,semt) values (@p1,@p2,@p3,@p4,@p5)", bağlantı);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTel.Text);
            komut.Parameters.AddWithValue("@p4", TxtŞehir.Text);
            komut.Parameters.AddWithValue("@p5", TxtSemt.Text);
            komut.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("İletişim Bilgisi Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void sil()
        {
            bağlantı.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_İletişimBilgileri where id=@k1", bağlantı);
            komutsil.Parameters.AddWithValue("@k1", Txtİd.Text);
            komutsil.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void güncelle()
        {
            bağlantı.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update Tbl_İletişimBilgileri Set ad=@a1,soyad=@a2,tel=@a3,sehir=@a4,semt=@a5 where id=@a6 ", bağlantı);
            komutgüncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", MskTel.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", TxtŞehir.Text);
            komutgüncelle.Parameters.AddWithValue("@a5", TxtSemt.Text);
            komutgüncelle.Parameters.AddWithValue("@a6", Txtİd.Text);
            komutgüncelle.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("İletişim Bilgileri Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void çifttık()
        {
            int seç = dataGridView1.SelectedCells[0].RowIndex;

            Txtİd.Text = dataGridView1.Rows[seç].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[seç].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[seç].Cells[2].Value.ToString();
            MskTel.Text = dataGridView1.Rows[seç].Cells[3].Value.ToString();
            TxtŞehir.Text = dataGridView1.Rows[seç].Cells[4].Value.ToString();
            TxtSemt.Text = dataGridView1.Rows[seç].Cells[5].Value.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // this.tbl_İletişimBilgileriTableAdapter.Fill(this.İletişimBilgileriDataSet.Tbl_İletişimBilgileri);
            // SqlConnection bağlantı = new SqlConnection("Data Source = DESKTOP-ATVNEGK; Initial Catalog = İletişimBilgileri; Integrated Security = True");
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_İletişimBilgileriTableAdapter.Fill(this.İletişimBilgileriDataSet.Tbl_İletişimBilgileri);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            çifttık();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
