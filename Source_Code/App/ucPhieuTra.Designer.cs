namespace App
{
    partial class ucPhieuTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuTra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblMaPhieuTra = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblMaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.rdoMaPhieTra = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.rdoMaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.btnXoaPhieuTra = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnThemPhieuTra = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnTimPhieuTra = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTimPhieuTra = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.gridPhieuTra = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaPhieuTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTailieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoPhieuTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuTra)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblMaPhieuTra);
            this.topPanel.Controls.Add(this.lblMaPhieuMuon);
            this.topPanel.Controls.Add(this.rdoMaPhieTra);
            this.topPanel.Controls.Add(this.rdoMaPhieuMuon);
            this.topPanel.Controls.Add(this.btnXoaPhieuTra);
            this.topPanel.Controls.Add(this.btnThemPhieuTra);
            this.topPanel.Controls.Add(this.btnRefresh);
            this.topPanel.Controls.Add(this.btnTimPhieuTra);
            this.topPanel.Controls.Add(this.txtTimPhieuTra);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(793, 113);
            this.topPanel.TabIndex = 3;
            // 
            // lblMaPhieuTra
            // 
            this.lblMaPhieuTra.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPhieuTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuTra.Location = new System.Drawing.Point(632, 22);
            this.lblMaPhieuTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMaPhieuTra.Name = "lblMaPhieuTra";
            this.lblMaPhieuTra.Size = new System.Drawing.Size(123, 28);
            this.lblMaPhieuTra.TabIndex = 20;
            this.lblMaPhieuTra.Text = "Mã phiếu trả";
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(467, 22);
            this.lblMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(153, 28);
            this.lblMaPhieuMuon.TabIndex = 19;
            this.lblMaPhieuMuon.Text = "Mã phiếu mượn";
            // 
            // rdoMaPhieTra
            // 
            this.rdoMaPhieTra.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaPhieTra.CheckedState.BorderThickness = 0;
            this.rdoMaPhieTra.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaPhieTra.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMaPhieTra.Location = new System.Drawing.Point(602, 16);
            this.rdoMaPhieTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoMaPhieTra.Name = "rdoMaPhieTra";
            this.rdoMaPhieTra.Size = new System.Drawing.Size(23, 23);
            this.rdoMaPhieTra.TabIndex = 4;
            this.rdoMaPhieTra.Text = "siticoneCustomRadioButton2";
            this.rdoMaPhieTra.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMaPhieTra.UncheckedState.BorderThickness = 2;
            this.rdoMaPhieTra.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMaPhieTra.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoMaPhieuMuon
            // 
            this.rdoMaPhieuMuon.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaPhieuMuon.CheckedState.BorderThickness = 0;
            this.rdoMaPhieuMuon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaPhieuMuon.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMaPhieuMuon.Location = new System.Drawing.Point(436, 16);
            this.rdoMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoMaPhieuMuon.Name = "rdoMaPhieuMuon";
            this.rdoMaPhieuMuon.Size = new System.Drawing.Size(23, 23);
            this.rdoMaPhieuMuon.TabIndex = 18;
            this.rdoMaPhieuMuon.Text = "siticoneCustomRadioButton1";
            this.rdoMaPhieuMuon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMaPhieuMuon.UncheckedState.BorderThickness = 2;
            this.rdoMaPhieuMuon.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMaPhieuMuon.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnXoaPhieuTra
            // 
            this.btnXoaPhieuTra.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnXoaPhieuTra.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaPhieuTra.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuTra.Image")));
            this.btnXoaPhieuTra.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnXoaPhieuTra.ImageRotate = 0F;
            this.btnXoaPhieuTra.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaPhieuTra.Location = new System.Drawing.Point(139, 55);
            this.btnXoaPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhieuTra.Name = "btnXoaPhieuTra";
            this.btnXoaPhieuTra.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoaPhieuTra.Size = new System.Drawing.Size(35, 35);
            this.btnXoaPhieuTra.TabIndex = 17;
            this.btnXoaPhieuTra.Click += new System.EventHandler(this.btnXoaPhieuTra_Click);
            // 
            // btnThemPhieuTra
            // 
            this.btnThemPhieuTra.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThemPhieuTra.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemPhieuTra.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuTra.Image")));
            this.btnThemPhieuTra.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemPhieuTra.ImageRotate = 0F;
            this.btnThemPhieuTra.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemPhieuTra.Location = new System.Drawing.Point(75, 55);
            this.btnThemPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuTra.Name = "btnThemPhieuTra";
            this.btnThemPhieuTra.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemPhieuTra.Size = new System.Drawing.Size(35, 35);
            this.btnThemPhieuTra.TabIndex = 16;
            this.btnThemPhieuTra.Click += new System.EventHandler(this.btnThemPhieuTra_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefresh.ImageRotate = 0F;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(18, 55);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTimPhieuTra
            // 
            this.btnTimPhieuTra.AutoRoundedCorners = true;
            this.btnTimPhieuTra.BorderRadius = 16;
            this.btnTimPhieuTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimPhieuTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimPhieuTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimPhieuTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimPhieuTra.FillColor = System.Drawing.Color.SlateBlue;
            this.btnTimPhieuTra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimPhieuTra.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieuTra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimPhieuTra.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnTimPhieuTra.Location = new System.Drawing.Point(651, 55);
            this.btnTimPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimPhieuTra.Name = "btnTimPhieuTra";
            this.btnTimPhieuTra.Size = new System.Drawing.Size(140, 35);
            this.btnTimPhieuTra.TabIndex = 14;
            this.btnTimPhieuTra.Text = "Tìm kiếm";
            this.btnTimPhieuTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimPhieuTra.TextOffset = new System.Drawing.Point(3, 0);
            this.btnTimPhieuTra.Click += new System.EventHandler(this.btnTimPhieuTra_Click);
            // 
            // txtTimPhieuTra
            // 
            this.txtTimPhieuTra.AutoRoundedCorners = true;
            this.txtTimPhieuTra.BorderRadius = 16;
            this.txtTimPhieuTra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimPhieuTra.DefaultText = "";
            this.txtTimPhieuTra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimPhieuTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimPhieuTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieuTra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieuTra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieuTra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimPhieuTra.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTimPhieuTra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieuTra.Location = new System.Drawing.Point(436, 55);
            this.txtTimPhieuTra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimPhieuTra.Name = "txtTimPhieuTra";
            this.txtTimPhieuTra.PasswordChar = '\0';
            this.txtTimPhieuTra.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimPhieuTra.PlaceholderText = "Mã phiếu";
            this.txtTimPhieuTra.SelectedText = "";
            this.txtTimPhieuTra.Size = new System.Drawing.Size(210, 35);
            this.txtTimPhieuTra.TabIndex = 15;
            // 
            // gridPhieuTra
            // 
            this.gridPhieuTra.AllowUserToAddRows = false;
            this.gridPhieuTra.AllowUserToDeleteRows = false;
            this.gridPhieuTra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPhieuTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPhieuTra.ColumnHeadersHeight = 35;
            this.gridPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.MaPhieuTra,
            this.MaPhieuMuon,
            this.MaDocGia,
            this.HoTenDocGia,
            this.MaTailieu,
            this.NgayTaoPhieuTra});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPhieuTra.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPhieuTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhieuTra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuTra.Location = new System.Drawing.Point(0, 113);
            this.gridPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.gridPhieuTra.Name = "gridPhieuTra";
            this.gridPhieuTra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuTra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPhieuTra.RowHeadersVisible = false;
            this.gridPhieuTra.RowHeadersWidth = 51;
            this.gridPhieuTra.RowTemplate.Height = 30;
            this.gridPhieuTra.Size = new System.Drawing.Size(793, 509);
            this.gridPhieuTra.TabIndex = 4;
            this.gridPhieuTra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuTra.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuTra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridPhieuTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuTra.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuTra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuTra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridPhieuTra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPhieuTra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuTra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPhieuTra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPhieuTra.ThemeStyle.HeaderStyle.Height = 35;
            this.gridPhieuTra.ThemeStyle.ReadOnly = false;
            this.gridPhieuTra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuTra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPhieuTra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuTra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuTra.ThemeStyle.RowsStyle.Height = 30;
            this.gridPhieuTra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuTra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // MaPhieuTra
            // 
            this.MaPhieuTra.HeaderText = "Mã phiếu trả";
            this.MaPhieuTra.MinimumWidth = 6;
            this.MaPhieuTra.Name = "MaPhieuTra";
            this.MaPhieuTra.ReadOnly = true;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.MaPhieuMuon.MinimumWidth = 10;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 10;
            this.MaDocGia.Name = "MaDocGia";
            // 
            // HoTenDocGia
            // 
            this.HoTenDocGia.HeaderText = "Họ tên độc giả";
            this.HoTenDocGia.MinimumWidth = 6;
            this.HoTenDocGia.Name = "HoTenDocGia";
            this.HoTenDocGia.ReadOnly = true;
            this.HoTenDocGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaTailieu
            // 
            this.MaTailieu.HeaderText = "Mã tài liệu";
            this.MaTailieu.MinimumWidth = 6;
            this.MaTailieu.Name = "MaTailieu";
            this.MaTailieu.ReadOnly = true;
            this.MaTailieu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NgayTaoPhieuTra
            // 
            this.NgayTaoPhieuTra.HeaderText = "Ngày tạo phiếu trả";
            this.NgayTaoPhieuTra.MinimumWidth = 10;
            this.NgayTaoPhieuTra.Name = "NgayTaoPhieuTra";
            // 
            // ucPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPhieuTra);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucPhieuTra";
            this.Size = new System.Drawing.Size(793, 622);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMaPhieuTra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMaPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton rdoMaPhieTra;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton rdoMaPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnXoaPhieuTra;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnThemPhieuTra;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimPhieuTra;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTimPhieuTra;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridPhieuTra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTailieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTaoPhieuTra;
    }
}
