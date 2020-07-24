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
using System.Collections;

namespace QuanLiNhaSach.GUI
{
    public partial class FrmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public int makhachhang, numrow, soluong;
        int manhanvien = FrmTaiKhoan.manhanvien;
        public string mahoadon;
        public ArrayList masach = new ArrayList();
        public FrmHoaDon()
        {

            InitializeComponent();

        }

        void LoadData()
        {
            dataGridView1.DataSource = SachBUS.Instance.getAll();
            dataGridView1.AutoGenerateColumns = false;
            cbSearch.SelectedIndex = 0;
            txtSoLuong.Text = "1";
        }
        void LoadData2()
        {
            dataGridView2.DataSource = SachBUS.Instance.getAll();
            dataGridView2.AutoGenerateColumns = false;
            comboBox2.SelectedIndex = 0;
            txtSoLuong2.Text = "1";

        }
        void Reset()
        {
            txtTenKhachHang.Text = "";
            txtSoLuong.Text = "1";
            txtThanhToan.Text = "";
            listView1.Items.Clear();
        }
        void Reset2()
        {
            txtSoLuong2.Text = "1";
            listView2.Items.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

            btnAddToHD.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            LoadData();

            listView1.Columns.Add("Mã Sách", 50);
            listView1.Columns.Add("Tên sách", 100);
            listView1.Columns.Add("Đơn giá", 70);
            listView1.Columns.Add("Số lượng", 70);
            listView1.Columns.Add("Giá", 60);
            listView1.View = View.Details;
            listView2.Columns.Add("Mã Sách", 50);
            listView2.Columns.Add("Tên sách", 100);
            listView2.Columns.Add("Đơn giá", 70);
            listView2.Columns.Add("Số lượng", 70);
            listView2.Columns.Add("Giá", 60);
            listView2.View = View.Details;

        }

        private void btnAddKhachHang_Click(object sender, EventArgs e)
        {
            FrmTimKiemKhachHang f = new FrmTimKiemKhachHang();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                txtTenKhachHang.Text = FrmTimKiemKhachHang.tenkhachhang;
                makhachhang = FrmTimKiemKhachHang.makhachhang;
                mahoadon = DateTime.UtcNow.ToString("ddMMyyyHHmmss");
                //MessageBox.Show(mahoadon);
                btnAddToHD.Enabled = true;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numrow = e.RowIndex;

                //masach = int.Parse(dataGridView1.Rows[numrow].Cells[0].Value.ToString());
                //txtTenSach.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                //txtGiaNhap.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                //txtGiaBan.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();

                soluong = int.Parse(dataGridView1.Rows[numrow].Cells[5].Value.ToString());
                //MessageBox.Show(numrow.ToString() + soluong.ToString());
                //gianhap = double.Parse(txtGiaNhap.Text);
                //DataTable sach = SachBUS.Instance.getSach(masach);
                //cbTheLoai.SelectedValue = sach.Rows[0][5];
                //cbNXB.SelectedValue = sach.Rows[0][6];
                //cbTacGia.SelectedValue = sach.Rows[0][7];

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        void TinhTongTien()
        {
            double tongtien = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int ii = 1;
                tongtien += double.Parse(listView1.Items[i].SubItems[4].Text);
                ii++;
            }
            txtTongTien.Text = tongtien.ToString();
            txtThanhToan.Text = tongtien.ToString();
        }

