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
using System.Runtime.InteropServices;

namespace projegaleri
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ARBANV7\SQLEXPRESS;Initial Catalog=projegaleri1;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projegaleri1DataSet12.personel1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel1TableAdapter1.Fill(this.projegaleri1DataSet12.personel1);
            // TODO: Bu kod satırı 'projegaleri1DataSet2.personel1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel1TableAdapter.Fill(this.projegaleri1DataSet2.personel1);


            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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
            personelekle frm = new personelekle();
            frm.Show();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.personel1TableAdapter1.Fill(this.projegaleri1DataSet12.personel1);
            personelgüncelle frm = new personelgüncelle();
            frm.prsno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.textBox5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.textBox6.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm.textBox7.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            //textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            // this.personelTableAdapter2.Fill(this.projegaleri1DataSet1.personel);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.personel1TableAdapter1.Fill(this.projegaleri1DataSet12.personel1);
            personelsil frm = new personelsil();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            personelgüncelle frm = new personelgüncelle();
            frm.Show();
            //personelgüncelle frm = new personelgüncelle();
            frm.prsno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.textBox5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.textBox6.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm.textBox7.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            //textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            this.personel1TableAdapter1.Fill(this.projegaleri1DataSet12.personel1);
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



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter2.Fill(this.projegaleri1DataSet1.personel);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.personel1TableAdapter1.Fill(this.projegaleri1DataSet12.personel1);
        }

        private void AutoSizeRowsMode(Object sender, EventArgs es)
        {
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select * from personel1 where personelno  like '%" + textBox1.Text + "%'", baglanti);            
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            anaekran frm = new anaekran();
            frm.Show();
        
        }
    } 
}


        
    


    
    
    




