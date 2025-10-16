namespace GUI
{
    partial class QLProducts
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.pictureBoxHA = new System.Windows.Forms.PictureBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTKSP = new System.Windows.Forms.TextBox();
            this.txtIDSP = new System.Windows.Forms.TextBox();
            this.lblIDSP = new System.Windows.Forms.Label();
            this.panelQLSP = new System.Windows.Forms.Panel();
            this.lblGiaSP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQLSP = new System.Windows.Forms.Label();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).BeginInit();
            this.panelQLSP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(128, 157);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(93, 25);
            this.btnTK.TabIndex = 19;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(517, 14);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(282, 24);
            this.cmbLoaiSP.TabIndex = 18;
            // 
            // pictureBoxHA
            // 
            this.pictureBoxHA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHA.Image = global::GUI.Properties.Resources.admin;
            this.pictureBoxHA.Location = new System.Drawing.Point(954, 6);
            this.pictureBoxHA.Name = "pictureBoxHA";
            this.pictureBoxHA.Size = new System.Drawing.Size(149, 179);
            this.pictureBoxHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHA.TabIndex = 13;
            this.pictureBoxHA.TabStop = false;
            this.pictureBoxHA.Click += new System.EventHandler(this.pictureBoxHA_Click);
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
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.Location = new System.Drawing.Point(517, 116);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(282, 66);
            this.txtMoTa.TabIndex = 12;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(441, 119);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(46, 16);
            this.lblMoTa.TabIndex = 11;
            this.lblMoTa.Text = "Mô tả :";
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhuyenMai.Location = new System.Drawing.Point(517, 67);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(282, 22);
            this.txtKhuyenMai.TabIndex = 9;
            this.txtKhuyenMai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhuyenMai_KeyPress);
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.Location = new System.Drawing.Point(429, 67);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(82, 16);
            this.lblKhuyenMai.TabIndex = 8;
            this.lblKhuyenMai.Text = "Khuyến mãi :";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location = new System.Drawing.Point(448, 16);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(39, 16);
            this.lblLoaiSP.TabIndex = 6;
            this.lblLoaiSP.Text = "Loại :";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaSP.Location = new System.Drawing.Point(128, 119);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(282, 22);
            this.txtGiaSP.TabIndex = 5;
            this.txtGiaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSP_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSP.Location = new System.Drawing.Point(128, 67);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(282, 22);
            this.txtTenSP.TabIndex = 3;
            this.txtTenSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSP_KeyPress);
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(19, 67);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(99, 16);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên sản phẩm :";
            // 
            // txtTKSP
            // 
            this.txtTKSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTKSP.Location = new System.Drawing.Point(237, 158);
            this.txtTKSP.Name = "txtTKSP";
            this.txtTKSP.Size = new System.Drawing.Size(173, 22);
            this.txtTKSP.TabIndex = 1;
            // 
            // txtIDSP
            // 
            this.txtIDSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDSP.Location = new System.Drawing.Point(128, 16);
            this.txtIDSP.Name = "txtIDSP";
            this.txtIDSP.ReadOnly = true;
            this.txtIDSP.Size = new System.Drawing.Size(282, 22);
            this.txtIDSP.TabIndex = 1;
            // 
            // lblIDSP
            // 
            this.lblIDSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDSP.AutoSize = true;
            this.lblIDSP.Location = new System.Drawing.Point(19, 16);
            this.lblIDSP.Name = "lblIDSP";
            this.lblIDSP.Size = new System.Drawing.Size(88, 16);
            this.lblIDSP.TabIndex = 0;
            this.lblIDSP.Text = "ID sản phẩm :";
            // 
            // panelQLSP
            // 
            this.panelQLSP.Controls.Add(this.btnTK);
            this.panelQLSP.Controls.Add(this.cmbLoaiSP);
            this.panelQLSP.Controls.Add(this.pictureBoxHA);
            this.panelQLSP.Controls.Add(this.chkTrangThai);
            this.panelQLSP.Controls.Add(this.btnXoa);
            this.panelQLSP.Controls.Add(this.btnLamMoi);
            this.panelQLSP.Controls.Add(this.btnSua);
            this.panelQLSP.Controls.Add(this.btnThem);
            this.panelQLSP.Controls.Add(this.txtMoTa);
            this.panelQLSP.Controls.Add(this.lblMoTa);
            this.panelQLSP.Controls.Add(this.txtKhuyenMai);
            this.panelQLSP.Controls.Add(this.lblKhuyenMai);
            this.panelQLSP.Controls.Add(this.lblLoaiSP);
            this.panelQLSP.Controls.Add(this.txtGiaSP);
            this.panelQLSP.Controls.Add(this.lblGiaSP);
            this.panelQLSP.Controls.Add(this.txtTenSP);
            this.panelQLSP.Controls.Add(this.lblTenSP);
            this.panelQLSP.Controls.Add(this.txtTKSP);
            this.panelQLSP.Controls.Add(this.txtIDSP);
            this.panelQLSP.Controls.Add(this.lblIDSP);
            this.panelQLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLSP.Location = new System.Drawing.Point(0, 0);
            this.panelQLSP.Name = "panelQLSP";
            this.panelQLSP.Size = new System.Drawing.Size(1106, 188);
            this.panelQLSP.TabIndex = 4;
            // 
            // lblGiaSP
            // 
            this.lblGiaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiaSP.AutoSize = true;
            this.lblGiaSP.Location = new System.Drawing.Point(19, 119);
            this.lblGiaSP.Name = "lblGiaSP";
            this.lblGiaSP.Size = new System.Drawing.Size(34, 16);
            this.lblGiaSP.TabIndex = 4;
            this.lblGiaSP.Text = "Giá :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelQLSP);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 188);
            this.panel1.TabIndex = 5;
            // 
            // lblQLSP
            // 
            this.lblQLSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQLSP.AutoSize = true;
            this.lblQLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSP.Location = new System.Drawing.Point(446, 0);
            this.lblQLSP.Name = "lblQLSP";
            this.lblQLSP.Size = new System.Drawing.Size(187, 25);
            this.lblQLSP.TabIndex = 0;
            this.lblQLSP.Text = "Quản lý sản phẩm";
            this.lblQLSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.IndianRed;
            this.panelTieuDe.Controls.Add(this.lblQLSP);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1106, 35);
            this.panelTieuDe.TabIndex = 6;
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenSP,
            this.colGia,
            this.colLoaiSP,
            this.colMoTa,
            this.colKuyenMai,
            this.colTrangThai,
            this.colIF});
            this.dgvDSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSP.Location = new System.Drawing.Point(0, 223);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersWidth = 51;
            this.dgvDSSP.RowTemplate.Height = 24;
            this.dgvDSSP.Size = new System.Drawing.Size(1106, 320);
            this.dgvDSSP.TabIndex = 7;
            this.dgvDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellContentClick);
            this.dgvDSSP.SelectionChanged += new System.EventHandler(this.dgvDSSP_SelectionChanged_1);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "Name";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            // 
            // colGia
            // 
            this.colGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGia.DataPropertyName = "Gia";
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLoaiSP.DataPropertyName = "CategoryID";
            this.colLoaiSP.HeaderText = "Loại sản phẩm";
            this.colLoaiSP.MinimumWidth = 6;
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.ReadOnly = true;
            this.colLoaiSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMoTa
            // 
            this.colMoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            // 
            // colKuyenMai
            // 
            this.colKuyenMai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKuyenMai.DataPropertyName = "KhuyenMai";
            this.colKuyenMai.HeaderText = "Khuến Mãi";
            this.colKuyenMai.MinimumWidth = 6;
            this.colKuyenMai.Name = "colKuyenMai";
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colIF
            // 
            this.colIF.DataPropertyName = "ImageFood";
            this.colIF.HeaderText = "Hình ảnh";
            this.colIF.MinimumWidth = 6;
            this.colIF.Name = "colIF";
            this.colIF.Width = 125;
            // 
            // QLProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSSP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTieuDe);
            this.Name = "QLProducts";
            this.Size = new System.Drawing.Size(1106, 543);
            this.Load += new System.EventHandler(this.QLProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).EndInit();
            this.panelQLSP.ResumeLayout(false);
            this.panelQLSP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.PictureBox pictureBoxHA;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTKSP;
        private System.Windows.Forms.TextBox txtIDSP;
        private System.Windows.Forms.Label lblIDSP;
        private System.Windows.Forms.Panel panelQLSP;
        private System.Windows.Forms.Label lblGiaSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQLSP;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIF;
    }
}
