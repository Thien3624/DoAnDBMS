namespace GUI
{
    partial class UserControlBanAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDatHang = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_maHoaDon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_thanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.lb_tongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.dgDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_soDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonHang)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.BackColor = System.Drawing.Color.White;
            this.panelNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 0);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1058, 797);
            this.panelNoiDung.TabIndex = 5;
            // 
            // panelDatHang
            // 
            this.panelDatHang.BackColor = System.Drawing.Color.White;
            this.panelDatHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDatHang.BorderThickness = 1;
            this.panelDatHang.Controls.Add(this.lb_maHoaDon);
            this.panelDatHang.Controls.Add(this.btn_thanhToan);
            this.panelDatHang.Controls.Add(this.lb_tongTien);
            this.panelDatHang.Controls.Add(this.label6);
            this.panelDatHang.Controls.Add(this.guna2Shapes1);
            this.panelDatHang.Controls.Add(this.dgDonHang);
            this.panelDatHang.Controls.Add(this.txt_soDienThoai);
            this.panelDatHang.Controls.Add(this.txt_tenKhachHang);
            this.panelDatHang.Controls.Add(this.guna2Panel2);
            this.panelDatHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDatHang.Location = new System.Drawing.Point(1064, 0);
            this.panelDatHang.Name = "panelDatHang";
            this.panelDatHang.Size = new System.Drawing.Size(517, 797);
            this.panelDatHang.TabIndex = 6;
            // 
            // lb_maHoaDon
            // 
            this.lb_maHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lb_maHoaDon.Location = new System.Drawing.Point(347, 694);
            this.lb_maHoaDon.Name = "lb_maHoaDon";
            this.lb_maHoaDon.Size = new System.Drawing.Size(78, 18);
            this.lb_maHoaDon.TabIndex = 24;
            this.lb_maHoaDon.Text = "Mã Hóa Đơn";
            this.lb_maHoaDon.Visible = false;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.BorderRadius = 10;
            this.btn_thanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_thanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhToan.Location = new System.Drawing.Point(302, 640);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(146, 35);
            this.btn_thanhToan.TabIndex = 19;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // lb_tongTien
            // 
            this.lb_tongTien.AutoSize = true;
            this.lb_tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongTien.ForeColor = System.Drawing.Color.Black;
            this.lb_tongTien.Location = new System.Drawing.Point(355, 583);
            this.lb_tongTien.Name = "lb_tongTien";
            this.lb_tongTien.Size = new System.Drawing.Size(70, 25);
            this.lb_tongTien.TabIndex = 18;
            this.lb_tongTien.Text = "0 VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(66, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng tiền:";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(71, 565);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(424, 2);
            this.guna2Shapes1.TabIndex = 16;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // dgDonHang
            // 
            this.dgDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDonHang.ColumnHeadersHeight = 30;
            this.dgDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenMonAn,
            this.soLuong,
            this.thanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDonHang.Location = new System.Drawing.Point(71, 179);
            this.dgDonHang.Name = "dgDonHang";
            this.dgDonHang.ReadOnly = true;
            this.dgDonHang.RowHeadersVisible = false;
            this.dgDonHang.RowHeadersWidth = 60;
            this.dgDonHang.RowTemplate.Height = 24;
            this.dgDonHang.Size = new System.Drawing.Size(408, 366);
            this.dgDonHang.TabIndex = 15;
            this.dgDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDonHang.ThemeStyle.HeaderStyle.Height = 30;
            this.dgDonHang.ThemeStyle.ReadOnly = true;
            this.dgDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgDonHang.ThemeStyle.RowsStyle.Height = 24;
            this.dgDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tenMonAn
            // 
            this.tenMonAn.HeaderText = "Tên món ăn";
            this.tenMonAn.MinimumWidth = 6;
            this.tenMonAn.Name = "tenMonAn";
            this.tenMonAn.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // txt_soDienThoai
            // 
            this.txt_soDienThoai.AutoRoundedCorners = true;
            this.txt_soDienThoai.BorderRadius = 16;
            this.txt_soDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soDienThoai.DefaultText = "";
            this.txt_soDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soDienThoai.Location = new System.Drawing.Point(71, 126);
            this.txt_soDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soDienThoai.Name = "txt_soDienThoai";
            this.txt_soDienThoai.PasswordChar = '\0';
            this.txt_soDienThoai.PlaceholderText = "Số điện thoại";
            this.txt_soDienThoai.ReadOnly = true;
            this.txt_soDienThoai.SelectedText = "";
            this.txt_soDienThoai.Size = new System.Drawing.Size(408, 34);
            this.txt_soDienThoai.TabIndex = 9;
            // 
            // txt_tenKhachHang
            // 
            this.txt_tenKhachHang.AutoRoundedCorners = true;
            this.txt_tenKhachHang.BorderRadius = 16;
            this.txt_tenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenKhachHang.DefaultText = "";
            this.txt_tenKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenKhachHang.Location = new System.Drawing.Point(71, 84);
            this.txt_tenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenKhachHang.Name = "txt_tenKhachHang";
            this.txt_tenKhachHang.PasswordChar = '\0';
            this.txt_tenKhachHang.PlaceholderText = "Tên khách hàng";
            this.txt_tenKhachHang.ReadOnly = true;
            this.txt_tenKhachHang.SelectedText = "";
            this.txt_tenKhachHang.Size = new System.Drawing.Size(408, 34);
            this.txt_tenKhachHang.TabIndex = 7;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(517, 77);
            this.guna2Panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bàn ăn";
            // 
            // UserControlBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panelDatHang);
            this.Controls.Add(this.panelNoiDung);
            this.Name = "UserControlBanAn";
            this.Size = new System.Drawing.Size(1581, 797);
            this.Load += new System.EventHandler(this.UserControlBanAn_Load);
            this.panelDatHang.ResumeLayout(false);
            this.panelDatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonHang)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
        private Guna.UI2.WinForms.Guna2Panel panelDatHang;
        private Guna.UI2.WinForms.Guna2Button btn_thanhToan;
        private System.Windows.Forms.Label lb_tongTien;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2DataGridView dgDonHang;
        private Guna.UI2.WinForms.Guna2TextBox txt_soDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenKhachHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_maHoaDon;
    }
}
