namespace GUI
{
    partial class QLLoaiSP
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
            this.lblQLLoaiSP = new System.Windows.Forms.Label();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.panelQLLoaiSP = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.pictureBoxHA = new System.Windows.Forms.PictureBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.txtTKLoaiSP = new System.Windows.Forms.TextBox();
            this.txtIDLoaiSP = new System.Windows.Forms.TextBox();
            this.lblIDLSP = new System.Windows.Forms.Label();
            this.dgvDSLOAISP = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTieuDe.SuspendLayout();
            this.panelQLLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLOAISP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLLoaiSP
            // 
            this.lblQLLoaiSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQLLoaiSP.AutoSize = true;
            this.lblQLLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLLoaiSP.Location = new System.Drawing.Point(414, 0);
            this.lblQLLoaiSP.Name = "lblQLLoaiSP";
            this.lblQLLoaiSP.Size = new System.Drawing.Size(238, 25);
            this.lblQLLoaiSP.TabIndex = 0;
            this.lblQLLoaiSP.Text = "Quản lý Loại Sản phẩm";
            this.lblQLLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.IndianRed;
            this.panelTieuDe.Controls.Add(this.lblQLLoaiSP);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1106, 35);
            this.panelTieuDe.TabIndex = 16;
            // 
            // panelQLLoaiSP
            // 
            this.panelQLLoaiSP.BackColor = System.Drawing.Color.White;
            this.panelQLLoaiSP.Controls.Add(this.btnXoa);
            this.panelQLLoaiSP.Controls.Add(this.btnLamMoi);
            this.panelQLLoaiSP.Controls.Add(this.btnSua);
            this.panelQLLoaiSP.Controls.Add(this.btnThem);
            this.panelQLLoaiSP.Controls.Add(this.btnTK);
            this.panelQLLoaiSP.Controls.Add(this.pictureBoxHA);
            this.panelQLLoaiSP.Controls.Add(this.chkTrangThai);
            this.panelQLLoaiSP.Controls.Add(this.txtTenLoai);
            this.panelQLLoaiSP.Controls.Add(this.lblTenLoai);
            this.panelQLLoaiSP.Controls.Add(this.txtTKLoaiSP);
            this.panelQLLoaiSP.Controls.Add(this.txtIDLoaiSP);
            this.panelQLLoaiSP.Controls.Add(this.lblIDLSP);
            this.panelQLLoaiSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLLoaiSP.Location = new System.Drawing.Point(0, 35);
            this.panelQLLoaiSP.Name = "panelQLLoaiSP";
            this.panelQLLoaiSP.Size = new System.Drawing.Size(1106, 179);
            this.panelQLLoaiSP.TabIndex = 19;
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
            this.btnTK.Location = new System.Drawing.Point(134, 143);
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
            // txtTenLoai
            // 
            this.txtTenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoai.Location = new System.Drawing.Point(134, 74);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(284, 22);
            this.txtTenLoai.TabIndex = 3;
            this.txtTenLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLoai_KeyPress);
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(3, 74);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(121, 16);
            this.lblTenLoai.TabIndex = 2;
            this.lblTenLoai.Text = "Tên loại sản phẩm:";
            // 
            // txtTKLoaiSP
            // 
            this.txtTKLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTKLoaiSP.Location = new System.Drawing.Point(233, 144);
            this.txtTKLoaiSP.Name = "txtTKLoaiSP";
            this.txtTKLoaiSP.Size = new System.Drawing.Size(185, 22);
            this.txtTKLoaiSP.TabIndex = 1;
            // 
            // txtIDLoaiSP
            // 
            this.txtIDLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDLoaiSP.Location = new System.Drawing.Point(134, 16);
            this.txtIDLoaiSP.Name = "txtIDLoaiSP";
            this.txtIDLoaiSP.ReadOnly = true;
            this.txtIDLoaiSP.Size = new System.Drawing.Size(282, 22);
            this.txtIDLoaiSP.TabIndex = 1;
            // 
            // lblIDLSP
            // 
            this.lblIDLSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDLSP.AutoSize = true;
            this.lblIDLSP.Location = new System.Drawing.Point(3, 19);
            this.lblIDLSP.Name = "lblIDLSP";
            this.lblIDLSP.Size = new System.Drawing.Size(114, 16);
            this.lblIDLSP.TabIndex = 0;
            this.lblIDLSP.Text = "ID Loại sản phẩm:";
            // 
            // dgvDSLOAISP
            // 
            this.dgvDSLOAISP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLOAISP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenLoai});
            this.dgvDSLOAISP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLOAISP.Location = new System.Drawing.Point(0, 214);
            this.dgvDSLOAISP.Name = "dgvDSLOAISP";
            this.dgvDSLOAISP.RowHeadersWidth = 51;
            this.dgvDSLOAISP.RowTemplate.Height = 24;
            this.dgvDSLOAISP.Size = new System.Drawing.Size(1106, 329);
            this.dgvDSLOAISP.TabIndex = 20;
            this.dgvDSLOAISP.SelectionChanged += new System.EventHandler(this.dgvDSLOAISP_SelectionChanged);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colTenLoai
            // 
            this.colTenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoai.DataPropertyName = "Name";
            this.colTenLoai.HeaderText = "Tên loại sả phẩm";
            this.colTenLoai.MinimumWidth = 6;
            this.colTenLoai.Name = "colTenLoai";
            // 
            // QLLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSLOAISP);
            this.Controls.Add(this.panelQLLoaiSP);
            this.Controls.Add(this.panelTieuDe);
            this.Name = "QLLoaiSP";
            this.Size = new System.Drawing.Size(1106, 543);
            this.Load += new System.EventHandler(this.QLLoaiSP_Load);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panelQLLoaiSP.ResumeLayout(false);
            this.panelQLLoaiSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLOAISP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQLLoaiSP;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Panel panelQLLoaiSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.PictureBox pictureBoxHA;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.TextBox txtTKLoaiSP;
        private System.Windows.Forms.TextBox txtIDLoaiSP;
        private System.Windows.Forms.Label lblIDLSP;
        private System.Windows.Forms.DataGridView dgvDSLOAISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
    }
}
