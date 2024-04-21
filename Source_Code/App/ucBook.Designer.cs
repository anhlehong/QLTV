namespace App
{
    partial class ucBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaTaiLieu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnTimSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTimSach = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnThemTaiLieu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.gridSach = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaTaiLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnSua);
            this.topPanel.Controls.Add(this.btnXoaTaiLieu);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.btnTimSach);
            this.topPanel.Controls.Add(this.txtTimSach);
            this.topPanel.Controls.Add(this.btnThemTaiLieu);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1153, 113);
            this.topPanel.TabIndex = 1;
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
            this.btnSua.Location = new System.Drawing.Point(374, 55);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 48);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.TextOffset = new System.Drawing.Point(3, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaTaiLieu
            // 
            this.btnXoaTaiLieu.AutoRoundedCorners = true;
            this.btnXoaTaiLieu.BorderRadius = 16;
            this.btnXoaTaiLieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTaiLieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTaiLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTaiLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTaiLieu.FillColor = System.Drawing.Color.SlateBlue;
            this.btnXoaTaiLieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaTaiLieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaTaiLieu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaTaiLieu.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnXoaTaiLieu.Location = new System.Drawing.Point(217, 55);
            this.btnXoaTaiLieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaTaiLieu.Name = "btnXoaTaiLieu";
            this.btnXoaTaiLieu.Size = new System.Drawing.Size(140, 35);
            this.btnXoaTaiLieu.TabIndex = 18;
            this.btnXoaTaiLieu.Text = "Xóa tài liệu";
            this.btnXoaTaiLieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaTaiLieu.TextOffset = new System.Drawing.Point(3, 0);
            this.btnXoaTaiLieu.Click += new System.EventHandler(this.btnXoaTaiLieu_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = ((System.Drawing.Image)(resources.GetObject("butRefresh.Image")));
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(2, 55);
            this.butRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(35, 35);
            this.butRefresh.TabIndex = 10;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // btnTimSach
            // 
            this.btnTimSach.AutoRoundedCorners = true;
            this.btnTimSach.BorderRadius = 16;
            this.btnTimSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimSach.FillColor = System.Drawing.Color.SlateBlue;
            this.btnTimSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimSach.ForeColor = System.Drawing.Color.White;
            this.btnTimSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimSach.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnTimSach.Location = new System.Drawing.Point(1013, 55);
            this.btnTimSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(140, 35);
            this.btnTimSach.TabIndex = 14;
            this.btnTimSach.Text = "Tìm kiếm";
            this.btnTimSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimSach.TextOffset = new System.Drawing.Point(3, 0);
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // txtTimSach
            // 
            this.txtTimSach.AutoRoundedCorners = true;
            this.txtTimSach.BorderRadius = 16;
            this.txtTimSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSach.DefaultText = "";
            this.txtTimSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimSach.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTimSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSach.Location = new System.Drawing.Point(799, 55);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.PasswordChar = '\0';
            this.txtTimSach.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimSach.PlaceholderText = "Mã, tên ";
            this.txtTimSach.SelectedText = "";
            this.txtTimSach.Size = new System.Drawing.Size(210, 35);
            this.txtTimSach.TabIndex = 15;
            // 
            // btnThemTaiLieu
            // 
            this.btnThemTaiLieu.AutoRoundedCorners = true;
            this.btnThemTaiLieu.BorderRadius = 16;
            this.btnThemTaiLieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTaiLieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTaiLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTaiLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTaiLieu.FillColor = System.Drawing.Color.SlateBlue;
            this.btnThemTaiLieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemTaiLieu.ForeColor = System.Drawing.Color.White;
            this.btnThemTaiLieu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemTaiLieu.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnThemTaiLieu.Location = new System.Drawing.Point(55, 55);
            this.btnThemTaiLieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTaiLieu.Name = "btnThemTaiLieu";
            this.btnThemTaiLieu.Size = new System.Drawing.Size(140, 35);
            this.btnThemTaiLieu.TabIndex = 7;
            this.btnThemTaiLieu.Text = "Thêm tài liệu";
            this.btnThemTaiLieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemTaiLieu.TextOffset = new System.Drawing.Point(3, 0);
            this.btnThemTaiLieu.Click += new System.EventHandler(this.btnThemTaiLieu_Click);
            // 
            // gridSach
            // 
            this.gridSach.AllowUserToAddRows = false;
            this.gridSach.AllowUserToDeleteRows = false;
            this.gridSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSach.ColumnHeadersHeight = 35;
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.MaTaiLieu,
            this.TenTaiLieu,
            this.LoaiTaiLieu,
            this.TacGia,
            this.NhaXuatBan,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSach.Location = new System.Drawing.Point(0, 113);
            this.gridSach.Margin = new System.Windows.Forms.Padding(2);
            this.gridSach.Name = "gridSach";
            this.gridSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSach.RowHeadersVisible = false;
            this.gridSach.RowHeadersWidth = 51;
            this.gridSach.RowTemplate.Height = 30;
            this.gridSach.Size = new System.Drawing.Size(1153, 620);
            this.gridSach.TabIndex = 2;
            this.gridSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSach.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridSach.ThemeStyle.HeaderStyle.Height = 35;
            this.gridSach.ThemeStyle.ReadOnly = false;
            this.gridSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridSach.ThemeStyle.RowsStyle.Height = 30;
            this.gridSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // MaTaiLieu
            // 
            this.MaTaiLieu.HeaderText = "Mã tài liệu";
            this.MaTaiLieu.MinimumWidth = 6;
            this.MaTaiLieu.Name = "MaTaiLieu";
            this.MaTaiLieu.ReadOnly = true;
            // 
            // TenTaiLieu
            // 
            this.TenTaiLieu.HeaderText = "Tên tài liệu";
            this.TenTaiLieu.MinimumWidth = 10;
            this.TenTaiLieu.Name = "TenTaiLieu";
            // 
            // LoaiTaiLieu
            // 
            this.LoaiTaiLieu.HeaderText = "Loại tài liệu";
            this.LoaiTaiLieu.MinimumWidth = 6;
            this.LoaiTaiLieu.Name = "LoaiTaiLieu";
            this.LoaiTaiLieu.ReadOnly = true;
            this.LoaiTaiLieu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.NhaXuatBan.MinimumWidth = 10;
            this.NhaXuatBan.Name = "NhaXuatBan";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 10;
            this.SoLuong.Name = "SoLuong";
            // 
            // ucBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSach);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucBook";
            this.Size = new System.Drawing.Size(1153, 733);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoaTaiLieu;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimSach;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTimSach;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnThemTaiLieu;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
    }
}
