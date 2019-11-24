using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bai4
{
    class CHocVien
    {
        #region Attributies
        private string iMHV;
        private string iHT;
        private DateTime iNS;
        private bool iGT;
        private float iD1;
        private float iD2;
        #endregion
        #region Properties
        public string MHV
        {
            get { return iMHV; }
            set { iMHV = value; }
        }
        public string HT
        {
            get { return iHT; }
            set { iHT = value; }
        }
        public DateTime NS
        {
            get { return iNS; }
            set { iNS = value; }
        }
        public bool GT
        {
            get { return iGT; }
            set { iGT = value; }
        }
        public float D1
        {
            get { return iD1; }
            set { iD1 = value; }
        }
        public float D2
        {
            get { return iD2; }
            set { iD2 = value; }
        }
        #endregion
        #region Contructor
        public CHocVien()
        {
            iMHV = iHT = "";
            iNS = DateTime.Now;
            iGT = false;
            iD1 = iD2 = 0;
        }
        public CHocVien(string mhv,string ht,DateTime ns,bool gt, float d1,float d2)
        {
            iMHV = mhv;
            iHT = ht;
            iNS = ns;
            iGT = gt;
            iD1 = d1;
            iD2 = d2;
        }
        #endregion
        #region Method
        public string KetQua()
        {
            return (((iD1 + iD2) / 2) >= 5 ? "Đậu" : "Rớt");
        }
        #endregion
    }
}
