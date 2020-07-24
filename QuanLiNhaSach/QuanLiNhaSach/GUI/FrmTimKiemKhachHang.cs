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

namespace QuanLiNhaSach.GUI
{
    public partial class FrmTimKiemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public static string tenkhachhang;
        public static int makhachhang;
        public static double tienno;
        public FrmTimKiemKhachHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dataGridView1.DataSource = KhachHangBUS.Instance.getAll();
            cbSearch.SelectedText = "SĐT";
        }

        private void FrmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow = e.RowIndex;
                makhachhang =int.Parse (dataGridView1.Rows[numrow].Cells[0].Value.ToString());
                tenkhachhang = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                tienno = double.Parse(dataGridView1.Rows[numrow].Cells[5].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void btnChon_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}