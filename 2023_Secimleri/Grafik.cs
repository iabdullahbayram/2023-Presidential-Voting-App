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

namespace _2023_Secimleri
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlConnection Veritabani = new SqlConnection("Data Source=DESKTOP-0SS6619\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Secim_2023");
        private void Grafik_Load(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komutgrafik = new SqlCommand("select isim,oy,count(*) from Secim_2023_oy group by isim,oy",Veritabani);
            SqlDataReader okuyucu = komutgrafik.ExecuteReader();
            while (okuyucu.Read())
            {
                chart1.Series["Seçim"].Points.AddXY(okuyucu[0], okuyucu[1]);
            }
            Veritabani.Close();

            Veritabani.Open();
            SqlCommand komutgrafik2 = new SqlCommand("select isim,oy,count(*) from Secim_2023_oy group by isim,oy", Veritabani);
            SqlDataReader okuyucu2 = komutgrafik2.ExecuteReader();
            while (okuyucu2.Read())
            {
                chart2.Series["Seçim"].Points.AddXY(okuyucu2[0], okuyucu2[1]);
            }
            Veritabani.Close();
            

        }
    }
}
