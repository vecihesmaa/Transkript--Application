using Npgsql;
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
    public partial class DersSil : Form
    {
        public DersSil()
        {
            InitializeComponent();
        }
        public string derskod;

        baglanti bgl = new baglanti();

        private void button2_Click(object sender, EventArgs e)
        {
            DersSil fr=new DersSil();
            this.Close();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = derskod;
            NpgsqlCommand komut=new NpgsqlCommand("Delete from tblders where derskodu=@p1", bgl.conn());
            komut.Parameters.AddWithValue("@p1", derskod);
            komut.ExecuteNonQuery();
            bgl.conn().Close();

            MessageBox.Show("Kaydınız Silinmiştir.");

        }
     
        private void DersSil_Load(object sender, EventArgs e)
        {
            label1.Text = derskod;
            NpgsqlCommand komut = new NpgsqlCommand("select derskodu,dersadi,ogretimuyesiadsoyad,donem,kredi,akts,dersharfnotu from tblders where derskodu=@p1", bgl.conn());
            komut.Parameters.AddWithValue("@p1", derskod);
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0] + " " +"|"+ dr[1] + " " +"|" +dr[2] + " " +"|"+ dr[3] + dr[4] + " " +"|"+ dr[5] + " " +"|"+ dr[6] ;
            }
            komut.Dispose();
            bgl.conn().Close();
        }
      
    }
    }

