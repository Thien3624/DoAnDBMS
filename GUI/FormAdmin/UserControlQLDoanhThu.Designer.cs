namespace GUI.FormAdmin
{
    partial class UserControlQLDoanhThu
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
            this.doanhThuChart = new LiveCharts.WinForms.CartesianChart();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLoc = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cboNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doanhThuChart
            // 
            this.doanhThuChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.doanhThuChart.Location = new System.Drawing.Point(0, 0);
            this.doanhThuChart.Name = "doanhThuChart";
            this.doanhThuChart.Size = new System.Drawing.Size(1172, 797);
            this.doanhThuChart.TabIndex = 0;
            this.doanhThuChart.Text = "doanhThuChart";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.cboLoai);
            this.guna2Panel1.Controls.Add(this.btnLoc);
            this.guna2Panel1.Controls.Add(this.cboNam);
            this.guna2Panel1.Controls.Add(this.cboThang);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1222, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(359, 797);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tháng:";
            // 
            // cboLoai
            // 
            this.cboLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoai.ItemHeight = 30;
            this.cboLoai.Items.AddRange(new object[] {
            "Doanh thu",
            "Khách",
            "Thức ăn"});
            this.cboLoai.Location = new System.Drawing.Point(30, 216);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(299, 36);
            this.cboLoai.TabIndex = 5;
            // 
            // btnLoc
            // 
            this.btnLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(124, 293);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLoc.Size = new System.Drawing.Size(115, 115);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "LỌC";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboNam
            // 
            this.cboNam.BackColor = System.Drawing.Color.Transparent;
            this.cboNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNam.ItemHeight = 30;
            this.cboNam.Items.AddRange(new object[] {
            "Tháng",
            "Năm",
            "Tổng"});
            this.cboNam.Location = new System.Drawing.Point(193, 161);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(136, 36);
            this.cboNam.TabIndex = 3;
            // 
            // cboThang
            // 
            this.cboThang.BackColor = System.Drawing.Color.Transparent;
            this.cboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThang.ItemHeight = 30;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(113, 161);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(74, 36);
            this.cboThang.TabIndex = 2;
            // 
            // UserControlQLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.doanhThuChart);
            this.Name = "UserControlQLDoanhThu";
            this.Size = new System.Drawing.Size(1581, 797);
            this.Load += new System.EventHandler(this.UserControlQLDoanhThu_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart doanhThuChart;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnLoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboNam;
        private Guna.UI2.WinForms.Guna2ComboBox cboThang;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoai;
        private System.Windows.Forms.Label label1;
    }
}
