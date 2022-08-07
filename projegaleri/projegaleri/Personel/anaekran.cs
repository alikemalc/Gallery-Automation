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
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");




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

        private void goster1()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select sum(maas)from personel1", baglanti);
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label5.Text = dr5[0].ToString();
            }

            baglanti.Close();
        }






       private void goster()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  * From personel1";
            cmd.Connection = baglanti;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label1.Text = dt.Rows.Count.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projegaleri1DataSet3.personel1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel1TableAdapter.Fill(this.projegaleri1DataSet3.personel1);
            timer1.Enabled = true;
            goster();
            goster1();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Width == 203)
            {
                flowLayoutPanel1.Width = 65;
            }
            else
                flowLayoutPanel1.Width = 203;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelekle admin = new personelekle();
            admin.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToShortTimeString();

            label3.Text = saat;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel frm = new personel();

            frm.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelgüncelle admin = new personelgüncelle();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelsil admin = new personelsil();
            admin.Show();
        }
    }
}
