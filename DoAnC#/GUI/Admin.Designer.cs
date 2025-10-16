namespace GUI
{
    partial class Admin
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
            this.panelHQL = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.btnQLCTHD = new System.Windows.Forms.Button();
            this.btnQLCC = new System.Windows.Forms.Button();
            this.btnQLTHETV = new System.Windows.Forms.Button();
            this.btnQLBan = new System.Windows.Forms.Button();
            this.btnQLLSP = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuaylaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHQL
            // 
            this.panelHQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHQL.Location = new System.Drawing.Point(257, 30);
            this.panelHQL.Name = "panelHQL";
            this.panelHQL.Size = new System.Drawing.Size(1106, 543);
            this.panelHQL.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnXemThongKe);
            this.panel1.Controls.Add(this.btnQLCTHD);
            this.panel1.Controls.Add(this.btnQLCC);
            this.panel1.Controls.Add(this.btnQLTHETV);
            this.panel1.Controls.Add(this.btnQLBan);
            this.panel1.Controls.Add(this.btnQLLSP);
            this.panel1.Controls.Add(this.btnQLHD);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Controls.Add(this.btnQLSP);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 543);
            this.panel1.TabIndex = 5;
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemThongKe.Location = new System.Drawing.Point(0, 480);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(257, 60);
            this.btnXemThongKe.TabIndex = 9;
            this.btnXemThongKe.Text = "Thống kê";
            this.btnXemThongKe.UseVisualStyleBackColor = true;
            this.btnXemThongKe.Click += new System.EventHandler(this.btnXemThongKe_Click);
            // 
            // btnQLCTHD
            // 
            this.btnQLCTHD.BackColor = System.Drawing.Color.White;
            this.btnQLCTHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLCTHD.Location = new System.Drawing.Point(0, 420);
            this.btnQLCTHD.Name = "btnQLCTHD";
            this.btnQLCTHD.Size = new System.Drawing.Size(257, 60);
            this.btnQLCTHD.TabIndex = 8;
            this.btnQLCTHD.Text = "Quản lý chi tiết hóa đơn";
            this.btnQLCTHD.UseVisualStyleBackColor = false;
            this.btnQLCTHD.Click += new System.EventHandler(this.btnQLCTHD_Click);
            // 
            // btnQLCC
            // 
            this.btnQLCC.BackColor = System.Drawing.Color.White;
            this.btnQLCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLCC.Location = new System.Drawing.Point(0, 360);
            this.btnQLCC.Name = "btnQLCC";
            this.btnQLCC.Size = new System.Drawing.Size(257, 60);
            this.btnQLCC.TabIndex = 7;
            this.btnQLCC.Text = "Quản lý chấm công";
            this.btnQLCC.UseVisualStyleBackColor = false;
            this.btnQLCC.Click += new System.EventHandler(this.btnQLCC_Click);
            // 
            // btnQLTHETV
            // 
            this.btnQLTHETV.BackColor = System.Drawing.Color.White;
            this.btnQLTHETV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTHETV.Location = new System.Drawing.Point(0, 300);
            this.btnQLTHETV.Name = "btnQLTHETV";
            this.btnQLTHETV.Size = new System.Drawing.Size(257, 60);
            this.btnQLTHETV.TabIndex = 6;
            this.btnQLTHETV.Text = "Quản lý thẻ thành viên";
            this.btnQLTHETV.UseVisualStyleBackColor = false;
            this.btnQLTHETV.Click += new System.EventHandler(this.btnQLTHETV_Click);
            // 
            // btnQLBan
            // 
            this.btnQLBan.BackColor = System.Drawing.Color.White;
            this.btnQLBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLBan.Location = new System.Drawing.Point(0, 240);
            this.btnQLBan.Name = "btnQLBan";
            this.btnQLBan.Size = new System.Drawing.Size(257, 60);
            this.btnQLBan.TabIndex = 5;
            this.btnQLBan.Text = "Quản lý bàn";
            this.btnQLBan.UseVisualStyleBackColor = false;
            this.btnQLBan.Click += new System.EventHandler(this.btnQLBan_Click);
            // 
            // btnQLLSP
            // 
            this.btnQLLSP.BackColor = System.Drawing.Color.White;
            this.btnQLLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLLSP.Location = new System.Drawing.Point(0, 180);
            this.btnQLLSP.Name = "btnQLLSP";
            this.btnQLLSP.Size = new System.Drawing.Size(257, 60);
            this.btnQLLSP.TabIndex = 4;
            this.btnQLLSP.Text = "Quản lý loại sản phẩm";
            this.btnQLLSP.UseVisualStyleBackColor = false;
            this.btnQLLSP.Click += new System.EventHandler(this.btnQLLSP_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.White;
            this.btnQLHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHD.Location = new System.Drawing.Point(0, 120);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(257, 60);
            this.btnQLHD.TabIndex = 3;
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.UseVisualStyleBackColor = false;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.White;
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.Location = new System.Drawing.Point(0, 60);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(257, 60);
            this.btnQLNV.TabIndex = 2;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.BackColor = System.Drawing.Color.White;
            this.btnQLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSP.Location = new System.Drawing.Point(0, 0);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(257, 60);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.UseVisualStyleBackColor = false;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.QuaylaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // QuaylaiToolStripMenuItem
            // 
            this.QuaylaiToolStripMenuItem.Name = "QuaylaiToolStripMenuItem";
            this.QuaylaiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.QuaylaiToolStripMenuItem.Text = "Quay lại";
            this.QuaylaiToolStripMenuItem.Click += new System.EventHandler(this.QuaylaiToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1363, 573);
            this.Controls.Add(this.panelHQL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLCTHD;
        private System.Windows.Forms.Button btnQLCC;
        private System.Windows.Forms.Button btnQLTHETV;
        private System.Windows.Forms.Button btnQLBan;
        private System.Windows.Forms.Button btnQLLSP;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuaylaiToolStripMenuItem;
        private System.Windows.Forms.Button btnXemThongKe;
    }
}