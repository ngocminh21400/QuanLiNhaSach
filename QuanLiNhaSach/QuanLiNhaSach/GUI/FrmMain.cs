using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLiNhaSach.BUS;
using QuanLiNhaSach.DTO;

namespace QuanLiNhaSach.GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static int SoLuongNhapToiThieu, SoLuongTonToiThieuKhiNhap, SoLuongTonKhoToiThieu;
        public static double NoToiDa;
        public static int TienBan;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region ClickAction
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //try
            //{
            //    //frmTestMdi f = new frmTestMdi();
            //    if (ExistForm(f)) return;
            //    f.MdiParent = this;
            //    f.Show();
            //}
            //catch { }
        }
        #endregion

        #region Function
        private bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("message");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmSach f = new FrmSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable qd = QuyDinhBUS.Instance.getAll();
            SoLuongNhapToiThieu = int.Parse(qd.Rows[0][1].ToString());
            SoLuongTonToiThieuKhiNhap = int.Parse(qd.Rows[0][2].ToString());
            SoLuongTonKhoToiThieu = int.Parse(qd.Rows[0][3].ToString());
            NoToiDa = double.Parse(qd.Rows[0][4].ToString());
            TienBan = int.Parse(qd.Rows[0][5].ToString());
            FrmHoaDon s = new FrmHoaDon();
            if (ExistForm(s)) return;
            s.MdiParent = this;
            s.Show();

        }


        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmKhachHang f = new FrmKhachHang();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmNhanVien f = new FrmNhanVien();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmHoaDon f = new FrmHoaDon();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmThongKe f = new FrmThongKe();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmQuyDinh f = new FrmQuyDinh();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmTaiKhoan f = new FrmTaiKhoan();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
              
            }
            catch { }
        }
    }
}