namespace BTL
{
    partial class search_add_pattern
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
            this.bt_find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_back_main = new System.Windows.Forms.Button();
            this.bt_show_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_find
            // 
            this.bt_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_find.Location = new System.Drawing.Point(1145, 547);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(675, 74);
            this.bt_find.TabIndex = 1;
            this.bt_find.Text = "Tìm Kiếm";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.search_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(848, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1308, 147);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin Bệnh Nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cmnd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_cmnd.Location = new System.Drawing.Point(1145, 396);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(675, 35);
            this.tb_cmnd.TabIndex = 3;
            this.tb_cmnd.Text = "Tìm Kiếm Bệnh Nhân Theo CMND";
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(1145, 814);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(675, 74);
            this.bt_add.TabIndex = 4;
            this.bt_add.Text = "Thêm Bệnh Nhân Mới";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.add);
            // 
            // bt_back_main
            // 
            this.bt_back_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back_main.Location = new System.Drawing.Point(2300, 1251);
            this.bt_back_main.Name = "bt_back_main";
            this.bt_back_main.Size = new System.Drawing.Size(346, 100);
            this.bt_back_main.TabIndex = 5;
            this.bt_back_main.Text = "Trở Lại Trung Tâm Lựa Chọn";
            this.bt_back_main.UseVisualStyleBackColor = true;
            this.bt_back_main.Click += new System.EventHandler(this.back);
            // 
            // bt_show_all
            // 
            this.bt_show_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show_all.Location = new System.Drawing.Point(1145, 1061);
            this.bt_show_all.Name = "bt_show_all";
            this.bt_show_all.Size = new System.Drawing.Size(675, 74);
            this.bt_show_all.TabIndex = 6;
            this.bt_show_all.Text = "Hien Thi Tat Ca Benh Nhan";
            this.bt_show_all.UseVisualStyleBackColor = true;
            this.bt_show_all.Click += new System.EventHandler(this.show_all);
            // 
            // search_add_pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2799, 1469);
            this.Controls.Add(this.bt_show_all);
            this.Controls.Add(this.bt_back_main);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_cmnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_find);
            this.Name = "search_add_pattern";
            this.Text = "search_add_pattern";
            this.Load += new System.EventHandler(this.search_add_pattern_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cmnd;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_back_main;
        private System.Windows.Forms.Button bt_show_all;
    }
}