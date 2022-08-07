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
    public partial class kiralikekle : Form
    {
        public kiralikekle()
        {
            InitializeComponent();
        }

        private void kiralikekle_Load(object sender, EventArgs e)
        {

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
        private void button4_Click(object sender, EventArgs e)
        {
            mgenel frm = new mgenel();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            TimeSpan toplam;
            toplam = DateTime.Parse(metroDateTime2.Text) - DateTime.Parse(metroDateTime1.Text);
            label4.Text = toplam.TotalDays.ToString();

            double fiyat1 = double.Parse(label4.Text);
            double fiyat = double.Parse(label5.Text);
            double sonuc = fiyat * fiyat1;
            bunifuMaterialTextbox6.Text = sonuc.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("İşlemi tamamlamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert INTO kiralama (personelno,aracno,müsterino,marka,model,alımtarihi,teslimtarihi,tutar) values (@pers,@arac,@mus,@mark,@mod,@al,@ver,@fiy)", baglanti);

                cmd.Parameters.AddWithValue("@pers", bunifuMaterialTextbox5.Text);
                cmd.Parameters.AddWithValue("@arac", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@mus", bunifuMaterialTextbox2.Text);
                cmd.Parameters.AddWithValue("@mark", bunifuMaterialTextbox3.Text);
                cmd.Parameters.AddWithValue("@mod", bunifuMaterialTextbox4.Text);
                cmd.Parameters.AddWithValue("@al", metroDateTime1.Text);
                cmd.Parameters.AddWithValue("@ver", metroDateTime2.Text);
                cmd.Parameters.AddWithValue("@fiy", bunifuMaterialTextbox6.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}