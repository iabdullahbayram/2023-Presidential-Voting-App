using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_Secimleri
{
    public partial class Sonuçlar : Form
    {
        public Sonuçlar()
        {
            InitializeComponent();
        }
        SqlConnection Veritabani = new SqlConnection("Data Source=DESKTOP-0SS6619\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Secim_2023");
        private void Sonuçlar_Load(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komutrte = new SqlCommand("select oy from Secim_2023_oy where isim='RTE'", Veritabani);
            SqlDataReader okuyucurte = komutrte.ExecuteReader();
            while (okuyucurte.Read())
            {
                labelrte.Text = okuyucurte[0].ToString();
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komutince = new SqlCommand("select oy from Secim_2023_oy where isim='INCE'", Veritabani);
            SqlDataReader okuyucuince = komutince.ExecuteReader();
            while (okuyucuince.Read())
            {
                labelince.Text = okuyucuince[0].ToString();
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komutogan = new SqlCommand("select oy from Secim_2023_oy where isim='OGAN'", Veritabani);
            SqlDataReader okuyucuogan = komutogan.ExecuteReader();
            while (okuyucuogan.Read())
            {
                labelogan.Text = okuyucuogan[0].ToString();
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komutkk = new SqlCommand("select oy from Secim_2023_oy where isim='KK'", Veritabani);
            SqlDataReader okuyucukk = komutkk.ExecuteReader();
            while (okuyucukk.Read())
            {
                labelkk.Text = okuyucukk[0].ToString();
            }
            Veritabani.Close();
            double rteyuzde;
            double kkyuzde;
            double inceyuzde;
            double oganyuzde;
            double oy1 = Convert.ToInt64(labelrte.Text);
            double oy2 = Convert.ToInt64(labelkk.Text);
            double oy3 = Convert.ToInt64(labelince.Text);
            double oy4 = Convert.ToInt64(labelogan.Text);
            rteyuzde = (oy1 * 100) / (oy1 + oy2 + oy3 + oy4);
            kkyuzde = (oy2 * 100) / (oy1 + oy2 + oy3 + oy4);
            inceyuzde = (oy3 * 100) / (oy1 + oy2 + oy3 + oy4);
            oganyuzde = (oy4 * 100) / (oy1 + oy2 + oy3 + oy4);

            labelrteyuzde.Text = rteyuzde.ToString("0.00");
            labeloganyuzde.Text = oganyuzde.ToString("0.00");
            labelkkyuzde.Text = kkyuzde.ToString("0.00");
            labelinceyuzde.Text = inceyuzde.ToString("0.00");

        }

        private void labelrte_Click(object sender, EventArgs e)
        {

        }
    }
}
