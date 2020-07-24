using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class ThongKeBUS
    {
        private static ThongKeBUS instance;

        internal static ThongKeBUS Instance
        {
            get
            {
                if (instance == null) instance = new ThongKeBUS(); return BUS.ThongKeBUS.instance;
            }

            private set
            {
                BUS.ThongKeBUS.instance = value;
            }


        }

        public DataTable ThongKeTheoThang()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.ThongKeDAO.Instance.ThongKeTheoThang()));
        }

        public DataTable ThongKeTheoSach()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.ThongKeDAO.Instance.ThongKeTheoSach()));
        }

        public DataTable ThongKeTheoTheLoai()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.ThongKeDAO.Instance.ThongKeTheoTheLoai()));
        }
    }
}
