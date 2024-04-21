namespace App
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 295);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lbTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(13, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 100);
            this.panel2.TabIndex = 0;
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(33, 43);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(122, 19);
            this.lbTenDangNhap.TabIndex = 0;
            this.lbTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 27);
            this.textBox1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.lbMatKhau);
            this.panel3.Location = new System.Drawing.Point(13, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 100);
            this.panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(372, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(33, 43);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(82, 19);
            this.lbMatKhau.TabIndex = 0;
            this.lbMatKhau.Text = "Mật khẩu:";
            this.lbMatKhau.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(254, 233);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 316);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

