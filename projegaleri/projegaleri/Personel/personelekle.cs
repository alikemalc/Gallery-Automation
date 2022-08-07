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
    public partial class personelekle : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");
        public personelekle()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox5.Text = openFileDialog1.FileName;
        }

        private void personelekle_Load(object sender, EventArgs e)
        {
            this.personel1TableAdapter.Fill(this.projegaleri1DataSet2.personel1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Personel Eklemek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert INTO personel1 (tcno,isim,soyisim,telefon,eposta,adres,departman,maas,personelfotografi,isegiris_tarihi,kullaniciadi,sifre) values (@tc,@isim,@soyisim,@tel,@eposta,@adres,@depart,@maas,@foto,@tarih,@nick,@pass)", baglanti);
                cmd.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@isim", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
                cmd.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
                cmd.Parameters.AddWithValue("@eposta", textBox8.Text);
                cmd.Parameters.AddWithValue("@adres", textBox3.Text);
                cmd.Parameters.AddWithValue("@depart", comboBox1.Text);
                cmd.Parameters.AddWithValue("@maas", textBox4.Text);
                cmd.Parameters.AddWithValue("@foto", textBox5.Text);
                cmd.Parameters.AddWithValue("@tarih", maskedTextBox3.Text);
                cmd.Parameters.AddWithValue("@nick", textBox6.Text);
                cmd.Parameters.AddWithValue("@pass", textBox7.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                this.personel1TableAdapter.Fill(this.projegaleri1DataSet2.personel1);
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            baglanti.Close();
            this.personel1TableAdapter.Fill(this.projegaleri1DataSet2.personel1);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = false;
            pictureBox3.Visible = true;
        }
    }
}
