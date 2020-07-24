using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;

        internal static ThongKeDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThongKeDAO(); return DAO.ThongKeDAO.instance;
            }

            private set
            {
                DAO.ThongKeDAO.instance = value;
            }

        }

        public string ThongKeTheoThang()
        {
            string sql;
            sql = "Select sum(ThanhTien) as thanhtien, sum(ThanhToan) as thuthuc, sum(TienNo) as no, MONTH(NgayHoaDon) as thang from HOADON group by MONTH(NgayHoaDon)";
            return sql;
        }

        public string ThongKeTheoSach()
        {
            string sql;
            sql = "  Select sum(TongTien) as tongtien, cthd.MaSach as masach, SACH.TenSach as tensach from CHITIETHOADON cthd, SACH where cthd.MaSach = SACH.MaSach group by cthd.MaSach, SACH.TenSach ";
            return sql;
        }

        public string ThongKeTheoTheLoai()
        {
            string sql;
            sql = "  Select sum(TongTien) as tongtien, TenTheLoai as loaisach from CHITIETHOADON  cthd, SACH, THELOAI where cthd.MaSach = SACH.MaSach and THELOAI.MaTheLoai =SACH.MaTheLoai group by TenTheLoai";
            return sql;
        }
    }
}
