using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAO(); return DAO.NhanVienDAO.instance;
            }

            private set
            {
                DAO.NhanVienDAO.instance = value;
            }
        }

        public string getAll()
        {
            string sql;
            sql = "SELECT * FROM NHANVIEN";
            return sql;
        }

        public string addNhanVien(NhanVienDTO nhanVienDTO)
        {
            string sql;
            sql = "INSERT INTO NHANVIEN VALUES (N'" + nhanVienDTO.TenNhanVien + "'," + nhanVienDTO.MaLoaiNhanVien + ", '" + nhanVienDTO.NgaySinh + "', N'" + nhanVienDTO.GioiTinh + "', N'" + nhanVienDTO.DiaChi + "', '" + nhanVienDTO.Email + "', '" + nhanVienDTO.SoDienThoai + "')    ";
            sql += "INSERT INTO TAIKHOAN VALUES ('"+nhanVienDTO.Username+"','"+nhanVienDTO.Password+"','"+nhanVienDTO.MaLoaiNhanVien+"','"+nhanVienDTO.MaLoaiNhanVien+"')";
            //MessageBox.Show(sql);
            return sql;
        }

        public string removeNhanVien(int manhanvien)
        {
            string sql;
            sql = "DELETE NHANVIEN WHERE MaNhanVien =" + manhanvien;
            return sql;
        }

        public string searchNhanVien (string col, string txt)
        {
            string sql;
            sql = "SELECT * FROM NHANVIEN WHERE "+col+" LIKE '%"+txt+"%'";
            return sql;
        }

        public string checkUser (string username, string password)
        {
            string sql;
            sql = "SELECT * FROM TAIKHOAN WHERE UserName = '"+username+"' AND MatKhau = '"+password+"'";
            return sql;
        }

        public string showAccount(string username)
        {
            string sql;
            sql = "SELECT * FROM NHANVIEN nv, TAIKHOAN tk WHERE UserName = '"+username+"' AND nv.MaNhanVien = tk.MaNhanVien";
            return sql;
        }

        public string updateNhanVien(NhanVienDTO nhanVienDTO)
        {
            string sql;
            sql = "UPDATE NHANVIEN SET TenNhanVien = N'"+nhanVienDTO.TenNhanVien+"', Email = '"+nhanVienDTO.Email+"', DiaChi = N'"+nhanVienDTO.DiaChi+"', SoDienThoai = '"+nhanVienDTO.SoDienThoai+"', GioiTinh = N'"+nhanVienDTO.GioiTinh+"', NgaySinh = '"+nhanVienDTO.NgaySinh+"', MaLoaiNhanVien = "+nhanVienDTO.MaLoaiNhanVien+" WHERE MaNhanVien = "+nhanVienDTO.MaNhanVien;
            return sql;
        }

    }
}
