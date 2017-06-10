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
    public partial class Form1 : Form
    {
        FirmaUyelikBilgileriGuncelle firmauyelikguncelle = new FirmaUyelikBilgileriGuncelle();
        MusteriUyelik mu = new MusteriUyelik();
        FirmaUyelik fu = new FirmaUyelik();
        MusteriPaneli mP = new MusteriPaneli();
        Form3 form3 = new Form3();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (musteriradiobtn.Checked == true) {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand("select * from Musteri where username='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", conn);
                SqlDataReader dr;
                dr = command.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    mP.kullaniciadi = textBox1.Text;
                    this.Hide();
                    label2.Visible = false;

                    mP.Show();


                }
                else
                {
                    label2.Visible = true;
                }
                conn.Close();
            }
            else if (firmaradiobtn.Checked==true) {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand("select *from Firma where username='"+textBox1.Text+"' and sifre='"+textBox2.Text+"'",conn);
                SqlDataReader dr;
                dr = command.ExecuteReader();
                int count=0;
                while (dr.Read()) {
                    count += 1;
                }
                if (count == 1)
                {
                    form3.kullaniciadi = textBox1.Text;
                    this.Hide();
                    label2.Visible = false;
                    form3.Show();
                }
                else {
                    label2.Visible = true;
                }
                conn.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (musteriradiobtn.Checked==true) {
                this.Hide();
                mu.Show();
            }
            else if (firmaradiobtn.Checked==true) {
                this.Hide();
                fu.Show();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
