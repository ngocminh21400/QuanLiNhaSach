namespace QuanLiNhaSach.GUI
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grThem = new System.Windows.Forms.GroupBox();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnAddToHD = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong2 = new System.Windows.Forms.TextBox();
            this.btnAddToHD2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddHoaDon2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongTien2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.grThem.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.navigationPage3.SuspendLayout();
            this.navigationPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Controls.Add(this.navigationPage4);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage4});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1282, 572);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(1282, 572);
            this.navigationPane1.TabIndex = 6;
            this.navigationPane1.Text = "navigationPane1";
            this.navigationPane1.Click += new System.EventHandler(this.navigationPane1_Click);
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
            this.navigationPage2.Caption = "Thành viên";
            this.navigationPage2.Controls.Add(this.grThem);
            this.navigationPage2.Controls.Add(this.grDanhSach);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1133, 482);
            // 
            // grThem
            // 
            this.grThem.Controls.Add(this.btnReset);
            this.grThem.Controls.Add(this.btnAddHoaDon);
            this.grThem.Controls.Add(this.btnResetThanhToan);
            this.grThem.Controls.Add(this.btnAddKhachHang);
            this.grThem.Controls.Add(this.listView1);
            this.grThem.Controls.Add(this.txtTenKhachHang);
            this.grThem.Controls.Add(this.txtThanhToan);
            this.grThem.Controls.Add(this.txtNo);
            this.grThem.Controls.Add(this.txtTongTien);
            this.grThem.Controls.Add(this.label4);
            this.grThem.Controls.Add(this.label3);
            this.grThem.Controls.Add(this.label2);
            this.grThem.Controls.Add(this.label1);
            this.grThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.grThem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThem.Location = new System.Drawing.Point(0, 0);
            this.grThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grThem.Name = "grThem";
            this.grThem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grThem.Size = new System.Drawing.Size(437, 482);
            this.grThem.TabIndex = 2;
            this.grThem.TabStop = false;
            this.grThem.Text = "Hóa đơn";
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
            this.btnReset.Location = new System.Drawing.Point(31, 406);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 42);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddHoaDon
            // 
            this.btnAddHoaDon.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddHoaDon.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddHoaDon.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHoaDon.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddHoaDon.Appearance.Options.UseBackColor = true;
            this.btnAddHoaDon.Appearance.Options.UseBorderColor = true;
            this.btnAddHoaDon.Appearance.Options.UseFont = true;
            this.btnAddHoaDon.Appearance.Options.UseForeColor = true;
            this.btnAddHoaDon.Appearance.Options.UseImage = true;
            this.btnAddHoaDon.Appearance.Options.UseTextOptions = true;
            this.btnAddHoaDon.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnAddHoaDon.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAddHoaDon.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddHoaDon.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAddHoaDon.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddHoaDon.AppearanceHovered.Options.UseForeColor = true;
            this.btnAddHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHoaDon.ImageOptions.Image")));
            this.btnAddHoaDon.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddHoaDon.Location = new System.Drawing.Point(227, 406);
            this.btnAddHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddHoaDon.Name = "btnAddHoaDon";
            this.btnAddHoaDon.Size = new System.Drawing.Size(164, 42);
            this.btnAddHoaDon.TabIndex = 30;
            this.btnAddHoaDon.Text = "Tạo Hóa Đơn";
            this.btnAddHoaDon.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnResetThanhToan
            // 
            this.btnResetThanhToan.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnResetThanhToan.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetThanhToan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetThanhToan.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnResetThanhToan.Appearance.Options.UseBackColor = true;
            this.btnResetThanhToan.Appearance.Options.UseBorderColor = true;
            this.btnResetThanhToan.Appearance.Options.UseFont = true;
            this.btnResetThanhToan.Appearance.Options.UseForeColor = true;
            this.btnResetThanhToan.Appearance.Options.UseImage = true;
            this.btnResetThanhToan.Appearance.Options.UseTextOptions = true;
            this.btnResetThanhToan.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnResetThanhToan.AppearanceDisabled.Options.UseBackColor = true;
            this.btnResetThanhToan.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResetThanhToan.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnResetThanhToan.AppearanceHovered.Options.UseBackColor = true;
            this.btnResetThanhToan.AppearanceHovered.Options.UseForeColor = true;
            this.btnResetThanhToan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnResetThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetThanhToan.ImageOptions.Image")));
            this.btnResetThanhToan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnResetThanhToan.Location = new System.Drawing.Point(294, 318);
            this.btnResetThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetThanhToan.Name = "btnResetThanhToan";
            this.btnResetThanhToan.Size = new System.Drawing.Size(50, 32);
            this.btnResetThanhToan.TabIndex = 29;
            this.btnResetThanhToan.Click += new System.EventHandler(this.btnResetThanhToan_Click);
            // 
            // btnAddKhachHang
            // 
            this.btnAddKhachHang.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddKhachHang.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddKhachHang.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKhachHang.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddKhachHang.Appearance.Options.UseBackColor = true;
            this.btnAddKhachHang.Appearance.Options.UseBorderColor = true;
            this.btnAddKhachHang.Appearance.Options.UseFont = true;
            this.btnAddKhachHang.Appearance.Options.UseForeColor = true;
            this.btnAddKhachHang.Appearance.Options.UseImage = true;
            this.btnAddKhachHang.Appearance.Options.UseTextOptions = true;
            this.btnAddKhachHang.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnAddKhachHang.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAddKhachHang.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddKhachHang.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAddKhachHang.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddKhachHang.AppearanceHovered.Options.UseForeColor = true;
            this.btnAddKhachHang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddKhachHang.ImageOptions.Image")));
            this.btnAddKhachHang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddKhachHang.Location = new System.Drawing.Point(335, 31);
            this.btnAddKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddKhachHang.Name = "btnAddKhachHang";
            this.btnAddKhachHang.Size = new System.Drawing.Size(57, 42);
            this.btnAddKhachHang.TabIndex = 28;
            this.btnAddKhachHang.Click += new System.EventHandler(this.btnAddKhachHang_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 91);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 169);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.White;
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKhachHang.Location = new System.Drawing.Point(149, 39);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(168, 16);
            this.txtTenKhachHang.TabIndex = 12;
            this.txtTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.Color.White;
            this.txtThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThanhToan.Location = new System.Drawing.Point(160, 318);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(115, 16);
            this.txtThanhToan.TabIndex = 8;
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThanhToan.TextChanged += new System.EventHandler(this.txtThanhToan_TextChanged);
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.White;
            this.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNo.Location = new System.Drawing.Point(160, 350);
            this.txtNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(115, 16);
            this.txtNo.TabIndex = 7;
            this.txtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Location = new System.Drawing.Point(160, 282);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(115, 16);
            this.txtTongTien.TabIndex = 6;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tiền trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // grDanhSach
            // 
            this.grDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDanhSach.Controls.Add(this.label5);
            this.grDanhSach.Controls.Add(this.txtSoLuong);
            this.grDanhSach.Controls.Add(this.btnAddToHD);
            this.grDanhSach.Controls.Add(this.btnSearch);
            this.grDanhSach.Controls.Add(this.label7);
            this.grDanhSach.Controls.Add(this.txtSearch);
            this.grDanhSach.Controls.Add(this.cbSearch);
            this.grDanhSach.Controls.Add(this.dataGridView1);
            this.grDanhSach.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grDanhSach.Location = new System.Drawing.Point(444, -1);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Size = new System.Drawing.Size(718, 552);
            this.grDanhSach.TabIndex = 5;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Location = new System.Drawing.Point(535, 26);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(42, 16);
            this.txtSoLuong.TabIndex = 13;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddToHD
            // 
            this.btnAddToHD.BackColor = System.Drawing.Color.Navy;
            this.btnAddToHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToHD.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.btnAddToHD.ForeColor = System.Drawing.Color.White;
            this.btnAddToHD.Location = new System.Drawing.Point(593, 17);
            this.btnAddToHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToHD.Name = "btnAddToHD";
            this.btnAddToHD.Size = new System.Drawing.Size(68, 41);
            this.btnAddToHD.TabIndex = 12;
            this.btnAddToHD.Text = "Chọn";
            this.btnAddToHD.UseVisualStyleBackColor = false;
            this.btnAddToHD.Click += new System.EventHandler(this.btnAddToHD_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(383, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "clear";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(191, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 16);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "tên sách",
            "thể loại",
            "tác giả"});
            this.cbSearch.Location = new System.Drawing.Point(78, 25);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(90, 24);
            this.cbSearch.TabIndex = 8;
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
            this.TenSach,
            this.GiaBan,
            this.TenTheLoai,
            this.TacGia,
            this.Sl});
            this.dataGridView1.Location = new System.Drawing.Point(16, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 435);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaSach";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Thể loại";
            this.TenTheLoai.Name = "TenTheLoai";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TenTacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.Name = "TacGia";
            // 
            // Sl
            // 
            this.Sl.DataPropertyName = "SoLuong";
            this.Sl.HeaderText = "Số lượng";
            this.Sl.Name = "Sl";
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "navigationPage3";
            this.navigationPage3.Controls.Add(this.button1);
            this.navigationPage3.Controls.Add(this.label8);
            this.navigationPage3.Controls.Add(this.textBox1);
            this.navigationPage3.Controls.Add(this.comboBox1);
            this.navigationPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(287, 482);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "label8";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 23);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên",
            "SĐT",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(93, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "Khách vãng lai";
            this.navigationPage4.Controls.Add(this.groupBox2);
            this.navigationPage4.Controls.Add(this.groupBox1);
            this.navigationPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(1137, 482);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSoLuong2);
            this.groupBox2.Controls.Add(this.btnAddToHD2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(444, -1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(689, 528);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "số lượng";
            // 
            // txtSoLuong2
            // 
            this.txtSoLuong2.Location = new System.Drawing.Point(535, 26);
            this.txtSoLuong2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong2.Name = "txtSoLuong2";
            this.txtSoLuong2.Size = new System.Drawing.Size(42, 23);
            this.txtSoLuong2.TabIndex = 13;
            // 
            // btnAddToHD2
            // 
            this.btnAddToHD2.BackColor = System.Drawing.Color.Navy;
            this.btnAddToHD2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToHD2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToHD2.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.btnAddToHD2.ForeColor = System.Drawing.Color.White;
            this.btnAddToHD2.Location = new System.Drawing.Point(593, 17);
            this.btnAddToHD2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToHD2.Name = "btnAddToHD2";
            this.btnAddToHD2.Size = new System.Drawing.Size(68, 41);
            this.btnAddToHD2.TabIndex = 12;
            this.btnAddToHD2.Text = "Chọn";
            this.btnAddToHD2.UseVisualStyleBackColor = false;
            this.btnAddToHD2.Click += new System.EventHandler(this.btnAddToHD2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tìm kiếm";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 27);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 23);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "tên sách",
            "thể loại",
            "tác giả"});
            this.comboBox2.Location = new System.Drawing.Point(58, 27);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.sl2});
            this.dataGridView2.Location = new System.Drawing.Point(16, 79);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(673, 411);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenTheLoai";
            this.dataGridViewTextBoxColumn4.HeaderText = "Thể loại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenTacGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tác giả";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // sl2
            // 
            this.sl2.DataPropertyName = "SoLuong";
            this.sl2.HeaderText = "Số lượng";
            this.sl2.Name = "sl2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btnAddHoaDon2);
            this.groupBox1.Controls.Add(this.txtTongTien2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(441, 482);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseImage = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simpleButton1.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(61, 314);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 42);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "Reset";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAddHoaDon2
            // 
            this.btnAddHoaDon2.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddHoaDon2.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddHoaDon2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHoaDon2.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddHoaDon2.Appearance.Options.UseBackColor = true;
            this.btnAddHoaDon2.Appearance.Options.UseBorderColor = true;
            this.btnAddHoaDon2.Appearance.Options.UseFont = true;
            this.btnAddHoaDon2.Appearance.Options.UseForeColor = true;
            this.btnAddHoaDon2.Appearance.Options.UseImage = true;
            this.btnAddHoaDon2.Appearance.Options.UseTextOptions = true;
            this.btnAddHoaDon2.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnAddHoaDon2.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAddHoaDon2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddHoaDon2.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAddHoaDon2.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddHoaDon2.AppearanceHovered.Options.UseForeColor = true;
            this.btnAddHoaDon2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddHoaDon2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddHoaDon2.Location = new System.Drawing.Point(230, 314);
            this.btnAddHoaDon2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddHoaDon2.Name = "btnAddHoaDon2";
            this.btnAddHoaDon2.Size = new System.Drawing.Size(164, 42);
            this.btnAddHoaDon2.TabIndex = 31;
            this.btnAddHoaDon2.Text = "Tạo Hóa Đơn";
            this.btnAddHoaDon2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // txtTongTien2
            // 
            this.txtTongTien2.BackColor = System.Drawing.Color.White;
            this.txtTongTien2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien2.Location = new System.Drawing.Point(104, 244);
            this.txtTongTien2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien2.Name = "txtTongTien2";
            this.txtTongTien2.ReadOnly = true;
            this.txtTongTien2.Size = new System.Drawing.Size(164, 16);
            this.txtTongTien2.TabIndex = 6;
            this.txtTongTien2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tổng tiền";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(23, 49);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(394, 174);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 572);
            this.Controls.Add(this.navigationPane1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmHoaDon.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.grThem.ResumeLayout(false);
            this.grThem.PerformLayout();
            this.grDanhSach.ResumeLayout(false);
            this.grDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage3.PerformLayout();
            this.navigationPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.GroupBox grThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtTongTien;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView2;
        //private System.Windows.Forms.ColumnHeader columnHeader1;
        //private System.Windows.Forms.ColumnHeader columnHeader2;
        //private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnAddToHD;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong2;
        private System.Windows.Forms.Button btnAddToHD2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl2;
        private DevExpress.XtraEditors.SimpleButton btnAddKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnResetThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnAddHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnAddHoaDon2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}