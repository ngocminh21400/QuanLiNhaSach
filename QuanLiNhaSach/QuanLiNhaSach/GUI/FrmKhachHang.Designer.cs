namespace QuanLiNhaSach.GUI
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grThem = new System.Windows.Forms.GroupBox();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAdd = new System.Windows.Forms.Label();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnExportCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.grThem.SuspendLayout();
            this.navigationPage3.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage3});
            this.navigationPane1.RegularSize = new System.Drawing.Size(407, 580);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(407, 580);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Khách Hàng";
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(647, 342);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Khách hàng";
            this.navigationPage2.Controls.Add(this.grThem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(274, 490);
            // 
            // grThem
            // 
            this.grThem.Controls.Add(this.btnReset);
            this.grThem.Controls.Add(this.btnThem);
            this.grThem.Controls.Add(this.txtEmail);
            this.grThem.Controls.Add(this.txtPhone);
            this.grThem.Controls.Add(this.label3);
            this.grThem.Controls.Add(this.label2);
            this.grThem.Controls.Add(this.label1);
            this.grThem.Controls.Add(this.txtName);
            this.grThem.Controls.Add(this.txtAddress);
            this.grThem.Controls.Add(this.lbAdd);
            this.grThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.grThem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThem.Location = new System.Drawing.Point(0, 0);
            this.grThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grThem.Name = "grThem";
            this.grThem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grThem.Size = new System.Drawing.Size(280, 490);
            this.grThem.TabIndex = 2;
            this.grThem.TabStop = false;
            this.grThem.Text = "Thêm khách hàng";
            // 
            // btnReset
            // 
            this.btnReset.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReset.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnReset.Appearance.Options.UseBackColor = true;
            this.btnReset.Appearance.Options.UseBorderColor = true;
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Appearance.Options.UseForeColor = true;
            this.btnReset.Appearance.Options.UseImage = true;
            this.btnReset.Appearance.Options.UseTextOptions = true;
            this.btnReset.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnReset.AppearanceDisabled.Options.UseBackColor = true;
            this.btnReset.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnReset.AppearanceHovered.Options.UseBackColor = true;
            this.btnReset.AppearanceHovered.Options.UseForeColor = true;
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnReset.Location = new System.Drawing.Point(6, 217);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 42);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Appearance.Options.UseImage = true;
            this.btnThem.Appearance.Options.UseTextOptions = true;
            this.btnThem.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnThem.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThem.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThem.AppearanceHovered.Options.UseBackColor = true;
            this.btnThem.AppearanceHovered.Options.UseForeColor = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnThem.Location = new System.Drawing.Point(155, 217);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 42);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail.Location = new System.Drawing.Point(125, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPhone.Location = new System.Drawing.Point(125, 118);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 20);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtName.Location = new System.Drawing.Point(125, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAddress.Location = new System.Drawing.Point(125, 78);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(149, 20);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.Location = new System.Drawing.Point(-3, 46);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(118, 17);
            this.lbAdd.TabIndex = 2;
            this.lbAdd.Text = "Tên khách hàng";
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Tìm kiếm";
            this.navigationPage3.Controls.Add(this.btnSearch);
            this.navigationPage3.Controls.Add(this.label4);
            this.navigationPage3.Controls.Add(this.txtSearch);
            this.navigationPage3.Controls.Add(this.cbSearch);
            this.navigationPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(274, 490);
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
            this.btnSearch.Location = new System.Drawing.Point(81, 184);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 49);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSearch.Location = new System.Drawing.Point(92, 128);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Tên",
            "SĐT",
            "Email"});
            this.cbSearch.Location = new System.Drawing.Point(91, 76);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(140, 24);
            this.cbSearch.TabIndex = 0;
            // 
            // grDanhSach
            // 
            this.grDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDanhSach.Controls.Add(this.dataGridView1);
            this.grDanhSach.Controls.Add(this.toolStrip1);
            this.grDanhSach.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhSach.Location = new System.Drawing.Point(414, 0);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Size = new System.Drawing.Size(504, 565);
            this.grDanhSach.TabIndex = 4;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 469);
            this.dataGridView1.TabIndex = 1;
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSua,
            this.btnXoa,
            this.btnReload,
            this.btnExportCSV,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(81, 24);
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnExportCSV.Image")));
            this.btnExportCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(97, 24);
            this.btnExportCSV.Text = "Xuất CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton1.Text = "Trả nợ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 580);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.navigationPane1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmKhachHang.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.grThem.ResumeLayout(false);
            this.grThem.PerformLayout();
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage3.PerformLayout();
            this.grDanhSach.ResumeLayout(false);
            this.grDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.GroupBox grThem;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAdd;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnExportCSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}