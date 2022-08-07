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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
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
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");

        private void goster1()
        {


            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select sum(stok)from kiralıkarac1", baglanti);
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label9.Text = dr5[0].ToString();
            }

            baglanti.Close();
        }





        private void goster()
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select sum(stoksayisi)from satilikarac1", baglanti);
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label7.Text = dr5[0].ToString();
            }

            baglanti.Close();
        }

        private void goster6()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  * From satis";
            cmd.Connection = baglanti;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label13.Text = dt.Rows.Count.ToString();
        }
        private void goster2()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  * From personel1";
            cmd.Connection = baglanti;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label2.Text = dt.Rows.Count.ToString();
        }

        private void goster3()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(isim) FROM musteri1", baglanti);
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label3.Text = dr5[0].ToString();
            }

            baglanti.Close();
        }

        private void goster5()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT  * From kiralama", baglanti);
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label25.Text = dr5[1].ToString();
            }

            baglanti.Close();
        }
        private void goster4()
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

        private void admin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TarihveSaat();
            goster();
            goster1();
            goster2();
            goster3();
            goster4();
            goster5();
            goster6();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TarihveSaat() {
            label14.Text = DateTime.Now.ToShortDateString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Width == 209)
            {
                flowLayoutPanel1.Width = 73;
            }
            else
                flowLayoutPanel1.Width = 209;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string saat = DateTime.Now.ToShortTimeString();

            label15.Text = saat;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            anaekran frm = new anaekran();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mgenel frm = new mgenel();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            depogenel frm = new depogenel();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            satis frm = new satis();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kiralik frm = new kiralik();
            frm.Show();
        }
    }
}
