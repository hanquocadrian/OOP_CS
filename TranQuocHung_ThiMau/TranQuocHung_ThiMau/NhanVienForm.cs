using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranQuocHung_ThiMau
{
    public partial class NhanVienForm : Form
    {
        #region Attributes
        private PhongBan xlnv = new PhongBan();
        PhongBanForm frmpb = new PhongBanForm();
        #endregion
        #region Method

        #endregion
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Msnv1 = txtMSNV.Text;
            nv.HoTen1 = txtHoTen.Text;
            nv.HeSo1 = Convert.ToDouble(txtHS.Text);
            nv.LuongCb1 = Convert.ToDouble(txtLCB.Text);

            if (string.Compare(cboTP.SelectedItem.ToString(), "") == 0) return;
            string mapb = cboTP.SelectedItem.ToString();
            PhongBan a = frmpb.Xl.tim(mapb);
            if(a!=null)
            {
                if(a.themNhanVien(nv))
                    
            }
        }
    }
}
