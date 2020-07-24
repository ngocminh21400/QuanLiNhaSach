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
    public partial class FrmQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        public FrmQuyDinh()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmQuyDinh_Load(object sender, EventArgs e)
        {
            txt1.Text = FrmMain.SoLuongNhapToiThieu.ToString();
            txt2.Text = FrmMain.SoLuongTonToiThieuKhiNhap.ToString();
            txt3.Text = FrmMain.SoLuongTonKhoToiThieu.ToString();
            txt4.Text = FrmMain.NoToiDa.ToString();
            txt5.Text = FrmMain.TienBan.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                QuyDinhDTO quyDinhDTO = new QuyDinhDTO();
                quyDinhDTO.SoLuongNhapToiThieu = int.Parse(txt1.Text);
                FrmMain.SoLuongNhapToiThieu = quyDinhDTO.SoLuongNhapToiThieu;
                quyDinhDTO.SoLuongTonToiThieuKhiNhap = int.Parse(txt2.Text);
                FrmMain.SoLuongTonToiThieuKhiNhap = quyDinhDTO.SoLuongTonToiThieuKhiNhap;
                quyDinhDTO.SoLuongTonKhoToiThieu = int.Parse(txt3.Text);
                FrmMain.SoLuongTonKhoToiThieu = quyDinhDTO.SoLuongTonKhoToiThieu;
                quyDinhDTO.NoToiDa = double.Parse(txt4.Text);
                FrmMain.NoToiDa = quyDinhDTO.NoToiDa;
                quyDinhDTO.TienBan = int.Parse(txt5.Text);
                FrmMain.TienBan = quyDinhDTO.TienBan;

                if (QuyDinhBUS.Instance.updateQuyDinh(quyDinhDTO) == -1)
                {
                    MessageBox.Show("update lỗi!");
                }
                else
                {
                    MessageBox.Show("Quy định đã thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số!");
            }
        }
    }
}