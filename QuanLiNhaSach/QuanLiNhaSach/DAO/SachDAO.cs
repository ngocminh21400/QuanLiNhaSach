using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach.DAO
{
    class SachDAO
    {
        private static SachDAO instance;

        internal static SachDAO Instance
        {
            get
            {
                if (instance == null) instance = new SachDAO(); return DAO.SachDAO.instance;
            }

            private set
            {
                DAO.SachDAO.instance = value;
            }
        }

        public string getAll()
        {
            string sql;
            sql = "SELECT *  FROM SACH s, THELOAI tl, TACGIA tg, NHAXUATBAN nxb WHERE s.MaTheLoai = tl.MaTheLoai AND s.MaTacGia = tg.MaTacGia AND s.MaNhaXuatBan = nxb.MaNhaXuatBan";
            return sql;
        }

        public string addSach(SachDTO sachDTO)
        {
            string sql;
            //sql = "INSERT INTO "
            sql = "INSERT INTO SACH VALUES(N'"+sachDTO.TenSach+"',0,"+sachDTO.GiaNhap+","+sachDTO.GiaBan+","+sachDTO.MaTheLoai+","+sachDTO.MaNhaXuatBan+","+sachDTO.MaTacGia+")";
            //MessageBox.Show(sql);
            return sql;
        }

        public string removeSach(int masach)
        {
            string sql;
            sql = "DELETE SACH WHERE MaSach = "+masach;
            return sql;
        }

        public string updateSach(SachDTO sachDTO)
        {
            string sql;
            sql = "UPDATE SACH SET TenSach = N'"+sachDTO.TenSach+"', GiaNhap = "+sachDTO.GiaNhap+", GiaBan = "+sachDTO.GiaBan+", MaTheLoai = "+sachDTO.MaTheLoai+", MaTacGia = "+sachDTO.MaTacGia+", MaNhaXuatBan = "+sachDTO.MaNhaXuatBan+" WHERE MaSach = "+sachDTO.MaSach;
            return sql;
        }

        public string getSach(int masach)
        {
            string sql;
            sql = "SELECT * FROM SACH WHERE MaSach = "+masach;
            return sql;
        }

        public string searchSach(string col, string txt)
        {
            string sql;
            sql = "SELECT *  FROM SACH s, THELOAI tl, TACGIA tg, NHAXUATBAN nxb WHERE s.MaTheLoai = tl.MaTheLoai AND s.MaTacGia = tg.MaTacGia AND s.MaNhaXuatBan = nxb.MaNhaXuatBan AND "+col+" LIKE '%"+txt+"%'";
            return sql;
        }
    }
}
