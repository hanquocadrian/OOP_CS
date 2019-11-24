using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _08_Bai8
{
    class CdmLopHoc
    {
        private Hashtable m_dmlop;
        public CdmLopHoc()
        {
            this.m_dmlop = new Hashtable();
        }
        public Hashtable dmLop
        {
            get
            {
                return m_dmlop;
            }
        }
        public CLopHoc[] arrayLophoc
        {
            get
            {
                CLopHoc[] dslop = new CLopHoc[m_dmlop.Count];
                m_dmlop.Values.CopyTo(dslop, 0);
                return dslop;
            }
        }
        public CLopHoc tim (string malop)
        {
            return (CLopHoc)m_dmlop[malop];
        }
        public bool them(CLopHoc cr)
        {
            try
            {
                CLopHoc a = tim(cr.SMalop);
                if(a==null)
                {
                    m_dmlop.Add(cr.SMalop, cr);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool xoa(string malop)
        {
            try
            {
                CLopHoc a = tim(malop);
                if (a != null)
                {
                    m_dmlop.Remove(malop);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool sua(CLopHoc cr)
        {
            try
            {
                CLopHoc a = tim(cr.SMalop);
                if (a != null)
                {
                    a.SKhoa = cr.SKhoa;
                    a.SHeDaoTao = cr.SHeDaoTao;
                    a.Dmhv = cr.Dmhv;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool themHV(string malop,CHocvien hv)
        {
            try
            {
                CLopHoc a = tim(malop);
                if (a != null)
                {
                    a.Dmhv.Add(hv.SMaHV, hv);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public CHocvien timHV(string malop,string mahv)
        {
            CLopHoc a = tim(malop);
            CHocvien hv = null;
            if (a!=null)
            {
                hv = (CHocvien)a.Dmhv[mahv];
            }
            return hv;
        }
        public bool xoaHV(string malop,string mahv)
        {
            try
            {
                CHocvien hv = timHV(malop,mahv);
                if (hv != null)
                {
                    CdmHocVien xl = new CdmHocVien();
                    xl.xoa(mahv);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Save()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("dslh.txt", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, m_dmlop);
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
                fs = new FileStream("dslh.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                m_dmlop = (Hashtable)bf.Deserialize(fs);
                fs.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
