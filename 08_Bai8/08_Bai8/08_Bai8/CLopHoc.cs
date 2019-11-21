using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_Bai8
{
    class CLopHoc
    {
        private string sMalop;
        private string sKhoa;
        private string sHeDaoTao;
        private Hashtable dmhv;

        public CLopHoc(string sMalop, string sKhoa, string sHeDaoTao)
        {
            this.SMalop = sMalop;
            this.SKhoa = sKhoa;
            this.SHeDaoTao = sHeDaoTao;
            this.Dmhv = new Hashtable();
        }

        public CLopHoc() : this("","","")
        {

        }

        public string SMalop { get => sMalop; set => sMalop = value; }
        public string SKhoa { get => sKhoa; set => sKhoa = value; }
        public string SHeDaoTao { get => sHeDaoTao; set => sHeDaoTao = value; }
        public Hashtable Dmhv { get => dmhv; set => dmhv = value; }

        public CHocvien[] ArrayHocvien
        {
            get
            {
                CHocvien[] dshv = new CHocvien[dmhv.Count];
                dmhv.Values.CopyTo(dshv, 0);
                return dshv;
            }
        }
    }
}
