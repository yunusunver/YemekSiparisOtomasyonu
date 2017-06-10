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
    public partial class MusteriPaneli : Form
    {
        public string deger,deger2;
        public int toplam = 0;
        
        MusteriUyelikBilgileriGuncelle guncelle = new MusteriUyelikBilgileriGuncelle();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");
        public string kullaniciadi { get; set; }
        public MusteriPaneli()
        {
            InitializeComponent();
        }

        private void MusteriPaneli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeYemekDataSet5.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.denemeYemekDataSet5.Menu);
            // TODO: This line of code loads data into the 'denemeYemekDataSet4.Firma' table. You can move, or remove it, as needed.
            this.firmaTableAdapter.Fill(this.denemeYemekDataSet4.Firma);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            String komut = "select distinct sehir from Firma";
            SqlCommand command = new SqlCommand(komut,conn);
            SqlDataReader dr=command.ExecuteReader();
            while (dr.Read()) {
                comboBox1.Items.Add(dr["sehir"].ToString());
            }
            conn.Close();

            KullaniciBilgileri(kullaniciadi);

        }

        public void tabloyuDoldur(string komut) {
            SqlCommand command = new SqlCommand(komut,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        public void ara(string arananSehir) {
            String komut;
            if (arananSehir.Equals("All"))
            {
                 komut = "select firmaadi,sehir,adres from Firma";
                 tabloyuDoldur(komut);
            }
            else {
                 komut = "select firmaadi,sehir,adres from Firma where sehir like '%"+arananSehir+"'";
                 tabloyuDoldur(komut);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "All")
            {
                ara("All");
            }
            else {
                string arananSehir = comboBox1.SelectedItem.ToString();
                ara(arananSehir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string firmaadi = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();

            string sorgu = "select menuismi, menufiyatı from Menu where menufirma like '%" + firmaadi + "%'";
            SqlCommand command = new SqlCommand(sorgu, conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        public void KullaniciBilgileri(string kullaniciadi) {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string komut = "select*from Musteri where username='"+kullaniciadi+"'";
            SqlCommand command = new SqlCommand(komut,conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read()) {
                kullaniciadilbl.Text = dr["username"].ToString();
                sifrelbl.Text = dr["sifre"].ToString();
                adlbl.Text = dr["ad"].ToString();
                soyadlbl.Text = dr["soyad"].ToString();
                emaillbl.Text = dr["email"].ToString();
                sehirlbl.Text = dr["sehir"].ToString();
                telefonlbl.Text = dr["telefon"].ToString();
                adreslbl.Text = dr["adres"].ToString();
            }
            conn.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            guncelle.username = kullaniciadilbl.Text;
            guncelle.ad = adlbl.Text;
            guncelle.soyad = soyadlbl.Text;
            guncelle.email = emaillbl.Text;
            guncelle.sehir = sehirlbl.Text;
            guncelle.telefon = telefonlbl.Text;
            guncelle.adres = adreslbl.Text;
            guncelle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select firmaadi from Firma where username='" + kullaniciadi + "'", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            String firmaadi = (String)command.ExecuteScalar();
            conn.Close();
            KullaniciBilgileri(kullaniciadi);
        }
        public string firmaAdiBul() {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string komut = "select firmaadi from Firma where username='" + kullaniciadi + "'";
            SqlCommand command = new SqlCommand(komut, conn);
            string firmaadi = (String)command.ExecuteScalar();
            conn.Close();
            return firmaadi;
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.ColumnCount = 2;
                dataGridView3.Columns[0].Name = "Menu Adı";
                dataGridView3.Columns[1].Name = "Menu Fiyatı";

                dataGridView3.Rows.Add(deger, deger2);
                int fiyatı = Int32.Parse(deger2);
                toplam = toplam + fiyatı;
                label2.Text = toplam.ToString();
            }
            catch (Exception hata) {

                MessageBox.Show("Lütfen en az bir menü seçiniz..!");
            }
            
        }

        private void siparisiverbtn_Click(object sender, EventArgs e)
        {
            string firma = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string siparisadi = "";
            for (int i=0;i<dataGridView3.Rows.Count;i++) {
                siparisadi += dataGridView3.Rows[i].Cells[0].Value+" , ";
            }
            string siparistarihi = DateTime.Now.ToString();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            String komut = "insert into siparis(siparisadi,siparistarihi,musteri,siparisfiyatı,firma) values(@siparisadi,@siparistarihi,@musteri,@siparisfiyatı,@firma)";
            SqlCommand command = new SqlCommand(komut,conn);
            command.Parameters.AddWithValue("@siparisadi",siparisadi);
            command.Parameters.AddWithValue("@siparistarihi",siparistarihi);
            command.Parameters.AddWithValue("@musteri",kullaniciadi);
            command.Parameters.AddWithValue("@siparisfiyatı",label2.Text);
            command.Parameters.AddWithValue("@firma",firma);
            

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Siparişiniz verildi. \n Müşteri:"+kullaniciadi +"\n Sipariş Adı:"+siparisadi+"\n Sipariş Tarihi :"+siparistarihi+"\n Firma :"+firma);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
           toplam = 0;
            label2.Text = toplam.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deger = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            deger2 = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
