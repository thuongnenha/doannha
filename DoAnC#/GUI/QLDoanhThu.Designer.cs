namespace GUI
{
    partial class QLDoanhThu
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
            this.btnSPUTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNVBNN = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSPUTN
            // 
            this.btnSPUTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSPUTN.Location = new System.Drawing.Point(243, 21);
            this.btnSPUTN.Name = "btnSPUTN";
            this.btnSPUTN.Size = new System.Drawing.Size(200, 52);
            this.btnSPUTN.TabIndex = 0;
            this.btnSPUTN.Text = "Sản phẩm ưu thích nhất";
            this.btnSPUTN.UseVisualStyleBackColor = true;
            this.btnSPUTN.Click += new System.EventHandler(this.btnSPUTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 78);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(612, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNVBNN
            // 
            this.btnNVBNN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNVBNN.Location = new System.Drawing.Point(603, 21);
            this.btnNVBNN.Name = "btnNVBNN";
            this.btnNVBNN.Size = new System.Drawing.Size(200, 52);
            this.btnNVBNN.TabIndex = 1;
            this.btnNVBNN.Text = "Nhân viên bán nhiều nhất";
            this.btnNVBNN.UseVisualStyleBackColor = true;
            this.btnNVBNN.Click += new System.EventHandler(this.btnNVBNN_Click);
            // 
            // btnDT
            // 
            this.btnDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDT.Location = new System.Drawing.Point(983, 21);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(200, 52);
            this.btnDT.TabIndex = 2;
            this.btnDT.Text = "Doanh thu";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnSPUTN);
            this.panel2.Controls.Add(this.btnDT);
            this.panel2.Controls.Add(this.btnNVBNN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1458, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvShow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1458, 451);
            this.panel3.TabIndex = 3;
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.Size = new System.Drawing.Size(1458, 451);
            this.dgvShow.TabIndex = 0;
            // 
            // QLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLDoanhThu";
            this.Size = new System.Drawing.Size(1458, 629);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSPUTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Button btnNVBNN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvShow;
    }
}
