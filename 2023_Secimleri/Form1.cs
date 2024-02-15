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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Veritabani = new SqlConnection("Data Source=DESKTOP-0SS6619\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Secim_2023");
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }
        
        private void buttonRte_Click(object sender, EventArgs e)
        {
            
            Veritabani.Open();
            SqlCommand komutrte = new SqlCommand("update Secim_2023_oy set oy=oy+1 where isim='RTE'", Veritabani);
            
            komutrte.ExecuteNonQuery();
            Veritabani.Close();
            MessageBox.Show("Oy Kullanıldı.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sonuçlar sonuclar = new Sonuçlar();
            sonuclar.Show();
            this.secim_2023_oyTableAdapter.Fill(this.dataSetSecim.Secim_2023_oy);
        }

        private void buttonince_Click(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komutince = new SqlCommand("update Secim_2023_oy set oy=oy+1 where isim='INCE'", Veritabani);

            komutince.ExecuteNonQuery();
            Veritabani.Close();
            MessageBox.Show("Oy Kullanıldı.");
        }

        private void buttonKk_Click(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komutkk = new SqlCommand("update Secim_2023_oy set oy=oy+1 where isim='KK'", Veritabani);

            komutkk.ExecuteNonQuery();
            Veritabani.Close();
            MessageBox.Show("Oy Kullanıldı.");
        }

        private void buttonOgan_Click(object sender, EventArgs e)
        {
            Veritabani.Open();
            SqlCommand komutogan = new SqlCommand("update Secim_2023_oy set oy=oy+1 where isim='OGAN'", Veritabani);

            komutogan.ExecuteNonQuery();
            Veritabani.Close();
            MessageBox.Show("Oy Kullanıldı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik();
            grafik.Show();
        }
    }
}
