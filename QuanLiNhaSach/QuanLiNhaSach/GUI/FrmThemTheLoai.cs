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
    public partial class FrmThemTheLoai : DevExpress.XtraEditors.XtraForm
    {
        public FrmThemTheLoai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTheLoai.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập tên thể loại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sCategory = txtTenTheLoai.Text.Trim();
                    TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
                    theLoaiDTO.TenTheLoai = txtTenTheLoai.Text.Trim();
                    if (TheLoaiBUS.Instance.addTheLoai(theLoaiDTO) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm dữ liệu!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch
            {

            }
        }
    }
}