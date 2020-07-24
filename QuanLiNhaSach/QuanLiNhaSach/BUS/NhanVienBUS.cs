using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class NhanVienBUS
    {

        private static NhanVienBUS instance;

        internal static NhanVienBUS Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienBUS(); return BUS.NhanVienBUS.instance;
            }

            private set
            {
                BUS.NhanVienBUS.instance = value;
            }
        }

        public DataTable getAll()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.NhanVienDAO.Instance.getAll()));
        }

        public int addNhanVien(NhanVienDTO nhanVienDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.NhanVienDAO.Instance.addNhanVien(nhanVienDTO)));
        }

        public int removeNhanVien(int manhanvien)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.NhanVienDAO.Instance.removeNhanVien(manhanvien)));
        }

        public DataTable searchNhanVien(string col, string txt)
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.NhanVienDAO.Instance.searchNhanVien(col,txt)));
        }

        public DataTable checkUser(string username, string password)
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.NhanVienDAO.Instance.checkUser(username,password)));
        }

        public DataTable showAccount(string username)
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.NhanVienDAO.Instance.showAccount(username)));
        }

        public int updateNhanVien(NhanVienDTO nhanVienDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.NhanVienDAO.Instance.updateNhanVien(nhanVienDTO)));
        }
    }
}
