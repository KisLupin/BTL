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
            this.tb1_login = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1_login
            // 
            this.tb1_login.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb1_login.Location = new System.Drawing.Point(487, 556);
            this.tb1_login.Name = "tb1_login";
            this.tb1_login.Size = new System.Drawing.Size(514, 26);
            this.tb1_login.TabIndex = 0;
            this.tb1_login.Text = "Tên Đăng Nhập";
            this.tb1_login.UseWaitCursor = true;
            this.tb1_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb2.Location = new System.Drawing.Point(487, 698);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(514, 26);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Mật Khẩu";
            this.tb2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 160);
            this.label1.MinimumSize = new System.Drawing.Size(128, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 129);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bệnh Viện Đa Khoa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(585, 842);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(313, 81);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "Đăng Nhập";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 1262);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb1_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Name = "Form1";
            this.Text = "Benh Vien Da Khoa";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1_login;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt1;
    }
}

