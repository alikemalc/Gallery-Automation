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
    public partial class mgenel : Form
    {
        public mgenel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Width == 192)
            {
                flowLayoutPanel1.Width = 63;
            }
            else
                flowLayoutPanel1.Width = 192;
        }

        private void goster2()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(kurumadi) FROM musteri1", baglanti);
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label5.Text = dr5[0].ToString();
            }

            baglanti.Close();
        }


        private void goster1()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(isim) FROM musteri1", baglanti);
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label1.Text = dr5[0].ToString();
            }

            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            goster1();
            goster2();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToShortTimeString();

            label3.Text = saat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmekle frm = new bmekle();
            frm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kmekle frm = new kmekle();
            frm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mlist frm = new mlist();
            frm.Show();
        }
    }
}
