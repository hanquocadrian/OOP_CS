using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormL4B1 frml4b1 = new FormL4B1();
            frml4b1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormL4B4 frml4b4 = new FormL4B4();
            frml4b4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BgMaTuY;
        }
    }
}
