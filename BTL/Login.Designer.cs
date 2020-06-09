namespace BTL
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
            this.tb1_user = new System.Windows.Forms.TextBox();
            this.tb2_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1_user
            // 
            this.tb1_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb1_user.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb1_user.Location = new System.Drawing.Point(487, 557);
            this.tb1_user.Name = "tb1_user";
            this.tb1_user.Size = new System.Drawing.Size(1104, 26);
            this.tb1_user.TabIndex = 0;
            this.tb1_user.Text = "Tên Đăng Nhập";
            this.tb1_user.UseWaitCursor = true;
            this.tb1_user.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.tb1_user.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // tb2_pass
            // 
            this.tb2_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb2_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb2_pass.Location = new System.Drawing.Point(487, 766);
            this.tb2_pass.Name = "tb2_pass";
            this.tb2_pass.Size = new System.Drawing.Size(1104, 26);
            this.tb2_pass.TabIndex = 1;
            this.tb2_pass.Text = "Mật Khẩu";
            this.tb2_pass.UseWaitCursor = true;
            this.tb2_pass.MouseEnter += new System.EventHandler(this.mouse_enter_pas);
            this.tb2_pass.MouseLeave += new System.EventHandler(this.mouse_leave_pas);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 219);
            this.label1.MinimumSize = new System.Drawing.Size(128, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bệnh Viện Đa Khoa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt1
            // 
            this.bt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(621, 958);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(903, 109);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "Đăng Nhập";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.UseWaitCursor = true;
            this.bt1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_login);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2098, 1396);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb1_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2_pass);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Benh Vien Da Khoa";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1_user;
        private System.Windows.Forms.TextBox tb2_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt1;
    }
}

