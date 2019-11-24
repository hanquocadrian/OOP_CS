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
    public partial class FormL4B4 : Form
    {
        private List<CSinhVien> arrSV;
        private int ipos= -1;
        public FormL4B4()
        {
            InitializeComponent();
        }

        private void FormL4B4_Load(object sender, EventArgs e)
        {
            arrSV = new List<CSinhVien>();
            lblImg.Text = "";
            lblImg.Image = imageList1.Images[1];
            chkGT.Checked = true ;
        }

        private void chkGT_CheckedChanged(object sender, EventArgs e)
        {
            if(chkGT.Checked==true)
            {
                lblImg.Image = imageList1.Images[1];
                chkGT.Text = "Nam";
            }
            else
            {
                lblImg.Image = imageList1.Images[0];
                chkGT.Text = "Nữ";
            }
        }

        public void ClearInput()
        {
            txtMSV.Text = "";
            txtHT.Text = "";
            dtpNS.Value= DateTime.Now;
            txtT.Text = "";
            chkGT.Checked = true;
            txtML.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CSinhVien sv = new CSinhVien();
            sv.MSV = txtMSV.Text;
            sv.HT = txtHT.Text;
            sv.NS = dtpNS.Value;
            txtT.Text = sv.Tuoi().ToString();
            sv.GT = chkGT.Checked;
            sv.ML = txtML.Text;
            arrSV.Add(sv);
            ipos++;
            HienThiDSSV();
            ClearInput();
        }
        
        public void HienThiSV(int vitri)
        {
            CSinhVien sv = (CSinhVien)arrSV[vitri];
            txtMSV.Text = sv.MSV;
            txtHT.Text = sv.HT;
            dtpNS.Value = sv.NS;
            txtT.Text = sv.Tuoi().ToString();
            chkGT.Checked = sv.GT;
            lblImg.Image = (sv.GT == true ? imageList1.Images[1] : imageList1.Images[0]);
            txtML.Text = sv.ML;
        }

        public void HienThiDSSV()
        {
            lvwDSHS.Items.Clear();
            foreach(CSinhVien csv in arrSV)
            {
                ListViewItem li = lvwDSHS.Items.Add(csv.MSV);
                li.SubItems.Add(csv.HT);
                li.SubItems.Add(csv.NS.ToShortDateString());
                li.SubItems.Add(csv.GT == true ? "Nam" : "Nữ");
                li.SubItems.Add(csv.ML);
                li.SubItems.Add(csv.Tuoi().ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (arrSV.Count > 0)
            {
                arrSV.RemoveAt(ipos);
                ipos--;
                if (ipos < 0 && arrSV.Count <= 0) ClearInput();
                if (ipos < 0 && arrSV.Count > 0) ipos = 0;
                if (ipos >= 0)
                {
                    HienThiSV(ipos);
                }
                HienThiDSSV();
            }
            else
                MessageBox.Show("Hết Học Viên Để xóa.", "Error");

        }

        private void lvwDSHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(int j in lvwDSHS.SelectedIndices)
            {
                ipos = j;
                HienThiSV(ipos);
                break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CSinhVien sv = (CSinhVien)arrSV[ipos];
            sv.MSV = txtMSV.Text;
            sv.HT = txtHT.Text;
            sv.NS = dtpNS.Value;
            txtT.Text = sv.Tuoi().ToString();
            sv.GT = chkGT.Checked;
            sv.ML = txtML.Text;
            HienThiDSSV();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            ipos--;
            if (ipos < 0 && arrSV.Count > 0) ipos = 0;
            if(ipos>=0)
            {
                HienThiDSSV();
                HienThiSV(ipos);
                lvwDSHS.Items[ipos].Selected = true;
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            ipos++;
            if (ipos > arrSV.Count -1) ipos = arrSV.Count -1;
            if (ipos >= 0)
            {
                HienThiDSSV();
                HienThiSV(ipos);
                lvwDSHS.Items[ipos].Selected = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