        void TinhTongTien2()
        {
            double tongtien = 0;
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                int ii = 1;
                tongtien += double.Parse(listView2.Items[i].SubItems[4].Text);
                ii++;
            }
            txtTongTien2.Text = tongtien.ToString();
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtNo.Text = (double.Parse(txtTongTien.Text) - double.Parse(txtThanhToan.Text)).ToString();
            }
            catch { }
        }
        void updateKhachHang()
        {
            int mkh = makhachhang;
            double no = double.Parse(txtNo.Text) + FrmTimKiemKhachHang.tienno;
            if (KhachHangBUS.Instance.updateNo(no, mkh) == -1)
            {
                MessageBox.Show("update khách hàng lỗi!");
            }


        }
        void TaoCTHD_KhachVangLai(HoaDonDTO hoaDonDTO)
        {
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO();
                chiTietHoaDonDTO.MaHoaDon = HoaDonBUS.Instance.searchMHD(hoaDonDTO);
                chiTietHoaDonDTO.MaSach = int.Parse(listView2.Items[i].SubItems[0].Text);
                chiTietHoaDonDTO.SoLuong = int.Parse(listView2.Items[i].SubItems[3].Text);
                chiTietHoaDonDTO.TongTien = double.Parse(listView2.Items[i].SubItems[4].Text);
                if (ChiTietHoaDonBUS.Instance.addCTDH(chiTietHoaDonDTO) == -1)
                {
                    MessageBox.Show("Lỗi tạo CTHD");
                }

            }
        }
        void TaoCTHD(HoaDonDTO hoaDonDTO)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO();
                chiTietHoaDonDTO.MaHoaDon = HoaDonBUS.Instance.searchMHD(hoaDonDTO);
                chiTietHoaDonDTO.MaSach = int.Parse(listView1.Items[i].SubItems[0].Text);
                chiTietHoaDonDTO.SoLuong = int.Parse(listView1.Items[i].SubItems[3].Text);
                chiTietHoaDonDTO.TongTien = double.Parse(listView1.Items[i].SubItems[4].Text);
                if (ChiTietHoaDonBUS.Instance.addCTDH(chiTietHoaDonDTO) == -1)
                {
                    MessageBox.Show("Lỗi tạo CTHD");
                }
                else
                {
                    //MessageBox.Show(chiTietHoaDonDTO.MaHoaDon);
                }
            }

        }
        void TaoHD()
        {
            HoaDonDTO hoaDonDTO = new HoaDonDTO();
            //hoaDonDTO.MaHoaDon = mahoadon;
            hoaDonDTO.MaKhachHang = makhachhang;
            hoaDonDTO.MaNhanVien = manhanvien;
            hoaDonDTO.NgayHoaDon = DateTime.UtcNow.ToString("MM-dd-yyyy");
            hoaDonDTO.ThanhTien = double.Parse(txtTongTien.Text);
            try
            {
                hoaDonDTO.ThanhToan = double.Parse(txtThanhToan.Text);
                hoaDonDTO.TienNo = double.Parse(txtNo.Text);
                if (HoaDonBUS.Instance.addHoaDon(hoaDonDTO) == -1)
                {
                    MessageBox.Show("Đã xảy ra lỗi!");
                }
                else
                {
                    TaoCTHD(hoaDonDTO);
                    updateKhachHang();
                    MessageBox.Show("Đã tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("nhập số tiền thanh toán!");
            }



        }
        void TaoHD2()
        {
            HoaDonDTO hoaDonDTO = new HoaDonDTO();
            hoaDonDTO.MaKhachHang = 1;
            hoaDonDTO.MaNhanVien = manhanvien;
            hoaDonDTO.NgayHoaDon = DateTime.UtcNow.ToString("MM-dd-yyyy");
            hoaDonDTO.ThanhTien = double.Parse(txtTongTien2.Text);
            try
            {
                hoaDonDTO.ThanhToan = double.Parse(txtTongTien2.Text);
                hoaDonDTO.TienNo = 0;
                if (HoaDonBUS.Instance.addHoaDon(hoaDonDTO) == -1)
                {
                    MessageBox.Show("Đã xảy ra lỗi!");
                }
                else
                {
                    TaoCTHD_KhachVangLai(hoaDonDTO);
                    MessageBox.Show("Đã tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset2();
                    LoadData2();
                }
            }
            catch
            {
                MessageBox.Show("nhập số tiền thanh toán!");
            }


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double no = double.Parse(txtNo.Text) + FrmTimKiemKhachHang.tienno;

            if (no > FrmMain.NoToiDa)
            {
                MessageBox.Show("Số nợ của khách hàng là " + FrmTimKiemKhachHang.tienno + ", Nợ tối đa chỉ là " + FrmMain.NoToiDa);
            }
            else
            {
                TaoHD();
                Reset();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtSearch.Text != "")
                {
                    if (cbSearch.Text == "tên sách")
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
                else
                {
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    if (cbSearch.Text == "tên sách")
                    {
                        dataGridView2.DataSource = SachBUS.Instance.searchSach("TenSach", txtSearch.Text);
                        dataGridView2.AutoGenerateColumns = false;
                    }
                    else if (cbSearch.Text == "thể loại")
                    {
                        dataGridView2.DataSource = SachBUS.Instance.searchSach("TenTheLoai", txtSearch.Text);
                        dataGridView2.AutoGenerateColumns = false;
                    }
                    else if (cbSearch.Text == "tác giả")
                    {
                        dataGridView2.DataSource = SachBUS.Instance.searchSach("TenTacGia", txtSearch.Text);
                        dataGridView2.AutoGenerateColumns = false;
                    }
                }
                else
                {
                    LoadData2();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numrow = e.RowIndex;

                //masach = int.Parse(dataGridView1.Rows[numrow].Cells[0].Value.ToString());
                //txtTenSach.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                //txtGiaNhap.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                //txtGiaBan.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
                soluong = int.Parse(dataGridView2.Rows[numrow].Cells[5].Value.ToString());
                //gianhap = double.Parse(txtGiaNhap.Text);
                //DataTable sach = SachBUS.Instance.getSach(masach);
                //cbTheLoai.SelectedValue = sach.Rows[0][5];
                //cbNXB.SelectedValue = sach.Rows[0][6];
                //cbTacGia.SelectedValue = sach.Rows[0][7];

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnAddToHD2_Click(object sender, EventArgs e)
        {
            if (soluong <= FrmMain.SoLuongTonKhoToiThieu)
            {
                // MessageBox.Show(soluong.ToString() + FrmMain.SoLuongTonKhoToiThieu.ToString());
                MessageBox.Show("Lượng tồn kho đạt mức tối thiểu, vui lòng nhập thêm sách!");
            }
            else
            {
                ListViewItem item = new ListViewItem(dataGridView2.Rows[numrow].Cells[0].Value.ToString());
                item.SubItems.Add(dataGridView2.Rows[numrow].Cells[1].Value.ToString());
                item.SubItems.Add(dataGridView2.Rows[numrow].Cells[2].Value.ToString());
                item.SubItems.Add(txtSoLuong2.Text);

                double gia = double.Parse(dataGridView2.Rows[numrow].Cells[2].Value.ToString()) * double.Parse(txtSoLuong.Text.Trim());
                item.SubItems.Add(gia.ToString());
                listView2.Items.Add(item);
                //masach.Add(int.Parse(dataGridView1.Rows[numrow].Cells[0].Value.ToString()));
                TinhTongTien2();
            }


        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            TaoHD2();
        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }

        /*private void navigationPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
         {
             if(listView2.Columns.Count == 5)
             {
                 var col = listView2.Columns[4];
                 listView2.Columns.Remove(col);
             }

             dataGridView2.AutoGenerateColumns = false;
             LoadData2();
             listView2.Columns.Add("Giá", 60);
             listView2.View = View.Details;
         }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Reset2();
            LoadData2();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Reset2();
            LoadData2();
        }

        private void btnResetThanhToan_Click(object sender, EventArgs e)
        {
            txtThanhToan.Text = "";
        }

        private void btnAddToHD_Click(object sender, EventArgs e)
        {

            if (soluong <= FrmMain.SoLuongTonKhoToiThieu)
            {
                // MessageBox.Show(soluong.ToString() + FrmMain.SoLuongTonKhoToiThieu.ToString());
                MessageBox.Show("Lượng tồn kho đạt mức tối thiểu, vui lòng nhập thêm sách!");
            }
            else
            {
                ListViewItem item = new ListViewItem(dataGridView1.Rows[numrow].Cells[0].Value.ToString());
                item.SubItems.Add(dataGridView1.Rows[numrow].Cells[1].Value.ToString());
                item.SubItems.Add(dataGridView1.Rows[numrow].Cells[2].Value.ToString());
                item.SubItems.Add(txtSoLuong.Text);

                double gia = double.Parse(dataGridView1.Rows[numrow].Cells[2].Value.ToString()) * double.Parse(txtSoLuong.Text.Trim());
                item.SubItems.Add(gia.ToString());
                listView1.Items.Add(item);
                //masach.Add(int.Parse(dataGridView1.Rows[numrow].Cells[0].Value.ToString()));
                TinhTongTien();
            }

        }
    }
}