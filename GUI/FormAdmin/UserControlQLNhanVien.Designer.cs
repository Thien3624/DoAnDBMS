namespace GUI.FormAdmin.UC_ThanPhanAdmin
{
    partial class UserControlQLNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewHienThiNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoaNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_suaThongTinNhanVien = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHienThiNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewHienThiNhanVien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridViewHienThiNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewHienThiNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewHienThiNhanVien.ColumnHeadersHeight = 28;
            this.gridViewHienThiNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewHienThiNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.CCCD,
            this.hoVaTen,
            this.gioiTinh,
            this.ngaySinh,
            this.soDienThoai,
            this.diaChi,
            this.trangThaiLamViec});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewHienThiNhanVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewHienThiNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewHienThiNhanVien.Location = new System.Drawing.Point(143, 304);
            this.gridViewHienThiNhanVien.Name = "gridViewHienThiNhanVien";
            this.gridViewHienThiNhanVien.RowHeadersVisible = false;
            this.gridViewHienThiNhanVien.Size = new System.Drawing.Size(900, 288);
            this.gridViewHienThiNhanVien.TabIndex = 0;
            this.gridViewHienThiNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewHienThiNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewHienThiNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewHienThiNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewHienThiNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewHienThiNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewHienThiNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewHienThiNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridViewHienThiNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewHienThiNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewHienThiNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewHienThiNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewHienThiNhanVien.ThemeStyle.HeaderStyle.Height = 28;
            this.gridViewHienThiNhanVien.ThemeStyle.ReadOnly = false;
            this.gridViewHienThiNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewHienThiNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewHienThiNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewHienThiNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewHienThiNhanVien.ThemeStyle.RowsStyle.Height = 22;
            this.gridViewHienThiNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewHienThiNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "MaNV";
            this.maNhanVien.Name = "maNhanVien";
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            // 
            // hoVaTen
            // 
            this.hoVaTen.DataPropertyName = "hoVaTen";
            this.hoVaTen.HeaderText = "TênNV";
            this.hoVaTen.Name = "hoVaTen";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.Name = "soDienThoai";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // trangThaiLamViec
            // 
            this.trangThaiLamViec.DataPropertyName = "trangThaiLamViec";
            this.trangThaiLamViec.HeaderText = "Trạng thái làm việc";
            this.trangThaiLamViec.Name = "trangThaiLamViec";
            // 
            // btn_themnhanvien
            // 
            this.btn_themnhanvien.BorderRadius = 20;
            this.btn_themnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themnhanvien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_themnhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themnhanvien.ForeColor = System.Drawing.Color.White;
            this.btn_themnhanvien.Location = new System.Drawing.Point(155, 152);
            this.btn_themnhanvien.Name = "btn_themnhanvien";
            this.btn_themnhanvien.Size = new System.Drawing.Size(234, 46);
            this.btn_themnhanvien.TabIndex = 3;
            this.btn_themnhanvien.Text = "Thêm nhân viên";
            this.btn_themnhanvien.Click += new System.EventHandler(this.btn_xemThongTinHoaDon_Click);
            // 
            // btn_xoaNhanVien
            // 
            this.btn_xoaNhanVien.BorderRadius = 20;
            this.btn_xoaNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoaNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xoaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_xoaNhanVien.Location = new System.Drawing.Point(463, 152);
            this.btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            this.btn_xoaNhanVien.Size = new System.Drawing.Size(234, 46);
            this.btn_xoaNhanVien.TabIndex = 4;
            this.btn_xoaNhanVien.Text = "Xóa nhân viên";
            this.btn_xoaNhanVien.Click += new System.EventHandler(this.btn_xoaNhanVien_Click);
            // 
            // btn_suaThongTinNhanVien
            // 
            this.btn_suaThongTinNhanVien.BorderRadius = 20;
            this.btn_suaThongTinNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suaThongTinNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_suaThongTinNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_suaThongTinNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_suaThongTinNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_suaThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaThongTinNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_suaThongTinNhanVien.Location = new System.Drawing.Point(771, 152);
            this.btn_suaThongTinNhanVien.Name = "btn_suaThongTinNhanVien";
            this.btn_suaThongTinNhanVien.Size = new System.Drawing.Size(234, 46);
            this.btn_suaThongTinNhanVien.TabIndex = 5;
            this.btn_suaThongTinNhanVien.Text = "Sửa thông tin nhân viên";
            // 
            // UserControlQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_suaThongTinNhanVien);
            this.Controls.Add(this.btn_xoaNhanVien);
            this.Controls.Add(this.btn_themnhanvien);
            this.Controls.Add(this.gridViewHienThiNhanVien);
            this.Name = "UserControlQLNhanVien";
            this.Size = new System.Drawing.Size(1186, 647);
            this.Load += new System.EventHandler(this.UserControlQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHienThiNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridViewHienThiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiLamViec;
        private Guna.UI2.WinForms.Guna2Button btn_themnhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_xoaNhanVien;
        private Guna.UI2.WinForms.Guna2Button btn_suaThongTinNhanVien;
    }
}
