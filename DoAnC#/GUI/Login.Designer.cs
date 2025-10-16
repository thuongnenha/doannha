namespace GUI
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLogin_MK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin_DN = new System.Windows.Forms.Button();
            this.txtLogin_TK = new System.Windows.Forms.TextBox();
            this.lblLogin_tbTK = new System.Windows.Forms.Label();
            this.lblLogin_tbMK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.okhoa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(579, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 283);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtLogin_MK
            // 
            this.txtLogin_MK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin_MK.Location = new System.Drawing.Point(219, 205);
            this.txtLogin_MK.Name = "txtLogin_MK";
            this.txtLogin_MK.PasswordChar = '*';
            this.txtLogin_MK.Size = new System.Drawing.Size(268, 22);
            this.txtLogin_MK.TabIndex = 1;
            this.txtLogin_MK.TextChanged += new System.EventHandler(this.txtLogin_MK_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tài khoản :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu :";
            // 
            // btnLogin_DN
            // 
            this.btnLogin_DN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin_DN.Location = new System.Drawing.Point(249, 266);
            this.btnLogin_DN.Name = "btnLogin_DN";
            this.btnLogin_DN.Size = new System.Drawing.Size(158, 40);
            this.btnLogin_DN.TabIndex = 2;
            this.btnLogin_DN.Text = "Đăng nhập";
            this.btnLogin_DN.UseVisualStyleBackColor = true;
            this.btnLogin_DN.Click += new System.EventHandler(this.btnLogin_DN_Click);
            // 
            // txtLogin_TK
            // 
            this.txtLogin_TK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin_TK.Location = new System.Drawing.Point(219, 133);
            this.txtLogin_TK.Name = "txtLogin_TK";
            this.txtLogin_TK.Size = new System.Drawing.Size(268, 22);
            this.txtLogin_TK.TabIndex = 0;
            this.txtLogin_TK.TextChanged += new System.EventHandler(this.txtLogin_TK_TextChanged);
            // 
            // lblLogin_tbTK
            // 
            this.lblLogin_tbTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin_tbTK.AutoSize = true;
            this.lblLogin_tbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_tbTK.ForeColor = System.Drawing.Color.Red;
            this.lblLogin_tbTK.Location = new System.Drawing.Point(216, 108);
            this.lblLogin_tbTK.Name = "lblLogin_tbTK";
            this.lblLogin_tbTK.Size = new System.Drawing.Size(0, 13);
            this.lblLogin_tbTK.TabIndex = 18;
            // 
            // lblLogin_tbMK
            // 
            this.lblLogin_tbMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin_tbMK.AutoSize = true;
            this.lblLogin_tbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_tbMK.ForeColor = System.Drawing.Color.Red;
            this.lblLogin_tbMK.Location = new System.Drawing.Point(216, 180);
            this.lblLogin_tbMK.Name = "lblLogin_tbMK";
            this.lblLogin_tbMK.Size = new System.Drawing.Size(0, 13);
            this.lblLogin_tbMK.TabIndex = 19;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.anhDN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 449);
            this.Controls.Add(this.lblLogin_tbMK);
            this.Controls.Add(this.lblLogin_tbTK);
            this.Controls.Add(this.txtLogin_MK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin_DN);
            this.Controls.Add(this.txtLogin_TK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLogin_MK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin_DN;
        private System.Windows.Forms.TextBox txtLogin_TK;
        private System.Windows.Forms.Label lblLogin_tbTK;
        private System.Windows.Forms.Label lblLogin_tbMK;
    }
}