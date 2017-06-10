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
    public partial class MenuEkle : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");
        public string menufirma { get; set; }
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void MenuEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String komut = "insert into Menu(menufirma,menuismi,menufiyatı) values(@menufirma,@menuismi,@menufiyatı)";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand(komut,conn);
            command.Parameters.AddWithValue("@menufirma",menufirma);
            command.Parameters.AddWithValue("@menuismi",menuismitxt.Text);
            command.Parameters.AddWithValue("@menufiyatı",menufiyatitxt.Text);
            command.ExecuteNonQuery();
            conn.Close();
            eklendilbl.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
