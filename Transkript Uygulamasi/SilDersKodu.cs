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
    public partial class SilDersKodu : Form
    {
        public SilDersKodu()
        {
            InitializeComponent();
        }

        public void btnGir_Click(object sender, EventArgs e)
        {
            DersSil fr=new DersSil();
            fr.derskod = txtSilDersKodu.Text;
            fr.Show();
        }
    }
}
