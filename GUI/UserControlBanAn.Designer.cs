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
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.cboSucChua = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.AutoScroll = true;
            this.panelNoiDung.BackColor = System.Drawing.Color.White;
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 75);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1581, 722);
            this.panelNoiDung.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.Controls.Add(this.cboSucChua);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1581, 75);
            this.panelTop.TabIndex = 3;
            // 
            // cboSucChua
            // 
            this.cboSucChua.BackColor = System.Drawing.Color.Transparent;
            this.cboSucChua.BorderRadius = 17;
            this.cboSucChua.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSucChua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucChua.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSucChua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSucChua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSucChua.IntegralHeight = false;
            this.cboSucChua.ItemHeight = 30;
            this.cboSucChua.Location = new System.Drawing.Point(620, 16);
            this.cboSucChua.Name = "cboSucChua";
            this.cboSucChua.Size = new System.Drawing.Size(342, 36);
            this.cboSucChua.TabIndex = 0;
            this.cboSucChua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(0, 75);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1352, 4);
            this.guna2Panel1.TabIndex = 4;
            // 
            // UserControlBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControlBanAn";
            this.Size = new System.Drawing.Size(1581, 797);
            this.Load += new System.EventHandler(this.UserControlBanAn_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2ComboBox cboSucChua;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
