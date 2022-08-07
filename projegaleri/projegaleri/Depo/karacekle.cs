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
    public partial class karacekle : Form
    {
        public karacekle()
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
        private void karacekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Araç Eklemek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert INTO kiralıkarac1 (marka,model,gunlukfiyat,haftalıkfiyat,aylıkfiyat,modelyili,motor,vites,yakıt,kasa,depozit,kasko,stok) values (@marka,@model,@gunlukfiyat,@haftalıkfiyat,@aylıkfiyat,@modelyili,@motor,@vites,@yakıt,@kasa,@depozit,@kasko,@stok)", baglanti);
                cmd.Parameters.AddWithValue("@marka", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@model", bunifuMaterialTextbox2.Text);
                cmd.Parameters.AddWithValue("@gunlukfiyat", bunifuMaterialTextbox3.Text);
                cmd.Parameters.AddWithValue("@haftalıkfiyat", bunifuMaterialTextbox4.Text);
                cmd.Parameters.AddWithValue("@aylıkfiyat", bunifuMaterialTextbox5.Text);
                cmd.Parameters.AddWithValue("@modelyili", bunifuMaterialTextbox6.Text);
                cmd.Parameters.AddWithValue("@motor", bunifuMaterialTextbox7.Text);
                //cmd.Parameters.AddWithValue("@motort", bunifuMaterialTextbox8.Text);
                cmd.Parameters.AddWithValue("@vites", bunifuMaterialTextbox9.Text);
                cmd.Parameters.AddWithValue("@yakıt", bunifuMaterialTextbox10.Text);
                cmd.Parameters.AddWithValue("@kasa", bunifuMaterialTextbox12.Text);
                cmd.Parameters.AddWithValue("@depozit", bunifuMaterialTextbox11.Text);
                cmd.Parameters.AddWithValue("@kasko", bunifuMaterialTextbox13.Text);
                cmd.Parameters.AddWithValue("@stok", bunifuMaterialTextbox14.Text);
               
                cmd.ExecuteNonQuery();
                baglanti.Close();



            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            baglanti.Close();
        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fiyat = double.Parse(bunifuMaterialTextbox3.Text);
            double sonuc = fiyat * 7;
            bunifuMaterialTextbox4.Text = sonuc.ToString();
            
            double fiyat1 = double.Parse(bunifuMaterialTextbox3.Text);
            double sonuc1 = fiyat1 * 30;
            bunifuMaterialTextbox5.Text = sonuc1.ToString();

        }
    }
}
