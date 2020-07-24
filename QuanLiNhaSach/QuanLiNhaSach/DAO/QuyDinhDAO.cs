using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class QuyDinhDAO
    {
        private static QuyDinhDAO instance;

        internal static QuyDinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuyDinhDAO(); return DAO.QuyDinhDAO.instance;
            }

            private set
            {
                DAO.QuyDinhDAO.instance = value;
            }
        }

        public string getAll()
        {
            string sql;
            sql = "SELECT * FROM QUYDINH";
            return sql;
        }

        public string updateQuyDinh(QuyDinhDTO quyDinhDTO)
        {
            string sql;
            sql = "UPDATE QUYDINH SET SoLuongNhapToiThieu = " + quyDinhDTO.SoLuongNhapToiThieu + ", SoLuongTonToiThieuKhiNhap = " + quyDinhDTO.SoLuongTonToiThieuKhiNhap + ", SoLuongTonKhoToiThieu = " + quyDinhDTO.SoLuongTonKhoToiThieu + ", NoToiDa = " + quyDinhDTO.NoToiDa + ",TienBan = " + quyDinhDTO.TienBan + " WHERE id = 1";
            return sql;
        }
    }
}
