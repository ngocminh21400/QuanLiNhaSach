using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class KhachHangBUS
    {

        private static KhachHangBUS instance;

        internal static KhachHangBUS Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangBUS(); return BUS.KhachHangBUS.instance;
            }

            private set
            {
                BUS.KhachHangBUS.instance = value;
            }
        }

        public DataTable getAll()
        {
            return DAO.ConnectionSQL.Instance.GetData(DAO.KhachHangDAO.Instance.getAll());
        }

        public int addKhachHang(KhachHangDTO khachHangDTO)
        {
            return DAO.ConnectionSQL.Instance.RunSql(DAO.KhachHangDAO.Instance.addKhachHang(khachHangDTO));
        }

        public int removeKhachHang(string makhachhang)
        {
            return DAO.ConnectionSQL.Instance.RunSql(DAO.KhachHangDAO.Instance.removeKhachHang(makhachhang));
        }

        public int updateKhachHang(KhachHangDTO khachHangDTO)
        {
            return DAO.ConnectionSQL.Instance.RunSql(DAO.KhachHangDAO.Instance.updateKhachHang(khachHangDTO));
        }

        public DataTable searchKhachHang(string col, string txt)
        {
            return DAO.ConnectionSQL.Instance.GetData(DAO.KhachHangDAO.Instance.searchKhachHang(col, txt));
        }

        public DataTable getKhachHang(string makhachhang)
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.KhachHangDAO.Instance.getKhachHang(makhachhang)));
        }
        
        public int updateNo(double no, int makhachhang)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.KhachHangDAO.Instance.updateNo(no, makhachhang)));
        }
    }
}
