namespace App
{
    partial class ucPhieuPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuPhat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblMaPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblMaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.rdoMaPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.rdoMaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.btnXoaPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnThemPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnTimPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTimPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.gridPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaPhieuPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoPhieuPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayQuaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnSua);
            this.topPanel.Controls.Add(this.lblMaPhieuPhat);
            this.topPanel.Controls.Add(this.lblMaPhieuMuon);
            this.topPanel.Controls.Add(this.rdoMaPhieuPhat);
            this.topPanel.Controls.Add(this.rdoMaPhieuMuon);
            this.topPanel.Controls.Add(this.btnXoaPhieuPhat);
            this.topPanel.Controls.Add(this.btnThemPhieuPhat);
            this.topPanel.Controls.Add(this.btnRefresh);
            this.topPanel.Controls.Add(this.btnTimPhieuPhat);
            this.topPanel.Controls.Add(this.txtTimPhieuPhat);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(793, 113);
            this.topPanel.TabIndex = 4;
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
            this.btnSua.Location = new System.Drawing.Point(189, 55);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 48);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.TextOffset = new System.Drawing.Point(3, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMaPhieuPhat
            // 
            this.lblMaPhieuPhat.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPhieuPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuPhat.Location = new System.Drawing.Point(632, 22);
            this.lblMaPhieuPhat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMaPhieuPhat.Name = "lblMaPhieuPhat";
            this.lblMaPhieuPhat.Size = new System.Drawing.Size(140, 28);
            this.lblMaPhieuPhat.TabIndex = 20;
            this.lblMaPhieuPhat.Text = "Mã phiếu phạt";
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
            // rdoMaPhieuPhat
            // 
            this.rdoMaPhieuPhat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaPhieuPhat.CheckedState.BorderThickness = 0;
            this.rdoMaPhieuPhat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMaPhieuPhat.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMaPhieuPhat.Location = new System.Drawing.Point(602, 16);
            this.rdoMaPhieuPhat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoMaPhieuPhat.Name = "rdoMaPhieuPhat";
            this.rdoMaPhieuPhat.Size = new System.Drawing.Size(23, 23);
            this.rdoMaPhieuPhat.TabIndex = 4;
            this.rdoMaPhieuPhat.Text = "siticoneCustomRadioButton2";
            this.rdoMaPhieuPhat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMaPhieuPhat.UncheckedState.BorderThickness = 2;
            this.rdoMaPhieuPhat.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMaPhieuPhat.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            // btnXoaPhieuPhat
            // 
            this.btnXoaPhieuPhat.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnXoaPhieuPhat.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaPhieuPhat.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuPhat.Image")));
            this.btnXoaPhieuPhat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnXoaPhieuPhat.ImageRotate = 0F;
            this.btnXoaPhieuPhat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaPhieuPhat.Location = new System.Drawing.Point(139, 55);
            this.btnXoaPhieuPhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhieuPhat.Name = "btnXoaPhieuPhat";
            this.btnXoaPhieuPhat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoaPhieuPhat.Size = new System.Drawing.Size(35, 35);
            this.btnXoaPhieuPhat.TabIndex = 17;
            this.btnXoaPhieuPhat.Click += new System.EventHandler(this.btnXoaPhieuPhat_Click);
            // 
            // btnThemPhieuPhat
            // 
            this.btnThemPhieuPhat.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThemPhieuPhat.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemPhieuPhat.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuPhat.Image")));
            this.btnThemPhieuPhat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemPhieuPhat.ImageRotate = 0F;
            this.btnThemPhieuPhat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemPhieuPhat.Location = new System.Drawing.Point(75, 55);
            this.btnThemPhieuPhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuPhat.Name = "btnThemPhieuPhat";
            this.btnThemPhieuPhat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemPhieuPhat.Size = new System.Drawing.Size(35, 35);
            this.btnThemPhieuPhat.TabIndex = 16;
            this.btnThemPhieuPhat.Click += new System.EventHandler(this.btnThemPhieuPhat_Click);
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
            // btnTimPhieuPhat
            // 
            this.btnTimPhieuPhat.AutoRoundedCorners = true;
            this.btnTimPhieuPhat.BorderRadius = 16;
            this.btnTimPhieuPhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimPhieuPhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimPhieuPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimPhieuPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimPhieuPhat.FillColor = System.Drawing.Color.SlateBlue;
            this.btnTimPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimPhieuPhat.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieuPhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimPhieuPhat.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnTimPhieuPhat.Location = new System.Drawing.Point(651, 55);
            this.btnTimPhieuPhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimPhieuPhat.Name = "btnTimPhieuPhat";
            this.btnTimPhieuPhat.Size = new System.Drawing.Size(140, 35);
            this.btnTimPhieuPhat.TabIndex = 14;
            this.btnTimPhieuPhat.Text = "Tìm kiếm";
            this.btnTimPhieuPhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimPhieuPhat.TextOffset = new System.Drawing.Point(3, 0);
            this.btnTimPhieuPhat.Click += new System.EventHandler(this.btnTimPhieuPhat_Click);
            // 
            // txtTimPhieuPhat
            // 
            this.txtTimPhieuPhat.AutoRoundedCorners = true;
            this.txtTimPhieuPhat.BorderRadius = 16;
            this.txtTimPhieuPhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimPhieuPhat.DefaultText = "";
            this.txtTimPhieuPhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimPhieuPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimPhieuPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieuPhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieuPhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimPhieuPhat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTimPhieuPhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieuPhat.Location = new System.Drawing.Point(436, 55);
            this.txtTimPhieuPhat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimPhieuPhat.Name = "txtTimPhieuPhat";
            this.txtTimPhieuPhat.PasswordChar = '\0';
            this.txtTimPhieuPhat.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimPhieuPhat.PlaceholderText = "Mã phiếu";
            this.txtTimPhieuPhat.SelectedText = "";
            this.txtTimPhieuPhat.Size = new System.Drawing.Size(210, 35);
            this.txtTimPhieuPhat.TabIndex = 15;
            // 
            // gridPhieuPhat
            // 
            this.gridPhieuPhat.AllowUserToAddRows = false;
            this.gridPhieuPhat.AllowUserToDeleteRows = false;
            this.gridPhieuPhat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuPhat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPhieuPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPhieuPhat.ColumnHeadersHeight = 35;
            this.gridPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPhieuPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.MaPhieuPhat,
            this.MaPhieuMuon,
            this.NgayTaoPhieuPhat,
            this.SoNgayQuaHan,
            this.TienPhat});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPhieuPhat.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPhieuPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhieuPhat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuPhat.Location = new System.Drawing.Point(0, 113);
            this.gridPhieuPhat.Margin = new System.Windows.Forms.Padding(2);
            this.gridPhieuPhat.Name = "gridPhieuPhat";
            this.gridPhieuPhat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuPhat.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPhieuPhat.RowHeadersVisible = false;
            this.gridPhieuPhat.RowHeadersWidth = 51;
            this.gridPhieuPhat.RowTemplate.Height = 30;
            this.gridPhieuPhat.Size = new System.Drawing.Size(793, 509);
            this.gridPhieuPhat.TabIndex = 5;
            this.gridPhieuPhat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuPhat.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuPhat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridPhieuPhat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuPhat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuPhat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuPhat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuPhat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridPhieuPhat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPhieuPhat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuPhat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPhieuPhat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPhieuPhat.ThemeStyle.HeaderStyle.Height = 35;
            this.gridPhieuPhat.ThemeStyle.ReadOnly = false;
            this.gridPhieuPhat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPhieuPhat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPhieuPhat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuPhat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPhieuPhat.ThemeStyle.RowsStyle.Height = 30;
            this.gridPhieuPhat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPhieuPhat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // MaPhieuPhat
            // 
            this.MaPhieuPhat.HeaderText = "Mã phiếu phạt";
            this.MaPhieuPhat.MinimumWidth = 6;
            this.MaPhieuPhat.Name = "MaPhieuPhat";
            this.MaPhieuPhat.ReadOnly = true;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.MaPhieuMuon.MinimumWidth = 10;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            // 
            // NgayTaoPhieuPhat
            // 
            this.NgayTaoPhieuPhat.HeaderText = "Ngày tạo phiếu phạt";
            this.NgayTaoPhieuPhat.MinimumWidth = 10;
            this.NgayTaoPhieuPhat.Name = "NgayTaoPhieuPhat";
            // 
            // SoNgayQuaHan
            // 
            this.SoNgayQuaHan.HeaderText = "Số ngày quá hạn";
            this.SoNgayQuaHan.MinimumWidth = 6;
            this.SoNgayQuaHan.Name = "SoNgayQuaHan";
            this.SoNgayQuaHan.ReadOnly = true;
            this.SoNgayQuaHan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TienPhat
            // 
            this.TienPhat.HeaderText = "Tiền phạt";
            this.TienPhat.MinimumWidth = 6;
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            this.TienPhat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ucPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPhieuPhat);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucPhieuPhat";
            this.Size = new System.Drawing.Size(793, 622);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuPhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMaPhieuPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMaPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton rdoMaPhieuPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton rdoMaPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnXoaPhieuPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnThemPhieuPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimPhieuPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTimPhieuPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridPhieuPhat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTaoPhieuPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayQuaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
    }
}
