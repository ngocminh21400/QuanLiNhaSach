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
    public partial class FrmSach : DevExpress.XtraEditors.XtraForm
    {
        public static int masach, soluong;
        public static double gianhap;
        public FrmSach()
        {
            InitializeComponent();
        }


        private void FrmSach_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadData();
            Reset();
           
        }
        void LoadData()
        {

            dataGridView1.DataSource = SachBUS.Instance.getAll();
            dataGridView1.AutoGenerateColumns = false;

            DataTable theloai = TheLoaiBUS.Instance.getAll();
            cbTheLoai.DataSource = theloai;
            cbTheLoai.ValueMember = "MaTheLoai";
            cbTheLoai.DisplayMember = "TenTheLoai";

            DataTable tacgia = TacGiaBUS.Instance.getAll();
            cbTacGia.DataSource = tacgia;
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";

            DataTable nxb = nxbBUS.Instance.getAll();
            cbNXB.DataSource = nxb;
            cbNXB.DisplayMember = "TenNhaXuatBan";
            cbNXB.ValueMember = "MaNhaXuatBan";
        }

        void Reset()
        {
            btnAdd.Enabled = true;
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtTenSach.Text = "";
            cbNXB.SelectedIndex = -1;
            cbTacGia.SelectedIndex = -1;
            cbTheLoai.SelectedIndex = -1;
        }

        private void addTheLoai_Click(object sender, EventArgs e)
        {
            FrmThemTheLoai f = new FrmThemTheLoai();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                LoadData();
                Reset();
            }
        }

        private void addTacGia_Click(object sender, EventArgs e)
        {
            FrmThemTacGia f = new FrmThemTacGia();
            f.ShowDialog();
            if(f.IsDisposed)
            {
               
                LoadData();
                Reset();
            }
        }

        private void addNXB_Click(object sender, EventArgs e)
        {
            FrmThemNXB f = new FrmThemNXB();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                LoadData();
                Reset();
            }
        }

     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            try
            {
                int numrow = e.RowIndex;
                
                masach = int.Parse(dataGridView1.Rows[numrow].Cells[0].Value.ToString());
                txtTenSach.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                txtGiaNhap.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                txtGiaBan.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
                soluong = int.Parse(dataGridView1.Rows[numrow].Cells[2].Value.ToString());
                gianhap = double.Parse(txtGiaNhap.Text);
                DataTable sach = SachBUS.Instance.getSach(masach);
                cbTheLoai.SelectedValue = sach.Rows[0][5];
                cbNXB.SelectedValue = sach.Rows[0][6];
                cbTacGia.SelectedValue = sach.Rows[0][7];

            }
            catch {
                //MessageBox.Show("error");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult mes = MessageBox.Show("Bạn chắc chắn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mes == DialogResult.Yes)
                {
                    SachBUS.Instance.removeSach(masach);
                    LoadData();
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SachDTO sachDTO = new SachDTO();
                sachDTO.MaSach = masach;
                sachDTO.TenSach = txtTenSach.Text;
                sachDTO.GiaNhap = double.Parse(txtGiaNhap.Text);
                sachDTO.GiaBan = (double.Parse(txtGiaBan.Text) * FrmMain.TienBan)/100;

                sachDTO.MaTheLoai = int.Parse(cbTheLoai.SelectedValue.ToString());
                sachDTO.MaTacGia = int.Parse(cbTacGia.SelectedValue.ToString());
                sachDTO.MaNhaXuatBan = int.Parse(cbNXB.SelectedValue.ToString());

                if (SachBUS.Instance.updateSach(sachDTO) == -1)
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if(soluong >= FrmMain.SoLuongTonToiThieuKhiNhap)
            {
                MessageBox.Show("Số lượng tồn kho vượt mức cho phép nhập");
            }
            else
            {
              FrmNhapKho f = new FrmNhapKho();
                f.ShowDialog();
                if (f.IsDisposed)
                {
                    LoadData();
                    Reset();
                }
            }
  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    if(cbSearch.Text == "tên sách")
                    {
                        dataGridView1.DataSource = SachBUS.Instance.searchSach("TenSach", txtSearch.Text);
                        dataGridView1.AutoGenerateColumns = false;
                    }
                    else if (cbSearch.Text == "thể loại")
                    {
                        dataGridView1.DataSource = SachBUS.Instance.searchSach("TenTheLoai", txtSearch.Text);
                        dataGridView1.AutoGenerateColumns = false;
                    }
                    else if (cbSearch.Text == "tác giả")
                    {
                        dataGridView1.DataSource = SachBUS.Instance.searchSach("TenTacGia", txtSearch.Text);
                        dataGridView1.AutoGenerateColumns = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            Reset();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                HelperUI.Instance.ExportExcel(dataGridView1);
            }
            catch { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtTenSach.Text == "" || txtGiaNhap.Text == "" || txtGiaBan.Text == "" || cbTheLoai.SelectedValue.ToString() == "-1" || cbTacGia.SelectedValue.ToString() == "-1" || cbNXB.SelectedValue.ToString() == "-1")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tensach = txtTenSach.Text;
                    string gianhap = txtGiaNhap.Text;
                    string giaban = txtGiaBan.Text;
                    string matheloai = cbTheLoai.SelectedValue.ToString();
                    string matacgia = cbTacGia.SelectedValue.ToString();
                    string maNXB = cbNXB.SelectedValue.ToString();

                    SachDTO sachDTO = new SachDTO();
                    sachDTO.TenSach = tensach;
                    sachDTO.GiaNhap = double.Parse(gianhap);
                    sachDTO.GiaBan = double.Parse(giaban);
                    sachDTO.MaTheLoai = int.Parse(matheloai);
                    sachDTO.MaTacGia = int.Parse(matacgia);
                    sachDTO.MaNhaXuatBan = int.Parse(maNXB);

                    if (SachBUS.Instance.addSach(sachDTO) == -1)
                    {
                        MessageBox.Show("Lỗi");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        LoadData();
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