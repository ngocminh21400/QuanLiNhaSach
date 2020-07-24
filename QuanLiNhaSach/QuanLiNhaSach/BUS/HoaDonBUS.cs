using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class HoaDonBUS
    {
        private static HoaDonBUS instance;

        internal static HoaDonBUS Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonBUS(); return BUS.HoaDonBUS.instance;
            }

            private set
            {
                BUS.HoaDonBUS.instance = value;
            }
        }

        public int addHoaDon(HoaDonDTO hoaDonDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.HoaDonDAO.Instance.addHoaDon(hoaDonDTO)));
        }

        public int searchMHD(HoaDonDTO hoaDonDTO)
        {
            return (DAO.ConnectionSQL.Instance.ExcuteInt(DAO.HoaDonDAO.Instance.SearchMHD(hoaDonDTO)));
        }

    }
}
