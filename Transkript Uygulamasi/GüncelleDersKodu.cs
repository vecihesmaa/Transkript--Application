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
    public partial class GüncelleDersKodu : Form
    {
        public GüncelleDersKodu()
        {
            InitializeComponent();
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            Güncelle fr = new Güncelle();
            fr.derskod = txtGüncelleDersKodu.Text;
            fr.Show();
        }
    }
}
