namespace BTL
{
    partial class Option
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_tt_bn = new System.Windows.Forms.Button();
            this.bt_phieu_kham = new System.Windows.Forms.Button();
            this.bt_hoa_don = new System.Windows.Forms.Button();
            this.bt_kham_chua = new System.Windows.Forms.Button();
            this.bt_phong_khoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1115, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bệnh Viện Đa Khoa";
            // 
            // bt_tt_bn
            // 
            this.bt_tt_bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tt_bn.Location = new System.Drawing.Point(1039, 304);
            this.bt_tt_bn.Name = "bt_tt_bn";
            this.bt_tt_bn.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.bt_tt_bn.Size = new System.Drawing.Size(738, 99);
            this.bt_tt_bn.TabIndex = 1;
            this.bt_tt_bn.Text = "1.Thông Tin Bệnh Nhân";
            this.bt_tt_bn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_tt_bn.UseVisualStyleBackColor = true;
            this.bt_tt_bn.Click += new System.EventHandler(this.bt_ttbn);
            // 
            // bt_phieu_kham
            // 
            this.bt_phieu_kham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_phieu_kham.Location = new System.Drawing.Point(1039, 468);
            this.bt_phieu_kham.Name = "bt_phieu_kham";
            this.bt_phieu_kham.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.bt_phieu_kham.Size = new System.Drawing.Size(738, 99);
            this.bt_phieu_kham.TabIndex = 2;
            this.bt_phieu_kham.Text = "2. Lập Phiếu Khám Bệnh";
            this.bt_phieu_kham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_phieu_kham.UseVisualStyleBackColor = true;
            this.bt_phieu_kham.Click += new System.EventHandler(this.bt_lpk);
            // 
            // bt_hoa_don
            // 
            this.bt_hoa_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hoa_don.Location = new System.Drawing.Point(1039, 622);
            this.bt_hoa_don.Name = "bt_hoa_don";
            this.bt_hoa_don.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.bt_hoa_don.Size = new System.Drawing.Size(738, 99);
            this.bt_hoa_don.TabIndex = 6;
            this.bt_hoa_don.Text = "3. In Hóa Đơn";
            this.bt_hoa_don.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_hoa_don.UseVisualStyleBackColor = true;
            this.bt_hoa_don.Click += new System.EventHandler(this.bt_hd);
            // 
            // bt_kham_chua
            // 
            this.bt_kham_chua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_kham_chua.Location = new System.Drawing.Point(1039, 792);
            this.bt_kham_chua.Name = "bt_kham_chua";
            this.bt_kham_chua.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.bt_kham_chua.Size = new System.Drawing.Size(738, 99);
            this.bt_kham_chua.TabIndex = 7;
            this.bt_kham_chua.Text = "4. Quản Lí Dịch Vụ Khám Chữa";
            this.bt_kham_chua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_kham_chua.UseVisualStyleBackColor = true;
            this.bt_kham_chua.Click += new System.EventHandler(this.bt_dv);
            // 
            // bt_phong_khoa
            // 
            this.bt_phong_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_phong_khoa.Location = new System.Drawing.Point(1039, 957);
            this.bt_phong_khoa.Name = "bt_phong_khoa";
            this.bt_phong_khoa.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.bt_phong_khoa.Size = new System.Drawing.Size(738, 99);
            this.bt_phong_khoa.TabIndex = 8;
            this.bt_phong_khoa.Text = "5. Quản Lí Danh Sách Phòng Khoa";
            this.bt_phong_khoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_phong_khoa.UseVisualStyleBackColor = true;
            this.bt_phong_khoa.Click += new System.EventHandler(this.bt_qldspk);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2762, 1467);
            this.Controls.Add(this.bt_phong_khoa);
            this.Controls.Add(this.bt_kham_chua);
            this.Controls.Add(this.bt_hoa_don);
            this.Controls.Add(this.bt_phieu_kham);
            this.Controls.Add(this.bt_tt_bn);
            this.Controls.Add(this.label1);
            this.Name = "Option";
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_tt_bn;
        private System.Windows.Forms.Button bt_phieu_kham;
        private System.Windows.Forms.Button bt_hoa_don;
        private System.Windows.Forms.Button bt_kham_chua;
        private System.Windows.Forms.Button bt_phong_khoa;
    }
}