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
    public partial class FirmaUyelikBilgileriGuncelle : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");

        public string username { get; set; }
        public string firmaadi { get; set; }
        public string password { get;set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string sehir { get; set; }
        public FirmaUyelikBilgileriGuncelle()
        {
            InitializeComponent();
        }

        private void FirmaUyelikBilgileriGuncelle_Load(object sender, EventArgs e)
        {
            string komut = "select sifre from Firma where username='" + username + "'";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand(komut, conn);
            password = (String)command.ExecuteScalar();
            conn.Close();

            kullaniciaditxt.Text = username;
            passwordtxt.Text = password;
            firmaaditxt.Text = firmaadi;
            emailtxt.Text = email;
            telefontxt.Text = telefon;
            adrestxt.Text = adres;
            sehirtxt.Text = sehir;

            
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String komut = "update Firma set sifre=@sifre,sehir=@sehir,email=@email,telefon=@telefon,adres=@adres where username='"+kullaniciaditxt.Text+"'";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand(komut, conn);
                command.Parameters.AddWithValue("@sifre", passwordtxt.Text);
                command.Parameters.AddWithValue("@sehir", sehirtxt.Text);
                command.Parameters.AddWithValue("@email", emailtxt.Text);
                command.Parameters.AddWithValue("@telefon", telefontxt.Text);
                command.Parameters.AddWithValue("@adres", adrestxt.Text);

                command.ExecuteNonQuery();
                conn.Close();
                guncelledilbl.Visible = true;
            }
            catch (Exception hata) {
                MessageBox.Show("hata="+hata);
            }
            }
    }
}
