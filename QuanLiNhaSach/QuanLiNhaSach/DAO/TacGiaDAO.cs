using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class TacGiaDAO
    {
        private static TacGiaDAO instance;

        internal static TacGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new TacGiaDAO(); return DAO.TacGiaDAO.instance;
            }

            private set
            {
                DAO.TacGiaDAO.instance = value;
            }
        }

        public string addTacGia(TacGiaDTO tacGiaDTO)
        {
            string sql;
            sql = "INSERT INTO TACGIA VALUES (N'" + tacGiaDTO.TenTacGia + "')";
            return sql;
        }

        public string getAll()
        {
            string sql;
            sql = "SELECT * FROM TACGIA";
            return sql;
        }
    }
}
