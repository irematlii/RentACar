using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace araçkiralama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int musteriId = 0;
        int aracId = 0;
        int gunSayisi = 0;
        float toplamTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            aracId = (int)cmbAraba.SelectedValue;
            musteriId = (int)cmbMusteri.SelectedValue;

            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True");
            connection.Open();

            SqlCommand komut3 = new SqlCommand($"Insert into Kiralamalar(AracId,MusteriId,DonusTarihi,Tutar) Values({aracId},{musteriId},@DonusTarihi,{float.Parse(lblToplamTutar.Text)})", connection);
            komut3.Parameters.AddWithValue("@DonusTarihi", dtpDonusTarihi.Value);

            komut3.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Araba Kiralandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void dtpDonusTarihi_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True");
            DateTime donusTarihi = DateTime.Parse(dtpDonusTarihi.Text);
            TimeSpan timeSpan = donusTarihi.Subtract(DateTime.Now);
            gunSayisi = timeSpan.Days;
            aracId = (int)cmbAraba.SelectedValue;


            connection.Open();
            SqlCommand komut2 = new SqlCommand($"Select kiraucreti from Araclar Where Id={aracId}", connection);
            SqlDataReader reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                toplamTutar = (gunSayisi * float.Parse(reader["kiraucreti"].ToString()));
            }
            connection.Close();

            lblToplamTutar.Text = toplamTutar.ToString();
            lblGunSayisi.Text = gunSayisi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMusteri.Items.Clear();
            cmbAraba.Items.Clear();


            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True");
            connection.Open();

            SqlCommand komut = new SqlCommand($"Select Id,tc,adsoyad from Musteriler Order By tc", connection);
            DataTable table = new DataTable();

            table.Load(komut.ExecuteReader());

            table.Columns.Add("TcAdSoyad", typeof(string), "tc + ' - ' + adsoyad");


            cmbMusteri.DataSource = table;
            cmbMusteri.ValueMember = "Id";
            cmbMusteri.DisplayMember = "TcAdSoyad";

            connection.Close();
            connection.Open();

            SqlCommand komut2 = new SqlCommand($"Select Id,plaka,marka,kiraucreti from Araclar Order By plaka", connection);
            DataTable table2 = new DataTable();

            table2.Load(komut2.ExecuteReader());

            table2.Columns.Add("Araba", typeof(string), "plaka + ' - ' + marka + ' - Fiyat : ' + kiraucreti + '₺'");


            cmbAraba.DataSource = table2;
            cmbAraba.ValueMember = "Id";
            cmbAraba.DisplayMember = "Araba";

            connection.Close();
        }
    }
}
