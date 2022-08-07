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
    public partial class saracekle : Form
    {
        public saracekle()
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


        private void saracekle_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
       
        
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
            bunifuMaterialTextbox17.Text = openFileDialog1.FileName;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Araç Eklemek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert INTO satilikarac1 (marka,seri,model,yil,yakit,vites,kasa,motorgucu,motorhacmi,cekis,renk,garanti,stoksayisi,gelisfiyati,satisfiyati,aracresmi) values (@mark,@ser,@mod,@yil,@yakit,@vites,@kasa,@motorg,@motorh,@cekis,@renk,@garanti,@stok,@gfiyat,@sfiyat,@resim)", baglanti);
                cmd.Parameters.AddWithValue("@mark", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@ser", bunifuMaterialTextbox2.Text);
                cmd.Parameters.AddWithValue("@mod", bunifuMaterialTextbox3.Text);
                cmd.Parameters.AddWithValue("@yil", bunifuMaterialTextbox4.Text);
                cmd.Parameters.AddWithValue("@yakit", bunifuMaterialTextbox5.Text);
                cmd.Parameters.AddWithValue("@vites", bunifuMaterialTextbox6.Text);
                cmd.Parameters.AddWithValue("@kasa", bunifuMaterialTextbox7.Text);
                //cmd.Parameters.AddWithValue("@motort", bunifuMaterialTextbox8.Text);
                cmd.Parameters.AddWithValue("@motorg", bunifuMaterialTextbox9.Text);
                cmd.Parameters.AddWithValue("@motorh", bunifuMaterialTextbox10.Text);
                cmd.Parameters.AddWithValue("@cekis", bunifuMaterialTextbox11.Text);
                cmd.Parameters.AddWithValue("@renk", bunifuMaterialTextbox12.Text);
                cmd.Parameters.AddWithValue("@garanti", bunifuMaterialTextbox13.Text);
                cmd.Parameters.AddWithValue("@stok", bunifuMaterialTextbox14.Text);
                cmd.Parameters.AddWithValue("@gfiyat", bunifuMaterialTextbox15.Text);
                cmd.Parameters.AddWithValue("@sfiyat", bunifuMaterialTextbox16.Text);
                cmd.Parameters.AddWithValue("@resim", bunifuMaterialTextbox17.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                

            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            baglanti.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double fiyat = double.Parse(bunifuMaterialTextbox15.Text);
            double sonuc = fiyat + fiyat * 20 / 100;
            bunifuMaterialTextbox16.Text = sonuc.ToString();
        }
    }
}
