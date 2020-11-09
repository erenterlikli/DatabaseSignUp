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
    public partial class FrmDuzenle : Form
    {
        public FrmDuzenle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source = EREN\SQLEXPRESS; Initial Catalog = Giris; Integrated Security = True");

        private void Goster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from uye", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                listView1.Items.Clear();
                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku["id"].ToString();
                ekle.SubItems.Add(oku["kad"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void txtSign_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update uye set kad='" + txtUser.Text.ToString() + "',sifre='" + txtPass.Text.ToString() + "' where id=" + id + " ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            Goster();
        }


        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtUser.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtPass.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }
    }
}
