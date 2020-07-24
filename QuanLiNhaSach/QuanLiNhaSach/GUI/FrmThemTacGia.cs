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
    public partial class FrmThemTacGia : DevExpress.XtraEditors.XtraForm
    {
        public FrmThemTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtTenTacGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên tác giả!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tentacgia = txtTenTacGia.Text;
                    TacGiaDTO tacGiaDTO = new TacGiaDTO();
                    tacGiaDTO.TenTacGia = tentacgia;
                    TacGiaBUS.Instance.addTacGia(tacGiaDTO);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch { }
        }
    }
}