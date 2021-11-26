namespace CuahangNongduoc
{
    partial class frmThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpThongtin = new System.Windows.Forms.GroupBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.numTongTien = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolIn = new System.Windows.Forms.ToolStripButton();
            this.toolTimKiem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.grpThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 121);
            this.panel1.TabIndex = 0;
            // 
            // grpThongtin
            // 
            this.grpThongtin.Controls.Add(this.txtMaPhieu);
            this.grpThongtin.Controls.Add(this.label4);
            this.grpThongtin.Controls.Add(this.txtGhiChu);
            this.grpThongtin.Controls.Add(this.label2);
            this.grpThongtin.Controls.Add(this.label5);
            this.grpThongtin.Controls.Add(this.dtNgayThanhToan);
            this.grpThongtin.Controls.Add(this.numTongTien);
            this.grpThongtin.Controls.Add(this.label3);
            this.grpThongtin.Controls.Add(this.label1);
            this.grpThongtin.Controls.Add(this.cmbKhachHang);
            this.grpThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongtin.Location = new System.Drawing.Point(0, 0);
            this.grpThongtin.Name = "grpThongtin";
            this.grpThongtin.Size = new System.Drawing.Size(651, 121);
            this.grpThongtin.TabIndex = 5;
            this.grpThongtin.TabStop = false;
            this.grpThongtin.Text = "Thông tin";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(114, 29);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(153, 20);
            this.txtMaPhieu.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã phiếu";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(393, 58);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(112, 45);
            this.txtGhiChu.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày thu";
            // 
            // dtNgayThanhToan
            // 
            this.dtNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dtNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThanhToan.Location = new System.Drawing.Point(393, 29);
            this.dtNgayThanhToan.Name = "dtNgayThanhToan";
            this.dtNgayThanhToan.Size = new System.Drawing.Size(106, 20);
            this.dtNgayThanhToan.TabIndex = 8;
            // 
            // numTongTien
            // 
            this.numTongTien.Location = new System.Drawing.Point(115, 82);
            this.numTongTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTongTien.Name = "numTongTien";
            this.numTongTien.Size = new System.Drawing.Size(106, 20);
            this.numTongTien.TabIndex = 5;
            this.numTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTongTien.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách hàng/Đại lý";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(115, 55);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(152, 21);
            this.cmbKhachHang.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.bindingNavigator);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Phiếu thu";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colKhachHang,
            this.colSotien,
            this.colNgayThanhToan,
            this.colGhiChu});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 62);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(645, 195);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView_UserDeletingRow);
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "ID";
            this.colMaPhieu.HeaderText = "Mã phiếu";
            this.colMaPhieu.Name = "colMaPhieu";
            // 
            // colKhachHang
            // 
            this.colKhachHang.DataPropertyName = "ID_KHACH_HANG";
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.Width = 150;
            // 
            // colSotien
            // 
            this.colSotien.DataPropertyName = "TONG_TIEN";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.colSotien.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSotien.HeaderText = "Số tiền";
            this.colSotien.Name = "colSotien";
            // 
            // colNgayThanhToan
            // 
            this.colNgayThanhToan.DataPropertyName = "NGAY_THANH_TOAN";
            this.colNgayThanhToan.HeaderText = "Ngày thu";
            this.colNgayThanhToan.Name = "colNgayThanhToan";
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GHI_CHU";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 150;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolAdd,
            this.toolDelete,
            this.toolSave,
            this.toolStripSeparator1,
            this.toolIn,
            this.toolTimKiem});
            this.bindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(645, 46);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 43);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = global::CuahangNongduoc.Properties.Resources.add;
            this.toolAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.RightToLeftAutoMirrorImage = true;
            this.toolAdd.Size = new System.Drawing.Size(42, 43);
            this.toolAdd.Text = "Thêm";
            this.toolAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = global::CuahangNongduoc.Properties.Resources.remove;
            this.toolDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.RightToLeftAutoMirrorImage = true;
            this.toolDelete.Size = new System.Drawing.Size(43, 43);
            this.toolDelete.Text = "  Xóa  ";
            this.toolDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolSave
            // 
            this.toolSave.Image = global::CuahangNongduoc.Properties.Resources.save;
            this.toolSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(43, 43);
            this.toolSave.Text = "  Lưu  ";
            this.toolSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolIn
            // 
            this.toolIn.Image = global::CuahangNongduoc.Properties.Resources.printer;
            this.toolIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIn.Name = "toolIn";
            this.toolIn.Size = new System.Drawing.Size(55, 43);
            this.toolIn.Text = "Trang in";
            this.toolIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolIn.Click += new System.EventHandler(this.toolIn_Click);
            // 
            // toolTimKiem
            // 
            this.toolTimKiem.Image = global::CuahangNongduoc.Properties.Resources.find;
            this.toolTimKiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTimKiem.Name = "toolTimKiem";
            this.toolTimKiem.Size = new System.Drawing.Size(61, 43);
            this.toolTimKiem.Text = "Tìm kiếm";
            this.toolTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTimKiem.Click += new System.EventHandler(this.toolTimKiem_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThanhToan";
            this.Text = "PHIEU THU";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.panel1.ResumeLayout(false);
            this.grpThongtin.ResumeLayout(false);
            this.grpThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpThongtin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayThanhToan;
        private System.Windows.Forms.NumericUpDown numTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.ToolStripButton toolTimKiem;
    }
}