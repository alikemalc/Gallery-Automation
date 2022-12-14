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
    public partial class kmekle : Form
    {
        public kmekle()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");
        OleDbConnection con;
        private void kmekle_Load(object sender, EventArgs e)
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Müşteriyi eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert INTO musteri1 (vergino,kurumadi,kurumtel,il,ilce,adreskalan,postakodu) values (@ver,@ad,@tel,@il,@ilce,@adres,@posta)", baglanti);
                cmd.Parameters.AddWithValue("@ver", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@ad", bunifuMaterialTextbox2.Text);
                cmd.Parameters.AddWithValue("@tel", bunifuMaterialTextbox3.Text);                
                cmd.Parameters.AddWithValue("@il", metroComboBox1.Text);
                cmd.Parameters.AddWithValue("@ilce", metroComboBox2.Text);
                cmd.Parameters.AddWithValue("@adres", bunifuMaterialTextbox6.Text);
                cmd.Parameters.AddWithValue("@posta", bunifuMaterialTextbox5.Text);

                cmd.ExecuteNonQuery();
                baglanti.Close();

            }
        }

       
    }
}
