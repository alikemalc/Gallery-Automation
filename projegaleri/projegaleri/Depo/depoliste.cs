using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projegaleri
{
    public partial class depoliste : Form
    {
        public depoliste()
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



        private void depoliste_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projegaleri1DataSet11.kiralıkarac1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiralıkarac1TableAdapter1.Fill(this.projegaleri1DataSet11.kiralıkarac1);
            // TODO: Bu kod satırı 'projegaleri1DataSet10.kiralıkarac1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiralıkarac1TableAdapter.Fill(this.projegaleri1DataSet10.kiralıkarac1);
            // TODO: Bu kod satırı 'projegaleri1DataSet9.satilikarac1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satilikarac1TableAdapter1.Fill(this.projegaleri1DataSet9.satilikarac1);
            // TODO: Bu kod satırı 'projegaleri1DataSet8.satilikarac1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satilikarac1TableAdapter.Fill(this.projegaleri1DataSet8.satilikarac1);
            // TODO: Bu kod satırı 'projegaleri1DataSet7.satilikarac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saracekle frm = new saracekle();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.satilikarac1TableAdapter1.Fill(this.projegaleri1DataSet9.satilikarac1);
            stokgüncelle frm = new stokgüncelle();
            frm.Show();
            frm.bunifuMaterialTextbox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            frm.bunifuMaterialTextbox3.Text = dataGridView2.CurrentRow.Cells[13].Value.ToString();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fiyatgüncellecs frm = new fiyatgüncellecs();
            frm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            aracsil frm = new aracsil();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            karacekle frm = new karacekle();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            kfiyatgüncelle frm = new kfiyatgüncelle();
            frm.Show();
            frm.bunifuMaterialTextbox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.bunifuMaterialTextbox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.bunifuMaterialTextbox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.bunifuMaterialTextbox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.kiralıkarac1TableAdapter1.Fill(this.projegaleri1DataSet11.kiralıkarac1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            karacsil frm = new karacsil();
            frm.Show();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.satilikarac1TableAdapter1.Fill(this.projegaleri1DataSet9.satilikarac1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.kiralıkarac1TableAdapter1.Fill(this.projegaleri1DataSet11.kiralıkarac1);
        }
    }
}
