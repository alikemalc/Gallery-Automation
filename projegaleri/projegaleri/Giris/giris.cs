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
    public partial class giris : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");
        public giris()
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


        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select departman from personel1 where kullaniciadi=@n and sifre=@p", baglanti);
            cmd.Parameters.AddWithValue("@n", textBox1.Text);
            cmd.Parameters.AddWithValue("@p", textBox2.Text);
            //SqlCommand = new SqlCommand("Select Unvan from PersonelBilgi", baglanti);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    if (rd["departman"].ToString() == "0")
                    {

                        admin admin = new admin();
                        admin.Show();
                        this.Hide();
                    }

                    else if (rd["departman"].ToString() == "1")
                    {
                        anaekran frm = new anaekran();
                        frm.Show();
                        this.Hide();
                    }
                    else if (rd["departman"].ToString() == "2")
                    {
                        gecis frm = new gecis();
                        frm.Show();
                        this.Hide();
                    }    
                    else if (rd["departman"].ToString() == "3")
                    {
                        depogenel frm = new depogenel();
                        frm.Show();
                        this.Hide();
                    }
                    else if (rd["departman"].ToString() == "4")
                    {
                        mgenel frm = new mgenel();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        rd.Close();
                        MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2.PasswordChar.ToString() == "*")
            {
                textBox2.PasswordChar = char.Parse("\0");
                //button3.Text = "Gizle";
            }
            else
            {
                textBox2.PasswordChar = char.Parse("*");
                //button3.Text = "Göster";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifremiunutum frm = new sifremiunutum();
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = char.Parse("\0");
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = char.Parse("*");
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }
    }
}
