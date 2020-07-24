namespace QuanLiNhaSach.GUI
{
    partial class FrmThemNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemNXB));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenNXB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(320, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Nhà Xuất Bản";
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
            this.btnThem.Location = new System.Drawing.Point(94, 100);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 42);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.BackColor = System.Drawing.Color.White;
            this.txtTenNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNXB.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTenNXB.Location = new System.Drawing.Point(162, 60);
            this.txtTenNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(146, 20);
            this.txtTenNXB.TabIndex = 1;
            this.txtTenNXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà xuất bản";
            // 
            // FrmThemNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 197);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmThemNXB.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmThemNXB";
            this.Text = "Thêm Nhà Xuất Bản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}