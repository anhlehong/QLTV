namespace App
{
    partial class ucPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuMuon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblMaDocGia = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblMaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.rdoMaDocGia = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.rdoMaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.btnXoaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnThemPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnTimPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTimPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.gridPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTailieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblMaDocGia);
            this.topPanel.Controls.Add(this.lblMaPhieuMuon);
            this.topPanel.Controls.Add(this.rdoMaDocGia);
            this.topPanel.Controls.Add(this.rdoMaPhieuMuon);
            this.topPanel.Controls.Add(this.btnXoaPhieuMuon);
            this.topPanel.Controls.Add(this.btnThemPhieuMuon);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.btnTimPhieuMuon);
            this.topPanel.Controls.Add(this.txtTimPhieuMuon);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(793, 113);
            this.topPanel.TabIndex = 2;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.BackColor = System.Drawing.Color.Transparent;
            this.lblMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDocGia.Location = new System.Drawing.Point(632, 22);
            this.lblMaDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(109, 28);
            this.lblMaDocGia.TabIndex = 20;
            this.lblMaDocGia.Text = "Mã độc giả";
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
            // rdoMaDocGia
            // 
            this.rdoMaDocGia.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaDocGia.CheckedState.BorderThickness = 0;
            this.rdoMaDocGia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaDocGia.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMaDocGia.Location = new System.Drawing.Point(602, 16);
            this.rdoMaDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoMaDocGia.Name = "rdoMaDocGia";
            this.rdoMaDocGia.Size = new System.Drawing.Size(23, 23);
            this.rdoMaDocGia.TabIndex = 4;
            this.rdoMaDocGia.Text = "siticoneCustomRadioButton2";
            this.rdoMaDocGia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMaDocGia.UncheckedState.BorderThickness = 2;
            this.rdoMaDocGia.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMaDocGia.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            // btnXoaPhieuMuon
            // 
            this.btnXoaPhieuMuon.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnXoaPhieuMuon.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaPhieuMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuMuon.Image")));
            this.btnXoaPhieuMuon.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnXoaPhieuMuon.ImageRotate = 0F;
            this.btnXoaPhieuMuon.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaPhieuMuon.Location = new System.Drawing.Point(139, 55);
            this.btnXoaPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhieuMuon.Name = "btnXoaPhieuMuon";
            this.btnXoaPhieuMuon.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoaPhieuMuon.Size = new System.Drawing.Size(35, 35);
            this.btnXoaPhieuMuon.TabIndex = 17;
            this.btnXoaPhieuMuon.Click += new System.EventHandler(this.btnXoaPhieuMuon_Click);
            // 
            // btnThemPhieuMuon
            // 
            this.btnThemPhieuMuon.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThemPhieuMuon.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemPhieuMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuMuon.Image")));
            this.btnThemPhieuMuon.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemPhieuMuon.ImageRotate = 0F;
            this.btnThemPhieuMuon.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemPhieuMuon.Location = new System.Drawing.Point(75, 55);
            this.btnThemPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuMuon.Name = "btnThemPhieuMuon";
            this.btnThemPhieuMuon.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemPhieuMuon.Size = new System.Drawing.Size(35, 35);
            this.btnThemPhieuMuon.TabIndex = 16;
            this.btnThemPhieuMuon.Click += new System.EventHandler(this.btnThemPhieuMuon_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = ((System.Drawing.Image)(resources.GetObject("butRefresh.Image")));
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(18, 55);
            this.butRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(35, 35);
            this.butRefresh.TabIndex = 10;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // btnTimPhieuMuon
            // 
            this.btnTimPhieuMuon.AutoRoundedCorners = true;
            this.btnTimPhieuMuon.BorderRadius = 16;
            this.btnTimPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimPhieuMuon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimPhieuMuon.FillColor = System.Drawing.Color.SlateBlue;
            this.btnTimPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieuMuon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimPhieuMuon.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnTimPhieuMuon.Location = new System.Drawing.Point(651, 55);
            this.btnTimPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimPhieuMuon.Name = "btnTimPhieuMuon";
            this.btnTimPhieuMuon.Size = new System.Drawing.Size(140, 35);
            this.btnTimPhieuMuon.TabIndex = 14;
            this.btnTimPhieuMuon.Text = "Tìm kiếm";
            this.btnTimPhieuMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimPhieuMuon.TextOffset = new System.Drawing.Point(3, 0);
            this.btnTimPhieuMuon.Click += new System.EventHandler(this.btnTimPhieuMuon_Click);
            // 
            // txtTimPhieuMuon
            // 
            this.txtTimPhieuMuon.AutoRoundedCorners = true;
            this.txtTimPhieuMuon.BorderRadius = 16;
            this.txtTimPhieuMuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimPhieuMuon.DefaultText = "";
            this.txtTimPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieuMuon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieuMuon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimPhieuMuon.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTimPhieuMuon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieuMuon.Location = new System.Drawing.Point(436, 55);
            this.txtTimPhieuMuon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimPhieuMuon.Name = "txtTimPhieuMuon";
            this.txtTimPhieuMuon.PasswordChar = '\0';
            this.txtTimPhieuMuon.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimPhieuMuon.PlaceholderText = "Mã phiếu, mã độc giả";
            this.txtTimPhieuMuon.SelectedText = "";
            this.txtTimPhieuMuon.Size = new System.Drawing.Size(210, 35);
            this.txtTimPhieuMuon.TabIndex = 15;
            // 
            // gridPhieuMuon
            // 
            this.gridPhieuMuon.AllowUserToAddRows = false;
            this.gridPhieuMuon.AllowUserToDeleteRows = false;
            this.gridPhieuMuon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPhieuMuon.ColumnHeadersHeight = 35;
            this.gridPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.MaPhieuMuon,
            this.MaDocGia,
            this.HoTenDocGia,
            this.MaTailieu,
            this.NgayTaoPhieuMuon,
            this.HanTra,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPhieuMuon.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhieuMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuMuon.Location = new System.Drawing.Point(0, 113);
            this.gridPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.gridPhieuMuon.Name = "gridPhieuMuon";
            this.gridPhieuMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPhieuMuon.RowHeadersVisible = false;
            this.gridPhieuMuon.RowHeadersWidth = 51;
            this.gridPhieuMuon.RowTemplate.Height = 30;
            this.gridPhieuMuon.Size = new System.Drawing.Size(793, 509);
            this.gridPhieuMuon.TabIndex = 3;
            this.gridPhieuMuon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuMuon.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuMuon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridPhieuMuon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuMuon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuMuon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuMuon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuMuon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridPhieuMuon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPhieuMuon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuMuon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPhieuMuon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPhieuMuon.ThemeStyle.HeaderStyle.Height = 35;
            this.gridPhieuMuon.ThemeStyle.ReadOnly = false;
            this.gridPhieuMuon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuMuon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPhieuMuon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuMuon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuMuon.ThemeStyle.RowsStyle.Height = 30;
            this.gridPhieuMuon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuMuon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.ReadOnly = true;
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
            // NgayTaoPhieuMuon
            // 
            this.NgayTaoPhieuMuon.HeaderText = "Ngày tạo phiếu";
            this.NgayTaoPhieuMuon.MinimumWidth = 10;
            this.NgayTaoPhieuMuon.Name = "NgayTaoPhieuMuon";
            // 
            // HanTra
            // 
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.MinimumWidth = 10;
            this.HanTra.Name = "HanTra";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 10;
            this.SoLuong.Name = "SoLuong";
            // 
            // ucPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPhieuMuon);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucPhieuMuon";
            this.Size = new System.Drawing.Size(793, 622);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTimPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnThemPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMaDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMaPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton rdoMaDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton rdoMaPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnXoaPhieuMuon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTailieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTaoPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}
