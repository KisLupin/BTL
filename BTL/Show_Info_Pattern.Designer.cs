namespace BTL
{
    partial class Show_Info_Pattern
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
            this.tb_ht = new System.Windows.Forms.TextBox();
            this.tb_cmt = new System.Windows.Forms.TextBox();
            this.tb_sex = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tx_msbn = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.bt_update_info = new System.Windows.Forms.Button();
            this.bt_back_munu_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Bệnh Nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ht
            // 
            this.tb_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ht.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_ht.Location = new System.Drawing.Point(128, 237);
            this.tb_ht.Name = "tb_ht";
            this.tb_ht.Size = new System.Drawing.Size(452, 35);
            this.tb_ht.TabIndex = 1;
            this.tb_ht.Text = "Họ Tên Bệnh Nhân";
            this.tb_ht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cmt
            // 
            this.tb_cmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cmt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_cmt.Location = new System.Drawing.Point(128, 386);
            this.tb_cmt.Name = "tb_cmt";
            this.tb_cmt.Size = new System.Drawing.Size(452, 35);
            this.tb_cmt.TabIndex = 2;
            this.tb_cmt.Text = "Số CMND/Thẻ Căn Cước";
            this.tb_cmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_sex
            // 
            this.tb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sex.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_sex.Location = new System.Drawing.Point(1228, 237);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(183, 35);
            this.tb_sex.TabIndex = 3;
            this.tb_sex.Text = "Giới Tính";
            this.tb_sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_age
            // 
            this.tb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_age.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_age.Location = new System.Drawing.Point(765, 237);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(281, 35);
            this.tb_age.TabIndex = 4;
            this.tb_age.Text = "Ngày Tháng Năm Sinh";
            this.tb_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tx_msbn
            // 
            this.tx_msbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_msbn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tx_msbn.Location = new System.Drawing.Point(959, 386);
            this.tx_msbn.Name = "tx_msbn";
            this.tx_msbn.Size = new System.Drawing.Size(452, 35);
            this.tx_msbn.TabIndex = 5;
            this.tx_msbn.Text = "Mã Số Bệnh Nhân ";
            this.tx_msbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tx_msbn.TextChanged += new System.EventHandler(this.tx_msbn_TextChanged);
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_address.Location = new System.Drawing.Point(128, 624);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(778, 157);
            this.tb_address.TabIndex = 6;
            this.tb_address.Text = "Địa Chỉ";
            this.tb_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_address.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tb_num
            // 
            this.tb_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_num.Location = new System.Drawing.Point(959, 624);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(452, 35);
            this.tb_num.TabIndex = 7;
            this.tb_num.Text = "Số Điện Thoại";
            this.tb_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_update_info
            // 
            this.bt_update_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update_info.Location = new System.Drawing.Point(128, 1124);
            this.bt_update_info.Name = "bt_update_info";
            this.bt_update_info.Size = new System.Drawing.Size(475, 106);
            this.bt_update_info.TabIndex = 8;
            this.bt_update_info.Text = "Cập Nhật Thông Tin Bệnh Nhân";
            this.bt_update_info.UseVisualStyleBackColor = true;
            // 
            // bt_back_munu_info
            // 
            this.bt_back_munu_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back_munu_info.Location = new System.Drawing.Point(936, 1124);
            this.bt_back_munu_info.Name = "bt_back_munu_info";
            this.bt_back_munu_info.Size = new System.Drawing.Size(475, 106);
            this.bt_back_munu_info.TabIndex = 9;
            this.bt_back_munu_info.Text = "Trở Về Menu Thông Tin Bệnh Nhân";
            this.bt_back_munu_info.UseVisualStyleBackColor = true;
            this.bt_back_munu_info.Click += new System.EventHandler(this.button2_Click);
            // 
            // Show_Info_Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 1335);
            this.Controls.Add(this.bt_back_munu_info);
            this.Controls.Add(this.bt_update_info);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tx_msbn);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.tb_cmt);
            this.Controls.Add(this.tb_ht);
            this.Controls.Add(this.label1);
            this.Name = "Show_Info_Pattern";
            this.Text = "Show_Info_Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ht;
        private System.Windows.Forms.TextBox tb_cmt;
        private System.Windows.Forms.TextBox tb_sex;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tx_msbn;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Button bt_update_info;
        private System.Windows.Forms.Button bt_back_munu_info;
    }
}