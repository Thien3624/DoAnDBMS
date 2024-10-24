namespace GUI.FormAdmin
{
    partial class SuaMonAn
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
            this.pn_NoiDungSua = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChonAnh = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_loaiMonAn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_soLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_AnhMonAn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_gia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenMonAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_maMonAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.pn_NoiDungSua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhMonAn)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_NoiDungSua
            // 
            this.pn_NoiDungSua.BackColor = System.Drawing.Color.White;
            this.pn_NoiDungSua.BorderColor = System.Drawing.Color.White;
            this.pn_NoiDungSua.BorderRadius = 15;
            this.pn_NoiDungSua.BorderThickness = 3;
            this.pn_NoiDungSua.Controls.Add(this.btn_Luu);
            this.pn_NoiDungSua.Controls.Add(this.btn_ChonAnh);
            this.pn_NoiDungSua.Controls.Add(this.cbo_loaiMonAn);
            this.pn_NoiDungSua.Controls.Add(this.txt_soLuong);
            this.pn_NoiDungSua.Controls.Add(this.pic_AnhMonAn);
            this.pn_NoiDungSua.Controls.Add(this.txt_gia);
            this.pn_NoiDungSua.Controls.Add(this.txt_tenMonAn);
            this.pn_NoiDungSua.Controls.Add(this.txt_maMonAn);
            this.pn_NoiDungSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_NoiDungSua.Location = new System.Drawing.Point(2, 2);
            this.pn_NoiDungSua.Name = "pn_NoiDungSua";
            this.pn_NoiDungSua.Size = new System.Drawing.Size(585, 740);
            this.pn_NoiDungSua.TabIndex = 7;
            // 
            // btn_Luu
            // 
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.DarkOrange;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(201, 679);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(180, 45);
            this.btn_Luu.TabIndex = 66;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChonAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChonAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChonAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChonAnh.FillColor = System.Drawing.Color.DarkOrange;
            this.btn_ChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ChonAnh.ForeColor = System.Drawing.Color.White;
            this.btn_ChonAnh.Location = new System.Drawing.Point(201, 228);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(180, 45);
            this.btn_ChonAnh.TabIndex = 65;
            this.btn_ChonAnh.Text = "Chọn Ảnh";
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // cbo_loaiMonAn
            // 
            this.cbo_loaiMonAn.BackColor = System.Drawing.Color.White;
            this.cbo_loaiMonAn.BorderRadius = 8;
            this.cbo_loaiMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbo_loaiMonAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_loaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaiMonAn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_loaiMonAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_loaiMonAn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cbo_loaiMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbo_loaiMonAn.ItemHeight = 35;
            this.cbo_loaiMonAn.Location = new System.Drawing.Point(85, 452);
            this.cbo_loaiMonAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_loaiMonAn.Name = "cbo_loaiMonAn";
            this.cbo_loaiMonAn.Size = new System.Drawing.Size(408, 41);
            this.cbo_loaiMonAn.TabIndex = 60;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.BorderRadius = 8;
            this.txt_soLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soLuong.DefaultText = "";
            this.txt_soLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txt_soLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soLuong.Location = new System.Drawing.Point(85, 520);
            this.txt_soLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.PasswordChar = '\0';
            this.txt_soLuong.PlaceholderText = "Số Lượng...";
            this.txt_soLuong.SelectedText = "";
            this.txt_soLuong.Size = new System.Drawing.Size(408, 48);
            this.txt_soLuong.TabIndex = 39;
            // 
            // pic_AnhMonAn
            // 
            this.pic_AnhMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_AnhMonAn.ImageRotate = 0F;
            this.pic_AnhMonAn.Location = new System.Drawing.Point(170, 12);
            this.pic_AnhMonAn.Name = "pic_AnhMonAn";
            this.pic_AnhMonAn.Size = new System.Drawing.Size(247, 200);
            this.pic_AnhMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AnhMonAn.TabIndex = 14;
            this.pic_AnhMonAn.TabStop = false;
            // 
            // txt_gia
            // 
            this.txt_gia.BorderRadius = 8;
            this.txt_gia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gia.DefaultText = "";
            this.txt_gia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txt_gia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gia.Location = new System.Drawing.Point(85, 595);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.PasswordChar = '\0';
            this.txt_gia.PlaceholderText = "Đơn giá...";
            this.txt_gia.SelectedText = "";
            this.txt_gia.Size = new System.Drawing.Size(408, 48);
            this.txt_gia.TabIndex = 7;
            // 
            // txt_tenMonAn
            // 
            this.txt_tenMonAn.BorderRadius = 8;
            this.txt_tenMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenMonAn.DefaultText = "";
            this.txt_tenMonAn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenMonAn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenMonAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenMonAn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txt_tenMonAn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenMonAn.Location = new System.Drawing.Point(85, 378);
            this.txt_tenMonAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenMonAn.Name = "txt_tenMonAn";
            this.txt_tenMonAn.PasswordChar = '\0';
            this.txt_tenMonAn.PlaceholderText = "Tên món ăn...";
            this.txt_tenMonAn.SelectedText = "";
            this.txt_tenMonAn.Size = new System.Drawing.Size(408, 48);
            this.txt_tenMonAn.TabIndex = 6;
            // 
            // txt_maMonAn
            // 
            this.txt_maMonAn.BorderRadius = 8;
            this.txt_maMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maMonAn.DefaultText = "";
            this.txt_maMonAn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maMonAn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maMonAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maMonAn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txt_maMonAn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maMonAn.Location = new System.Drawing.Point(85, 301);
            this.txt_maMonAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maMonAn.Name = "txt_maMonAn";
            this.txt_maMonAn.PasswordChar = '\0';
            this.txt_maMonAn.PlaceholderText = "Mã món ăn...";
            this.txt_maMonAn.ReadOnly = true;
            this.txt_maMonAn.SelectedText = "";
            this.txt_maMonAn.Size = new System.Drawing.Size(408, 48);
            this.txt_maMonAn.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.guna2Panel11);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel8);
            this.guna2Panel1.Controls.Add(this.pn_NoiDungSua);
            this.guna2Panel1.Controls.Add(this.guna2Panel9);
            this.guna2Panel1.Controls.Add(this.guna2Panel10);
            this.guna2Panel1.Controls.Add(this.guna2Panel12);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(589, 742);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel11.Location = new System.Drawing.Point(2, 741);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(585, 1);
            this.guna2Panel11.TabIndex = 16;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.DimGray;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(585, 4);
            this.guna2Panel3.TabIndex = 8;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderRadius = 15;
            this.guna2Panel8.BorderThickness = 3;
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(585, 0);
            this.guna2Panel8.TabIndex = 9;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel9.Location = new System.Drawing.Point(587, 2);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(2, 740);
            this.guna2Panel9.TabIndex = 14;
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel10.Location = new System.Drawing.Point(0, 2);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(2, 740);
            this.guna2Panel10.TabIndex = 15;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel12.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(589, 2);
            this.guna2Panel12.TabIndex = 17;
            // 
            // SuaMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 742);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SuaMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaMonAn";
            this.Load += new System.EventHandler(this.SuaMonAn_Load);
            this.pn_NoiDungSua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhMonAn)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pn_NoiDungSua;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private Guna.UI2.WinForms.Guna2Button btn_ChonAnh;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_loaiMonAn;
        private Guna.UI2.WinForms.Guna2TextBox txt_soLuong;
        private Guna.UI2.WinForms.Guna2PictureBox pic_AnhMonAn;
        private Guna.UI2.WinForms.Guna2TextBox txt_gia;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenMonAn;
        private Guna.UI2.WinForms.Guna2TextBox txt_maMonAn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
    }
}