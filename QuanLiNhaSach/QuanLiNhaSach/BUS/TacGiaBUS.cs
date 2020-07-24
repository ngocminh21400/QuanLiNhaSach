using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class TacGiaBUS
    {
        private static TacGiaBUS instance;

        internal static TacGiaBUS Instance
        {
            get
            {
                if (instance == null) instance = new TacGiaBUS(); return BUS.TacGiaBUS.instance;
            }

            private set
            {
                BUS.TacGiaBUS.instance = value;
            }
        }

        public int addTacGia(TacGiaDTO tacGiaDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.TacGiaDAO.Instance.addTacGia(tacGiaDTO)));
        }

        public DataTable getAll()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.TacGiaDAO.Instance.getAll()));
        }
    }
}
