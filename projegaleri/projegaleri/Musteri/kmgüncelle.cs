using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projegaleri
{
    public partial class kmgüncelle : Form
    {
        public kmgüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");

        OleDbConnection con;
        private void kmgüncelle_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=iller.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from iller ORDER BY id ASC ", con);
            da.Fill(dt);
            metroComboBox1.ValueMember = "id";
            metroComboBox1.DisplayMember = "sehir";
            metroComboBox1.DataSource = dt;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from ilceler where sehir = " + metroComboBox1.SelectedValue, con);
                da.Fill(dt);
                metroComboBox2.ValueMember = "id";
                metroComboBox2.DisplayMember = "ilce";
                metroComboBox2.DataSource = dt;
            }



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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Güncellemek istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update musteri1 set vergino='" + bunifuMaterialTextbox1.Text + "',kurumadi='" + bunifuMaterialTextbox2.Text + "',kurumtel='" + bunifuMaterialTextbox3.Text + "',il='" + metroComboBox1.Text + "',ilce='" + metroComboBox2.Text + "',adreskalan='" + bunifuMaterialTextbox6.Text + "',postakodu='" + bunifuMaterialTextbox5.Text + "'where müsterino='" + bunifuMaterialTextbox7.Text + "'", baglanti);


                cmd.ExecuteNonQuery();
                baglanti.Close();
               

            }
            else
            {
                MessageBox.Show("Başarısız", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
