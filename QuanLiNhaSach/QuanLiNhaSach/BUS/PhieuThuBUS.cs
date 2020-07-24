using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class PhieuThuBUS
    {

        private static PhieuThuBUS instance;

        internal static PhieuThuBUS Instance
        {
            get
            {
                if (instance == null) instance = new PhieuThuBUS(); return BUS.PhieuThuBUS.instance;
            }

            private set
            {
                BUS.PhieuThuBUS.instance = value;
            }
        }

        public int addPhieuThu(PhieuThuDTO phieuThuDTO, double noconlai)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.PhieuThuDAO.Instance.addPhieuThu(phieuThuDTO, noconlai)));
        }
    }
}
