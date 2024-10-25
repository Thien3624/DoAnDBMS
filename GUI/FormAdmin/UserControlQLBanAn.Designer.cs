namespace GUI.FormAdmin
{
    partial class UserControlQLBanAn
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
            this.btn_ThemMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_MaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.BackColor = System.Drawing.Color.White;
            this.panelNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 76);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1581, 721);
            this.panelNoiDung.TabIndex = 9;
            // 
            // btn_ThemMonAn
            // 
            this.btn_ThemMonAn.AutoRoundedCorners = true;
            this.btn_ThemMonAn.BorderRadius = 21;
            this.btn_ThemMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemMonAn.FillColor = System.Drawing.Color.DarkOrange;
            this.btn_ThemMonAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMonAn.ForeColor = System.Drawing.Color.White;
            this.btn_ThemMonAn.Location = new System.Drawing.Point(946, 14);
            this.btn_ThemMonAn.Name = "btn_ThemMonAn";
            this.btn_ThemMonAn.Size = new System.Drawing.Size(274, 45);
            this.btn_ThemMonAn.TabIndex = 1;
            this.btn_ThemMonAn.Text = "Thêm bàn";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.BorderThickness = 1;
            this.panelTop.Controls.Add(this.txt_MaBan);
            this.panelTop.Controls.Add(this.btn_ThemMonAn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1581, 76);
            this.panelTop.TabIndex = 8;
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.AutoRoundedCorners = true;
            this.txt_MaBan.BorderRadius = 21;
            this.txt_MaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaBan.DefaultText = "";
            this.txt_MaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaBan.Location = new System.Drawing.Point(637, 14);
            this.txt_MaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.PasswordChar = '\0';
            this.txt_MaBan.PlaceholderText = "Mã Bàn ";
            this.txt_MaBan.SelectedText = "";
            this.txt_MaBan.Size = new System.Drawing.Size(278, 45);
            this.txt_MaBan.TabIndex = 2;
            // 
            // UserControlQLBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.panelTop);
            this.Name = "UserControlQLBanAn";
            this.Size = new System.Drawing.Size(1581, 797);
            this.Load += new System.EventHandler(this.UserControlBanAn_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMonAn;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaBan;
    }
}
