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
using QuanLiNhaSach.Resource.ExtensionHelper;

namespace QuanLiNhaSach.GUI
{
    public partial class FrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public static string makhachhang;

        public FrmKhachHang()
        {
            InitializeComponent();
        }

      

       


        void LoadData()
        {
            dataGridView1.DataSource = KhachHangBUS.Instance.getAll();
        }

        void Reset()
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow = e.RowIndex;
                makhachhang = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                string address = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
                string sdt = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                string email = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
                txtName.Text = name;
                txtAddress.Text = address;
                txtPhone.Text = sdt;
                txtEmail.Text = email;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmThuNo f = new FrmThuNo();
                f.ShowDialog();
                if (f.IsDisposed)
                {
                    LoadData();
                    Reset();
                }
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangDTO khachhangDTO = new KhachHangDTO();
                khachhangDTO.MaKhachHang = makhachhang;
                khachhangDTO.TenKhachHang = txtName.Text.Trim();
                khachhangDTO.DiaChi = txtName.Text.Trim();
                khachhangDTO.Email = txtEmail.Text.Trim();
                khachhangDTO.Phone = txtPhone.Text.Trim();

                if (KhachHangBUS.Instance.updateKhachHang(khachhangDTO) == -1)
                {
                    MessageBox.Show("Lỗi!");
                }
                else
                {
                    Reset();
                    MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch { }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (makhachhang != null)
                {
                    if (MessageBox.Show("Bạn muốn xóa thể loại này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        KhachHangBUS.Instance.removeKhachHang(makhachhang);
                        LoadData();
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 thể loại cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                HelperUI.Instance.ExportExcel(dataGridView1);

            }
            catch { }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name = txtName.Text.Trim();
                    string address = txtAddress.Text.Trim();
                    string sdt = txtPhone.Text.Trim();
                    string email = txtEmail.Text.Trim();

                    KhachHangDTO khachHangDTO = new KhachHangDTO();
                    khachHangDTO.TenKhachHang = name;
                    khachHangDTO.DiaChi = address;
                    khachHangDTO.Email = email;
                    khachHangDTO.Phone = sdt;

                    if (KhachHangBUS.Instance.addKhachHang(khachHangDTO) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Reset();
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSearch.Text == "Tên")
                {
                    string txt = txtSearch.Text;
                    dataGridView1.DataSource = KhachHangBUS.Instance.searchKhachHang("TenKhachHang", txt);
                }
                else if (cbSearch.Text == "Email")
                {
                    string txt = txtSearch.Text;
                    dataGridView1.DataSource = KhachHangBUS.Instance.searchKhachHang("Email", txt);
                }
                else if (cbSearch.Text == "SĐT")
                {
                    string txt = txtSearch.Text;
                    dataGridView1.DataSource = KhachHangBUS.Instance.searchKhachHang("Phone", txt);
                }
            }
            catch { }
        }
    }
}