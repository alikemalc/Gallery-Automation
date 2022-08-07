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
    public partial class kiralik : Form
    {
        public kiralik()
        {
            InitializeComponent();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            kiralikekle frm = new kiralikekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\kiralikaraclar\\araclar\\1.png");
            frm.label1.Text = label3.Text;
            frm.bunifuMaterialTextbox3.Text = label1.Text;
            frm.bunifuMaterialTextbox4.Text = label2.Text;
            frm.label5.Text = label10.Text;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\no4.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox5.Image;
            label13.Show();
            pictureBox2.Load("im_car1\\kiralikaraclar\\araclar\\1.png");
            pictureBox3.Load("im_car1\\kiralikaraclar\\araclar\\11.png");
            pictureBox4.Load("im_car1\\kiralikaraclar\\araclar\\111.png");
            pictureBox11.Load("im_car1\\kiralikaraclar\\3.png");
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label11.Text = String.Empty;
            label12.Text = String.Empty;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\s60g.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label3.Text = label3.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\s60ma.txt");
            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                label1.Text = label1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }

            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\s60mo.txt");
            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                label2.Text = label2.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\s60km.txt");
            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                label9.Text = label9.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
            StreamReader SR4 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\s60gu.txt");
            string metin4 = SR4.ReadLine();
            while (metin4 != null)
            {
                label10.Text = label10.Text + "\n" + metin4;
                metin4 = SR4.ReadLine();
            }
            StreamReader SR5 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\s60h.txt");
            string metin5 = SR5.ReadLine();
            while (metin5 != null)
            {
                label11.Text = label11.Text + "\n" + metin5;
                metin5 = SR5.ReadLine();
            }

            StreamReader SR6 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\s60a.txt");
            string metin6 = SR6.ReadLine();
            while (metin6 != null)
            {
                label12.Text = label12.Text + "\n" + metin6;
                metin6 = SR6.ReadLine();
            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox4.Image;
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            kiralikekle frm = new kiralikekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\kiralikaraclar\\araclar\\2.png");
            frm.label1.Text = label3.Text;
            frm.bunifuMaterialTextbox3.Text = label1.Text;
            frm.bunifuMaterialTextbox4.Text = label2.Text;
            frm.label5.Text = label10.Text;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\no5.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox6.Image;
            label13.Show();
            pictureBox2.Load("im_car1\\kiralikaraclar\\araclar\\2.png");
            pictureBox3.Load("im_car1\\kiralikaraclar\\araclar\\22.png");
            pictureBox4.Load("im_car1\\kiralikaraclar\\araclar\\222.png");
            pictureBox11.Load("im_car1\\kiralikaraclar\\4.png");
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label11.Text = String.Empty;
            label12.Text = String.Empty;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\camg.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label3.Text = label3.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\camma.txt");
            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                label1.Text = label1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }

            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\cammo.txt");
            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                label2.Text = label2.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\camkm.txt");
            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                label9.Text = label9.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
            StreamReader SR4 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\camgu.txt");
            string metin4 = SR4.ReadLine();
            while (metin4 != null)
            {
                label10.Text = label10.Text + "\n" + metin4;
                metin4 = SR4.ReadLine();
            }
            StreamReader SR5 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\camha.txt");
            string metin5 = SR5.ReadLine();
            while (metin5 != null)
            {
                label11.Text = label11.Text + "\n" + metin5;
                metin5 = SR5.ReadLine();
            }

            StreamReader SR6 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\cama.txt");
            string metin6 = SR6.ReadLine();
            while (metin6 != null)
            {
                label12.Text = label12.Text + "\n" + metin6;
                metin6 = SR6.ReadLine();
            }




        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e) {

            kiralikekle frm = new kiralikekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\kiralikaraclar\\araclar\\3.png");
            frm.label1.Text = label3.Text;
            frm.bunifuMaterialTextbox3.Text = label1.Text;
            frm.bunifuMaterialTextbox4.Text = label2.Text;
            frm.label5.Text = label10.Text;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\no6.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            kiralikekle frm = new kiralikekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\kiralikaraclar\\araclar\\6.png");
            frm.label1.Text = label3.Text;
            frm.bunifuMaterialTextbox3.Text = label1.Text;
            frm.bunifuMaterialTextbox4.Text = label2.Text;
            frm.label5.Text = label10.Text;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\no7.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            kiralikekle frm = new kiralikekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\kiralikaraclar\\araclar\\5.png");
            frm.label1.Text = label3.Text;
            frm.bunifuMaterialTextbox3.Text = label1.Text;
            frm.bunifuMaterialTextbox4.Text = label2.Text;
            frm.label5.Text = label10.Text;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\no8.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
        }



        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            kiralikekle frm = new kiralikekle();
            frm.Show();
            frm.pictureBox1.Load("im_car1\\kiralikaraclar\\araclar\\4.png");
            frm.label1.Text = label3.Text;
            frm.bunifuMaterialTextbox3.Text = label1.Text;
            frm.bunifuMaterialTextbox4.Text = label2.Text;
            frm.label5.Text = label10.Text;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\no9.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                frm.bunifuMaterialTextbox1.Text = frm.bunifuMaterialTextbox1.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox7.Image;
            label13.Show();
            pictureBox2.Load("im_car1\\kiralikaraclar\\araclar\\3.png");
            pictureBox3.Load("im_car1\\kiralikaraclar\\araclar\\33.png");
            pictureBox4.Load("im_car1\\kiralikaraclar\\araclar\\333.png");
            pictureBox11.Load("im_car1\\kiralikaraclar\\1.png");
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label11.Text = String.Empty;
            label12.Text = String.Empty;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\kia.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label3.Text = label3.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\kiama.txt");
            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                label1.Text = label1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }

            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\kiamo.txt");
            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                label2.Text = label2.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\kiakm.txt");
            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                label9.Text = label9.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
            StreamReader SR4 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\kiagu.txt");
            string metin4 = SR4.ReadLine();
            while (metin4 != null)
            {
                label10.Text = label10.Text + "\n" + metin4;
                metin4 = SR4.ReadLine();
            }
            StreamReader SR5 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\kiaha.txt");
            string metin5 = SR5.ReadLine();
            while (metin5 != null)
            {
                label11.Text = label11.Text + "\n" + metin5;
                metin5 = SR5.ReadLine();
            }

            StreamReader SR6 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\kiaa.txt");
            string metin6 = SR6.ReadLine();
            while (metin6 != null)
            {
                label12.Text = label12.Text + "\n" + metin6;
                metin6 = SR6.ReadLine();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox8.Image;
            label13.Show();
            pictureBox2.Load("im_car1\\kiralikaraclar\\araclar\\4.png");
            pictureBox3.Load("im_car1\\kiralikaraclar\\araclar\\44.png");
            pictureBox4.Load("im_car1\\kiralikaraclar\\araclar\\444.png");
            pictureBox11.Load("im_car1\\kiralikaraclar\\4.png");
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label11.Text = String.Empty;
            label12.Text = String.Empty;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\tesla.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label3.Text = label3.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\teslama.txt");
            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                label1.Text = label1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }

            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\teslamo.txt");
            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                label2.Text = label2.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\teslakm.txt");
            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                label9.Text = label9.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
            StreamReader SR4 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\teslag.txt");
            string metin4 = SR4.ReadLine();
            while (metin4 != null)
            {
                label10.Text = label10.Text + "\n" + metin4;
                metin4 = SR4.ReadLine();
            }
            StreamReader SR5 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\teslah.txt");
            string metin5 = SR5.ReadLine();
            while (metin5 != null)
            {
                label11.Text = label11.Text + "\n" + metin5;
                metin5 = SR5.ReadLine();
            }

            StreamReader SR6 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\teslaa.txt");
            string metin6 = SR6.ReadLine();
            while (metin6 != null)
            {
                label12.Text = label12.Text + "\n" + metin6;
                metin6 = SR6.ReadLine();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox9.Image;
            label13.Show();
            pictureBox2.Load("im_car1\\kiralikaraclar\\araclar\\5.png");
            pictureBox3.Load("im_car1\\kiralikaraclar\\araclar\\55.png");
            pictureBox4.Load("im_car1\\kiralikaraclar\\araclar\\555.png");
            pictureBox11.Load("im_car1\\kiralikaraclar\\5.png");
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label11.Text = String.Empty;
            label12.Text = String.Empty;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\rs7.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label3.Text = label3.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\rs7ma.txt");
            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                label1.Text = label1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }

            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\rs7mo.txt");
            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                label2.Text = label2.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\rs7km.txt");
            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                label9.Text = label9.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
            StreamReader SR4 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\rs7g.txt");
            string metin4 = SR4.ReadLine();
            while (metin4 != null)
            {
                label10.Text = label10.Text + "\n" + metin4;
                metin4 = SR4.ReadLine();
            }
            StreamReader SR5 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\rs7h.txt");
            string metin5 = SR5.ReadLine();
            while (metin5 != null)
            {
                label11.Text = label11.Text + "\n" + metin5;
                metin5 = SR5.ReadLine();
            }

            StreamReader SR6 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\rs7a.txt");
            string metin6 = SR6.ReadLine();
            while (metin6 != null)
            {
                label12.Text = label12.Text + "\n" + metin6;
                metin6 = SR6.ReadLine();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox10.Image;
            label13.Show();
            pictureBox2.Load("im_car1\\kiralikaraclar\\araclar\\6.png");
            pictureBox3.Load("im_car1\\kiralikaraclar\\araclar\\66.png");
            pictureBox4.Load("im_car1\\kiralikaraclar\\araclar\\666.png");
            pictureBox11.Load("im_car1\\kiralikaraclar\\5.png");
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label11.Text = String.Empty;
            label12.Text = String.Empty;

            StreamReader SR = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\nissan.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                label3.Text = label3.Text + "\n" + metin;
                metin = SR.ReadLine();
            }
            StreamReader SR1 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\nissanma.txt");
            string metin1 = SR1.ReadLine();
            while (metin1 != null)
            {
                label1.Text = label1.Text + "\n" + metin1;
                metin1 = SR1.ReadLine();
            }

            StreamReader SR2 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\nissanmo.txt");
            string metin2 = SR2.ReadLine();
            while (metin2 != null)
            {
                label2.Text = label2.Text + "\n" + metin2;
                metin2 = SR2.ReadLine();
            }

            StreamReader SR3 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\nissankm.txt");
            string metin3 = SR3.ReadLine();
            while (metin3 != null)
            {
                label9.Text = label9.Text + "\n" + metin3;
                metin3 = SR3.ReadLine();
            }
            StreamReader SR4 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\nissang.txt");
            string metin4 = SR4.ReadLine();
            while (metin4 != null)
            {
                label10.Text = label10.Text + "\n" + metin4;
                metin4 = SR4.ReadLine();
            }
            StreamReader SR5 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\nissanha.txt");
            string metin5 = SR5.ReadLine();
            while (metin5 != null)
            {
                label11.Text = label11.Text + "\n" + metin5;
                metin5 = SR5.ReadLine();
            }

            StreamReader SR6 = new StreamReader("C:\\Users\\CETIN\\Desktop\\proje\\projegaleri\\projegaleri\\bin\\Debug\\im_car1\\kiralikaraclar\\txt\\nissana.txt");
            string metin6 = SR6.ReadLine();
            while (metin6 != null)
            {
                label12.Text = label12.Text + "\n" + metin6;
                metin6 = SR6.ReadLine();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kiralik_Load(object sender, EventArgs e)
        {
            label13.Hide();
        }
    }
    }

