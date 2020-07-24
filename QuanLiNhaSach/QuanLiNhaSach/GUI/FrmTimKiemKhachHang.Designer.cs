namespace QuanLiNhaSach.GUI
{
    partial class FrmTimKiemKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenKhachHang,
            this.DiaChi,
            this.Phone,
            this.Email,
            this.TienNo});
            this.dataGridView1.Location = new System.Drawing.Point(62, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 340);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaKhachHang";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số ĐT";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // TienNo
            // 
            this.TienNo.DataPropertyName = "TienNo";
            this.TienNo.HeaderText = "Tiền Nợ";
            this.TienNo.Name = "TienNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(219, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 16);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Tên",
            "SĐT",
            "Email"});
            this.cbSearch.Location = new System.Drawing.Point(134, 21);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(77, 24);
            this.cbSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.AppearanceHovered.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.AppearanceHovered.Options.UseBackColor = true;
            this.btnSearch.AppearancePressed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.AppearancePressed.Options.UseBackColor = true;
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSearch.Location = new System.Drawing.Point(426, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 30);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnChon
            // 
            this.btnChon.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChon.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnChon.Appearance.Options.UseBackColor = true;
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.Appearance.Options.UseForeColor = true;
            this.btnChon.AppearanceHovered.BackColor = System.Drawing.Color.Navy;
            this.btnChon.AppearanceHovered.Options.UseBackColor = true;
            this.btnChon.AppearancePressed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChon.AppearancePressed.Options.UseBackColor = true;
            this.btnChon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnChon.Location = new System.Drawing.Point(62, 67);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(162, 30);
            this.btnChon.TabIndex = 17;
            this.btnChon.Text = "CHỌN";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // FrmTimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 471);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimKiemKhachHang";
            this.Text = "Tìm kiếm khách hàng";
            this.Load += new System.EventHandler(this.FrmTimKiemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnChon;
    }
}