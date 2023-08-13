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
    public partial class frmMüşteriEkle : Form
    {
        Araç_Kiralama arac_kiralama = new Araç_Kiralama();
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Musteriler(tc,adsoyad,telefon,adres,email) values (@tc,@adsoyad,@telefon,@adres,@email)";

            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", $"{comboBox1.Text} \n{txtAdres.Text}");
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            arac_kiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";



        }
    }
}
