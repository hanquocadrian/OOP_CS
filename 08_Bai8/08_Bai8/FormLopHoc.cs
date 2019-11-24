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
    public partial class FormLopHoc : Form
    {
        CdmLopHoc xllop;
        CdmHocVien xlhv;
        public FormLopHoc()
        {
            InitializeComponent();
            xllop = new CdmLopHoc();
            xlhv = new CdmHocVien();
            xlhv.Open();
            if (xlhv.dmHocVien.Count > 0)
                HienThiTatCaHV();
            xllop.Open();
            if (xllop.dmLop.Count > 0)
                hienthi();
        }

        public void HienThiTatCaHV()
        {
            lvwDSHV.Items.Clear();
            if (xlhv.dmHocVien.Count > 0)
            {
                foreach (CHocvien hv in xlhv.arrayHocVien)
                {
                    ListViewItem li = lvwDSHV.Items.Add(hv.SMaHV);
                    li.SubItems.Add(hv.SHoTen);
                    li.SubItems.Add(hv.DNgaySinh.ToShortDateString());
                    li.SubItems.Add(hv.BGioiTinh ? "Nam" : "Nữ");
                }
            }
        }
        public void hienthi()
        {
            lvwDSLH.Items.Clear();
            if (xllop.dmLop.Count > 0)
            {
                foreach (CLopHoc cr in xllop.arrayLophoc)
                {
                    ListViewItem li = lvwDSLH.Items.Add(cr.SMalop);
                    li.SubItems.Add(cr.SKhoa);
                    li.SubItems.Add(cr.SHeDaoTao);
                }
            }
        }
        public void hienthiHV()
        {
            lvwDSHVTL.Items.Clear();
            foreach (int j in lvwDSLH.SelectedIndices)
            {
                if (xllop.arrayLophoc[j].Dmhv.Count > 0)
                {
                    foreach (CHocvien hv in xllop.arrayLophoc[j].ArrayHocvien)
                    {
                        ListViewItem li = lvwDSHVTL.Items.Add(hv.SMaHV);
                        li.SubItems.Add(hv.SHoTen);
                        li.SubItems.Add(hv.DNgaySinh.ToShortDateString());
                        li.SubItems.Add(hv.BGioiTinh ? "Nam" : "Nữ");
                    }
                }
                break;
            }
        }

        public void hienthiLH(string malop)
        {
            CLopHoc cr = xllop.tim(malop);
            if(cr!=null)
            {
                txtMaL.Text = cr.SMalop;
                txtKhoa.Text = cr.SKhoa;
                txtHDT.Text = cr.SHeDaoTao;
            }
        }

        private void lvwDSLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int j in lvwDSLH.SelectedIndices)
            {
                hienthiLH(lvwDSLH.Items[j].Text);
                hienthiHV();
                break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CLopHoc cr = new CLopHoc();
            cr.SMalop = txtMaL.Text;
            cr.SKhoa = txtKhoa.Text;
            cr.SHeDaoTao = txtHDT.Text;
            if (xllop.them(cr))
                hienthi();
            else
                MessageBox.Show("Khong them lop dc");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(int j in lvwDSLH.SelectedIndices)
            {
                if(xllop.xoa(lvwDSLH.Items[j].Text))
                    hienthi();
                lvwDSHVTL.Items.Clear();
                break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CLopHoc cr = new CLopHoc();
            cr.SMalop = txtMaL.Text;
            cr.SKhoa = txtKhoa.Text;
            cr.SHeDaoTao = txtHDT.Text;
            if (xllop.sua(cr))
                hienthi();
            else
                MessageBox.Show("Khong sua lop dc");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            xllop.Save();
            FormMain frmm = new FormMain();
            this.Hide();
            frmm.ShowDialog();
            this.Close();
        }

        private void btnThemHSVL_Click(object sender, EventArgs e)
        {
            foreach (int i in lvwDSLH.SelectedIndices)
            {
                foreach (int j in lvwDSHV.SelectedIndices)
                {
                    CHocvien hv = xlhv.tim(lvwDSHV.Items[j].Text);
                    CLopHoc cr = xllop.tim(lvwDSLH.Items[i].Text);
                    cr.Dmhv.Add(hv.SMaHV, hv);
                    hienthiHV();
                    break;
                }
                break;
            }
        }

        private void btnXoaHSRL_Click(object sender, EventArgs e)
        {
            foreach (int i in lvwDSLH.SelectedIndices)
            {
                foreach (int j in lvwDSHVTL.SelectedIndices)
                {
                    CLopHoc cr = xllop.tim(lvwDSLH.Items[i].Text);
                    cr.Dmhv.Remove(lvwDSHVTL.Items[j].Text);
                    hienthiHV();
                    break;
                }
            }
        }
    }
}
