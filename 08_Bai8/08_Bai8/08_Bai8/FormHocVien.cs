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
    public partial class FormHocVien : Form
    {
        private CdmHocVien xl;
        public FormHocVien()
        {
            InitializeComponent();
            xl = new CdmHocVien();
        }
        public void hienthi()
        {
            lvwHV.Items.Clear();
            if(xl.dmHocVien.Count>0)
            {
                foreach(CHocvien hv in xl.arrayHocVien)
                {
                    ListViewItem li = lvwHV.Items.Add(hv.SMaHV);
                    li.SubItems.Add(hv.SHoTen);
                    li.SubItems.Add(hv.DNgaySinh.ToShortDateString());
                    li.SubItems.Add(hv.BGioiTinh ? "Nam" : "Nữ");
                    li.SubItems.Add(hv.FDiem1.ToString());
                    li.SubItems.Add(hv.FDiem2.ToString());
                    li.SubItems.Add(hv.KetQua().ToString());
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHocvien hv = new CHocvien();
            hv.SMaHV = txtMaHV.Text;
            hv.SHoTen = txtHT.Text;
            hv.DNgaySinh = dtpNS.Value;
            hv.BGioiTinh = chkGT.Checked;
            hv.FDiem1 = float.Parse(txtD1.Text);
            hv.FDiem2 = float.Parse(txtD2.Text);
            txtKQ.Text = hv.KetQua();
            if(xl.them(hv))
                hienthi();
            else
                MessageBox.Show("Thêm bị lỗi.","Error");
        }
        public void hienthiHV(string ma)
        {
            CHocvien hv = xl.tim(ma);
            if(hv!=null)
            {
                txtMaHV.Text = hv.SMaHV;
                txtHT.Text = hv.SHoTen;
                dtpNS.Value = hv.DNgaySinh;
                chkGT.Checked = hv.BGioiTinh;
                txtD1.Text = hv.FDiem1.ToString();
                txtD1.Text = hv.FDiem1.ToString();
                txtKQ.Text = hv.KetQua().ToString();
            }
        }
        public void clearHV()
        {
            txtMaHV.Text = "";
            txtHT.Text = "";
            dtpNS.Value = DateTime.Now;
            chkGT.Checked = false;
            txtD1.Text = "";
            txtD1.Text = "";
            txtKQ.Text = "";
        }
        private void lvwHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int j in lvwHV.SelectedIndices)
            {
                hienthiHV(lvwHV.Items[j].Text);
                break;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (int j in lvwHV.SelectedIndices)
            {
                if (xl.xoa(lvwHV.Items[j].Text))
                    hienthi();
                else
                    MessageBox.Show("Xóa bị lỗi.");
                break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHocvien hv = new CHocvien();
            hv.SMaHV = txtMaHV.Text;
            hv.SHoTen = txtHT.Text;
            hv.DNgaySinh = dtpNS.Value;
            hv.BGioiTinh = chkGT.Checked;
            hv.FDiem1 = float.Parse(txtD1.Text);
            hv.FDiem2 = float.Parse(txtD2.Text);
            txtKQ.Text = hv.KetQua();
            if (xl.sua(hv))
                hienthi();
            else
                MessageBox.Show("Sửa bị lỗi.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkGT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGT.Checked)
                chkGT.Text = "Nam";
            else
                chkGT.Text = "Nữ";
        }
    }
}
