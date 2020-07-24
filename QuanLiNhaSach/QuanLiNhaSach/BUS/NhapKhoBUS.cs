using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class NhapKhoBUS
    {
        private static NhapKhoBUS instance;

        internal static NhapKhoBUS Instance
        {
            get
            {
                if (instance == null) instance = new NhapKhoBUS(); return BUS.NhapKhoBUS.instance;
            }

            private set
            {
                BUS.NhapKhoBUS.instance = value;
            }
        }

        public int addNhapKho(NhapKhoDTO nhapKhoDTO, int soluong)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.NhapKhoDAO.Instance.addNhapKho(nhapKhoDTO,soluong)));
        }
    }
}
