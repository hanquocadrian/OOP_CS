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
    public partial class FormL4B1 : Form
    {
        //Khai báo DS HV (List<CHV>)
        private List<CHocVien> arrHV;
        //Vị trí hiện tại.
        private int ipos = -1;  
        private void FormL4B1_Load(object sender, EventArgs e)
        {
            //Cho DS HV hoạt động khi CT chạy
            arrHV = new List<CHocVien>();
            chkGT.Checked = true;
        }
        #region Ko SD 
       
        public FormL4B1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
       
        #endregion        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGT.Checked == true)
                chkGT.Text = "Nam";
            else
                chkGT.Text = "Nữ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Nhập 1 hv vào Mảng:
            CHocVien hv = new CHocVien();
            hv.MHV = txtMHV.Text;
            hv.HT = txtHT.Text;
            hv.NS = dtpNS.Value;
            hv.GT = chkGT.Checked;
            hv.D1 = Convert.ToSingle(txtD1.Text);
            hv.D2 = Convert.ToSingle(txtD2.Text);
            txtKetQua.Text = hv.KetQua();
            arrHV.Add(hv);
            ipos++;
            Clear();
            HienThiListHV();
        }
        public void HienThiHV(int vitri)
        {
            CHocVien hv = (CHocVien)arrHV[vitri];
            txtMHV.Text = hv.MHV;
            txtHT.Text = hv.HT;
            dtpNS.Value = hv.NS;
            chkGT.Checked = hv.GT;
            txtD1.Text = Convert.ToString(hv.D1);
            txtD2.Text = hv.D2.ToString();
            txtKetQua.Text = hv.KetQua();
        }
        public void HienThiListHV()
        {
            //Xóa full data có trên bản để update lên lại
            lvwDSHV.Items.Clear();
            foreach(CHocVien hv in arrHV)
            {
                ListViewItem li = lvwDSHV.Items.Add(hv.MHV);
                li.SubItems.Add(hv.HT);
                li.SubItems.Add(hv.NS.ToShortDateString());
                li.SubItems.Add(hv.GT == true ? "Nam" : "Nữ");
                li.SubItems.Add(hv.D1.ToString());
                li.SubItems.Add(hv.D2.ToString());
                li.SubItems.Add(hv.KetQua());
            }

        }
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            ipos--;
            if (ipos < 0 && arrHV.Count > 0) ipos = 0;
            if(ipos>=0)
            {
                HienThiListHV();
                HienThiHV(ipos);
                lvwDSHV.Items[ipos].Selected = true;
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            ipos++;
            if (ipos > arrHV.Count-1) ipos = arrHV.Count-1;
            if (ipos >= 0)
            {

                HienThiListHV();
                HienThiHV(ipos);
                lvwDSHV.Items[ipos].Selected = true;
            }
        }

        public void Clear()
        {
            txtMHV.Text = "";
            txtHT.Text = "";
            dtpNS.Value = DateTime.Now;
            chkGT.Checked = true;
            txtD1.Text = "";
            txtD2.Text = "";
            txtKetQua.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (arrHV.Count > 0)
            {
                arrHV.RemoveAt(ipos);
                ipos--;
                if (ipos < 0 && arrHV.Count <= 0)
                {
                    Clear();
                }
                if (ipos < 0 && arrHV.Count > 0) ipos = 0;
                if (ipos >= 0)
                {
                    HienThiHV(ipos);
                }
                HienThiListHV();
            }
            else
            {
                MessageBox.Show("Hết Học Viên Để xóa.", "Error");
            }
                
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHocVien hv = (CHocVien)arrHV[ipos];
            hv.MHV = txtMHV.Text;
            hv.HT = txtHT.Text;
            hv.NS = dtpNS.Value;
            hv.GT = chkGT.Checked;
            hv.D1 = Convert.ToSingle(txtD1.Text);
            hv.D2 = Convert.ToSingle(txtD2.Text);
            txtKetQua.Text = hv.KetQua();
            HienThiListHV();
        }

        private void lvwDSHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(int j in lvwDSHV.SelectedIndices)
            {
                ipos = j;
                HienThiHV(ipos);
                break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
