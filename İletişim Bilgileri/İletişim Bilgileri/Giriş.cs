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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source = DESKTOP-ATVNEGK; Initial Catalog = İletişimBilgileri; Integrated Security = True");

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand gir = new SqlCommand("Select * From Tbl_Giriş where KullanıcıAd=@a1 and Şifre=@a2", bağlantı);
            gir.Parameters.AddWithValue("@a1", TxtKAd.Text);
            gir.Parameters.AddWithValue("@a2", TxtŞifre.Text);
            SqlDataReader gg = gir.ExecuteReader();
            if (gg.Read())
            {
                AnaSayfa ff = new AnaSayfa();
                ff.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bağlantı.Close();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            Kaydol k = new Kaydol();
            k.Show();
            this.Hide();
        }
    }
}
