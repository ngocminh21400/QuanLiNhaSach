using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class QuyDinhBUS
    {
        private static QuyDinhBUS instance;

        internal static QuyDinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new QuyDinhBUS(); return BUS.QuyDinhBUS.instance;
            }

            private set
            {
                BUS.QuyDinhBUS.instance = value;
            }
        }
        
        public DataTable getAll()
        {
            return (DAO.ConnectionSQL.Instance.GetData(DAO.QuyDinhDAO.Instance.getAll()));
        }

        public int updateQuyDinh(QuyDinhDTO quyDinhDTO)
        {
            return (DAO.ConnectionSQL.Instance.RunSql(DAO.QuyDinhDAO.Instance.updateQuyDinh(quyDinhDTO)));
        }

    }
}
