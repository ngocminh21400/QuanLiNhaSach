using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach.DAO
{
    class PhieuThuDAO
    {
        private static PhieuThuDAO instance;

        internal static PhieuThuDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuThuDAO(); return DAO.PhieuThuDAO.instance;
            }

            private set
            {
                DAO.PhieuThuDAO.instance = value;
            }
        }

        public string addPhieuThu(PhieuThuDTO phieuThuDTO, double noconlai)
        {
            string sql;
            sql = "INSERT INTO PHIEUTHUTIEN VALUES("+phieuThuDTO.MaKhachHang+","+phieuThuDTO.MaNhanVien+",'"+phieuThuDTO.NgayThuTien+"',"+phieuThuDTO.SoTienThu+")";

            sql += "    UPDATE KHACHHANG SET TienNo = "+noconlai+" WHERE MaKhachHang = "+phieuThuDTO.MaKhachHang;
            //MessageBox.Show(sql);
            return sql;
        }
    }
}
