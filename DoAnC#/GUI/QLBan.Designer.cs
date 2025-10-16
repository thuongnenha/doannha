namespace GUI
{
    partial class QLBan
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
            this.lblQLBan = new System.Windows.Forms.Label();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.panelQLBan = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.pictureBoxHA = new System.Windows.Forms.PictureBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.txtTKBan = new System.Windows.Forms.TextBox();
            this.txtIDBan = new System.Windows.Forms.TextBox();
            this.lblIDBan = new System.Windows.Forms.Label();
            this.dgvDSBAN = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTieuDe.SuspendLayout();
            this.panelQLBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBAN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLBan
            // 
            this.lblQLBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQLBan.AutoSize = true;
            this.lblQLBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLBan.Location = new System.Drawing.Point(474, 0);
            this.lblQLBan.Name = "lblQLBan";
            this.lblQLBan.Size = new System.Drawing.Size(131, 25);
            this.lblQLBan.TabIndex = 0;
            this.lblQLBan.Text = "Quản lý Bàn";
            this.lblQLBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.IndianRed;
            this.panelTieuDe.Controls.Add(this.lblQLBan);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1106, 35);
            this.panelTieuDe.TabIndex = 13;
            // 
            // panelQLBan
            // 
            this.panelQLBan.BackColor = System.Drawing.Color.White;
            this.panelQLBan.Controls.Add(this.btnXoa);
            this.panelQLBan.Controls.Add(this.btnLamMoi);
            this.panelQLBan.Controls.Add(this.btnSua);
            this.panelQLBan.Controls.Add(this.btnThem);
            this.panelQLBan.Controls.Add(this.btnTK);
            this.panelQLBan.Controls.Add(this.pictureBoxHA);
            this.panelQLBan.Controls.Add(this.chkTrangThai);
            this.panelQLBan.Controls.Add(this.txtTenBan);
            this.panelQLBan.Controls.Add(this.lblTenBan);
            this.panelQLBan.Controls.Add(this.txtTKBan);
            this.panelQLBan.Controls.Add(this.txtIDBan);
            this.panelQLBan.Controls.Add(this.lblIDBan);
            this.panelQLBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLBan.Location = new System.Drawing.Point(0, 35);
            this.panelQLBan.Name = "panelQLBan";
            this.panelQLBan.Size = new System.Drawing.Size(1106, 179);
            this.panelQLBan.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(855, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 38);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(855, 140);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(93, 38);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(855, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 38);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(855, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 38);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(109, 145);
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
            this.pictureBoxHA.Location = new System.Drawing.Point(954, 3);
            this.pictureBoxHA.Name = "pictureBoxHA";
            this.pictureBoxHA.Size = new System.Drawing.Size(149, 182);
            this.pictureBoxHA.TabIndex = 13;
            this.pictureBoxHA.TabStop = false;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrangThai.Location = new System.Drawing.Point(3, 150);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(89, 20);
            this.chkTrangThai.TabIndex = 17;
            this.chkTrangThai.Text = "Trạng thái";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenBan.Location = new System.Drawing.Point(109, 74);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(284, 22);
            this.txtTenBan.TabIndex = 3;
            // 
            // lblTenBan
            // 
            this.lblTenBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(19, 74);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(60, 16);
            this.lblTenBan.TabIndex = 2;
            this.lblTenBan.Text = "Tên bàn:";
            // 
            // txtTKBan
            // 
            this.txtTKBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTKBan.Location = new System.Drawing.Point(208, 148);
            this.txtTKBan.Name = "txtTKBan";
            this.txtTKBan.Size = new System.Drawing.Size(185, 22);
            this.txtTKBan.TabIndex = 1;
            // 
            // txtIDBan
            // 
            this.txtIDBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDBan.Location = new System.Drawing.Point(111, 13);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.ReadOnly = true;
            this.txtIDBan.Size = new System.Drawing.Size(282, 22);
            this.txtIDBan.TabIndex = 1;
            // 
            // lblIDBan
            // 
            this.lblIDBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDBan.AutoSize = true;
            this.lblIDBan.Location = new System.Drawing.Point(19, 16);
            this.lblIDBan.Name = "lblIDBan";
            this.lblIDBan.Size = new System.Drawing.Size(50, 16);
            this.lblIDBan.TabIndex = 0;
            this.lblIDBan.Text = "ID Bàn:";
            // 
            // dgvDSBAN
            // 
            this.dgvDSBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenBan,
            this.colTrangThai});
            this.dgvDSBAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBAN.Location = new System.Drawing.Point(0, 214);
            this.dgvDSBAN.Name = "dgvDSBAN";
            this.dgvDSBAN.RowHeadersWidth = 51;
            this.dgvDSBAN.RowTemplate.Height = 24;
            this.dgvDSBAN.Size = new System.Drawing.Size(1106, 329);
            this.dgvDSBAN.TabIndex = 17;
            this.dgvDSBAN.SelectionChanged += new System.EventHandler(this.dgvDSBAN_SelectionChanged);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colTenBan
            // 
            this.colTenBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenBan.DataPropertyName = "Name";
            this.colTenBan.HeaderText = "Tên bàn";
            this.colTenBan.MinimumWidth = 6;
            this.colTenBan.Name = "colTenBan";
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrangThai.DataPropertyName = "Status";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // QLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSBAN);
            this.Controls.Add(this.panelQLBan);
            this.Controls.Add(this.panelTieuDe);
            this.Name = "QLBan";
            this.Size = new System.Drawing.Size(1106, 543);
            this.Load += new System.EventHandler(this.QLBan_Load);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panelQLBan.ResumeLayout(false);
            this.panelQLBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQLBan;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Panel panelQLBan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.PictureBox pictureBoxHA;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.TextBox txtTKBan;
        private System.Windows.Forms.TextBox txtIDBan;
        private System.Windows.Forms.Label lblIDBan;
        private System.Windows.Forms.DataGridView dgvDSBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
