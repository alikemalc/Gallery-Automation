﻿using System;
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
    public partial class aracsil : Form
    {
        public aracsil()
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


        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silmek istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from satilikarac1 where aracno=@id", baglanti);
                cmd.Parameters.AddWithValue("@id", bunifuMaterialTextbox1.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();


            }
            else { MessageBox.Show("İşlemi iptal ettiniz"); }
        }
    }
}
