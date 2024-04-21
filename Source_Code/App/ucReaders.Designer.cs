namespace App
{
    partial class ucReaders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReaders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaDocGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnTimDocGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTimDocGia = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnThemDocGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.gridDocGia = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSachDangMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.btnSua);
            this.TopPanel.Controls.Add(this.btnXoaDocGia);
            this.TopPanel.Controls.Add(this.btnTimDocGia);
            this.TopPanel.Controls.Add(this.txtTimDocGia);
            this.TopPanel.Controls.Add(this.btnRefresh);
            this.TopPanel.Controls.Add(this.btnThemDocGia);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1079, 112);
            this.TopPanel.TabIndex = 5;
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
            this.btnSua.Location = new System.Drawing.Point(448, 50);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 48);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "sửa";
            this.btnSua.TextOffset = new System.Drawing.Point(3, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaDocGia
            // 
            this.btnXoaDocGia.AutoRoundedCorners = true;
            this.btnXoaDocGia.BorderRadius = 16;
            this.btnXoaDocGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDocGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaDocGia.FillColor = System.Drawing.Color.SlateBlue;
            this.btnXoaDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaDocGia.ForeColor = System.Drawing.Color.White;
            this.btnXoaDocGia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaDocGia.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnXoaDocGia.Location = new System.Drawing.Point(280, 50);
            this.btnXoaDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDocGia.Name = "btnXoaDocGia";
            this.btnXoaDocGia.Size = new System.Drawing.Size(152, 35);
            this.btnXoaDocGia.TabIndex = 20;
            this.btnXoaDocGia.Text = "Xóa độc giả";
            this.btnXoaDocGia.TextOffset = new System.Drawing.Point(3, 0);
            this.btnXoaDocGia.Click += new System.EventHandler(this.btnXoaDocGia_Click);
            // 
            // btnTimDocGia
            // 
            this.btnTimDocGia.AutoRoundedCorners = true;
            this.btnTimDocGia.BorderRadius = 16;
            this.btnTimDocGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimDocGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimDocGia.FillColor = System.Drawing.Color.SlateBlue;
            this.btnTimDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimDocGia.ForeColor = System.Drawing.Color.White;
            this.btnTimDocGia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimDocGia.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnTimDocGia.Location = new System.Drawing.Point(937, 50);
            this.btnTimDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimDocGia.Name = "btnTimDocGia";
            this.btnTimDocGia.Size = new System.Drawing.Size(140, 35);
            this.btnTimDocGia.TabIndex = 18;
            this.btnTimDocGia.Text = "Tìm kiếm";
            this.btnTimDocGia.TextOffset = new System.Drawing.Point(3, 0);
            this.btnTimDocGia.Click += new System.EventHandler(this.btnTimDocGia_Click);
            // 
            // txtTimDocGia
            // 
            this.txtTimDocGia.AutoRoundedCorners = true;
            this.txtTimDocGia.BorderRadius = 16;
            this.txtTimDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimDocGia.DefaultText = "";
            this.txtTimDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtTimDocGia.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTimDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimDocGia.Location = new System.Drawing.Point(758, 50);
            this.txtTimDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimDocGia.Name = "txtTimDocGia";
            this.txtTimDocGia.PasswordChar = '\0';
            this.txtTimDocGia.PlaceholderText = "Mã, tên độc giả";
            this.txtTimDocGia.SelectedText = "";
            this.txtTimDocGia.Size = new System.Drawing.Size(175, 35);
            this.txtTimDocGia.TabIndex = 19;
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefresh.ImageRotate = 0F;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(18, 50);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.AutoRoundedCorners = true;
            this.btnThemDocGia.BorderRadius = 16;
            this.btnThemDocGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDocGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemDocGia.FillColor = System.Drawing.Color.SlateBlue;
            this.btnThemDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemDocGia.ForeColor = System.Drawing.Color.White;
            this.btnThemDocGia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemDocGia.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnThemDocGia.Location = new System.Drawing.Point(96, 50);
            this.btnThemDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(152, 35);
            this.btnThemDocGia.TabIndex = 0;
            this.btnThemDocGia.Text = "Thêm độc giả";
            this.btnThemDocGia.TextOffset = new System.Drawing.Point(3, 0);
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // gridDocGia
            // 
            this.gridDocGia.AllowUserToAddRows = false;
            this.gridDocGia.AllowUserToDeleteRows = false;
            this.gridDocGia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDocGia.ColumnHeadersHeight = 35;
            this.gridDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isChosen,
            this.MaDocGia,
            this.TenDocGia,
            this.GioiTinh,
            this.SoSachDangMuon,
            this.NgayHetHan,
            this.TongNo,
            this.Edit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDocGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDocGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDocGia.Location = new System.Drawing.Point(0, 112);
            this.gridDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.gridDocGia.Name = "gridDocGia";
            this.gridDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDocGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDocGia.RowHeadersVisible = false;
            this.gridDocGia.RowHeadersWidth = 51;
            this.gridDocGia.RowTemplate.Height = 30;
            this.gridDocGia.Size = new System.Drawing.Size(1079, 510);
            this.gridDocGia.TabIndex = 6;
            this.gridDocGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDocGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDocGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDocGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDocGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDocGia.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDocGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDocGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridDocGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridDocGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDocGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridDocGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDocGia.ThemeStyle.HeaderStyle.Height = 35;
            this.gridDocGia.ThemeStyle.ReadOnly = false;
            this.gridDocGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDocGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDocGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDocGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridDocGia.ThemeStyle.RowsStyle.Height = 30;
            this.gridDocGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDocGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.DataPropertyName = "isChosen";
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isChosen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isChosen.TrueValue = "1";
            this.isChosen.Visible = false;
            this.isChosen.Width = 35;
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            this.MaDocGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenDocGia
            // 
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            this.TenDocGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 10;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SoSachDangMuon
            // 
            this.SoSachDangMuon.HeaderText = "Sách đang mượn";
            this.SoSachDangMuon.MinimumWidth = 6;
            this.SoSachDangMuon.Name = "SoSachDangMuon";
            this.SoSachDangMuon.ReadOnly = true;
            this.SoSachDangMuon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.HeaderText = "Ngày hết hạn ";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            this.NgayHetHan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TongNo
            // 
            this.TongNo.HeaderText = "Tình trạng";
            this.TongNo.MinimumWidth = 6;
            this.TongNo.Name = "TongNo";
            this.TongNo.ReadOnly = true;
            this.TongNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 6;
            // 
            // ucReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDocGia);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucReaders";
            this.Size = new System.Drawing.Size(1079, 622);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel TopPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTimDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnThemDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSachDangMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNo;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoaDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
    }
}
