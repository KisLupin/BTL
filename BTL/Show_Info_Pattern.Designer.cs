﻿namespace BTL
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_update_info = new System.Windows.Forms.Button();
            this.bt_back_munu_info = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.benh_vienDataSet = new BTL.benh_vienDataSet();
            this.thongtinbenhnhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thong_tin_benh_nhanTableAdapter = new BTL.benh_vienDataSetTableAdapters.thong_tin_benh_nhanTableAdapter();
            this.mSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTheCanCuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benh_vienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinbenhnhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1078, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Bệnh Nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_update_info
            // 
            this.bt_update_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update_info.Location = new System.Drawing.Point(527, 1221);
            this.bt_update_info.Name = "bt_update_info";
            this.bt_update_info.Size = new System.Drawing.Size(475, 106);
            this.bt_update_info.TabIndex = 8;
            this.bt_update_info.Text = "Cập Nhật Thông Tin Bệnh Nhân";
            this.bt_update_info.UseVisualStyleBackColor = true;
            // 
            // bt_back_munu_info
            // 
            this.bt_back_munu_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back_munu_info.Location = new System.Drawing.Point(2302, 1221);
            this.bt_back_munu_info.Name = "bt_back_munu_info";
            this.bt_back_munu_info.Size = new System.Drawing.Size(475, 106);
            this.bt_back_munu_info.TabIndex = 9;
            this.bt_back_munu_info.Text = "Trở Về Menu Thông Tin Bệnh Nhân";
            this.bt_back_munu_info.UseVisualStyleBackColor = true;
            this.bt_back_munu_info.Click += new System.EventHandler(this.click_back);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSBNDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.soTheCanCuocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thongtinbenhnhanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(514, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1920, 831);
            this.dataGridView1.TabIndex = 10;
            // 
            // benh_vienDataSet
            // 
            this.benh_vienDataSet.DataSetName = "benh_vienDataSet";
            this.benh_vienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongtinbenhnhanBindingSource
            // 
            this.thongtinbenhnhanBindingSource.DataMember = "thong_tin_benh_nhan";
            this.thongtinbenhnhanBindingSource.DataSource = this.benh_vienDataSet;
            // 
            // thong_tin_benh_nhanTableAdapter
            // 
            this.thong_tin_benh_nhanTableAdapter.ClearBeforeFill = true;
            // 
            // mSBNDataGridViewTextBoxColumn
            // 
            this.mSBNDataGridViewTextBoxColumn.DataPropertyName = "MSBN";
            this.mSBNDataGridViewTextBoxColumn.HeaderText = "MSBN";
            this.mSBNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mSBNDataGridViewTextBoxColumn.Name = "mSBNDataGridViewTextBoxColumn";
            this.mSBNDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 150;
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            this.tuoiDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 150;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // soTheCanCuocDataGridViewTextBoxColumn
            // 
            this.soTheCanCuocDataGridViewTextBoxColumn.DataPropertyName = "SoTheCanCuoc";
            this.soTheCanCuocDataGridViewTextBoxColumn.HeaderText = "SoTheCanCuoc";
            this.soTheCanCuocDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soTheCanCuocDataGridViewTextBoxColumn.Name = "soTheCanCuocDataGridViewTextBoxColumn";
            this.soTheCanCuocDataGridViewTextBoxColumn.Width = 150;
            // 
            // Show_Info_Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2814, 1452);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_back_munu_info);
            this.Controls.Add(this.bt_update_info);
            this.Controls.Add(this.label1);
            this.Name = "Show_Info_Pattern";
            this.Text = "Show_Info_Pattern";
            this.Load += new System.EventHandler(this.Show_Info_Pattern_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benh_vienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinbenhnhanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_update_info;
        private System.Windows.Forms.Button bt_back_munu_info;
        private System.Windows.Forms.DataGridView dataGridView1;
        private benh_vienDataSet benh_vienDataSet;
        private System.Windows.Forms.BindingSource thongtinbenhnhanBindingSource;
        private benh_vienDataSetTableAdapters.thong_tin_benh_nhanTableAdapter thong_tin_benh_nhanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTheCanCuocDataGridViewTextBoxColumn;
    }
}