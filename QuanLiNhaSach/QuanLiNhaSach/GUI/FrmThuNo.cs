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
using QuanLiNhaSach.BUS;
using QuanLiNhaSach.DTO;

namespace QuanLiNhaSach.GUI
{
    public partial class FrmThuNo : DevExpress.XtraEditors.XtraForm
    {
        public FrmThuNo()
        {
            InitializeComponent();
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void FrmThuNo_Load(object sender, EventArgs e)
        {
            DataTable khachang = KhachHangBUS.Instance.getKhachHang(FrmKhachHang.makhachhang);
            txtname.Text = khachang.Rows[0][1].ToString();
            txtNoHienTai.Text = khachang.Rows[0][5].ToString();
            
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            if(txtThanhToan.Text != "")
            {
                try
                {
                    txtNoConLai.Text = (double.Parse(txtNoHienTai.Text) - double.Parse(txtThanhToan.Text)).ToString();

                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtThanhToan.Text = "";
                }
            }

        }

        private void btnAddPhieuThu_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtNoConLai.Text) < 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền nhỏ hơn hoặc bằng số nợ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PhieuThuDTO phieuThuDTO = new PhieuThuDTO();
                    phieuThuDTO.MaKhachHang = int.Parse(FrmKhachHang.makhachhang);
                    phieuThuDTO.MaNhanVien = FrmTaiKhoan.manhanvien;
                    phieuThuDTO.NgayThuTien = DateTime.UtcNow.ToString("MM-dd-yyyy");
                    phieuThuDTO.SoTienThu = double.Parse(txtThanhToan.Text);
                    if (PhieuThuBUS.Instance.addPhieuThu(phieuThuDTO, int.Parse(txtNoConLai.Text)) == -1)
                    {
                        MessageBox.Show("Lỗi!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu thu nợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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