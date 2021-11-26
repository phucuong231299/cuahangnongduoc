namespace CuahangNongduoc
{
    partial class frmDunoKhachhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDunoKhachhang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDauKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolThang = new System.Windows.Forms.ToolStripComboBox();
            this.toolNam = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTongHop = new System.Windows.Forms.ToolStripButton();
            this.toolLuu = new System.Windows.Forms.ToolStripButton();
            this.toolIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolThoat = new System.Windows.Forms.ToolStripButton();
            this.toolProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.bindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 416);
            this.panel2.TabIndex = 16;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKhachHang,
            this.colThang,
            this.colNam,
            this.colDauKy,
            this.colPhatSinh,
            this.colDaTra,
            this.colConNo});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(744, 370);
            this.dataGridView.TabIndex = 1;
            // 
            // colKhachHang
            // 
            this.colKhachHang.DataPropertyName = "ID_KHACH_HANG";
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.Name = "colKhachHang";
            // 
            // colThang
            // 
            this.colThang.DataPropertyName = "THANG";
            this.colThang.HeaderText = "Tháng";
            this.colThang.Name = "colThang";
            // 
            // colNam
            // 
            this.colNam.DataPropertyName = "NAM";
            this.colNam.HeaderText = "Năm";
            this.colNam.Name = "colNam";
            // 
            // colDauKy
            // 
            this.colDauKy.DataPropertyName = "DAU_KY";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.colDauKy.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDauKy.HeaderText = "Đầu kỳ";
            this.colDauKy.Name = "colDauKy";
            // 
            // colPhatSinh
            // 
            this.colPhatSinh.DataPropertyName = "PHAT_SINH";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.colPhatSinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPhatSinh.HeaderText = "Phát sinh";
            this.colPhatSinh.Name = "colPhatSinh";
            // 
            // colDaTra
            // 
            this.colDaTra.DataPropertyName = "DA_TRA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            this.colDaTra.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDaTra.HeaderText = "Đã trả";
            this.colDaTra.Name = "colDaTra";
            // 
            // colConNo
            // 
            this.colConNo.DataPropertyName = "CUOI_KY";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            this.colConNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.colConNo.HeaderText = "Cuối kỳ";
            this.colConNo.Name = "colConNo";
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
            this.toolThang,
            this.toolNam,
            this.toolStripSeparator1,
            this.toolTongHop,
            this.toolLuu,
            this.toolIn,
            this.toolStripSeparator2,
            this.toolThoat,
            this.toolProgress});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(744, 46);
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
            // toolThang
            // 
            this.toolThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.toolThang.Name = "toolThang";
            this.toolThang.Size = new System.Drawing.Size(75, 46);
            // 
            // toolNam
            // 
            this.toolNam.Name = "toolNam";
            this.toolNam.Size = new System.Drawing.Size(50, 46);
            this.toolNam.Validating += new System.ComponentModel.CancelEventHandler(this.toolNam_Validating);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolTongHop
            // 
            this.toolTongHop.Image = global::CuahangNongduoc.Properties.Resources.reload_24;
            this.toolTongHop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolTongHop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTongHop.Name = "toolTongHop";
            this.toolTongHop.Size = new System.Drawing.Size(63, 43);
            this.toolTongHop.Text = "Tổng hợp";
            this.toolTongHop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTongHop.Click += new System.EventHandler(this.toolTongHop_Click);
            // 
            // toolLuu
            // 
            this.toolLuu.Image = global::CuahangNongduoc.Properties.Resources.save;
            this.toolLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLuu.Name = "toolLuu";
            this.toolLuu.Size = new System.Drawing.Size(31, 43);
            this.toolLuu.Text = "Lưu";
            this.toolLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolLuu.Click += new System.EventHandler(this.toolLuu_Click);
            // 
            // toolIn
            // 
            this.toolIn.Image = global::CuahangNongduoc.Properties.Resources.printer;
            this.toolIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIn.Name = "toolIn";
            this.toolIn.Size = new System.Drawing.Size(28, 43);
            this.toolIn.Text = "In";
            this.toolIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolIn.Click += new System.EventHandler(this.toolIn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // toolThoat
            // 
            this.toolThoat.Image = global::CuahangNongduoc.Properties.Resources.stop;
            this.toolThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolThoat.Name = "toolThoat";
            this.toolThoat.Size = new System.Drawing.Size(42, 43);
            this.toolThoat.Text = "Thoát";
            this.toolThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolThoat.Click += new System.EventHandler(this.toolThoat_Click);
            // 
            // toolProgress
            // 
            this.toolProgress.Name = "toolProgress";
            this.toolProgress.Size = new System.Drawing.Size(200, 43);
            this.toolProgress.Visible = false;
            // 
            // frmDunoKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 416);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDunoKhachhang";
            this.Text = "DU NO KHACH HANG";
            this.Load += new System.EventHandler(this.frmDunoKhachhang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolThang;
        private System.Windows.Forms.ToolStripTextBox toolNam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolTongHop;
        private System.Windows.Forms.ToolStripButton toolLuu;
        private System.Windows.Forms.ToolStripButton toolIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolThoat;
        private System.Windows.Forms.ToolStripProgressBar toolProgress;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDauKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConNo;

    }
}