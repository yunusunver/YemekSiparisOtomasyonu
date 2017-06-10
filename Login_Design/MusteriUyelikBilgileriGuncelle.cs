using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Login_Design
{
    public partial class MusteriUyelikBilgileriGuncelle : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");
        public string username { get; set; }
        public string  password { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string email { get; set; }
        public string sehir { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }


        public MusteriUyelikBilgileriGuncelle()
        {
            InitializeComponent();
        }

        private void MusteriUyelikBilgileriGuncelle_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            String komut = "select sifre from Musteri where username='"+username+"'";
            SqlCommand command = new SqlCommand(komut,conn);
            password = (String)command.ExecuteScalar();
            kullaniciaditxt.Text = username;
            sifretxt.Text = password;
            adtxt.Text = ad;
            soyadtxt.Text = soyad;
            emailtxt.Text = email;
            sehirtxt.Text = sehir;
            telefontxt.Text = telefon;
            adrestxt.Text = adres;

            conn.Close();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            String komut = "update Musteri set sifre=@sifre,ad=@ad,soyad=@soyad,email=@email,sehir=@sehir,telefon=@telefon,adres=@adres where username='" + kullaniciaditxt.Text + "'";
            SqlCommand command = new SqlCommand(komut,conn);
            command.Parameters.AddWithValue("@sifre",sifretxt.Text);
            command.Parameters.AddWithValue("@ad",adtxt.Text);
            command.Parameters.AddWithValue("@soyad",soyadtxt.Text);
            command.Parameters.AddWithValue("@email",emailtxt.Text);
            command.Parameters.AddWithValue("@sehir",sehirtxt.Text);
            command.Parameters.AddWithValue("@telefon",telefontxt.Text);
            command.Parameters.AddWithValue("@adres",adrestxt.Text);
            command.ExecuteNonQuery();
            conn.Close();
            label9.Visible = true;
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
