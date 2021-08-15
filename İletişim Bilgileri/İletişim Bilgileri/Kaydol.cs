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
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source = DESKTOP-ATVNEGK; Initial Catalog = İletişimBilgileri; Integrated Security = True");
        void kaydol()
        {
            bağlantı.Open();
            SqlCommand kk = new SqlCommand("insert into Tbl_Giriş(KullanıcıAd,Şifre) values (@p1,@p2)", bağlantı);
            kk.Parameters.AddWithValue("@p1", TxtKAd.Text);
            kk.Parameters.AddWithValue("@p2", TxtŞifre.Text);
            kk.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Kayıdınız oluşturuldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Giriş g = new Giriş();
            g.Show();
            this.Hide();
        }
        private void BtnKaydol_Click(object sender, EventArgs e)
        {
            kaydol();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
