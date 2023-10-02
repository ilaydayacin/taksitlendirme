using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksitlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int tutar, taksit;
            double borc;
            tutar=Convert.ToInt32(txtTutar.Text);
            taksit = Convert.ToInt32(cmbTaksit.Text);
            borc = tutar / taksit;
            lblBorc.Text = "Her ay Ödenecek tutar: " + borc.ToString();
        }
    }
}
