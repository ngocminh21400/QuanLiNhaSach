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

namespace QuanLiNhaSach.GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (DAO.ConnectionSQL.OpenConnection() == false)
            {
                ReConnection();
            }
        }

        #region frmConnection
        FrmConnectionSQL m_Connection = null;
        //frmLogin m_FrmLogin = null;
        public void ReConnection()
        {
            MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            //m_Connection = new frmConnection();
            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new FrmConnectionSQL();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
                return;
        }
        #endregion

        int checkUser(string username, string password)
        {
            return BUS.NhanVienBUS.Instance.checkUser(username,password).Rows.Count;
        }
        void login()
        {
            try
            {
                NhanVienDTO nv = new NhanVienDTO();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                //MessageBox.Show(checkUser(username, password).ToString());
                if (checkUser(username, password) >= 1)
                {
                    nv.Username = username;
                    nv.Password = password;
                    Program.user = username;
                    FrmMain f = new FrmMain();
                    //frmMain.QuyenHan = AD_BUS.GetQuyenHan(AD);

                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

           

            }
            catch
            {
                MessageBox.Show("Bạn chưa kết nối cơ sở dữ liệu vui vòng kết nối lại!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}