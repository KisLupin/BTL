namespace BTL
{
    partial class ShowAll
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
            this.benhvienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benh_vienDataSet = new BTL.benh_vienDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.mSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTheCanCuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongtinbenhnhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benh_vienDataSet1 = new BTL.benh_vienDataSet1();
            this.thong_tin_benh_nhanTableAdapter = new BTL.benh_vienDataSet1TableAdapters.thong_tin_benh_nhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.benhvienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benh_vienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinbenhnhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benh_vienDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // benhvienDataSetBindingSource
            // 
            this.benhvienDataSetBindingSource.DataSource = this.benh_vienDataSet;
            this.benhvienDataSetBindingSource.Position = 0;
            // 
            // benh_vienDataSet
            // 
            this.benh_vienDataSet.DataSetName = "benh_vienDataSet";
            this.benh_vienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 1142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(475, 156);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sap xep theo ten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sort);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1503, 1142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(475, 156);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.back);
            // 
            // data
            // 
            this.data.AutoGenerateColumns = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSBNDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.soTheCanCuocDataGridViewTextBoxColumn});
            this.data.DataSource = this.thongtinbenhnhanBindingSource;
            this.data.Location = new System.Drawing.Point(113, 60);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 62;
            this.data.RowTemplate.Height = 28;
            this.data.Size = new System.Drawing.Size(1865, 924);
            this.data.StandardTab = true;
            this.data.TabIndex = 3;
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
            // thongtinbenhnhanBindingSource
            // 
            this.thongtinbenhnhanBindingSource.DataMember = "thong_tin_benh_nhan";
            this.thongtinbenhnhanBindingSource.DataSource = this.benh_vienDataSet1;
            // 
            // benh_vienDataSet1
            // 
            this.benh_vienDataSet1.DataSetName = "benh_vienDataSet1";
            this.benh_vienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thong_tin_benh_nhanTableAdapter
            // 
            this.thong_tin_benh_nhanTableAdapter.ClearBeforeFill = true;
            // 
            // ShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2558, 1438);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ShowAll";
            this.Text = "ShowAll";
            this.Load += new System.EventHandler(this.ShowAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.benhvienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benh_vienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinbenhnhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benh_vienDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource benhvienDataSetBindingSource;
        private benh_vienDataSet benh_vienDataSet;
        private System.Windows.Forms.DataGridView data;
        private benh_vienDataSet1 benh_vienDataSet1;
        private System.Windows.Forms.BindingSource thongtinbenhnhanBindingSource;
        private benh_vienDataSet1TableAdapters.thong_tin_benh_nhanTableAdapter thong_tin_benh_nhanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTheCanCuocDataGridViewTextBoxColumn;
    }
}