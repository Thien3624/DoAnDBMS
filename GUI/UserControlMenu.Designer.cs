namespace GUI
{
    partial class UserControlMenu
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
            this.panelDatHang = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_themDonHang = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.dtGVDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_gioiTinhNu = new System.Windows.Forms.CheckBox();
            this.cb_gioiTinhNam = new System.Windows.Forms.CheckBox();
            this.txt_sDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoVaTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_maBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.cboLoaiMonAn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDonHang)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatHang
            // 
            this.panelDatHang.BackColor = System.Drawing.Color.White;
            this.panelDatHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDatHang.BorderThickness = 1;
            this.panelDatHang.Controls.Add(this.btn_themDonHang);
            this.panelDatHang.Controls.Add(this.label5);
            this.panelDatHang.Controls.Add(this.label6);
            this.panelDatHang.Controls.Add(this.guna2Shapes1);
            this.panelDatHang.Controls.Add(this.dtGVDonHang);
            this.panelDatHang.Controls.Add(this.cb_gioiTinhNu);
            this.panelDatHang.Controls.Add(this.cb_gioiTinhNam);
            this.panelDatHang.Controls.Add(this.txt_sDT);
            this.panelDatHang.Controls.Add(this.label4);
            this.panelDatHang.Controls.Add(this.txt_hoVaTen);
            this.panelDatHang.Controls.Add(this.guna2Panel2);
            this.panelDatHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDatHang.Location = new System.Drawing.Point(1064, 0);
            this.panelDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDatHang.Name = "panelDatHang";
            this.panelDatHang.Size = new System.Drawing.Size(517, 798);
            this.panelDatHang.TabIndex = 5;
            // 
            // btn_themDonHang
            // 
            this.btn_themDonHang.BorderRadius = 10;
            this.btn_themDonHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themDonHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themDonHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themDonHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themDonHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_themDonHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themDonHang.ForeColor = System.Drawing.Color.White;
            this.btn_themDonHang.Location = new System.Drawing.Point(203, 722);
            this.btn_themDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themDonHang.Name = "btn_themDonHang";
            this.btn_themDonHang.Size = new System.Drawing.Size(147, 41);
            this.btn_themDonHang.TabIndex = 19;
            this.btn_themDonHang.Text = "Xác nhận";
            this.btn_themDonHang.Click += new System.EventHandler(this.btn_themDonHang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(299, 678);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "1.000.000 VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(67, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng tiền:";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(64, 656);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(424, 2);
            this.guna2Shapes1.TabIndex = 16;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // dtGVDonHang
            // 
            this.dtGVDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGVDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGVDonHang.ColumnHeadersHeight = 30;
            this.dtGVDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGVDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonAn,
            this.tenMonAn,
            this.soLuong,
            this.gia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGVDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVDonHang.Location = new System.Drawing.Point(61, 272);
            this.dtGVDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGVDonHang.Name = "dtGVDonHang";
            this.dtGVDonHang.ReadOnly = true;
            this.dtGVDonHang.RowHeadersVisible = false;
            this.dtGVDonHang.RowHeadersWidth = 60;
            this.dtGVDonHang.RowTemplate.Height = 24;
            this.dtGVDonHang.Size = new System.Drawing.Size(408, 366);
            this.dtGVDonHang.TabIndex = 15;
            this.dtGVDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGVDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGVDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGVDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGVDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGVDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGVDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtGVDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGVDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGVDonHang.ThemeStyle.HeaderStyle.Height = 30;
            this.dtGVDonHang.ThemeStyle.ReadOnly = true;
            this.dtGVDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGVDonHang.ThemeStyle.RowsStyle.Height = 24;
            this.dtGVDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maMonAn
            // 
            this.maMonAn.HeaderText = "Mã Món Ăn";
            this.maMonAn.MinimumWidth = 6;
            this.maMonAn.Name = "maMonAn";
            this.maMonAn.ReadOnly = true;
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
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // cb_gioiTinhNu
            // 
            this.cb_gioiTinhNu.AutoSize = true;
            this.cb_gioiTinhNu.Location = new System.Drawing.Point(403, 270);
            this.cb_gioiTinhNu.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioiTinhNu.Name = "cb_gioiTinhNu";
            this.cb_gioiTinhNu.Size = new System.Drawing.Size(46, 20);
            this.cb_gioiTinhNu.TabIndex = 14;
            this.cb_gioiTinhNu.Text = "Nữ";
            this.cb_gioiTinhNu.UseVisualStyleBackColor = true;
            // 
            // cb_gioiTinhNam
            // 
            this.cb_gioiTinhNam.AutoSize = true;
            this.cb_gioiTinhNam.Location = new System.Drawing.Point(248, 270);
            this.cb_gioiTinhNam.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioiTinhNam.Name = "cb_gioiTinhNam";
            this.cb_gioiTinhNam.Size = new System.Drawing.Size(58, 20);
            this.cb_gioiTinhNam.TabIndex = 13;
            this.cb_gioiTinhNam.Text = "Nam";
            this.cb_gioiTinhNam.UseVisualStyleBackColor = true;
            // 
            // txt_sDT
            // 
            this.txt_sDT.AutoRoundedCorners = true;
            this.txt_sDT.BorderRadius = 20;
            this.txt_sDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sDT.DefaultText = "";
            this.txt_sDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sDT.Location = new System.Drawing.Point(61, 219);
            this.txt_sDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sDT.Name = "txt_sDT";
            this.txt_sDT.PasswordChar = '\0';
            this.txt_sDT.PlaceholderText = "Số điện thoại";
            this.txt_sDT.SelectedText = "";
            this.txt_sDT.Size = new System.Drawing.Size(408, 42);
            this.txt_sDT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(68, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khách hàng";
            // 
            // txt_hoVaTen
            // 
            this.txt_hoVaTen.AutoRoundedCorners = true;
            this.txt_hoVaTen.BorderRadius = 20;
            this.txt_hoVaTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hoVaTen.DefaultText = "";
            this.txt_hoVaTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hoVaTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hoVaTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoVaTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoVaTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoVaTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_hoVaTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoVaTen.Location = new System.Drawing.Point(61, 152);
            this.txt_hoVaTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hoVaTen.Name = "txt_hoVaTen";
            this.txt_hoVaTen.PasswordChar = '\0';
            this.txt_hoVaTen.PlaceholderText = "Tên khách hàng";
            this.txt_hoVaTen.SelectedText = "";
            this.txt_hoVaTen.Size = new System.Drawing.Size(408, 42);
            this.txt_hoVaTen.TabIndex = 7;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.cbo_maBan);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(517, 101);
            this.guna2Panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(299, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bàn:";
            // 
            // cbo_maBan
            // 
            this.cbo_maBan.AutoRoundedCorners = true;
            this.cbo_maBan.BackColor = System.Drawing.Color.Transparent;
            this.cbo_maBan.BorderRadius = 12;
            this.cbo_maBan.BorderThickness = 0;
            this.cbo_maBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_maBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_maBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_maBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_maBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_maBan.ItemHeight = 20;
            this.cbo_maBan.Location = new System.Drawing.Point(303, 47);
            this.cbo_maBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_maBan.Name = "cbo_maBan";
            this.cbo_maBan.Size = new System.Drawing.Size(164, 26);
            this.cbo_maBan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saturday, 21/10/2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.panelNoiDung);
            this.leftPanel.Controls.Add(this.panelTop);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1059, 798);
            this.leftPanel.TabIndex = 6;
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
            this.panelNoiDung.Size = new System.Drawing.Size(1059, 697);
            this.panelNoiDung.TabIndex = 7;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.BorderThickness = 1;
            this.panelTop.Controls.Add(this.cboLoaiMonAn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1059, 101);
            this.panelTop.TabIndex = 5;
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
            this.cboLoaiMonAn.Location = new System.Drawing.Point(357, 18);
            this.cboLoaiMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiMonAn.Name = "cboLoaiMonAn";
            this.cboLoaiMonAn.Size = new System.Drawing.Size(343, 36);
            this.cboLoaiMonAn.TabIndex = 0;
            this.cboLoaiMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cboLoaiMonAn_SelectedIndexChanged);
            // 
            // UserControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panelDatHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlMenu";
            this.Size = new System.Drawing.Size(1581, 798);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelDatHang.ResumeLayout(false);
            this.panelDatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDonHang)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelDatHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_maBan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel leftPanel;
        private System.Windows.Forms.FlowLayoutPanel panelNoiDung;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiMonAn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_hoVaTen;
        private Guna.UI2.WinForms.Guna2TextBox txt_sDT;
        private System.Windows.Forms.CheckBox cb_gioiTinhNu;
        private System.Windows.Forms.CheckBox cb_gioiTinhNam;

        private Guna.UI2.WinForms.Guna2DataGridView dtGVDonHang;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btn_themDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}
