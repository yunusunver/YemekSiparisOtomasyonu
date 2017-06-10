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
    public partial class FirmaUyelik : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");
        public FirmaUyelik()
        {
            InitializeComponent();
        }

        private void uyeolbtn_Click(object sender, EventArgs e)
        {
            if (parolatxt.Text.Equals(parolatekrartxt.Text))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand("insert into Firma(username,sifre,firmaadi,sehir,email,telefon,adres) values(@username,@sifre,@firmaadi,@sehir,@email,@telefon,@adres)", conn);
                    command.Parameters.AddWithValue("@username", usernametxt.Text);
                    command.Parameters.AddWithValue("@sifre", parolatxt.Text);
                    command.Parameters.AddWithValue("@firmaadi", firmaaditxt.Text);
                    command.Parameters.AddWithValue("@sehir", sehirtxt.Text);
                    command.Parameters.AddWithValue("@email", emailtxt.Text);
                    command.Parameters.AddWithValue("@telefon", telefontxt.Text);
                    command.Parameters.AddWithValue("@adres", adrestxt.Text);

                    command.ExecuteNonQuery();
                    conn.Close();
                    label5.Visible = true;
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Lütfen farklı bir kullanıcı adı giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Parolalar eşleşmiyor.");

            }
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirmaUyelik_Load(object sender, EventArgs e)
        {

        }
    }
}
