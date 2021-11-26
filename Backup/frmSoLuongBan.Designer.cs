namespace CuahangNongduoc
{
    partial class frmSoLuongBan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoLuongBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.btnXemThang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXemNgay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietPhieuBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 104);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbThang);
            this.groupBox1.Controls.Add(this.btnXemThang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(203, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem theo tháng/nãm";
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(147, 23);
            this.numNam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(64, 20);
            this.numNam.TabIndex = 13;
            this.numNam.Value = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nãm";
            // 
            // cmbThang
            // 
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
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
            this.cmbThang.Location = new System.Drawing.Point(50, 22);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(56, 21);
            this.cmbThang.TabIndex = 11;
            // 
            // btnXemThang
            // 
            this.btnXemThang.Image = global::CuahangNongduoc.Properties.Resources.reload;
            this.btnXemThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemThang.Location = new System.Drawing.Point(61, 60);
            this.btnXemThang.Name = "btnXemThang";
            this.btnXemThang.Size = new System.Drawing.Size(97, 24);
            this.btnXemThang.TabIndex = 10;
            this.btnXemThang.Text = "Xem tháng";
            this.btnXemThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemThang.UseVisualStyleBackColor = true;
            this.btnXemThang.Click += new System.EventHandler(this.btnXemThang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgay);
            this.groupBox2.Controls.Add(this.btnXemNgay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(426, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem theo ngày";
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(66, 21);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(107, 20);
            this.dtNgay.TabIndex = 6;
            // 
            // btnXemNgay
            // 
            this.btnXemNgay.Image = global::CuahangNongduoc.Properties.Resources.reload;
            this.btnXemNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemNgay.Location = new System.Drawing.Point(53, 60);
            this.btnXemNgay.Name = "btnXemNgay";
            this.btnXemNgay.Size = new System.Drawing.Size(80, 24);
            this.btnXemNgay.TabIndex = 7;
            this.btnXemNgay.Text = "Xem";
            this.btnXemNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemNgay.UseVisualStyleBackColor = true;
            this.btnXemNgay.Click += new System.EventHandler(this.btnXemNgay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 436);
            this.panel2.TabIndex = 12;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CuahangNongduoc_BusinessObject_ChiTietPhieuBan";
            reportDataSource1.Value = this.ChiTietPhieuBanBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CuahangNongduoc.Report.rptSoLuongBan.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(860, 436);
            this.reportViewer.TabIndex = 0;
            // 
            // ChiTietPhieuBanBindingSource
            // 
            this.ChiTietPhieuBanBindingSource.DataSource = typeof(CuahangNongduoc.BusinessObject.ChiTietPhieuBan);
            // 
            // frmSoLuongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSoLuongBan";
            this.Text = "SO LUONG BAN";
            this.Load += new System.EventHandler(this.frmSoLuongBan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Button btnXemThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnXemNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ChiTietPhieuBanBindingSource;

    }
}