using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DAO
{
    class nxbDAO
    {
        private static nxbDAO instance;

        internal static nxbDAO Instance
        {
            get
            {
                if (instance == null) instance = new nxbDAO(); return DAO.nxbDAO.instance;
            }

            private set
            {
                DAO.nxbDAO.instance = value;
            }
        }

        public string addNXB(nxbDTO nxbDTO)
        {
            string sql;
            sql = "INSERT INTO NHAXUATBAN VALUES (N'" + nxbDTO.TenNhaXuatBan + "')";
            return sql;
        }

        public string getAll()
        {
            string sql;
            sql = "SELECT * FROM NHAXUATBAN ORDER BY TenNhaXuatBan ASC";
            return sql;
        }
    }
}
