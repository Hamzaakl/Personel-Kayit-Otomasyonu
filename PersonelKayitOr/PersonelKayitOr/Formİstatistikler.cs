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

namespace PersonelKayitOr
{
    public partial class Formİstatistikler : Form
    {
        public Formİstatistikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1KOVR18\\SQLEXPRESS;Initial Catalog=Personalveritabani;Integrated Security=True");
        private void Formİstatistikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            //toplam personel istatistik..//
            SqlCommand komut1= new SqlCommand("Select count(*) From Table_1 ",baglanti);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                lbltoplampersonel.Text = dr1[0].ToString();
            }

            //

            baglanti.Close();
            //Evli Pesonel sayısı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) From Table_1 where perDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {

                lblevlisayisi.Text=dr2[0].ToString();
            }


            baglanti.Close();



            //Bekar personel sayısı
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select count(*) From Table_1 Where perDurum=0 ", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekarsayisi.Text = dr3[0].ToString();
            }



            baglanti.Close();

            //sehir sayisi
            baglanti.Open ();
            SqlCommand komut4 = new SqlCommand("Select count(distinct(perSehir)) From Table_1 ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblsehirsayısı.Text = dr4[0].ToString();


            }

            baglanti.Close();


            //toplam maaş 
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(perMaas) From Table_1",baglanti);
            SqlDataReader dr5= komut5.ExecuteReader();

            while (dr5.Read())
            {
                lbltoplammaas.Text=dr5[0].ToString();   

            }

            baglanti.Close();

            //Ortalama maas
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(perMaas) From Table_1", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblortmaas.Text=dr6[0].ToString();
            }

            baglanti.Close();

        }







        private void lblevlisayısı_Click(object sender, EventArgs e)
        {

        }
    }
}
