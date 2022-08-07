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
    public partial class depogenel : Form
    {
        public depogenel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Width == 206)
            {
                flowLayoutPanel1.Width = 65;
            }
            else
                flowLayoutPanel1.Width = 206;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goster1()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  * From kiralıkarac1";
            cmd.Connection = baglanti;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label5.Text = dt.Rows.Count.ToString();
        }

        private void goster()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  * From satilikarac1";
            cmd.Connection = baglanti;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label1.Text = dt.Rows.Count.ToString();
        }


        private void depogenel_Load(object sender, EventArgs e)
        {
            goster();
            goster1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            depoliste frm = new depoliste();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saracekle frm = new saracekle();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            karacekle frm = new karacekle();
            frm.Show();
        }
    }
}
