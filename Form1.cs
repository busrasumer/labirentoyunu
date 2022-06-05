using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace merhaba_dünya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("tebrikler Kazandınız");
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettin... !!!");
        }
    }
}
