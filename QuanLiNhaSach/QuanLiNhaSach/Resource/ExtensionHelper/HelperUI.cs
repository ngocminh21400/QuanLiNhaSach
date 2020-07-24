using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLiNhaSach.Resource.ExtensionHelper
{
    class HelperUI
    {

        //Mỗi khi tạo ra class ở bất cứ đâu trừ - DTO thì đều thêm cái phần instance này vào -> đổi tên theo class là dùng được
        #region instance
        private static HelperUI instance;

        internal static HelperUI Instance
        {
            get
            {
                if (instance == null) instance = new HelperUI(); return ExtensionHelper.HelperUI.instance;
            }

            private set
            {
                ExtensionHelper.HelperUI.instance = value;
            }
        }
        #endregion

        public void HamHoTroUI()
        {
            MessageBox.Show("Hàm Hỗ trợ UI sẽ được viết trong đyâ");
        }

        #region ExportCSV
        public void ExportExcel(DataGridView dgv_DL)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    //sfd.Title = "Save an Excel File";
                    //sfd.ShowDialog();
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult dlg = MessageBox.Show("Bạn có chắc chắn xuất CSV!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dlg == DialogResult.OK)
                        {
                            app obj = new app();
                            obj.Application.Workbooks.Add(Type.Missing);
                            obj.Columns.ColumnWidth = 25;

                            for (int i = 1; i < dgv_DL.Columns.Count + 1; i++)
                                obj.Cells[1, i] = dgv_DL.Columns[i - 1].HeaderText;

                            for (int i = 0; i < dgv_DL.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv_DL.Columns.Count; j++)
                                {
                                    if (dgv_DL.Rows[i].Cells[j].Value != null)
                                        obj.Cells[i + 2, j + 1] = dgv_DL.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                            obj.ActiveWorkbook.SaveCopyAs(sfd.FileName.ToString());
                            obj.ActiveWorkbook.Saved = true;
                            obj.Quit();
                            MessageBox.Show("Xuất File Thành Công!");
                        }
                    }
                }
            }
            catch
            {

            }
        }
        #endregion

    }
}
