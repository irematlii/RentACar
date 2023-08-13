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
    public partial class frmAraçKayıt : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        public frmAraçKayıt()
        {
            InitializeComponent();
        }
        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Araclar(plaka,marka,yil,renk,km,yakit,kiraucreti,tarih,durum) values(@plaka,@marka,@yil,@renk,@km,@yakit,@kiraucreti,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text.ToUpper());
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renkcombo.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakıtcombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", float.Parse(Ücrettxt.Text));
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now);
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            arackiralama.ekle_sil_güncelle(komut2, cümle);

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }
        private void Sericombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
