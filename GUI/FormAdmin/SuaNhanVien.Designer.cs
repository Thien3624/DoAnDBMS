﻿namespace GUI.FormAdmin
{
    partial class SuaNhanVien
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
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.radio_nu = new System.Windows.Forms.RadioButton();
            this.radio_nam = new System.Windows.Forms.RadioButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.datetime_ngaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tb_diaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tb_soDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tb_hoVaTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tb_cccd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_maNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(50, 51);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel7.TabIndex = 32;
            this.guna2HtmlLabel7.Text = "Mã nhân viên:";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_luu
            // 
            this.btn_luu.BorderRadius = 20;
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(184, 415);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(188, 56);
            this.btn_luu.TabIndex = 31;
            this.btn_luu.Text = "Lưu thông tin";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // radio_nu
            // 
            this.radio_nu.AutoSize = true;
            this.radio_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nu.Location = new System.Drawing.Point(157, 12);
            this.radio_nu.Name = "radio_nu";
            this.radio_nu.Size = new System.Drawing.Size(42, 20);
            this.radio_nu.TabIndex = 1;
            this.radio_nu.TabStop = true;
            this.radio_nu.Text = "Nữ";
            this.radio_nu.UseVisualStyleBackColor = true;
            // 
            // radio_nam
            // 
            this.radio_nam.AutoSize = true;
            this.radio_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nam.Location = new System.Drawing.Point(12, 12);
            this.radio_nam.Name = "radio_nam";
            this.radio_nam.Size = new System.Drawing.Size(54, 20);
            this.radio_nam.TabIndex = 0;
            this.radio_nam.TabStop = true;
            this.radio_nam.Text = "Nam";
            this.radio_nam.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.radio_nu);
            this.guna2Panel1.Controls.Add(this.radio_nam);
            this.guna2Panel1.Location = new System.Drawing.Point(162, 203);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(297, 40);
            this.guna2Panel1.TabIndex = 30;
            // 
            // datetime_ngaySinh
            // 
            this.datetime_ngaySinh.BackColor = System.Drawing.Color.Transparent;
            this.datetime_ngaySinh.BorderRadius = 10;
            this.datetime_ngaySinh.Checked = true;
            this.datetime_ngaySinh.FillColor = System.Drawing.Color.White;
            this.datetime_ngaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_ngaySinh.Location = new System.Drawing.Point(162, 254);
            this.datetime_ngaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_ngaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_ngaySinh.Name = "datetime_ngaySinh";
            this.datetime_ngaySinh.Size = new System.Drawing.Size(297, 36);
            this.datetime_ngaySinh.TabIndex = 29;
            this.datetime_ngaySinh.Value = new System.DateTime(2024, 10, 23, 15, 10, 9, 457);
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.BorderRadius = 10;
            this.tb_diaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_diaChi.DefaultText = "";
            this.tb_diaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_diaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_diaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_diaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_diaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_diaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_diaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_diaChi.Location = new System.Drawing.Point(162, 358);
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.PasswordChar = '\0';
            this.tb_diaChi.PlaceholderText = "";
            this.tb_diaChi.SelectedText = "";
            this.tb_diaChi.Size = new System.Drawing.Size(297, 36);
            this.tb_diaChi.TabIndex = 28;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(50, 358);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel5.TabIndex = 27;
            this.guna2HtmlLabel5.Text = "Địa chỉ:";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_soDienThoai
            // 
            this.tb_soDienThoai.BorderRadius = 10;
            this.tb_soDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_soDienThoai.DefaultText = "";
            this.tb_soDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_soDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_soDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_soDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_soDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_soDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_soDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_soDienThoai.Location = new System.Drawing.Point(162, 307);
            this.tb_soDienThoai.Name = "tb_soDienThoai";
            this.tb_soDienThoai.PasswordChar = '\0';
            this.tb_soDienThoai.PlaceholderText = "";
            this.tb_soDienThoai.SelectedText = "";
            this.tb_soDienThoai.Size = new System.Drawing.Size(297, 36);
            this.tb_soDienThoai.TabIndex = 26;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(50, 307);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel6.TabIndex = 25;
            this.guna2HtmlLabel6.Text = "Số điện thoại:";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(50, 254);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel3.TabIndex = 24;
            this.guna2HtmlLabel3.Text = "Ngày sinh";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(50, 203);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel4.TabIndex = 23;
            this.guna2HtmlLabel4.Text = "Giới tính";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_hoVaTen
            // 
            this.tb_hoVaTen.BorderRadius = 10;
            this.tb_hoVaTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hoVaTen.DefaultText = "";
            this.tb_hoVaTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_hoVaTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_hoVaTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_hoVaTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_hoVaTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_hoVaTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_hoVaTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_hoVaTen.Location = new System.Drawing.Point(162, 151);
            this.tb_hoVaTen.Name = "tb_hoVaTen";
            this.tb_hoVaTen.PasswordChar = '\0';
            this.tb_hoVaTen.PlaceholderText = "";
            this.tb_hoVaTen.SelectedText = "";
            this.tb_hoVaTen.Size = new System.Drawing.Size(297, 36);
            this.tb_hoVaTen.TabIndex = 22;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(50, 151);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Họ và tên:";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_cccd
            // 
            this.tb_cccd.BorderRadius = 10;
            this.tb_cccd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_cccd.DefaultText = "";
            this.tb_cccd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_cccd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_cccd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cccd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cccd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_cccd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_cccd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_cccd.Location = new System.Drawing.Point(162, 100);
            this.tb_cccd.Name = "tb_cccd";
            this.tb_cccd.PasswordChar = '\0';
            this.tb_cccd.PlaceholderText = "";
            this.tb_cccd.SelectedText = "";
            this.tb_cccd.Size = new System.Drawing.Size(297, 36);
            this.tb_cccd.TabIndex = 20;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(50, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel1.TabIndex = 19;
            this.guna2HtmlLabel1.Text = "CCCD:";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_maNhanVien
            // 
            this.cbb_maNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cbb_maNhanVien.BorderRadius = 10;
            this.cbb_maNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_maNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_maNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_maNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_maNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_maNhanVien.ItemHeight = 30;
            this.cbb_maNhanVien.Location = new System.Drawing.Point(162, 51);
            this.cbb_maNhanVien.Name = "cbb_maNhanVien";
            this.cbb_maNhanVien.Size = new System.Drawing.Size(297, 36);
            this.cbb_maNhanVien.TabIndex = 33;
            this.cbb_maNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbb_maNhanVien_SelectedIndexChanged);
            // 
            // SuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 669);
            this.Controls.Add(this.cbb_maNhanVien);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.datetime_ngaySinh);
            this.Controls.Add(this.tb_diaChi);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.tb_soDienThoai);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.tb_hoVaTen);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.tb_cccd);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "SuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaNhanVien";
            this.Load += new System.EventHandler(this.SuaNhanVien_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private System.Windows.Forms.RadioButton radio_nu;
        private System.Windows.Forms.RadioButton radio_nam;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_ngaySinh;
        private Guna.UI2.WinForms.Guna2TextBox tb_diaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox tb_soDienThoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox tb_hoVaTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tb_cccd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_maNhanVien;
    }
}