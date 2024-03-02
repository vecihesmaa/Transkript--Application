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
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void btnTranskriptGöster_Click(object sender, EventArgs e)
        {
            TRANSKRİPT.Items.Clear();
            NpgsqlCommand komut = new NpgsqlCommand("Select *from tblders", bgl.conn());
            NpgsqlDataReader reader = komut.ExecuteReader();    
            while(reader.Read())
            {
                TRANSKRİPT.Items.Add(reader[0]+"     " + reader[1]+"                                " + reader[2]+"                                     " + reader[3]+"           "+reader[4]+"            " + reader[5]+"            " + reader[6]);    
            }
            bgl.conn().Close();
        }
        private void btnGANOGoster_Click(object sender, EventArgs e)
        {

            using (var cmd = new NpgsqlCommand("SELECT kredi, dersharfnotu FROM tblders where dersharfnotu!='Girilmedi'", bgl.conn()))
            using (var reader = cmd.ExecuteReader())
            {
                double toplamalinankredi = 0;
                double toplamalinanharfnotu = 0;
                while (reader.Read())
                {
                    int kredi = (int)reader["kredi"];
                    string letterGrade = (string)reader["dersharfnotu"];
                    double harf_deger = 0;
                    switch (letterGrade)
                    {
                        case "AA": harf_deger = 4.0; break;
                        case "BA": harf_deger = 3.5; break;
                        case "BB": harf_deger = 3.0; break;
                        case "CB": harf_deger = 2.5; break;
                        case "CC": harf_deger = 2.0; break;
                        case "DC": harf_deger = 1.5; break;
                        case "DD": harf_deger = 1.0; break;
                        case "FF": harf_deger = 0.0; break;
                    }
                    toplamalinankredi += kredi;
                    toplamalinanharfnotu += kredi * harf_deger;
                }
                double GANO = toplamalinanharfnotu / toplamalinankredi;
                MessageBox.Show($"GANO (GPA): {GANO:F2}");
            }

            

        }
    }
}
