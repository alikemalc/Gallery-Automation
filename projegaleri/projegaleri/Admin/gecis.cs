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
    public partial class gecis : Form
    {
        public gecis()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satis frm = new satis();
            frm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kiralik frm = new kiralik();
            frm.Show();
            
        }
    }
}
