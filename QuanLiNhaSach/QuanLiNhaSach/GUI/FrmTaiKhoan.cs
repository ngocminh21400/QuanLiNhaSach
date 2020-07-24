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
using QuanLiNhaSach.DAO;

namespace QuanLiNhaSach.GUI
{
    public partial class FrmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public static int manhanvien;
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }
       void LoadData()
       {
            DataTable userAccount = NhanVienBUS.Instance.showAccount(Program.user);
            txtMaTaiKhoan.Text = userAccount.Rows[0][9].ToString();
            txtTenNhanVien.Text = userAccount.Rows[0][1].ToString();
            txtEmail.Text = userAccount.Rows[0][6].ToString();
            txtDiaChi.Text = userAccount.Rows[0][5].ToString();
            txtSDT.Text = userAccount.Rows[0][7].ToString();
            manhanvien = int.Parse(userAccount.Rows[0][0].ToString());
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult mes = MessageBox.Show("Thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mes == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {

            }
        }
    }
}