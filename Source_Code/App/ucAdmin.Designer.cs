namespace App
{
    partial class ucAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDoiMatKhau = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaNhanVien = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnThemNhanVien = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnTimNhanVien = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTimNhanVien = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.gridNhanVien = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnSua);
            this.topPanel.Controls.Add(this.btnDoiMatKhau);
            this.topPanel.Controls.Add(this.btnXoaNhanVien);
            this.topPanel.Controls.Add(this.btnThemNhanVien);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.btnTimNhanVien);
            this.topPanel.Controls.Add(this.txtTimNhanVien);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1586, 217);
            this.topPanel.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 23;
            this.btnSua.DefaultAutoSize = true;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.SlateBlue;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnSua.Location = new System.Drawing.Point(460, 125);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 48);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.TextOffset = new System.Drawing.Point(3, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AutoRoundedCorners = true;
            this.btnDoiMatKhau.BorderRadius = 23;
            this.btnDoiMatKhau.DefaultAutoSize = true;
            this.btnDoiMatKhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.SlateBlue;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiMatKhau.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(226, 125);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(212, 48);
            this.btnDoiMatKhau.TabIndex = 18;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiMatKhau.TextOffset = new System.Drawing.Point(3, 0);
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnXoaNhanVien.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhanVien.Image")));
            this.btnXoaNhanVien.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnXoaNhanVien.ImageRotate = 0F;
            this.btnXoaNhanVien.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaNhanVien.Location = new System.Drawing.Point(148, 106);
            this.btnXoaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoaNhanVien.Size = new System.Drawing.Size(70, 67);
            this.btnXoaNhanVien.TabIndex = 17;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThemNhanVien.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhanVien.Image")));
            this.btnThemNhanVien.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemNhanVien.ImageRotate = 0F;
            this.btnThemNhanVien.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemNhanVien.Location = new System.Drawing.Point(82, 106);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemNhanVien.Size = new System.Drawing.Size(70, 67);
            this.btnThemNhanVien.TabIndex = 16;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = ((System.Drawing.Image)(resources.GetObject("butRefresh.Image")));
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(4, 106);
            this.butRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(70, 67);
            this.butRefresh.TabIndex = 10;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.AutoRoundedCorners = true;
            this.btnTimNhanVien.BorderRadius = 32;
            this.btnTimNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimNhanVien.FillColor = System.Drawing.Color.SlateBlue;
            this.btnTimNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnTimNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimNhanVien.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnTimNhanVien.Location = new System.Drawing.Point(1227, 106);
            this.btnTimNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            this.btnTimNhanVien.Size = new System.Drawing.Size(280, 67);
            this.btnTimNhanVien.TabIndex = 14;
            this.btnTimNhanVien.Text = "Tìm kiếm";
            this.btnTimNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimNhanVien.TextOffset = new System.Drawing.Point(3, 0);
            this.btnTimNhanVien.Click += new System.EventHandler(this.btnTimNhanVien_Click);
            // 
            // txtTimNhanVien
            // 
            this.txtTimNhanVien.AutoRoundedCorners = true;
            this.txtTimNhanVien.BorderRadius = 32;
            this.txtTimNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimNhanVien.DefaultText = "";
            this.txtTimNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimNhanVien.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTimNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNhanVien.Location = new System.Drawing.Point(799, 106);
            this.txtTimNhanVien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTimNhanVien.Name = "txtTimNhanVien";
            this.txtTimNhanVien.PasswordChar = '\0';
            this.txtTimNhanVien.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimNhanVien.PlaceholderText = "Mã nhân viên, Tên đăng nhập";
            this.txtTimNhanVien.SelectedText = "";
            this.txtTimNhanVien.Size = new System.Drawing.Size(420, 67);
            this.txtTimNhanVien.TabIndex = 15;
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.AllowUserToAddRows = false;
            this.gridNhanVien.AllowUserToDeleteRows = false;
            this.gridNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridNhanVien.ColumnHeadersHeight = 35;
            this.gridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.colMaNhanVien,
            this.colTenNhanVien,
            this.colNgaySinh,
            this.colDiaChi,
            this.colGioiTinh,
            this.colTenDangNhap});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridNhanVien.Location = new System.Drawing.Point(0, 217);
            this.gridNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridNhanVien.RowHeadersVisible = false;
            this.gridNhanVien.RowHeadersWidth = 51;
            this.gridNhanVien.RowTemplate.Height = 30;
            this.gridNhanVien.Size = new System.Drawing.Size(1586, 606);
            this.gridNhanVien.TabIndex = 4;
            this.gridNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridNhanVien.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridNhanVien.ThemeStyle.HeaderStyle.Height = 35;
            this.gridNhanVien.ThemeStyle.ReadOnly = false;
            this.gridNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanVien.ThemeStyle.RowsStyle.Height = 30;
            this.gridNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.TrueValue = "1";
            this.isChosen.Width = 6;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.HeaderText = "Mã nhân viên";
            this.colMaNhanVien.MinimumWidth = 6;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.MinimumWidth = 10;
            this.colTenNhanVien.Name = "colTenNhanVien";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 10;
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.HeaderText = "Tên đăng nhập";
            this.colTenDangNhap.MinimumWidth = 10;
            this.colTenDangNhap.Name = "colTenDangNhap";
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridNhanVien);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(1586, 823);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnXoaNhanVien;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnThemNhanVien;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimNhanVien;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTimNhanVien;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridNhanVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDoiMatKhau;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
    }
}
