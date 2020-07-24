namespace QuanLiNhaSach.GUI
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lbAdd = new System.Windows.Forms.Label();
            this.grThem = new System.Windows.Forms.GroupBox();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnExportCSV = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.navigationPage3.SuspendLayout();
            this.grThem.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(121, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 16);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(121, 222);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 16);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(121, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 16);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(121, 188);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(149, 16);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Tìm kiếm";
            this.navigationPage3.Controls.Add(this.btnSearch);
            this.navigationPage3.Controls.Add(this.label7);
            this.navigationPage3.Controls.Add(this.txtSearch);
            this.navigationPage3.Controls.Add(this.cbSearch);
            this.navigationPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(306, 463);
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
            this.btnSearch.Location = new System.Drawing.Point(93, 143);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 49);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(93, 91);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 16);
            this.txtSearch.TabIndex = 5;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Tên",
            "SĐT",
            "Email"});
            this.cbSearch.Location = new System.Drawing.Point(93, 41);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(140, 24);
            this.cbSearch.TabIndex = 4;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.Location = new System.Drawing.Point(3, 44);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(105, 17);
            this.lbAdd.TabIndex = 2;
            this.lbAdd.Text = "Tên nhân viên";
            // 
            // grThem
            // 
            this.grThem.Controls.Add(this.btnReset);
            this.grThem.Controls.Add(this.btnAdd);
            this.grThem.Controls.Add(this.txtPassword);
            this.grThem.Controls.Add(this.txtUsername);
            this.grThem.Controls.Add(this.label9);
            this.grThem.Controls.Add(this.label8);
            this.grThem.Controls.Add(this.date);
            this.grThem.Controls.Add(this.label6);
            this.grThem.Controls.Add(this.cbGioiTinh);
            this.grThem.Controls.Add(this.label5);
            this.grThem.Controls.Add(this.cbLoaiNhanVien);
            this.grThem.Controls.Add(this.label4);
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
            this.grThem.Size = new System.Drawing.Size(280, 463);
            this.grThem.TabIndex = 2;
            this.grThem.TabStop = false;
            this.grThem.Text = "Thêm  nhân viên";
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
            this.btnReset.Location = new System.Drawing.Point(10, 385);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 42);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Appearance.Options.UseImage = true;
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd.Location = new System.Drawing.Point(155, 385);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 42);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(121, 346);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 16);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(121, 305);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 16);
            this.txtUsername.TabIndex = 21;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Username";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(121, 258);
            this.date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(149, 23);
            this.date.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày sinh";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "nam",
            "nữ",
            "khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(121, 114);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(149, 24);
            this.cbGioiTinh.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giới tính";
            // 
            // cbLoaiNhanVien
            // 
            this.cbLoaiNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLoaiNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLoaiNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLoaiNhanVien.FormattingEnabled = true;
            this.cbLoaiNhanVien.Items.AddRange(new object[] {
            "nhân viên",
            "admin"});
            this.cbLoaiNhanVien.Location = new System.Drawing.Point(121, 81);
            this.cbLoaiNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiNhanVien.Name = "cbLoaiNhanVien";
            this.cbLoaiNhanVien.Size = new System.Drawing.Size(149, 24);
            this.cbLoaiNhanVien.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loại nhân viên";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(647, 342);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Nhân viên";
            this.navigationPage2.Controls.Add(this.grThem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(306, 463);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage3});
            this.navigationPane1.RegularSize = new System.Drawing.Size(429, 553);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(429, 553);
            this.navigationPane1.TabIndex = 1;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSua,
            this.btnXoa,
            this.btnReload,
            this.btnExportCSV});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(470, 27);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenNhanVien,
            this.LoaiNhanVien,
            this.DiaChi,
            this.SoDienThoai,
            this.Email,
            this.NgaySinh,
            this.GioiTinh,
            this.username});
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 457);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaNhanVien";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // LoaiNhanVien
            // 
            this.LoaiNhanVien.DataPropertyName = "MaLoaiNhanVien";
            this.LoaiNhanVien.HeaderText = "Mã loại nhân viên";
            this.LoaiNhanVien.Name = "LoaiNhanVien";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số ĐT";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // username
            // 
            this.username.DataPropertyName = "UserName";
            this.username.HeaderText = " username";
            this.username.Name = "username";
            // 
            // grDanhSach
            // 
            this.grDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDanhSach.Controls.Add(this.dataGridView1);
            this.grDanhSach.Controls.Add(this.toolStrip1);
            this.grDanhSach.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhSach.Location = new System.Drawing.Point(436, 0);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Size = new System.Drawing.Size(476, 553);
            this.grDanhSach.TabIndex = 3;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 553);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.grDanhSach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage3.PerformLayout();
            this.grThem.ResumeLayout(false);
            this.grThem.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grDanhSach.ResumeLayout(false);
            this.grDanhSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.GroupBox grThem;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiNhanVien;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnExportCSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}