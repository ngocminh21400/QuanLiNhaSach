namespace QuanLiNhaSach.GUI
{
    partial class FrmNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapKho));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhapKho = new DevExpress.XtraEditors.SimpleButton();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNhapKho);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(297, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập kho";
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNhapKho.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Appearance.Options.UseBackColor = true;
            this.btnNhapKho.Appearance.Options.UseFont = true;
            this.btnNhapKho.Appearance.Options.UseForeColor = true;
            this.btnNhapKho.AppearanceHovered.BackColor = System.Drawing.Color.Navy;
            this.btnNhapKho.AppearanceHovered.Options.UseBackColor = true;
            this.btnNhapKho.AppearancePressed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNhapKho.AppearancePressed.Options.UseBackColor = true;
            this.btnNhapKho.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNhapKho.Location = new System.Drawing.Point(92, 170);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(140, 43);
            this.btnNhapKho.TabIndex = 14;
            this.btnNhapKho.Text = "NHẬP KHO";
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThanhTien.Location = new System.Drawing.Point(134, 137);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(142, 21);
            this.txtThanhTien.TabIndex = 5;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thành tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Location = new System.Drawing.Point(134, 92);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(142, 21);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.White;
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSach.Location = new System.Drawing.Point(134, 47);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(142, 21);
            this.txtMaSach.TabIndex = 0;
            this.txtMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 278);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmNhapKho.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNhapKho";
            this.Text = "Nhập Kho";
            this.Load += new System.EventHandler(this.FrmNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSach;
        private DevExpress.XtraEditors.SimpleButton btnNhapKho;
    }
}