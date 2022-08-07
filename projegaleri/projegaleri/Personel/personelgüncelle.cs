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
    public partial class personelgüncelle : Form
    {
        public personelgüncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
        }

        private void personelgüncelle_Load(object sender, EventArgs e)
        {
            
            this.personel1TableAdapter.Fill(this.projegaleri1DataSet2.personel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Güncellemek istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update personel1 set tcno='" + maskedTextBox1.Text + "',isim='" + textBox1.Text + "',soyisim='" + textBox2.Text + "',telefon='" + maskedTextBox2.Text + "',eposta='" + textBox8.Text + "',adres='" + textBox3.Text + "',departman='" + comboBox1.Text + "',maas='" + textBox4.Text + "',personelfotografi='" + textBox5.Text + "',isegiris_tarihi='" + maskedTextBox3.Text + "',kullaniciadi='" + textBox6.Text + "',sifre='" + textBox7.Text + "'where personelno='" + prsno.Text + "'", baglanti);


                cmd.ExecuteNonQuery();
                baglanti.Close();
                this.personel1TableAdapter.Fill(this.projegaleri1DataSet2.personel1);

            }
            else
            {
                MessageBox.Show("Başarısız", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }

            this.personel1TableAdapter.Fill(this.projegaleri1DataSet2.personel1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox5.Text = openFileDialog1.FileName;
        }
    }
}
