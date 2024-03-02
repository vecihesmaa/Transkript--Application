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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }


        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            EkleDersKodu fr=new EkleDersKodu();
            fr.Show();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            SilDersKodu fr=new SilDersKodu();
            fr.Show();
        }

        private void btnDersEkle_Click_1(object sender, EventArgs e)
        {
            {
                EkleDersKodu fr = new EkleDersKodu();
                fr.Show();
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            GüncelleDersKodu fr = new GüncelleDersKodu();
            fr.Show();
         
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            Transkript fr=new Transkript();
            fr.Show();
        }
    }
}
