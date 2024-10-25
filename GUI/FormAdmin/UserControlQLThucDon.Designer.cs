namespace GUI.FormAdmin
{
    partial class UserControlQLThucDon
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
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.cboLoaiMonAn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_ThemMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.Panel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.BackColor = System.Drawing.Color.White;
            this.panelNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 101);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1581, 696);
            this.panelNoiDung.TabIndex = 7;
            // 
            // cboLoaiMonAn
            // 
            this.cboLoaiMonAn.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiMonAn.BorderRadius = 17;
            this.cboLoaiMonAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMonAn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiMonAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiMonAn.IntegralHeight = false;
            this.cboLoaiMonAn.ItemHeight = 30;
            this.cboLoaiMonAn.Location = new System.Drawing.Point(590, 31);
            this.cboLoaiMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiMonAn.Name = "cboLoaiMonAn";
            this.cboLoaiMonAn.Size = new System.Drawing.Size(343, 36);
            this.cboLoaiMonAn.TabIndex = 0;
            this.cboLoaiMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.CboLoaiMonAn_SelectedIndexChanged);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Controls.Add(this.panelNoiDung);
            this.Panel.Controls.Add(this.panelTop);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1581, 797);
            this.Panel.TabIndex = 9;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.BorderThickness = 1;
            this.panelTop.Controls.Add(this.btn_ThemMonAn);
            this.panelTop.Controls.Add(this.cboLoaiMonAn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1581, 101);
            this.panelTop.TabIndex = 5;
            // 
            // btn_ThemMonAn
            // 
            this.btn_ThemMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemMonAn.FillColor = System.Drawing.Color.DarkOrange;
            this.btn_ThemMonAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ThemMonAn.ForeColor = System.Drawing.Color.White;
            this.btn_ThemMonAn.Location = new System.Drawing.Point(1372, 31);
            this.btn_ThemMonAn.Name = "btn_ThemMonAn";
            this.btn_ThemMonAn.Size = new System.Drawing.Size(180, 45);
            this.btn_ThemMonAn.TabIndex = 1;
            this.btn_ThemMonAn.Text = "Thêm món";
            this.btn_ThemMonAn.Click += new System.EventHandler(this.Btn_ThemMonAn_Click);
            // 
            // UserControlQLThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "UserControlQLThucDon";
            this.Size = new System.Drawing.Size(1581, 797);
            this.Load += new System.EventHandler(this.UserControlQLThucDon_Load);
            this.Panel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiMonAn;
        private Guna.UI2.WinForms.Guna2Panel Panel;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMonAn;
    }
}
