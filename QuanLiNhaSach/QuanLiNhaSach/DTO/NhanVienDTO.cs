using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.DTO
{
    class NhanVienDTO
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int MaLoaiNhanVien { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string Username {get; set;}
        public string Password { get; set; }
    }
}
