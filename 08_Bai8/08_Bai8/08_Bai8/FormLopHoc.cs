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
                    ListViewItem li = lvwDSHV.Items.Add(cr.SMalop);
                    li.SubItems.Add(cr.SKhoa);
                    li.SubItems.Add(cr.SHeDaoTao);
                }
            }
        }
        public void hienthiHV()
        {
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
                break;
            }
        }
    }
}
