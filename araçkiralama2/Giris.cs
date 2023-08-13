using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace araçkiralama2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Users WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text.Trim());
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);

            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
                frmAnaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreli Hatalı", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }
    }
}