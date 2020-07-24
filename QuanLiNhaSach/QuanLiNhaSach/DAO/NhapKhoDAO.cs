using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class NhapKhoDAO
    {
        private static NhapKhoDAO instance;

        internal static NhapKhoDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhapKhoDAO(); return DAO.NhapKhoDAO.instance;
            }

            private set
            {
                DAO.NhapKhoDAO.instance = value;
            }
        }

        public string addNhapKho(NhapKhoDTO nhapKhoDTO, int soluong)
        {
            string sql;
            sql = "INSERT INTO NHAPKHO VALUES("+nhapKhoDTO.MaNhanVien+",'"+nhapKhoDTO.NgayNhapKho+"',"+nhapKhoDTO.TongSoLuong+","+nhapKhoDTO.ThanhTien+","+nhapKhoDTO.MaSach+")";
            sql += "    UPDATE SACH SET SoLuong = "+soluong+" WHERE MaSach ="+nhapKhoDTO.MaSach;
            return sql;
        }
    }
}
