using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach.DAO
{
    class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        internal static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietHoaDonDAO(); return DAO.ChiTietHoaDonDAO.instance;
            }

            private set
            {
                DAO.ChiTietHoaDonDAO.instance = value;
            }
        }

        public string addCTDH(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            string sql;

            sql = "INSERT INTO CHITIETHOADON VALUES ('" + chiTietHoaDonDTO.MaHoaDon + "'," + chiTietHoaDonDTO.MaSach + "," + chiTietHoaDonDTO.SoLuong + "," + chiTietHoaDonDTO.TongTien + ")";
            sql += "    UPDATE SACH SET SoLuong =SoLuong - " + chiTietHoaDonDTO.SoLuong + " WHERE MaSach =" + chiTietHoaDonDTO.MaSach;
            //MessageBox.Show(sql);
            return sql;
        }
    }
}
