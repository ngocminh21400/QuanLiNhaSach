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
    public partial class FrmThemNXB : DevExpress.XtraEditors.XtraForm
    {
        public FrmThemNXB()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtTenNXB.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên Nhà xuất bản!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string tenNXB = txtTenNXB.Text;
                    nxbDTO nxb = new nxbDTO();
                    nxb.TenNhaXuatBan = tenNXB;
                    nxbBUS.Instance.addNXB(nxb);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch { }
        }
    }
}