using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araçkiralama2
{
    public partial class Kiralamalar : Form
    {
        public Kiralamalar()
        {
            InitializeComponent();
        }

        private void Kiralamalar_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True");
            connection.Open();
            SqlCommand komut = new SqlCommand("Select a.plaka,m.adsoyad,m.telefon,k.DonusTarihi,k.Tutar from Kiralamalar k inner join Araclar a ON a.Id = k.AracId inner join Musteriler m ON m.Id = k.MusteriId ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
