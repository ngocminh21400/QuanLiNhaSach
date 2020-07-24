using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        internal static KhachHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangDAO(); return DAO.KhachHangDAO.instance;
            }

            private set
            {
                DAO.KhachHangDAO.instance = value;
            }
        }


        public string getAll()
        {
            string sql;
            sql = "SELECT * FROM KHACHHANG";
            return sql;
        }

        public string addKhachHang(KhachHangDTO khachHangDTO)
        {
            string sql;
            sql = "INSERT INTO KHACHHANG VALUES (N'" + khachHangDTO.TenKhachHang + "',N'" + khachHangDTO.DiaChi + "', N'" + khachHangDTO.Phone + "', N'" + khachHangDTO.Email + "'," + khachHangDTO.TienNo + ")";
            return sql;
        }

        public string removeKhachHang(string makhachhang)
        {
            string sql;
            sql = "DELETE KHACHHANG WHERE MaKhachHang = '" + makhachhang + "'";
            return sql;
        }

        public string updateKhachHang(KhachHangDTO khachHangDTO)
        {
            string sql;
            sql = "UPDATE KHACHHANG Set TenKhachHang = N'" + khachHangDTO.TenKhachHang+ "',DiaChi = N'"+khachHangDTO.DiaChi+"', Phone = N'"+khachHangDTO.Phone+"', Email = N'"+khachHangDTO.Email+"', TienNo = "+khachHangDTO.TienNo + "WHERE MaKhachHang = " + khachHangDTO.MaKhachHang;
            return sql;
        }

        public string searchKhachHang(string col, string txt)
        {
            string sql;
            sql = "SELECT * FROM KHACHHANG WHERE "+col+" LIKE '%"+txt+"%';";
            return sql;
        }

        public string getKhachHang(string makhachhang)
        {
            string sql;
            sql = "SELECT * FROM KHACHHANG WHERE MaKhachHang = "+makhachhang;
            return sql;
        }

        public string updateNo(double no, int makhachhang)
        {
            string sql;
            sql = "UPDATE KHACHHANG SET TienNo =" + no + " WHERE MaKhachHang = " + makhachhang;
            return sql;
        }
    }
}
