using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08_Bai8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pcbClass_Click_1(object sender, EventArgs e)
        {
            FormLopHoc frmlop = new FormLopHoc();
            this.Hide();
            frmlop.ShowDialog();
            this.Close();
        }

        private void pcbStudent_Click_1(object sender, EventArgs e)
        {

        }

        private void pcbStudent_Click(object sender, EventArgs e)
        {
            FormHocVien frmhv = new FormHocVien();
            this.Hide();
            frmhv.ShowDialog();
            this.Close();
        }
    }
}
