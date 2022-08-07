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

namespace projegaleri
{
    public partial class sifremiunutum : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");
        public sifremiunutum()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show( "Şifrenizi değişitmek istiyor musunuz?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update personel1 set sifre='" + textBox2.Text + "' where personelno='" + textBox1.Text + "'", baglanti);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı", "",MessageBoxButtons.OK, MessageBoxIcon.Information);         
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Başarısız", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }
    }
}
