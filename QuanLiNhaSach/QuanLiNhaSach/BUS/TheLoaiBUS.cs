using QuanLiNhaSach.DAO;
using QuanLiNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.BUS
{
    class TheLoaiBUS
    {
        private static TheLoaiBUS instance;

        internal static TheLoaiBUS Instance
        {
            get
            {
                if (instance == null) instance = new TheLoaiBUS(); return BUS.TheLoaiBUS.instance;
            }

            private set
            {
                BUS.TheLoaiBUS.instance = value;
            }
        }

        public int addTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return ConnectionSQL.Instance.RunSql(TheLoaiDAO.Instance.addTheLoai(theLoaiDTO));
        }

        public DataTable getAll()
        {
            return ConnectionSQL.Instance.GetData(TheLoaiDAO.Instance.getAll());
        }

        public int deleteTheLoai(string MaTheLoai)
        {
            return ConnectionSQL.Instance.RunSql(TheLoaiDAO.Instance.deleteTheLoai(MaTheLoai));
        }

        public int updateTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return ConnectionSQL.Instance.RunSql(TheLoaiDAO.Instance.updateTheLoai(theLoaiDTO));
        }

        
    }
}
