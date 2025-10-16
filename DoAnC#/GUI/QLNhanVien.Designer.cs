namespace GUI
{
    partial class QLNhanVien
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
            this.lblQLNV = new System.Windows.Forms.Label();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.panelQLNV = new System.Windows.Forms.Panel();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.pictureBoxHA = new System.Windows.Forms.PictureBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.lblSĐT = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.lblHoNV = new System.Windows.Forms.Label();
            this.txtTKNV = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTieuDe.SuspendLayout();
            this.panelQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLNV
            // 
            this.lblQLNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQLNV.AutoSize = true;
            this.lblQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLNV.Location = new System.Drawing.Point(436, 0);
            this.lblQLNV.Name = "lblQLNV";
            this.lblQLNV.Size = new System.Drawing.Size(194, 25);
            this.lblQLNV.TabIndex = 0;
            this.lblQLNV.Text = "Quản lý Nhân Viên";
            this.lblQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.IndianRed;
            this.panelTieuDe.Controls.Add(this.lblQLNV);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1106, 35);
            this.panelTieuDe.TabIndex = 8;
            // 
            // panelQLNV
            // 
            this.panelQLNV.BackColor = System.Drawing.Color.White;
            this.panelQLNV.Controls.Add(this.txtPW);
            this.panelQLNV.Controls.Add(this.lblPassword);
            this.panelQLNV.Controls.Add(this.txtLuong);
            this.panelQLNV.Controls.Add(this.btnTK);
            this.panelQLNV.Controls.Add(this.pictureBoxHA);
            this.panelQLNV.Controls.Add(this.chkTrangThai);
            this.panelQLNV.Controls.Add(this.btnXoa);
            this.panelQLNV.Controls.Add(this.btnLamMoi);
            this.panelQLNV.Controls.Add(this.btnSua);
            this.panelQLNV.Controls.Add(this.btnThem);
            this.panelQLNV.Controls.Add(this.txtEmail);
            this.panelQLNV.Controls.Add(this.lblEmail);
            this.panelQLNV.Controls.Add(this.txtSĐT);
            this.panelQLNV.Controls.Add(this.lblSĐT);
            this.panelQLNV.Controls.Add(this.lblLuong);
            this.panelQLNV.Controls.Add(this.txtTenNV);
            this.panelQLNV.Controls.Add(this.lblTenNV);
            this.panelQLNV.Controls.Add(this.txtHoNV);
            this.panelQLNV.Controls.Add(this.lblHoNV);
            this.panelQLNV.Controls.Add(this.txtTKNV);
            this.panelQLNV.Controls.Add(this.txtID);
            this.panelQLNV.Controls.Add(this.lblIDNV);
            this.panelQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLNV.Location = new System.Drawing.Point(0, 35);
            this.panelQLNV.Name = "panelQLNV";
            this.panelQLNV.Size = new System.Drawing.Size(1106, 188);
            this.panelQLNV.TabIndex = 10;
            // 
            // txtPW
            // 
            this.txtPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPW.Location = new System.Drawing.Point(537, 157);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(282, 22);
            this.txtPW.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(438, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuong.Location = new System.Drawing.Point(537, 13);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(282, 22);
            this.txtLuong.TabIndex = 20;
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(128, 154);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(93, 25);
            this.btnTK.TabIndex = 19;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // pictureBoxHA
            // 
            this.pictureBoxHA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHA.BackgroundImage = global::GUI.Properties.Resources.admin;
            this.pictureBoxHA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHA.Location = new System.Drawing.Point(954, 6);
            this.pictureBoxHA.Name = "pictureBoxHA";
            this.pictureBoxHA.Size = new System.Drawing.Size(149, 179);
            this.pictureBoxHA.TabIndex = 13;
            this.pictureBoxHA.TabStop = false;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Location = new System.Drawing.Point(22, 157);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(89, 20);
            this.chkTrangThai.TabIndex = 17;
            this.chkTrangThai.Text = "Trạng thái";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(855, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 38);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(855, 141);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(93, 38);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(855, 53);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 38);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(855, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 38);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(537, 113);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(448, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtSĐT
            // 
            this.txtSĐT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSĐT.Location = new System.Drawing.Point(537, 67);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(282, 22);
            this.txtSĐT.TabIndex = 9;
            this.txtSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSĐT_KeyPress);
            // 
            // lblSĐT
            // 
            this.lblSĐT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSĐT.AutoSize = true;
            this.lblSĐT.Location = new System.Drawing.Point(429, 67);
            this.lblSĐT.Name = "lblSĐT";
            this.lblSĐT.Size = new System.Drawing.Size(88, 16);
            this.lblSĐT.TabIndex = 8;
            this.lblSĐT.Text = "Số điện thoại:";
            // 
            // lblLuong
            // 
            this.lblLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(448, 16);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(47, 16);
            this.lblLuong.TabIndex = 6;
            this.lblLuong.Text = "Lương:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Location = new System.Drawing.Point(128, 113);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(282, 22);
            this.txtTenNV.TabIndex = 5;
            this.txtTenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNV_KeyPress);
            // 
            // lblTenNV
            // 
            this.lblTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(16, 116);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(94, 16);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // txtHoNV
            // 
            this.txtHoNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoNV.Location = new System.Drawing.Point(128, 67);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(282, 22);
            this.txtHoNV.TabIndex = 3;
            this.txtHoNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoNV_KeyPress);
            // 
            // lblHoNV
            // 
            this.lblHoNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoNV.AutoSize = true;
            this.lblHoNV.Location = new System.Drawing.Point(19, 67);
            this.lblHoNV.Name = "lblHoNV";
            this.lblHoNV.Size = new System.Drawing.Size(91, 16);
            this.lblHoNV.TabIndex = 2;
            this.lblHoNV.Text = "Họ nhân viên :";
            // 
            // txtTKNV
            // 
            this.txtTKNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTKNV.Location = new System.Drawing.Point(227, 157);
            this.txtTKNV.Name = "txtTKNV";
            this.txtTKNV.Size = new System.Drawing.Size(183, 22);
            this.txtTKNV.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(128, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(282, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblIDNV
            // 
            this.lblIDNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Location = new System.Drawing.Point(19, 16);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(86, 16);
            this.lblIDNV.TabIndex = 0;
            this.lblIDNV.Text = "ID nhân viên :";
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colHoNV,
            this.colTenNV,
            this.colLuong,
            this.colSĐT,
            this.colEmail,
            this.colPW});
            this.dgvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNV.Location = new System.Drawing.Point(0, 223);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.RowTemplate.Height = 24;
            this.dgvDSNV.Size = new System.Drawing.Size(1106, 320);
            this.dgvDSNV.TabIndex = 11;
            this.dgvDSNV.SelectionChanged += new System.EventHandler(this.dgvDSNV_SelectionChanged);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colHoNV
            // 
            this.colHoNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoNV.DataPropertyName = "Ho";
            this.colHoNV.HeaderText = "Họ nhân viên";
            this.colHoNV.MinimumWidth = 6;
            this.colHoNV.Name = "colHoNV";
            // 
            // colTenNV
            // 
            this.colTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNV.DataPropertyName = "Ten";
            this.colTenNV.HeaderText = "Tên nhân viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            // 
            // colLuong
            // 
            this.colLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLuong.DataPropertyName = "Luong";
            this.colLuong.HeaderText = "Lương";
            this.colLuong.MinimumWidth = 6;
            this.colLuong.Name = "colLuong";
            this.colLuong.ReadOnly = true;
            this.colLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSĐT
            // 
            this.colSĐT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSĐT.DataPropertyName = "PhoneNumber";
            this.colSĐT.HeaderText = "Số điện thoại";
            this.colSĐT.MinimumWidth = 6;
            this.colSĐT.Name = "colSĐT";
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            // 
            // colPW
            // 
            this.colPW.DataPropertyName = "Password";
            this.colPW.HeaderText = "Mật khẩu";
            this.colPW.MinimumWidth = 6;
            this.colPW.Name = "colPW";
            this.colPW.Width = 125;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.panelQLNV);
            this.Controls.Add(this.panelTieuDe);
            this.Name = "QLNhanVien";
            this.Size = new System.Drawing.Size(1106, 543);
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panelQLNV.ResumeLayout(false);
            this.panelQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQLNV;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Panel panelQLNV;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.PictureBox pictureBoxHA;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.Label lblSĐT;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.Label lblHoNV;
        private System.Windows.Forms.TextBox txtTKNV;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDNV;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSĐT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPW;
    }
}
