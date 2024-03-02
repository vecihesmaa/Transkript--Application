using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisikdeneme
{
    public partial class Güncelle : Form
    {
        public Güncelle()
        {
            InitializeComponent();
        }
        public string derskod;
        baglanti bgl = new baglanti();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            lblGüncelle.Text = derskod;
            NpgsqlCommand komut = new NpgsqlCommand("Update tblders set derskodu=@p1,dersadi=@p2,ogretimuyesiadsoyad=@p3,donem=@p4,kredi=@p5,akts=@p6,dersharfnotu=@p7 where derskodu=@p8", bgl.conn());
            komut.Parameters.AddWithValue("@p1", NpgsqlDbType.Text).Value = txtDersKodu.Text;
            komut.Parameters.AddWithValue("@p2", NpgsqlDbType.Text).Value = txtDersAdi.Text;
            komut.Parameters.AddWithValue("@p3", NpgsqlDbType.Text).Value = txtOgretimUyesi.Text;
            komut.Parameters.AddWithValue("@p4", NpgsqlDbType.Text).Value = Convert.ToInt32(txtDonem.Text);
            komut.Parameters.AddWithValue("@p5", NpgsqlDbType.Text).Value = Convert.ToInt32(txtKredi.Text);
            komut.Parameters.AddWithValue("@p6", NpgsqlDbType.Text).Value = Convert.ToInt32(txtAKTS.Text);
            komut.Parameters.AddWithValue("@p7", NpgsqlDbType.Text).Value = txtDersHarfNotu.Text;
            komut.Parameters.AddWithValue("@p8", derskod);
            komut.ExecuteNonQuery();
            bgl.conn().Close();

            MessageBox.Show("Kaydınız Güncellenmiştir.");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Güncelle fr = new Güncelle();
            this.Close();
        }

        private void Güncelle_Load(object sender, EventArgs e)
        {
            lblGüncelle.Text = derskod;
            NpgsqlCommand komut = new NpgsqlCommand("select derskodu,dersadi,ogretimuyesiadsoyad,donem,kredi,akts,dersharfnotu from tblders where derskodu=@p1", bgl.conn());
            komut.Parameters.AddWithValue("@p1", derskod);
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblGüncelle.Text = dr[0] + " " + "|" + dr[1] + " " + "|" + dr[2] + " " + "|" + dr[3] + dr[4] + " " + "|" + dr[5] + " " + "|" + dr[6];
            }
            komut.Dispose();
            bgl.conn().Close();
        }
    }
}
