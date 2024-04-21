namespace App
{
    partial class frThemPhieuPhat
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelEmailError = new System.Windows.Forms.Label();
            this.lblNgayTaoPhieuPhat = new System.Windows.Forms.Label();
            this.btnThem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dateNgayTaoPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.lbSoTienPhat = new System.Windows.Forms.Label();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.lblMaPhieuPhat = new System.Windows.Forms.Label();
            this.txtSoTienPhat = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaPhieuMuon = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaPhieuPhat = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.mainPanel.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.mainPanel.BorderRadius = 4;
            this.mainPanel.Controls.Add(this.labelEmailError);
            this.mainPanel.Controls.Add(this.lblNgayTaoPhieuPhat);
            this.mainPanel.Controls.Add(this.btnThem);
            this.mainPanel.Controls.Add(this.dateNgayTaoPhieuPhat);
            this.mainPanel.Controls.Add(this.lbSoTienPhat);
            this.mainPanel.Controls.Add(this.lblMaPhieuMuon);
            this.mainPanel.Controls.Add(this.lblMaPhieuPhat);
            this.mainPanel.Controls.Add(this.txtSoTienPhat);
            this.mainPanel.Controls.Add(this.txtMaPhieuMuon);
            this.mainPanel.Controls.Add(this.txtMaPhieuPhat);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Location = new System.Drawing.Point(13, 11);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Color = System.Drawing.Color.MediumSlateBlue;
            this.mainPanel.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.mainPanel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.mainPanel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.mainPanel.Size = new System.Drawing.Size(573, 523);
            this.mainPanel.TabIndex = 3;
            // 
            // labelEmailError
            // 
            this.labelEmailError.AutoSize = true;
            this.labelEmailError.Location = new System.Drawing.Point(117, 369);
            this.labelEmailError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailError.Name = "labelEmailError";
            this.labelEmailError.Size = new System.Drawing.Size(0, 31);
            this.labelEmailError.TabIndex = 8;
            // 
            // lblNgayTaoPhieuPhat
            // 
            this.lblNgayTaoPhieuPhat.AutoSize = true;
            this.lblNgayTaoPhieuPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNgayTaoPhieuPhat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNgayTaoPhieuPhat.Location = new System.Drawing.Point(115, 238);
            this.lblNgayTaoPhieuPhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTaoPhieuPhat.Name = "lblNgayTaoPhieuPhat";
            this.lblNgayTaoPhieuPhat.Size = new System.Drawing.Size(267, 31);
            this.lblNgayTaoPhieuPhat.TabIndex = 2;
            this.lblNgayTaoPhieuPhat.Text = "Ngày tạo phiếu phạt*";
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 3;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.SlateBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(219, 446);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 43);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNgayTaoPhieuPhat
            // 
            this.dateNgayTaoPhieuPhat.Checked = true;
            this.dateNgayTaoPhieuPhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dateNgayTaoPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayTaoPhieuPhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTaoPhieuPhat.Location = new System.Drawing.Point(115, 277);
            this.dateNgayTaoPhieuPhat.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgayTaoPhieuPhat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayTaoPhieuPhat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayTaoPhieuPhat.Name = "dateNgayTaoPhieuPhat";
            this.dateNgayTaoPhieuPhat.Size = new System.Drawing.Size(142, 44);
            this.dateNgayTaoPhieuPhat.TabIndex = 3;
            this.dateNgayTaoPhieuPhat.Value = new System.DateTime(2023, 11, 30, 5, 25, 33, 0);
            // 
            // lbSoTienPhat
            // 
            this.lbSoTienPhat.AutoSize = true;
            this.lbSoTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoTienPhat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbSoTienPhat.Location = new System.Drawing.Point(115, 348);
            this.lbSoTienPhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoTienPhat.Name = "lbSoTienPhat";
            this.lbSoTienPhat.Size = new System.Drawing.Size(169, 31);
            this.lbSoTienPhat.TabIndex = 2;
            this.lbSoTienPhat.Text = "Số tiền phạt*";
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaPhieuMuon.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(111, 168);
            this.lblMaPhieuMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(198, 31);
            this.lblMaPhieuMuon.TabIndex = 2;
            this.lblMaPhieuMuon.Text = "Mã phiếu mượn";
            // 
            // lblMaPhieuPhat
            // 
            this.lblMaPhieuPhat.AutoSize = true;
            this.lblMaPhieuPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaPhieuPhat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMaPhieuPhat.Location = new System.Drawing.Point(113, 98);
            this.lblMaPhieuPhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPhieuPhat.Name = "lblMaPhieuPhat";
            this.lblMaPhieuPhat.Size = new System.Drawing.Size(195, 31);
            this.lblMaPhieuPhat.TabIndex = 2;
            this.lblMaPhieuPhat.Text = "Mã phiếu phạt*";
            // 
            // txtSoTienPhat
            // 
            this.txtSoTienPhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTienPhat.DefaultText = "";
            this.txtSoTienPhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTienPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTienPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTienPhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTienPhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTienPhat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoTienPhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTienPhat.Location = new System.Drawing.Point(115, 381);
            this.txtSoTienPhat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienPhat.Name = "txtSoTienPhat";
            this.txtSoTienPhat.PasswordChar = '\0';
            this.txtSoTienPhat.PlaceholderText = "";
            this.txtSoTienPhat.SelectedText = "";
            this.txtSoTienPhat.Size = new System.Drawing.Size(160, 33);
            this.txtSoTienPhat.TabIndex = 4;
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieuMuon.DefaultText = "";
            this.txtMaPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuMuon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuMuon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaPhieuMuon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(117, 189);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.PasswordChar = '\0';
            this.txtMaPhieuMuon.PlaceholderText = "";
            this.txtMaPhieuMuon.SelectedText = "";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(321, 33);
            this.txtMaPhieuMuon.TabIndex = 2;
            // 
            // txtMaPhieuPhat
            // 
            this.txtMaPhieuPhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieuPhat.DefaultText = "";
            this.txtMaPhieuPhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieuPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieuPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuPhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuPhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaPhieuPhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuPhat.Location = new System.Drawing.Point(117, 122);
            this.txtMaPhieuPhat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieuPhat.Name = "txtMaPhieuPhat";
            this.txtMaPhieuPhat.PasswordChar = '\0';
            this.txtMaPhieuPhat.PlaceholderText = "";
            this.txtMaPhieuPhat.SelectedText = "";
            this.txtMaPhieuPhat.Size = new System.Drawing.Size(321, 33);
            this.txtMaPhieuPhat.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(130, 42);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(629, 73);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM PHIẾU PHẠT";
            // 
            // frThemPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(597, 542);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frThemPhieuPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM PHIẾU PHẠT";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel mainPanel;
        private System.Windows.Forms.Label labelEmailError;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnThem;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgayTaoPhieuPhat;
        private System.Windows.Forms.Label lblNgayTaoPhieuPhat;
        private System.Windows.Forms.Label lbSoTienPhat;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.Label lblMaPhieuPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSoTienPhat;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaPhieuMuon;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaPhieuPhat;
        private System.Windows.Forms.Label lblTitle;
    }
}