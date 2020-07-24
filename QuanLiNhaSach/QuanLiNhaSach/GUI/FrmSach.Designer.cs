namespace QuanLiNhaSach.GUI
{
    partial class FrmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSach));
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.addNXB = new System.Windows.Forms.Button();
            this.addTacGia = new System.Windows.Forms.Button();
            this.addTheLoai = new System.Windows.Forms.Button();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnExportCSV = new System.Windows.Forms.ToolStripButton();
            this.btnNhapKho = new System.Windows.Forms.ToolStripButton();
            this.navigationPage2.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.btnSearch);
            this.navigationPage2.Controls.Add(this.label7);
            this.navigationPage2.Controls.Add(this.txtSearch);
            this.navigationPage2.Controls.Add(this.cbSearch);
            this.navigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.ImageOptions.Image")));
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(57, 460);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(98, 144);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(98, 89);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 23);
            this.txtSearch.TabIndex = 9;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "tên sách",
            "thể loại",
            "tác giả"});
            this.cbSearch.Location = new System.Drawing.Point(98, 38);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(140, 24);
            this.cbSearch.TabIndex = 8;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Sách";
            this.navigationPage1.Controls.Add(this.groupBox1);
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(313, 370);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.addNXB);
            this.groupBox1.Controls.Add(this.addTacGia);
            this.groupBox1.Controls.Add(this.addTheLoai);
            this.groupBox1.Controls.Add(this.cbNXB);
            this.groupBox1.Controls.Add(this.cbTacGia);
            this.groupBox1.Controls.Add(this.cbTheLoai);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(310, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm";
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
            this.btnReset.Location = new System.Drawing.Point(15, 303);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 42);
            this.btnReset.TabIndex = 25;
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
            this.btnAdd.Location = new System.Drawing.Point(177, 303);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 42);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-4, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nhà xuất bản:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tác giả:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Thể loại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(39, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giá bán:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Giá nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên sách:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.Color.White;
            this.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenSach.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.Location = new System.Drawing.Point(122, 52);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(182, 20);
            this.txtTenSach.TabIndex = 17;
            this.txtTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addNXB
            // 
            this.addNXB.Location = new System.Drawing.Point(272, 260);
            this.addNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addNXB.Name = "addNXB";
            this.addNXB.Size = new System.Drawing.Size(30, 28);
            this.addNXB.TabIndex = 14;
            this.addNXB.Text = "+";
            this.addNXB.UseVisualStyleBackColor = true;
            this.addNXB.Click += new System.EventHandler(this.addNXB_Click);
            // 
            // addTacGia
            // 
            this.addTacGia.Location = new System.Drawing.Point(272, 214);
            this.addTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addTacGia.Name = "addTacGia";
            this.addTacGia.Size = new System.Drawing.Size(30, 28);
            this.addTacGia.TabIndex = 13;
            this.addTacGia.Text = "+";
            this.addTacGia.UseVisualStyleBackColor = true;
            this.addTacGia.Click += new System.EventHandler(this.addTacGia_Click);
            // 
            // addTheLoai
            // 
            this.addTheLoai.Location = new System.Drawing.Point(272, 172);
            this.addTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addTheLoai.Name = "addTheLoai";
            this.addTheLoai.Size = new System.Drawing.Size(30, 28);
            this.addTheLoai.TabIndex = 12;
            this.addTheLoai.Text = "+";
            this.addTheLoai.UseVisualStyleBackColor = true;
            this.addTheLoai.Click += new System.EventHandler(this.addTheLoai_Click);
            // 
            // cbNXB
            // 
            this.cbNXB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNXB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(122, 261);
            this.cbNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(140, 24);
            this.cbNXB.TabIndex = 11;
            // 
            // cbTacGia
            // 
            this.cbTacGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTacGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(122, 215);
            this.cbTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(140, 24);
            this.cbTacGia.TabIndex = 7;
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(122, 172);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(140, 24);
            this.cbTheLoai.TabIndex = 6;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.White;
            this.txtGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaBan.Font = new System.Drawing.Font("Arial", 10F);
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.Location = new System.Drawing.Point(122, 129);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(180, 20);
            this.txtGiaBan.TabIndex = 5;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.White;
            this.txtGiaNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaNhap.Font = new System.Drawing.Font("Arial", 10F);
            this.txtGiaNhap.ForeColor = System.Drawing.Color.Black;
            this.txtGiaNhap.Location = new System.Drawing.Point(122, 87);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(182, 20);
            this.txtGiaNhap.TabIndex = 4;
            this.txtGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(412, 460);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(412, 460);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // grDanhSach
            // 
            this.grDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDanhSach.Controls.Add(this.dataGridView1);
            this.grDanhSach.Controls.Add(this.toolStrip1);
            this.grDanhSach.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grDanhSach.Location = new System.Drawing.Point(419, 0);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDanhSach.Size = new System.Drawing.Size(598, 460);
            this.grDanhSach.TabIndex = 5;
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenSach,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan,
            this.TenTheLoai,
            this.TacGia,
            this.NXB});
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 364);
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
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
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
            // NXB
            // 
            this.NXB.DataPropertyName = "TenNhaXuatBan";
            this.NXB.HeaderText = "Nhà xuất bản";
            this.NXB.Name = "NXB";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSua,
            this.btnXoa,
            this.btnReload,
            this.btnExportCSV,
            this.btnNhapKho});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(592, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 28);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 28);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(99, 28);
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnExportCSV.Image")));
            this.btnExportCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(123, 28);
            this.btnExportCSV.Text = "Xuất CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.Image")));
            this.btnNhapKho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(124, 28);
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 460);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.navigationPane1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmSach.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.navigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.grDanhSach.ResumeLayout(false);
            this.grDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Button addNXB;
        private System.Windows.Forms.Button addTacGia;
        private System.Windows.Forms.Button addTheLoai;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnExportCSV;
        private System.Windows.Forms.ToolStripButton btnNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTenSach;
        private DevExpress.XtraEditors.SimpleButton btnReset;
    }
}