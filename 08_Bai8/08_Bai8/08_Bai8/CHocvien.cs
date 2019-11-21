using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_Bai8
{
    [Serializable]
    class CHocvien
    {
        #region Attributes
        private string sMaHV;
        private string sHoTen;
        private DateTime dNgaySinh;
        private bool bGioiTinh;
        private float fDiem1;
        private float fDiem2;
        #endregion

        #region Properties
        public string SMaHV { get => sMaHV; set => sMaHV = value; }
        public string SHoTen { get => sHoTen; set => sHoTen = value; }
        public DateTime DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
        public bool BGioiTinh { get => bGioiTinh; set => bGioiTinh = value; }
        public float FDiem1 { get => fDiem1; set => fDiem1 = value; }
        public float FDiem2 { get => fDiem2; set => fDiem2 = value; }
        #endregion

        #region Constructor
        public CHocvien() : this("","",DateTime.Now,false,0,0)
        {

        }
        public CHocvien(string sMaHV, string sHoTen, DateTime dNgaySinh, bool bGioiTinh, float fDiem1, float fDiem2)
        {
            this.sMaHV = sMaHV;
            this.sHoTen = sHoTen;
            this.dNgaySinh = dNgaySinh;
            this.bGioiTinh = bGioiTinh;
            this.fDiem1 = fDiem1;
            this.fDiem2 = fDiem2;
        }
        #endregion

        #region Method
        public string KetQua()
        {
            return (((FDiem1 + FDiem2) / 2) >= 5 ? "Đậu" : "Rớt");
        }
        #endregion

    }
}
