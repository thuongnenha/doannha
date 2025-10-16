namespace GUI
{
    partial class QLChamCong
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
            this.lblQLCC = new System.Windows.Forms.Label();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.panelQLCC = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpGioRa = new System.Windows.Forms.DateTimePicker();
            this.dtpGioVao = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.pictureBoxHA = new System.Windows.Forms.PictureBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.txtTongTG = new System.Windows.Forms.TextBox();
            this.lblTongTG = new System.Windows.Forms.Label();
            this.lblTKD = new System.Windows.Forms.Label();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.txtTKCC = new System.Windows.Forms.TextBox();
            this.txtIDCC = new System.Windows.Forms.TextBox();
            this.lblIDCC = new System.Windows.Forms.Label();
            this.dgvDSCC = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNVID = new System.Windows.Forms.TextBox();
            this.panelTieuDe.SuspendLayout();
            this.panelQLCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLCC
            // 
            this.lblQLCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQLCC.AutoSize = true;
            this.lblQLCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLCC.Location = new System.Drawing.Point(427, 0);
            this.lblQLCC.Name = "lblQLCC";
            this.lblQLCC.Size = new System.Drawing.Size(208, 25);
            this.lblQLCC.TabIndex = 0;
            this.lblQLCC.Text = "Quản lý Chấm Công";
            this.lblQLCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.IndianRed;
            this.panelTieuDe.Controls.Add(this.lblQLCC);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1106, 35);
            this.panelTieuDe.TabIndex = 15;
            // 
            // panelQLCC
            // 
            this.panelQLCC.BackColor = System.Drawing.Color.White;
            this.panelQLCC.Controls.Add(this.cmbNVID);
            this.panelQLCC.Controls.Add(this.dtpNgay);
            this.panelQLCC.Controls.Add(this.dtpGioRa);
            this.panelQLCC.Controls.Add(this.dtpGioVao);
            this.panelQLCC.Controls.Add(this.btnXoa);
            this.panelQLCC.Controls.Add(this.btnLamMoi);
            this.panelQLCC.Controls.Add(this.btnSua);
            this.panelQLCC.Controls.Add(this.btnThem);
            this.panelQLCC.Controls.Add(this.btnTK);
            this.panelQLCC.Controls.Add(this.pictureBoxHA);
            this.panelQLCC.Controls.Add(this.chkTrangThai);
            this.panelQLCC.Controls.Add(this.txtTongTG);
            this.panelQLCC.Controls.Add(this.lblTongTG);
            this.panelQLCC.Controls.Add(this.lblTKD);
            this.panelQLCC.Controls.Add(this.lblGioVao);
            this.panelQLCC.Controls.Add(this.lblNgay);
            this.panelQLCC.Controls.Add(this.lblIDNV);
            this.panelQLCC.Controls.Add(this.txtTKCC);
            this.panelQLCC.Controls.Add(this.txtIDCC);
            this.panelQLCC.Controls.Add(this.lblIDCC);
            this.panelQLCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLCC.Location = new System.Drawing.Point(0, 35);
            this.panelQLCC.Name = "panelQLCC";
            this.panelQLCC.Size = new System.Drawing.Size(1106, 179);
            this.panelQLCC.TabIndex = 16;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgay.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(128, 111);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(282, 22);
            this.dtpNgay.TabIndex = 28;
            // 
            // dtpGioRa
            // 
            this.dtpGioRa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGioRa.CustomFormat = "HH:mm:ss";
            this.dtpGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioRa.Location = new System.Drawing.Point(537, 67);
            this.dtpGioRa.Name = "dtpGioRa";
            this.dtpGioRa.Size = new System.Drawing.Size(282, 22);
            this.dtpGioRa.TabIndex = 27;
            this.dtpGioRa.ValueChanged += new System.EventHandler(this.dtpGioRa_ValueChanged);
            // 
            // dtpGioVao
            // 
            this.dtpGioVao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGioVao.CustomFormat = "HH:mm:ss";
            this.dtpGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioVao.Location = new System.Drawing.Point(537, 16);
            this.dtpGioVao.Name = "dtpGioVao";
            this.dtpGioVao.Size = new System.Drawing.Size(282, 22);
            this.dtpGioVao.TabIndex = 27;
            this.dtpGioVao.ValueChanged += new System.EventHandler(this.dtpGioVao_ValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(855, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 38);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = " Xóa";
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
            this.btnTK.Location = new System.Drawing.Point(128, 150);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(93, 25);
            this.btnTK.TabIndex = 19;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
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
            this.chkTrangThai.Location = new System.Drawing.Point(19, 153);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(89, 20);
            this.chkTrangThai.TabIndex = 17;
            this.chkTrangThai.Text = "Trạng thái";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtTongTG
            // 
            this.txtTongTG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTG.Location = new System.Drawing.Point(537, 113);
            this.txtTongTG.Multiline = true;
            this.txtTongTG.Name = "txtTongTG";
            this.txtTongTG.ReadOnly = true;
            this.txtTongTG.Size = new System.Drawing.Size(282, 25);
            this.txtTongTG.TabIndex = 12;
            // 
            // lblTongTG
            // 
            this.lblTongTG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTG.AutoSize = true;
            this.lblTongTG.Location = new System.Drawing.Point(421, 116);
            this.lblTongTG.Name = "lblTongTG";
            this.lblTongTG.Size = new System.Drawing.Size(95, 16);
            this.lblTongTG.TabIndex = 11;
            this.lblTongTG.Text = "Tổng thời gian:";
            // 
            // lblTKD
            // 
            this.lblTKD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTKD.AutoSize = true;
            this.lblTKD.Location = new System.Drawing.Point(440, 70);
            this.lblTKD.Name = "lblTKD";
            this.lblTKD.Size = new System.Drawing.Size(46, 16);
            this.lblTKD.TabIndex = 8;
            this.lblTKD.Text = "Giờ ra:";
            // 
            // lblGioVao
            // 
            this.lblGioVao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Location = new System.Drawing.Point(429, 16);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(82, 16);
            this.lblGioVao.TabIndex = 6;
            this.lblGioVao.Text = "Giờ vào làm:";
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(30, 117);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(68, 16);
            this.lblNgay.TabIndex = 4;
            this.lblNgay.Text = "Ngày làm:";
            // 
            // lblIDNV
            // 
            this.lblIDNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Location = new System.Drawing.Point(48, 70);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(39, 16);
            this.lblIDNV.TabIndex = 2;
            this.lblIDNV.Text = "User:";
            // 
            // txtTKCC
            // 
            this.txtTKCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTKCC.Location = new System.Drawing.Point(227, 151);
            this.txtTKCC.Name = "txtTKCC";
            this.txtTKCC.Size = new System.Drawing.Size(183, 22);
            this.txtTKCC.TabIndex = 1;
            // 
            // txtIDCC
            // 
            this.txtIDCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDCC.Location = new System.Drawing.Point(128, 16);
            this.txtIDCC.Name = "txtIDCC";
            this.txtIDCC.ReadOnly = true;
            this.txtIDCC.Size = new System.Drawing.Size(282, 22);
            this.txtIDCC.TabIndex = 1;
            // 
            // lblIDCC
            // 
            this.lblIDCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDCC.AutoSize = true;
            this.lblIDCC.Location = new System.Drawing.Point(19, 16);
            this.lblIDCC.Name = "lblIDCC";
            this.lblIDCC.Size = new System.Drawing.Size(97, 16);
            this.lblIDCC.TabIndex = 0;
            this.lblIDCC.Text = "ID Chấm công :";
            // 
            // dgvDSCC
            // 
            this.dgvDSCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIDNV,
            this.colNgay,
            this.colGioVao,
            this.colGioRa,
            this.colTongTG});
            this.dgvDSCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCC.Location = new System.Drawing.Point(0, 214);
            this.dgvDSCC.Name = "dgvDSCC";
            this.dgvDSCC.RowHeadersWidth = 51;
            this.dgvDSCC.RowTemplate.Height = 24;
            this.dgvDSCC.Size = new System.Drawing.Size(1106, 329);
            this.dgvDSCC.TabIndex = 17;
            this.dgvDSCC.SelectionChanged += new System.EventHandler(this.dgvDSCC_SelectionChanged_1);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colIDNV
            // 
            this.colIDNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIDNV.DataPropertyName = "UserID";
            this.colIDNV.HeaderText = "UserID";
            this.colIDNV.MinimumWidth = 6;
            this.colIDNV.Name = "colIDNV";
            // 
            // colNgay
            // 
            this.colNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgay.DataPropertyName = "Ngay";
            this.colNgay.HeaderText = "Ngày làm";
            this.colNgay.MinimumWidth = 6;
            this.colNgay.Name = "colNgay";
            this.colNgay.ReadOnly = true;
            this.colNgay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colGioVao
            // 
            this.colGioVao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGioVao.DataPropertyName = "GioVao";
            this.colGioVao.HeaderText = "Giờ vào làm";
            this.colGioVao.MinimumWidth = 6;
            this.colGioVao.Name = "colGioVao";
            // 
            // colGioRa
            // 
            this.colGioRa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGioRa.DataPropertyName = "GioRa";
            this.colGioRa.HeaderText = "Giờ tan làm";
            this.colGioRa.MinimumWidth = 6;
            this.colGioRa.Name = "colGioRa";
            // 
            // colTongTG
            // 
            this.colTongTG.DataPropertyName = "WorkingTime";
            this.colTongTG.HeaderText = "Tổng thời gian";
            this.colTongTG.MinimumWidth = 6;
            this.colTongTG.Name = "colTongTG";
            this.colTongTG.Width = 125;
            // 
            // cmbNVID
            // 
            this.cmbNVID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNVID.Location = new System.Drawing.Point(128, 64);
            this.cmbNVID.Name = "cmbNVID";
            this.cmbNVID.Size = new System.Drawing.Size(282, 22);
            this.cmbNVID.TabIndex = 29;
            // 
            // QLChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSCC);
            this.Controls.Add(this.panelQLCC);
            this.Controls.Add(this.panelTieuDe);
            this.Name = "QLChamCong";
            this.Size = new System.Drawing.Size(1106, 543);
            this.Load += new System.EventHandler(this.QLChamCong_Load);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panelQLCC.ResumeLayout(false);
            this.panelQLCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQLCC;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Panel panelQLCC;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DateTimePicker dtpGioRa;
        private System.Windows.Forms.DateTimePicker dtpGioVao;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.PictureBox pictureBoxHA;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.TextBox txtTongTG;
        private System.Windows.Forms.Label lblTongTG;
        private System.Windows.Forms.Label lblTKD;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblIDNV;
        private System.Windows.Forms.TextBox txtTKCC;
        private System.Windows.Forms.TextBox txtIDCC;
        private System.Windows.Forms.Label lblIDCC;
        private System.Windows.Forms.DataGridView dgvDSCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTG;
        private System.Windows.Forms.TextBox cmbNVID;
    }
}
