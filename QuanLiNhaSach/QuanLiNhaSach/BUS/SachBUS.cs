using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class SachBUS
    {
        private static SachBUS instance;

        internal static SachBUS Instance
        {
            get
            {
                if (instance == null) instance = new SachBUS(); return BUS.SachBUS.instance;
            }

            private set
            {
                BUS.SachBUS.instance = value;
            }
        }

        public DataTable getAll()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.SachDAO.Instance.getAll()));
        }

        public int addSach(SachDTO sachDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.SachDAO.Instance.addSach(sachDTO)));
        }

        public int removeSach(int masach)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.SachDAO.Instance.removeSach(masach)));
        }

        public int updateSach(SachDTO sachDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.SachDAO.Instance.updateSach(sachDTO)));
        }

        public DataTable getSach(int masach)
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.SachDAO.Instance.getSach(masach)));
        }

        public DataTable searchSach(string col, string txt)
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.SachDAO.Instance.searchSach(col, txt)));
        }
    }
}
