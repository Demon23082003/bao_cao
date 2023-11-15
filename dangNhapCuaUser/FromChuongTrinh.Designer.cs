namespace dangNhapCuaUser
{
    partial class FromChuongTrinh
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
            this.btDangXuat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDangXuat
            // 
            this.btDangXuat.Location = new System.Drawing.Point(497, 380);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(128, 58);
            this.btDangXuat.TabIndex = 0;
            this.btDangXuat.Text = "Đăng Xuất";
            this.btDangXuat.UseVisualStyleBackColor = true;
            this.btDangXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(660, 380);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(128, 58);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FromChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangXuat);
            this.Name = "FromChuongTrinh";
            this.Text = "FromChuongTrinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromChuongTrinh_FormClosing);
            this.Load += new System.EventHandler(this.FromChuongTrinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDangXuat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btThoat;
    }
}