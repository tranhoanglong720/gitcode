namespace BTtuan4
{
    partial class Frmlogin
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
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhap.Location = new System.Drawing.Point(0, -6);
            this.lbldangnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(426, 40);
            this.lbldangnhap.TabIndex = 0;
            this.lbldangnhap.Text = "Đăng nhập thuê Xe";
            this.lbldangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(33, 101);
            this.lbltaikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(80, 20);
            this.lbltaikhoan.TabIndex = 1;
            this.lbltaikhoan.Text = "Tài Khoản";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Location = new System.Drawing.Point(36, 177);
            this.lblmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(77, 20);
            this.lblmatkhau.TabIndex = 1;
            this.lblmatkhau.Text = "Mật Khẩu";
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(117, 249);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(202, 52);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(117, 95);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(246, 26);
            this.txttaikhoan.TabIndex = 3;
            this.txttaikhoan.Text = "ABC";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(117, 177);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(246, 26);
            this.txtmatkhau.TabIndex = 3;
            this.txtmatkhau.Text = "123";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 352);
            this.ControlBox = false;
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.lbldangnhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        public System.Windows.Forms.TextBox txttaikhoan;
        public System.Windows.Forms.TextBox txtmatkhau;
    }
}