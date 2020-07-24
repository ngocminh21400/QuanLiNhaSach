using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLiNhaSach.DTO;
using QuanLiNhaSach.BUS;

namespace QuanLiNhaSach.GUI
{
    public partial class FrmNhapKho : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhapKho()
        {
            InitializeComponent();
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = FrmSach.masach.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Text != "")
            {
                try
                {
                        txtThanhTien.Text = (double.Parse(txtSoLuong.Text) * FrmSach.gianhap).ToString();  

                }
                catch
                {
                    MessageBox.Show("vui lòng nhập số!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            int soluong_update = int.Parse(txtSoLuong.Text) + FrmSach.soluong;
            NhapKhoDTO nhapKhoDTO = new NhapKhoDTO();
            nhapKhoDTO.MaNhanVien = FrmTaiKhoan.manhanvien;
            nhapKhoDTO.MaSach = int.Parse(txtMaSach.Text);
            nhapKhoDTO.TongSoLuong = int.Parse(txtSoLuong.Text);
            nhapKhoDTO.ThanhTien = double.Parse(txtThanhTien.Text);
            nhapKhoDTO.NgayNhapKho = DateTime.UtcNow.ToString("MM-dd-yyyy");
            try
            {
                if (double.Parse(txtSoLuong.Text) < FrmMain.SoLuongNhapToiThieu)
                {
                    MessageBox.Show("Số lượng nhập tối thiểu là " + FrmMain.SoLuongNhapToiThieu.ToString());
                }
                else
                {
                    if (NhapKhoBUS.Instance.addNhapKho(nhapKhoDTO, soluong_update) == -1)
                    {
                        MessageBox.Show("Lỗi khi update!");
                    }
                    else
                    {
                        MessageBox.Show("Đã tạo đơn nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }


            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}