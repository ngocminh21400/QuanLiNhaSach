using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class TheLoaiDAO
    {
        private static TheLoaiDAO instance;

        internal static TheLoaiDAO Instance
        {
            get
            {
                if (instance == null) instance = new TheLoaiDAO(); return DAO.TheLoaiDAO.instance;
            }

            private set
            {
                DAO.TheLoaiDAO.instance = value;
            }
        }

        public string addTheLoai(TheLoaiDTO theLoaiDTO)
        {
            string sql;
            sql = "INSERT INTO THELOAI VALUES (N'" + theLoaiDTO.TenTheLoai + "')";

            return sql;
        }

        public string getAll()
        {
            string sql;
            sql = "SELECT * FROM THELOAI ORDER BY TenTheLoai ASC";
            return sql;
        }

        public string deleteTheLoai(string MaTheLoai)
        {
            string sql;
            sql = "DELETE THELOAI WHERE MaTheLoai = " + MaTheLoai;
            return sql;
        }

        public string updateTheLoai(TheLoaiDTO theLoaiDTO)
        {
            string sql;
            sql = "UPDATE THELOAI SET TenTheLoai =N'" + theLoaiDTO.TenTheLoai + "' WHERE MaTheLoai =" + theLoaiDTO.MaTheLoai;
            return sql;
        }
    }
}
