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
    public partial class satisekle : Form
    {
        public satisekle()
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




        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


       

        private void satisekle_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mgenel frm = new mgenel();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("İşlemi tamamlamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert INTO satis (personelno,aracno,marka,model,fiyat,müsterino,adet,tarih) values (@pers,@arac,@mark,@mod,@fiy,@müs,@adet,@tarih)", baglanti);
                
                cmd.Parameters.AddWithValue("@pers", bunifuMaterialTextbox5.Text);
                cmd.Parameters.AddWithValue("@arac", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@mark", bunifuMaterialTextbox2.Text);
                cmd.Parameters.AddWithValue("@mod", bunifuMaterialTextbox3.Text);
                cmd.Parameters.AddWithValue("@fiy", bunifuMaterialTextbox4.Text);
                cmd.Parameters.AddWithValue("@müs", bunifuMaterialTextbox6.Text);
                cmd.Parameters.AddWithValue("@adet", bunifuMaterialTextbox7.Text);
                cmd.Parameters.AddWithValue("@tarih", label2.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();

            }
        }
    }
}
