using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeritabanıGiriş
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=EREN\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True");



        private void txtSign_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql = "Select * from uye where kad=@kadi AND sifre=@pass";
                SqlParameter prm1 = new SqlParameter("kadi", txtUser.Text.Trim());
                SqlParameter prm2 = new SqlParameter("pass", txtPass.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglan);

                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    FrmAna frm = new FrmAna();
                    frm.Show();
                    this.Hide();
                }

                


            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalıdır!");
            }
        }
    }
}
