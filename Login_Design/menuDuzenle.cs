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
    public partial class menuDuzenle : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DenemeYemek;Integrated Security=True");
        public string menuid { get; set; }
        public menuDuzenle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "Update Menu set menuismi=@menuismi,menufiyatı=@menufiyatı where menuid='"+menuid+"'";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand(komut,conn);
            command.Parameters.AddWithValue("@menuismi",menuismitxt.Text);
            command.Parameters.AddWithValue("@menufiyatı",menufiyatitxt.Text);
            command.ExecuteNonQuery();
            conn.Close();
            kaydedildilbl.Visible = true;
        }

        private void menuDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
