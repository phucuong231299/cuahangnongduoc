
namespace CuahangNongduoc
{
    partial class frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhanVien));
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
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
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnluu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btntim = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolTimMaSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTimTenSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTimSanPham = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(188, 48);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(217, 26);
            this.txtmanv.TabIndex = 0;
            this.txtmanv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(188, 110);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(217, 26);
            this.txttennv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên nhân viên";
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(625, 51);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(217, 26);
            this.txttendn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(625, 113);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(217, 26);
            this.txtmk.TabIndex = 7;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.AutoSize = false;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.btnthem,
            this.btnxoa,
            this.btnluu,
            this.toolStripSeparator1,
            this.btnthoat,
            this.toolStripSeparator2,
            this.btntim,
            this.toolTimSanPham});
            this.bindingNavigator.Location = new System.Drawing.Point(9, 194);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(1280, 58);
            this.bindingNavigator.TabIndex = 8;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 53);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 53);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 53);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 58);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 53);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 53);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::CuahangNongduoc.Properties.Resources.add;
            this.btnthem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnthem.Name = "btnthem";
            this.btnthem.RightToLeftAutoMirrorImage = true;
            this.btnthem.Size = new System.Drawing.Size(70, 53);
            this.btnthem.Text = " Thêm ";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::CuahangNongduoc.Properties.Resources.remove;
            this.btnxoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.RightToLeftAutoMirrorImage = true;
            this.btnxoa.Size = new System.Drawing.Size(67, 53);
            this.btnxoa.Text = "  Xóa  ";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = global::CuahangNongduoc.Properties.Resources.save;
            this.btnluu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(65, 53);
            this.btnluu.Text = "  Lưu  ";
            this.btnluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::CuahangNongduoc.Properties.Resources.stop;
            this.btnthoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(61, 53);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // btntim
            // 
            this.btntim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTimMaSanPham,
            this.toolTimTenSanPham});
            this.btntim.Image = global::CuahangNongduoc.Properties.Resources.find;
            this.btntim.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(42, 53);
            // 
            // toolTimMaSanPham
            // 
            this.toolTimMaSanPham.Checked = true;
            this.toolTimMaSanPham.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolTimMaSanPham.Name = "toolTimMaSanPham";
            this.toolTimMaSanPham.Size = new System.Drawing.Size(223, 34);
            this.toolTimMaSanPham.Text = "Mã sản phẩm";
            // 
            // toolTimTenSanPham
            // 
            this.toolTimTenSanPham.Name = "toolTimTenSanPham";
            this.toolTimTenSanPham.Size = new System.Drawing.Size(223, 34);
            this.toolTimTenSanPham.Text = "Tên sản phẩm";
            // 
            // toolTimSanPham
            // 
            this.toolTimSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolTimSanPham.ForeColor = System.Drawing.Color.Silver;
            this.toolTimSanPham.Name = "toolTimSanPham";
            this.toolTimSanPham.Size = new System.Drawing.Size(148, 58);
            this.toolTimSanPham.Text = "Tìm theo mã";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colhovaten,
            this.coltendangnhap,
            this.colmatkhau});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 454);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttendn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1288, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên";
            // 
            // colid
            // 
            this.colid.DataPropertyName = "ID";
            this.colid.HeaderText = "ID";
            this.colid.MinimumWidth = 8;
            this.colid.Name = "colid";
            this.colid.Width = 150;
            // 
            // colhovaten
            // 
            this.colhovaten.DataPropertyName = "HO_VA_TEN";
            this.colhovaten.HeaderText = "Họ Và Tên";
            this.colhovaten.MinimumWidth = 8;
            this.colhovaten.Name = "colhovaten";
            this.colhovaten.Width = 150;
            // 
            // coltendangnhap
            // 
            this.coltendangnhap.DataPropertyName = "TEN_DANG_NHAP";
            this.coltendangnhap.HeaderText = "Tên Đăng Nhập";
            this.coltendangnhap.MinimumWidth = 8;
            this.coltendangnhap.Name = "coltendangnhap";
            this.coltendangnhap.Width = 150;
            // 
            // colmatkhau
            // 
            this.colmatkhau.DataPropertyName = "MAT_KHAU";
            this.colmatkhau.HeaderText = "Mật khẩu";
            this.colmatkhau.MinimumWidth = 8;
            this.colmatkhau.Name = "colmatkhau";
            this.colmatkhau.Width = 150;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmk;
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
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnluu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btntim;
        private System.Windows.Forms.ToolStripMenuItem toolTimMaSanPham;
        private System.Windows.Forms.ToolStripMenuItem toolTimTenSanPham;
        private System.Windows.Forms.ToolStripTextBox toolTimSanPham;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmatkhau;
    }
}