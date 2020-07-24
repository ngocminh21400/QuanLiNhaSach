using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        internal static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO(); return DAO.HoaDonDAO.instance;
            }

            private set
            {
                DAO.HoaDonDAO.instance = value;
            }
        }

        public string addHoaDon(HoaDonDTO hoaDonDTO)
        {
            string sql;
            sql = "INSERT INTO HOADON VALUES ('"+hoaDonDTO.NgayHoaDon+"',"+hoaDonDTO.MaNhanVien+","+hoaDonDTO.MaKhachHang+","+hoaDonDTO.ThanhTien+","+hoaDonDTO.ThanhToan+","+hoaDonDTO.TienNo+")";
            return sql;
        }

        public string SearchMHD(HoaDonDTO hoaDonDTO)
        {
            string sql;
            sql = "SELECT MAX(MaHoaDon) FROM HOADON";
            return sql;
        }


    }
}
