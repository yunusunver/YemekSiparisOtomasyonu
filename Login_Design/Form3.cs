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
    

    public partial class Form3 : Form
    {
        FirmaUyelikBilgileriGuncelle firmagüncelle = new FirmaUyelikBilgileriGuncelle();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");
        public string kullaniciadi { get; set; }
        public string menufirmasi;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeYemekDataSet6.Siparis' table. You can move, or remove it, as needed.
            this.siparisTableAdapter.Fill(this.denemeYemekDataSet6.Siparis);
            // TODO: This line of code loads data into the 'denemeYemekDataSet3.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.denemeYemekDataSet3.Menu);
            SqlCommand command = new SqlCommand("select firmaadi from Firma where username='"+kullaniciadi+"'",conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            String firmaadi= (String)command.ExecuteScalar();
            conn.Close();
            veriyiDoldur(firmaadi);
            kullaniciBilgileri(kullaniciadi);

            menufirmasi = firmaadi;

            siparisTablosuDoldur();
        }
        public void siparisTablosuDoldur() {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string komut = "select*from Siparis where firma='"+firmaadilbl.Text+"'";
            SqlCommand command = new SqlCommand(komut,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            conn.Close();


        }
        public void veriyiDoldur(string firmaAdi) {
            String komut = "select*from Menu where menufirma='"+firmaAdi+"'";
            SqlCommand command = new SqlCommand(komut,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void kullaniciBilgileri(string kullaniciadi) {
            String komut = "select * from Firma where username='"+kullaniciadi+"'";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand(komut,conn);
            SqlDataReader dr=command.ExecuteReader();
            while (dr.Read()) {
                usernamelbl.Text = dr["username"].ToString();
                firmaadilbl.Text = dr["firmaadi"].ToString();
                sehirlbl.Text = dr["sehir"].ToString();
                emaillbl.Text = dr["email"].ToString();
                telefonlbl.Text = dr["telefon"].ToString();
                adreslbl.Text = dr["adres"].ToString();
            }
            conn.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firmagüncelle.username = usernamelbl.Text;
            firmagüncelle.telefon = telefonlbl.Text;
            firmagüncelle.sehir = sehirlbl.Text;
            firmagüncelle.firmaadi = firmaadilbl.Text;
            firmagüncelle.adres = adreslbl.Text;
            firmagüncelle.email = emaillbl.Text;

            firmagüncelle.Show();
        }

        private void menuEklebtn_Click(object sender, EventArgs e)
        {
            MenuEkle menuekle = new MenuEkle();
            menuekle.menufirma = menufirmasi;
            menuekle.Show();
        }

        public void updateTable() {
            
            SqlCommand command = new SqlCommand("select*from Menu where menufirma='"+menufirmasi+"'",conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void menuSilbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
                string menuid = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sorgu = "delete from Menu where menuid='" + menuid + "'";
                SqlCommand command = new SqlCommand(sorgu, conn);
                command.ExecuteNonQuery();
                updateTable();
                conn.Close();
            }
            catch (Exception hata) {
                MessageBox.Show("hata = "+hata);
            }

        }

        private void yenilebtn_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void menuGuncellebtn_Click(object sender, EventArgs e)
        {
            menuDuzenle menuduzenle = new menuDuzenle();
            menuduzenle.Show();
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string menuid = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();
            menuduzenle.menuid = menuid;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select firmaadi from Firma where username='" + kullaniciadi + "'", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            String firmaadi = (String)command.ExecuteScalar();
            conn.Close();
            kullaniciBilgileri(kullaniciadi);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string adres;
            string musteri = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string komut="select * from Musteri where username='"+musteri+"'";
            SqlCommand command = new SqlCommand(komut,conn);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read()) {
                richTextBox1.Text = oku["adres"].ToString();
            }
            conn.Close();
            
        }
    }
}
