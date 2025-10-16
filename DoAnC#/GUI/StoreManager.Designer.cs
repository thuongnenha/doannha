namespace GUI
{
    partial class StoreManager
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
            this.btnXacNhan_SM = new System.Windows.Forms.Button();
            this.cbxChuyenBan_SN = new System.Windows.Forms.ComboBox();
            this.nmudGiamMon_SM = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptb_Food_SM = new System.Windows.Forms.PictureBox();
            this.cbxGhepBan_SM = new System.Windows.Forms.ComboBox();
            this.btnChuyenBan_SM = new System.Windows.Forms.Button();
            this.btnGhepBan_SM = new System.Windows.Forms.Button();
            this.btnGiamMon_SM = new System.Windows.Forms.Button();
            this.btnThemMon_SM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmudThemMon_SM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SDT_SM = new System.Windows.Forms.TextBox();
            this.txtThemMon_SM = new System.Windows.Forms.TextBox();
            this.cbxThemMon_SM = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFood_SM = new System.Windows.Forms.DataGridView();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGiamMon_SM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Food_SM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudThemMon_SM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood_SM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXacNhan_SM
            // 
            this.btnXacNhan_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan_SM.Location = new System.Drawing.Point(542, 75);
            this.btnXacNhan_SM.Name = "btnXacNhan_SM";
            this.btnXacNhan_SM.Size = new System.Drawing.Size(226, 53);
            this.btnXacNhan_SM.TabIndex = 4;
            this.btnXacNhan_SM.Text = "Xác nhận";
            this.btnXacNhan_SM.UseVisualStyleBackColor = true;
            this.btnXacNhan_SM.Click += new System.EventHandler(this.btnXacNhan_SM_Click);
            // 
            // cbxChuyenBan_SN
            // 
            this.cbxChuyenBan_SN.FormattingEnabled = true;
            this.cbxChuyenBan_SN.Location = new System.Drawing.Point(153, 98);
            this.cbxChuyenBan_SN.Name = "cbxChuyenBan_SN";
            this.cbxChuyenBan_SN.Size = new System.Drawing.Size(100, 24);
            this.cbxChuyenBan_SN.TabIndex = 0;
            this.cbxChuyenBan_SN.DropDown += new System.EventHandler(this.cbxChuyenBan_SN_DropDown);
            // 
            // nmudGiamMon_SM
            // 
            this.nmudGiamMon_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmudGiamMon_SM.Location = new System.Drawing.Point(667, 47);
            this.nmudGiamMon_SM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudGiamMon_SM.Name = "nmudGiamMon_SM";
            this.nmudGiamMon_SM.Size = new System.Drawing.Size(101, 22);
            this.nmudGiamMon_SM.TabIndex = 4;
            this.nmudGiamMon_SM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudGiamMon_SM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmudGiamMon_SM_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.ptb_Food_SM);
            this.panel2.Controls.Add(this.cbxGhepBan_SM);
            this.panel2.Controls.Add(this.btnChuyenBan_SM);
            this.panel2.Controls.Add(this.cbxChuyenBan_SN);
            this.panel2.Controls.Add(this.btnGhepBan_SM);
            this.panel2.Controls.Add(this.btnGiamMon_SM);
            this.panel2.Controls.Add(this.btnThemMon_SM);
            this.panel2.Controls.Add(this.btnXacNhan_SM);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nmudGiamMon_SM);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nmudThemMon_SM);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_SDT_SM);
            this.panel2.Controls.Add(this.txtThemMon_SM);
            this.panel2.Controls.Add(this.cbxThemMon_SM);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 131);
            this.panel2.TabIndex = 8;
            // 
            // ptb_Food_SM
            // 
            this.ptb_Food_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_Food_SM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Food_SM.Location = new System.Drawing.Point(774, 3);
            this.ptb_Food_SM.Name = "ptb_Food_SM";
            this.ptb_Food_SM.Size = new System.Drawing.Size(95, 125);
            this.ptb_Food_SM.TabIndex = 10;
            this.ptb_Food_SM.TabStop = false;
            // 
            // cbxGhepBan_SM
            // 
            this.cbxGhepBan_SM.FormattingEnabled = true;
            this.cbxGhepBan_SM.Location = new System.Drawing.Point(436, 98);
            this.cbxGhepBan_SM.Name = "cbxGhepBan_SM";
            this.cbxGhepBan_SM.Size = new System.Drawing.Size(100, 24);
            this.cbxGhepBan_SM.TabIndex = 13;
            this.cbxGhepBan_SM.DropDown += new System.EventHandler(this.cbxGhepBan_SM_DropDown);
            // 
            // btnChuyenBan_SM
            // 
            this.btnChuyenBan_SM.Location = new System.Drawing.Point(15, 90);
            this.btnChuyenBan_SM.Name = "btnChuyenBan_SM";
            this.btnChuyenBan_SM.Size = new System.Drawing.Size(132, 38);
            this.btnChuyenBan_SM.TabIndex = 12;
            this.btnChuyenBan_SM.Text = "Chuyển bàn";
            this.btnChuyenBan_SM.UseVisualStyleBackColor = true;
            this.btnChuyenBan_SM.Click += new System.EventHandler(this.btnChuyenBan_SM_Click);
            // 
            // btnGhepBan_SM
            // 
            this.btnGhepBan_SM.Location = new System.Drawing.Point(298, 90);
            this.btnGhepBan_SM.Name = "btnGhepBan_SM";
            this.btnGhepBan_SM.Size = new System.Drawing.Size(132, 38);
            this.btnGhepBan_SM.TabIndex = 11;
            this.btnGhepBan_SM.Text = "Ghép bàn";
            this.btnGhepBan_SM.UseVisualStyleBackColor = true;
            this.btnGhepBan_SM.Click += new System.EventHandler(this.btnGhepBan_SM_Click);
            // 
            // btnGiamMon_SM
            // 
            this.btnGiamMon_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiamMon_SM.Location = new System.Drawing.Point(658, 3);
            this.btnGiamMon_SM.Name = "btnGiamMon_SM";
            this.btnGiamMon_SM.Size = new System.Drawing.Size(110, 38);
            this.btnGiamMon_SM.TabIndex = 9;
            this.btnGiamMon_SM.Text = "Giảm món";
            this.btnGiamMon_SM.UseVisualStyleBackColor = true;
            this.btnGiamMon_SM.Click += new System.EventHandler(this.btnGiamMon_SM_Click);
            // 
            // btnThemMon_SM
            // 
            this.btnThemMon_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMon_SM.Location = new System.Drawing.Point(542, 3);
            this.btnThemMon_SM.Name = "btnThemMon_SM";
            this.btnThemMon_SM.Size = new System.Drawing.Size(110, 38);
            this.btnThemMon_SM.TabIndex = 8;
            this.btnThemMon_SM.Text = "Thêm móm";
            this.btnThemMon_SM.UseVisualStyleBackColor = true;
            this.btnThemMon_SM.Click += new System.EventHandler(this.btnThemMon_SM_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá sản phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sản phẩm :";
            // 
            // nmudThemMon_SM
            // 
            this.nmudThemMon_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmudThemMon_SM.Location = new System.Drawing.Point(542, 47);
            this.nmudThemMon_SM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudThemMon_SM.Name = "nmudThemMon_SM";
            this.nmudThemMon_SM.Size = new System.Drawing.Size(110, 22);
            this.nmudThemMon_SM.TabIndex = 3;
            this.nmudThemMon_SM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudThemMon_SM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmudThemMon_SM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số điện thoại khách hàng :";
            // 
            // txt_SDT_SM
            // 
            this.txt_SDT_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SDT_SM.Location = new System.Drawing.Point(229, 62);
            this.txt_SDT_SM.Name = "txt_SDT_SM";
            this.txt_SDT_SM.Size = new System.Drawing.Size(307, 22);
            this.txt_SDT_SM.TabIndex = 4;
            // 
            // txtThemMon_SM
            // 
            this.txtThemMon_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThemMon_SM.Location = new System.Drawing.Point(229, 33);
            this.txtThemMon_SM.Name = "txtThemMon_SM";
            this.txtThemMon_SM.ReadOnly = true;
            this.txtThemMon_SM.Size = new System.Drawing.Size(307, 22);
            this.txtThemMon_SM.TabIndex = 1;
            // 
            // cbxThemMon_SM
            // 
            this.cbxThemMon_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxThemMon_SM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThemMon_SM.FormattingEnabled = true;
            this.cbxThemMon_SM.Location = new System.Drawing.Point(229, 3);
            this.cbxThemMon_SM.Name = "cbxThemMon_SM";
            this.cbxThemMon_SM.Size = new System.Drawing.Size(307, 24);
            this.cbxThemMon_SM.TabIndex = 0;
            this.cbxThemMon_SM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvFood_SM);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(562, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 554);
            this.panel1.TabIndex = 7;
            // 
            // dgvFood_SM
            // 
            this.dgvFood_SM.AllowUserToAddRows = false;
            this.dgvFood_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood_SM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood_SM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HinhAnh,
            this.TenMon,
            this.SoLuong,
            this.Gia});
            this.dgvFood_SM.Location = new System.Drawing.Point(3, 137);
            this.dgvFood_SM.Name = "dgvFood_SM";
            this.dgvFood_SM.RowHeadersWidth = 52;
            this.dgvFood_SM.RowTemplate.Height = 24;
            this.dgvFood_SM.Size = new System.Drawing.Size(872, 411);
            this.dgvFood_SM.TabIndex = 0;
            // 
            // HinhAnh
            // 
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Width = 90;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 554);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Tag = "";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.làmMớiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuItem1.Text = "Quay lại";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // StoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StoreManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreManeger";
            this.Load += new System.EventHandler(this.StoreManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmudGiamMon_SM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Food_SM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudThemMon_SM)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood_SM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXacNhan_SM;
        private System.Windows.Forms.ComboBox cbxChuyenBan_SN;
        private System.Windows.Forms.NumericUpDown nmudGiamMon_SM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmudThemMon_SM;
        private System.Windows.Forms.TextBox txtThemMon_SM;
        private System.Windows.Forms.ComboBox cbxThemMon_SM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFood_SM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT_SM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb_Food_SM;
        private System.Windows.Forms.Button btnGiamMon_SM;
        private System.Windows.Forms.Button btnThemMon_SM;
        private System.Windows.Forms.Button btnChuyenBan_SM;
        private System.Windows.Forms.Button btnGhepBan_SM;
        private System.Windows.Forms.ComboBox cbxGhepBan_SM;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}