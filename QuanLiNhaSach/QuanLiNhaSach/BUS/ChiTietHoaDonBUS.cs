using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS instance;

        internal static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietHoaDonBUS(); return BUS.ChiTietHoaDonBUS.instance;
            }

            private set
            {
                BUS.ChiTietHoaDonBUS.instance = value;
            }

  
        }

        public int addCTDH(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.ChiTietHoaDonDAO.Instance.addCTDH(chiTietHoaDonDTO)));
        }
    }
}
