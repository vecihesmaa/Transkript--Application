using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisikdeneme
{
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DersEkle fr = new DersEkle();
            this.Hide();
        }
        baglanti bgl = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("insert into tblders (derskodu,dersadi,ogretimuyesiadsoyad,donem,kredi,akts,dersharfnotu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.conn());
            komut.Parameters.AddWithValue("@p1", NpgsqlDbType.Text).Value = txtDersKodu.Text;
            komut.Parameters.AddWithValue("@p2", NpgsqlDbType.Text).Value = txtDersAdi.Text;
            komut.Parameters.AddWithValue("@p3", NpgsqlDbType.Text).Value = txtOgretimUyesi.Text;
            komut.Parameters.AddWithValue("@p4", NpgsqlDbType.Text).Value = Convert.ToInt32(txtDonem.Text);
            komut.Parameters.AddWithValue("@p5", NpgsqlDbType.Text).Value = Convert.ToInt32(txtKredi.Text);
            komut.Parameters.AddWithValue("@p6", NpgsqlDbType.Text).Value = Convert.ToInt32(txtAKTS.Text);
            komut.Parameters.AddWithValue("@p7", NpgsqlDbType.Text).Value = txtDersHarfNotu.Text;
            komut.ExecuteNonQuery();
            bgl.conn().Close();
            MessageBox.Show("Yeni Kayıt Gerçekleştirilmiştir.");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
