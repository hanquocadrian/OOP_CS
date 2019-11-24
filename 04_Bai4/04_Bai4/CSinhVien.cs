using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bai4
{
    class CSinhVien
    {
        #region Attributies
        private string iMSV;
        private string iHT;
        private DateTime iNS;
        private bool iGT;
        private string iML;
        #endregion
        #region Properties
        public string MSV
        {
            get { return iMSV; }
            set { iMSV = value; }
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
        public string ML
        {
            get { return iML; }
            set { iML = value; }
        }
        #endregion
        #region Contructor
        public CSinhVien()
        {
            iMSV = iHT = "";
            iNS = DateTime.Now;
            iGT = false;
            iML = "";
        }
        public CSinhVien(string msv, string ht, DateTime ns, bool gt, string ml)
        {
            iMSV = msv;
            iHT = ht;
            iNS = ns;
            iGT = gt;
            iML = ml;
        }
        #endregion
        #region Method
        public int Tuoi()
        {
            int kq;
            kq = DateTime.Now.Year - NS.Year;
            return kq;
        }
        #endregion
    }
}
