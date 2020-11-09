using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabanıGiriş
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSifDeg_Click(object sender, EventArgs e)
        {
            FrmDuzenle sifre = new FrmDuzenle();
            sifre.Show();
        }
    }
}
