namespace App
{
    partial class frManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frManager));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.tabPhieuPhat = new System.Windows.Forms.TabPage();
            this.tabPhieuTra = new System.Windows.Forms.TabPage();
            this.tabPhieuMuon = new System.Windows.Forms.TabPage();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabReaders = new System.Windows.Forms.TabPage();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.SlateBlue;
            this.iconList.Images.SetKeyName(0, "home_icon.png");
            this.iconList.Images.SetKeyName(1, "nguoidung.png");
            this.iconList.Images.SetKeyName(2, "book_icon.png");
            this.iconList.Images.SetKeyName(3, "phieuthu.png");
            this.iconList.Images.SetKeyName(4, "phieumuon_icon.png");
            this.iconList.Images.SetKeyName(5, "phieumuontra.png");
            this.iconList.Images.SetKeyName(6, "user_icon02.png");
            this.iconList.Images.SetKeyName(7, "key_icon.png");
            this.iconList.Images.SetKeyName(8, "user_icon.png");
            this.iconList.Images.SetKeyName(9, "thaydoiquydinh.png");
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabAdmin.ImageIndex = 9;
            this.tabAdmin.Location = new System.Drawing.Point(244, 4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(1196, 712);
            this.tabAdmin.TabIndex = 7;
            this.tabAdmin.Text = "Admin";
            // 
            // tabPhieuPhat
            // 
            this.tabPhieuPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabPhieuPhat.ImageIndex = 5;
            this.tabPhieuPhat.Location = new System.Drawing.Point(244, 4);
            this.tabPhieuPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhieuPhat.Name = "tabPhieuPhat";
            this.tabPhieuPhat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhieuPhat.Size = new System.Drawing.Size(1196, 712);
            this.tabPhieuPhat.TabIndex = 5;
            this.tabPhieuPhat.Text = "Phiếu phạt";
            // 
            // tabPhieuTra
            // 
            this.tabPhieuTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabPhieuTra.ImageIndex = 4;
            this.tabPhieuTra.Location = new System.Drawing.Point(244, 4);
            this.tabPhieuTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhieuTra.Name = "tabPhieuTra";
            this.tabPhieuTra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhieuTra.Size = new System.Drawing.Size(1196, 712);
            this.tabPhieuTra.TabIndex = 4;
            this.tabPhieuTra.Text = "Phiếu Trả";
            // 
            // tabPhieuMuon
            // 
            this.tabPhieuMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabPhieuMuon.ImageIndex = 3;
            this.tabPhieuMuon.Location = new System.Drawing.Point(244, 4);
            this.tabPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhieuMuon.Name = "tabPhieuMuon";
            this.tabPhieuMuon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhieuMuon.Size = new System.Drawing.Size(1196, 712);
            this.tabPhieuMuon.TabIndex = 3;
            this.tabPhieuMuon.Text = "Phiếu mượn";
            // 
            // tabBooks
            // 
            this.tabBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabBooks.ImageIndex = 2;
            this.tabBooks.Location = new System.Drawing.Point(244, 4);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBooks.Size = new System.Drawing.Size(1196, 712);
            this.tabBooks.TabIndex = 2;
            this.tabBooks.Text = "Sách";
            // 
            // tabReaders
            // 
            this.tabReaders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabReaders.ImageIndex = 1;
            this.tabReaders.Location = new System.Drawing.Point(244, 4);
            this.tabReaders.Margin = new System.Windows.Forms.Padding(0);
            this.tabReaders.Name = "tabReaders";
            this.tabReaders.Size = new System.Drawing.Size(1196, 712);
            this.tabReaders.TabIndex = 1;
            this.tabReaders.Text = "Độc giả";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabReaders);
            this.tabControl.Controls.Add(this.tabBooks);
            this.tabControl.Controls.Add(this.tabPhieuMuon);
            this.tabControl.Controls.Add(this.tabPhieuTra);
            this.tabControl.Controls.Add(this.tabPhieuPhat);
            this.tabControl.Controls.Add(this.tabAdmin);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.iconList;
            this.tabControl.ItemSize = new System.Drawing.Size(240, 60);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1444, 720);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonImageOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSize = new System.Drawing.Size(240, 60);
            this.tabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonTextOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabIndex = 3;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.MediumSlateBlue;
            // 
            // frManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 720);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện ĐHSP";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabPhieuPhat;
        private System.Windows.Forms.TabPage tabPhieuTra;
        private System.Windows.Forms.TabPage tabPhieuMuon;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabReaders;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabControl;
    }
}