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
    public partial class FrmThongKe : DevExpress.XtraEditors.XtraForm
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbThongKe.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = ThongKeBUS.Instance.ThongKeTheoThang();
                }else if(cbThongKe.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = ThongKeBUS.Instance.ThongKeTheoSach();
                }else if(cbThongKe.SelectedIndex == 2)
                {
                    dataGridView1.DataSource = ThongKeBUS.Instance.ThongKeTheoTheLoai();
                }
            }
            catch {
                MessageBox.Show("error");
            }
        }
    }
}