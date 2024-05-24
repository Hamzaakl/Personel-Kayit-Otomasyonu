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



namespace PersonelKayitOr
{
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1KOVR18\\SQLEXPRESS;Initial Catalog=Personalveritabani;Integrated Security=True");


        private void FormGrafikler_Load(object sender, EventArgs e)
        {   
            //grafik 1
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select perSehir,Count(*) From Table_1 Group by perSehir",baglanti);
            SqlDataReader dr1=komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0],dr1[1]);

            }


            baglanti.Close();

            //grafik 2
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select perMeslek,Avg(perMaas) From Table_1 Group by perMeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);

            }

            baglanti.Close();

        }
    }
}
