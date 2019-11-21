using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _08_Bai8
{
    class CdmHocVien
    {
        private Hashtable m_dmhv;
        public CdmHocVien()
        {
            m_dmhv = new Hashtable();
        }
        public Hashtable dmHocVien
        {
            get
            {
                return m_dmhv;
            }
        }
        public CHocvien[] arrayHocVien
        {
            get
            {
                CHocvien[] x = new CHocvien[m_dmhv.Count];
                m_dmhv.Values.CopyTo(x, 0);
                return x;
            }
        }
        public CHocvien tim(string ma)
        {
            return (CHocvien)m_dmhv[ma];
        }
        public bool them(CHocvien hv)
        {
            try
            {
                CHocvien a = tim(hv.SMaHV);
                if(a== null)
                {
                    m_dmhv.Add(hv.SMaHV, hv);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool xoa(string ma)
        {
            CHocvien a = tim(ma);
            if(a!=null)
            {
                m_dmhv.Remove(ma);
                return true;
            }
            return false;
        }
        public bool sua(CHocvien hv)
        {
            CHocvien a = tim(hv.SMaHV);
            if(a!=null)
            {
                a.SHoTen = hv.SHoTen;
                a.DNgaySinh = hv.DNgaySinh;
                a.BGioiTinh = hv.BGioiTinh;
                a.FDiem1 = hv.FDiem1;
                a.FDiem2 = hv.FDiem2;
                return true;
            }
            return false;
        }

        public void Save()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("dshv.txt", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, m_dmhv);
                fs.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Open()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("dshv.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                m_dmhv=(Hashtable)bf.Deserialize(fs);
                fs.Close();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
