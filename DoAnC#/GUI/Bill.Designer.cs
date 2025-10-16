namespace GUI
{
    partial class Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTienKhachDua_B = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSum_B = new System.Windows.Forms.TextBox();
            this.btnXacNhan_B = new System.Windows.Forms.Button();
            this.btnQuayLai_B = new System.Windows.Forms.Button();
            this.txtTienKhachDua_B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBill_B = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKM_bill = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill_B)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Thanh Toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtKM_bill);
            this.panel2.Controls.Add(this.lblTienKhachDua_B);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSum_B);
            this.panel2.Controls.Add(this.btnXacNhan_B);
            this.panel2.Controls.Add(this.btnQuayLai_B);
            this.panel2.Controls.Add(this.txtTienKhachDua_B);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1440, 81);
            this.panel2.TabIndex = 2;
            // 
            // lblTienKhachDua_B
            // 
            this.lblTienKhachDua_B.AutoSize = true;
            this.lblTienKhachDua_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienKhachDua_B.ForeColor = System.Drawing.Color.Red;
            this.lblTienKhachDua_B.Location = new System.Drawing.Point(186, 9);
            this.lblTienKhachDua_B.Name = "lblTienKhachDua_B";
            this.lblTienKhachDua_B.Size = new System.Drawing.Size(34, 13);
            this.lblTienKhachDua_B.TabIndex = 7;
            this.lblTienKhachDua_B.Text = "hello";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng tiền phải trả:";
            // 
            // txtSum_B
            // 
            this.txtSum_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum_B.Location = new System.Drawing.Point(810, 54);
            this.txtSum_B.Name = "txtSum_B";
            this.txtSum_B.ReadOnly = true;
            this.txtSum_B.Size = new System.Drawing.Size(278, 22);
            this.txtSum_B.TabIndex = 5;
            // 
            // btnXacNhan_B
            // 
            this.btnXacNhan_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan_B.Location = new System.Drawing.Point(1094, 13);
            this.btnXacNhan_B.Name = "btnXacNhan_B";
            this.btnXacNhan_B.Size = new System.Drawing.Size(164, 57);
            this.btnXacNhan_B.TabIndex = 4;
            this.btnXacNhan_B.Text = "Xác nhận thanh toán ";
            this.btnXacNhan_B.UseVisualStyleBackColor = true;
            this.btnXacNhan_B.Click += new System.EventHandler(this.btnXacNhan_B_Click);
            // 
            // btnQuayLai_B
            // 
            this.btnQuayLai_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai_B.Location = new System.Drawing.Point(1264, 13);
            this.btnQuayLai_B.Name = "btnQuayLai_B";
            this.btnQuayLai_B.Size = new System.Drawing.Size(164, 57);
            this.btnQuayLai_B.TabIndex = 3;
            this.btnQuayLai_B.Text = "Quay lại";
            this.btnQuayLai_B.UseVisualStyleBackColor = true;
            this.btnQuayLai_B.Click += new System.EventHandler(this.btnQuayLai_B_Click);
            // 
            // txtTienKhachDua_B
            // 
            this.txtTienKhachDua_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienKhachDua_B.Location = new System.Drawing.Point(189, 28);
            this.txtTienKhachDua_B.Name = "txtTienKhachDua_B";
            this.txtTienKhachDua_B.Size = new System.Drawing.Size(380, 22);
            this.txtTienKhachDua_B.TabIndex = 1;
            this.txtTienKhachDua_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhachDua_B_KeyPress);
            this.txtTienKhachDua_B.Leave += new System.EventHandler(this.txtTienKhachDua_B_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền khách đưa:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvBill_B);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1440, 452);
            this.panel3.TabIndex = 3;
            // 
            // dgvBill_B
            // 
            this.dgvBill_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill_B.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.dgvBill_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill_B.Location = new System.Drawing.Point(0, 0);
            this.dgvBill_B.Name = "dgvBill_B";
            this.dgvBill_B.RowHeadersWidth = 51;
            this.dgvBill_B.RowTemplate.Height = 24;
            this.dgvBill_B.Size = new System.Drawing.Size(1440, 452);
            this.dgvBill_B.TabIndex = 0;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng ";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Khuyến Mãi:";
            // 
            // txtKM_bill
            // 
            this.txtKM_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKM_bill.Location = new System.Drawing.Point(810, 7);
            this.txtKM_bill.Name = "txtKM_bill";
            this.txtKM_bill.ReadOnly = true;
            this.txtKM_bill.Size = new System.Drawing.Size(278, 22);
            this.txtKM_bill.TabIndex = 8;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 582);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill_B)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBill_B;
        private System.Windows.Forms.TextBox txtTienKhachDua_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuayLai_B;
        private System.Windows.Forms.Button btnXacNhan_B;
        private System.Windows.Forms.TextBox txtSum_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lblTienKhachDua_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKM_bill;
    }
}