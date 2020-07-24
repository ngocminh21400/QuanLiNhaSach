using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class nxbBUS
    {
        private static nxbBUS instance;

        internal static nxbBUS Instance
        {
            get
            {
                if (instance == null) instance = new nxbBUS(); return BUS.nxbBUS.instance;
            }

            private set
            {
                BUS.nxbBUS.instance = value;
            }
        }

        public int addNXB(nxbDTO nxbDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.nxbDAO.Instance.addNXB(nxbDTO)));
        }

        public DataTable getAll()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.nxbDAO.Instance.getAll()));
        }
    }
}
