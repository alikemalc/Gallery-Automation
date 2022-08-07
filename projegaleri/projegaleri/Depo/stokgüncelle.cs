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
    public partial class stokgüncelle : Form
    {
        public stokgüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private void stokgüncelle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Güncellemek istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update satilikarac1 set stoksayisi='" + bunifuMaterialTextbox3.Text + "'where aracno='" + bunifuMaterialTextbox1.Text + "'", baglanti);


                cmd.ExecuteNonQuery();
                baglanti.Close();


            }
            else
            {
                MessageBox.Show("Başarısız", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
        }
    }
}
