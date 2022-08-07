using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projegaleri
{
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }

        private void satis_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e) {
            satisekle frm = new satisekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\1.png");
            
            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q8.txt");
            frm.label1.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.label1.Text = frm.label1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q8no.txt");
            
            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }
            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q8m.txt");
            
            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                frm.bunifuMaterialTextbox3.Text = frm.bunifuMaterialTextbox3.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q8f.txt");

            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                frm.bunifuMaterialTextbox4.Text = frm.bunifuMaterialTextbox4.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox1.Image;
            pictureBox9.Load("im_car1\\1.png");
            pictureBox10.Load("im_car1\\11.png");
            pictureBox11.Load("im_car1\\111.png");
            
            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q8.txt");
            label23.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label23.Text = label23.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

            label22.Text = label3.Text; 
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox9.Image;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox10.Image;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox11.Image;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e) 
        {
            satisekle frm = new satisekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\2.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\rs7.txt");
            frm.label1.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.label1.Text = frm.label1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\rs7no.txt");

            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }
            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\rs7m.txt");

            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                frm.bunifuMaterialTextbox3.Text = frm.bunifuMaterialTextbox3.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\rs7f.txt");

            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                frm.bunifuMaterialTextbox4.Text = frm.bunifuMaterialTextbox4.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox2.Image;
            pictureBox9.Load("im_car1\\2.png");
            pictureBox10.Load("im_car1\\22.png");
            pictureBox11.Load("im_car1\\222.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\rs7.txt");
            label23.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label23.Text = label23.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

            label22.Text = label4.Text;
        }
        private void pictureBox7_DoubleClick(object sender, EventArgs e) 
        {
            satisekle frm = new satisekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\6.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q7.txt");
            frm.label1.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.label1.Text = frm.label1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q7no.txt");

            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }
            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q7m.txt");

            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                frm.bunifuMaterialTextbox3.Text = frm.bunifuMaterialTextbox3.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q7f.txt");

            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                frm.bunifuMaterialTextbox4.Text = frm.bunifuMaterialTextbox4.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
        }
        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            satisekle frm = new satisekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\7.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a8.txt");
            frm.label1.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.label1.Text = frm.label1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a8no.txt");

            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }
            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a8m.txt");

            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                frm.bunifuMaterialTextbox3.Text = frm.bunifuMaterialTextbox3.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a8f.txt");

            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                frm.bunifuMaterialTextbox4.Text = frm.bunifuMaterialTextbox4.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
        }
        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            satisekle frm = new satisekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\5.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a7.txt");
            frm.label1.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.label1.Text = frm.label1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a7no.txt");

            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }
            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a7m.txt");

            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                frm.bunifuMaterialTextbox3.Text = frm.bunifuMaterialTextbox3.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a7f.txt");

            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                frm.bunifuMaterialTextbox4.Text = frm.bunifuMaterialTextbox4.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
        }
        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            satisekle frm = new satisekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\4.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a3.txt");
            frm.label1.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.label1.Text = frm.label1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a3no.txt");

            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }
            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a3m.txt");

            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                frm.bunifuMaterialTextbox3.Text = frm.bunifuMaterialTextbox3.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a3f.txt");

            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                frm.bunifuMaterialTextbox4.Text = frm.bunifuMaterialTextbox4.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
        }
        
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            satisekle frm = new satisekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\3.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a6.txt");
            frm.label1.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.label1.Text = frm.label1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a6no.txt");

            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }
            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a6m.txt");

            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                frm.bunifuMaterialTextbox3.Text = frm.bunifuMaterialTextbox3.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a6f.txt");

            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                frm.bunifuMaterialTextbox4.Text = frm.bunifuMaterialTextbox4.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox3.Image;
            pictureBox9.Load("im_car1\\3.png");
            pictureBox10.Load("im_car1\\33.png");
            pictureBox11.Load("im_car1\\333.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a6.txt");
            label23.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label23.Text = label23.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

            label22.Text = label7.Text;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox4.Image;
            pictureBox9.Load("im_car1\\4.png");
            pictureBox10.Load("im_car1\\44.png");
            pictureBox11.Load("im_car1\\444.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a3.txt");
            label23.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label23.Text = label23.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

            label22.Text = label10.Text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox5.Image;
            pictureBox9.Load("im_car1\\5.png");
            pictureBox10.Load("im_car1\\55.png");
            pictureBox11.Load("im_car1\\555.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a7.txt");
            label23.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label23.Text = label23.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

            label22.Text = label13.Text;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox6.Image;
            pictureBox9.Load("im_car1\\7.png");
            pictureBox10.Load("im_car1\\77.png");
            pictureBox11.Load("im_car1\\777.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\a8.txt");
            label23.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label23.Text = label23.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

            label22.Text = label16.Text;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox7.Image;
            pictureBox9.Load("im_car1\\6.png");
            pictureBox10.Load("im_car1\\66.png");
            pictureBox11.Load("im_car1\\666.png");

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\q7.txt");
            label23.Text = String.Empty;
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label23.Text = label23.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

            label22.Text = label19.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
