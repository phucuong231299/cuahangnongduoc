
namespace CuahangNongduoc
{
    partial class frmdangnhap
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
            this.txttendn = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(277, 53);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(197, 26);
            this.txttendn.TabIndex = 0;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(277, 150);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(197, 26);
            this.txtmk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đăng nhập";
            // 
            // btndn
            // 
            this.btndn.Location = new System.Drawing.Point(209, 235);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(107, 42);
            this.btndn.TabIndex = 3;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(433, 235);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 42);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 337);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttendn);
            this.Name = "frmdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
    }
}