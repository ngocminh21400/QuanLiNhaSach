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
using QuanLiNhaSach.Resource.ExtensionHelper;

namespace QuanLiNhaSach.GUI
{
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string manhanvien;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {

            dataGridView1.DataSource = NhanVienBUS.Instance.getAll();
            dataGridView1.AutoGenerateColumns = false; 
        }

        void Reset()
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            cbLoaiNhanVien.SelectedIndex = -1;
            cbGioiTinh.SelectedIndex = -1;
            date.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            
        }

      

       

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            try
            {
                int numrow = e.RowIndex;
                manhanvien = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
                date.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
                if(dataGridView1.Rows[numrow].Cells[7].Value.ToString()== "nam")
                {
                    cbGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cbGioiTinh.SelectedIndex = 1;
                }
                if (dataGridView1.Rows[numrow].Cells[2].Value.ToString() == "1")
                {
                    cbLoaiNhanVien.SelectedIndex = 0;
                }
                else
                {
                    cbLoaiNhanVien.SelectedIndex = 1;
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
        }

     

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult mes = MessageBox.Show("Bạn chắc chắn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(mes == DialogResult.Yes)
            {
                NhanVienBUS.Instance.removeNhanVien(int.Parse(manhanvien));
                LoadData();
                Reset();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                NhanVienDTO nhanVienDTO = new NhanVienDTO();
                nhanVienDTO.MaNhanVien = int.Parse(manhanvien);
                nhanVienDTO.TenNhanVien = txtName.Text.Trim();
                nhanVienDTO.Email = txtEmail.Text.Trim();
                nhanVienDTO.DiaChi = txtAddress.Text.Trim();
                nhanVienDTO.SoDienThoai = txtPhone.Text.Trim();
                nhanVienDTO.GioiTinh = cbGioiTinh.Text;
                nhanVienDTO.NgaySinh = date.Value.ToShortDateString();
                if (cbLoaiNhanVien.Text == "nhân viên")
                {
                    nhanVienDTO.MaLoaiNhanVien = 0;
                }
                else
                {
                    nhanVienDTO.MaLoaiNhanVien = 1;
                }

                if(NhanVienBUS.Instance.updateNhanVien(nhanVienDTO) == -1)
                {
                    MessageBox.Show("Lỗi khi update dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (txtName.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtUsername.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPhone.Text.Trim() == "" || cbLoaiNhanVien.Text == "" || cbGioiTinh.Text == ""|| date.Value.ToShortDateString()=="")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name = txtName.Text.Trim();
                    string address = txtAddress.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string sdt = txtPhone.Text.Trim();
                    string maloai = cbLoaiNhanVien.Text;
                    string gioitinh = cbGioiTinh.Text;
                    string ngaysinh = date.Value.ToShortDateString();
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();

                    NhanVienDTO nhanVienDTO = new NhanVienDTO();
                    nhanVienDTO.TenNhanVien = name;
                    nhanVienDTO.DiaChi = address;
                    nhanVienDTO.Email = email;
                    nhanVienDTO.SoDienThoai = sdt;
                    nhanVienDTO.GioiTinh = gioitinh;
                    nhanVienDTO.NgaySinh = ngaysinh;
                    nhanVienDTO.Password = password;
                    nhanVienDTO.Username = username;

                    if (maloai == "nhân viên")
                    {
                        nhanVienDTO.MaLoaiNhanVien = 0;
                    }
                    else
                    {
                        nhanVienDTO.MaLoaiNhanVien = 1;
                    }


                    if (NhanVienBUS.Instance.addNhanVien(nhanVienDTO) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        Reset();
                    }
                }

            }
            catch { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Tên")
            {
                NhanVienBUS.Instance.searchNhanVien("TenNhanVien", txtSearch.Text);
            }
            else if (cbSearch.Text == "Email")
            {
                NhanVienBUS.Instance.searchNhanVien("Email", txtSearch.Text);
            }
            else if (cbSearch.Text == "SĐT")
            {
                dataGridView1.DataSource = NhanVienBUS.Instance.searchNhanVien("SoDienThoai", txtSearch.Text);
            }
        }
    }
}