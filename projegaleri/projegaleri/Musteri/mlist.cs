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
    public partial class mlist : Form
    {
        public mlist()
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





        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void mlist_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projegaleri1DataSet6.musteri1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri1TableAdapter.Fill(this.projegaleri1DataSet6.musteri1);
            // TODO: Bu kod satırı 'projegaleri1DataSet5.musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           /// this.musteriTableAdapter1.Fill(this.projegaleri1DataSet5.musteri);
            // TODO: Bu kod satırı 'projegaleri1DataSet4.musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.musteriTableAdapter.Fill(this.projegaleri1DataSet4.musteri);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = false;
            pictureBox3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmekle frm = new bmekle();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kmekle frm = new kmekle();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           
            bmgüncelle frm = new bmgüncelle();
            frm.Show();
            //personelgüncelle frm = new personelgüncelle();
            frm.bunifuMaterialTextbox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.bunifuMaterialTextbox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.bunifuMaterialTextbox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.bunifuMaterialTextbox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.bunifuMaterialTextbox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.metroComboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.metroComboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.bunifuMaterialTextbox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.bunifuMaterialTextbox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            this.musteri1TableAdapter.Fill(this.projegaleri1DataSet6.musteri1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmsil frm = new bmsil();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmsil frm = new bmsil();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            kmgüncelle frm = new kmgüncelle();
            frm.Show();
            //personelgüncelle frm = new personelgüncelle();
            frm.bunifuMaterialTextbox7.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            frm.bunifuMaterialTextbox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            frm.bunifuMaterialTextbox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            frm.bunifuMaterialTextbox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            frm.metroComboBox1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            frm.metroComboBox2.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            frm.bunifuMaterialTextbox6.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            frm.bunifuMaterialTextbox5.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            
           // this.musteri1TableAdapter.Fill(this.projegaleri1DataSet6.musteri1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.musteri1TableAdapter.Fill(this.projegaleri1DataSet6.musteri1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.musteri1TableAdapter.Fill(this.projegaleri1DataSet6.musteri1);
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            
            SqlDataAdapter ara = new SqlDataAdapter("Select * from musteri1 where kurumadi  like '%" + bunifuMaterialTextbox2.Text + "%'", baglanti);
           
            
            ara.Fill(tbl);
            
            baglanti.Close();
            dataGridView2.DataSource = tbl;
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            SqlDataAdapter ara = new SqlDataAdapter("Select * from musteri1 where isim  like '%" + bunifuMaterialTextbox1.Text + "%'", baglanti);


            ara.Fill(tbl);

            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }
    }
}

   
       





