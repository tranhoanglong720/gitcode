namespace BTtuan4
{
    partial class FrmThuexe
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
            this.lblnhan = new System.Windows.Forms.Label();
            this.lblThongtinkh = new System.Windows.Forms.Label();
            this.lblMakh = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblDunghan = new System.Windows.Forms.Label();
            this.lblThongke = new System.Windows.Forms.Label();
            this.lblTrehan = new System.Windows.Forms.Label();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.ckgiam = new System.Windows.Forms.CheckBox();
            this.cktang = new System.Windows.Forms.CheckBox();
            this.btnaddall = new System.Windows.Forms.Button();
            this.btnadda = new System.Windows.Forms.Button();
            this.btnxoaa = new System.Windows.Forms.Button();
            this.btnXoaall = new System.Windows.Forms.Button();
            this.lvwDanhsach = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblnhan
            // 
            this.lblnhan.AllowDrop = true;
            this.lblnhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblnhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.Location = new System.Drawing.Point(-19, 2);
            this.lblnhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(772, 49);
            this.lblnhan.TabIndex = 0;
            this.lblnhan.Text = "Quản Lý Thuê Xe";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongtinkh
            // 
            this.lblThongtinkh.AutoSize = true;
            this.lblThongtinkh.Location = new System.Drawing.Point(13, 80);
            this.lblThongtinkh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtinkh.Name = "lblThongtinkh";
            this.lblThongtinkh.Size = new System.Drawing.Size(171, 20);
            this.lblThongtinkh.TabIndex = 0;
            this.lblThongtinkh.Text = "Thông Tin Khách Hàng";
            // 
            // lblMakh
            // 
            this.lblMakh.AutoSize = true;
            this.lblMakh.Location = new System.Drawing.Point(167, 117);
            this.lblMakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.Size = new System.Drawing.Size(54, 20);
            this.lblMakh.TabIndex = 0;
            this.lblMakh.Text = "Mã Kh";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(81, 166);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(153, 20);
            this.lblHoten.TabIndex = 0;
            this.lblHoten.Text = "Họ Tên Khách Hàng";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(84, 235);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(128, 20);
            this.lblSoluong.TabIndex = 0;
            this.lblSoluong.Text = "Số lượng xe thuê";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(157, 310);
            this.lblDongia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(64, 20);
            this.lblDongia.TabIndex = 0;
            this.lblDongia.Text = "Đơn giá";
            // 
            // lblDunghan
            // 
            this.lblDunghan.AutoSize = true;
            this.lblDunghan.Location = new System.Drawing.Point(125, 389);
            this.lblDunghan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDunghan.Name = "lblDunghan";
            this.lblDunghan.Size = new System.Drawing.Size(109, 20);
            this.lblDunghan.TabIndex = 0;
            this.lblDunghan.Text = "Trả Đúng Hạn";
            // 
            // lblThongke
            // 
            this.lblThongke.AutoSize = true;
            this.lblThongke.Location = new System.Drawing.Point(13, 565);
            this.lblThongke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongke.Name = "lblThongke";
            this.lblThongke.Size = new System.Drawing.Size(77, 20);
            this.lblThongke.TabIndex = 0;
            this.lblThongke.Text = "Thống Kê";
            // 
            // lblTrehan
            // 
            this.lblTrehan.AutoSize = true;
            this.lblTrehan.Location = new System.Drawing.Point(141, 438);
            this.lblTrehan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrehan.Name = "lblTrehan";
            this.lblTrehan.Size = new System.Drawing.Size(93, 20);
            this.lblTrehan.TabIndex = 0;
            this.lblTrehan.Text = "Trả Trễ Hạn";
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(242, 108);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(530, 26);
            this.txtMakh.TabIndex = 1;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(242, 166);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(530, 26);
            this.txtHoten.TabIndex = 1;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(242, 235);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(530, 26);
            this.txtSoluong.TabIndex = 1;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(242, 307);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(530, 26);
            this.txtDongia.TabIndex = 1;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(824, 108);
            this.btntinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(219, 29);
            this.btntinh.TabIndex = 2;
            this.btntinh.Text = "Tính Thuê";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(824, 168);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(219, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(824, 232);
            this.btnTong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(219, 29);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tổng Tiền";
            this.btnTong.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(824, 307);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(219, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ckgiam
            // 
            this.ckgiam.AutoSize = true;
            this.ckgiam.Location = new System.Drawing.Point(257, 389);
            this.ckgiam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckgiam.Name = "ckgiam";
            this.ckgiam.Size = new System.Drawing.Size(174, 24);
            this.ckgiam.TabIndex = 3;
            this.ckgiam.Text = "(Giảm 3%thành tiền)";
            this.ckgiam.UseVisualStyleBackColor = true;
            // 
            // cktang
            // 
            this.cktang.AutoSize = true;
            this.cktang.Location = new System.Drawing.Point(259, 437);
            this.cktang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cktang.Name = "cktang";
            this.cktang.Size = new System.Drawing.Size(172, 24);
            this.cktang.TabIndex = 3;
            this.cktang.Text = "(Tăng 5%thành tiền)";
            this.cktang.UseVisualStyleBackColor = true;
            // 
            // btnaddall
            // 
            this.btnaddall.Location = new System.Drawing.Point(13, 518);
            this.btnaddall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddall.Name = "btnaddall";
            this.btnaddall.Size = new System.Drawing.Size(219, 29);
            this.btnaddall.TabIndex = 2;
            this.btnaddall.Text = "<<";
            this.btnaddall.UseVisualStyleBackColor = true;
            // 
            // btnadda
            // 
            this.btnadda.Location = new System.Drawing.Point(257, 518);
            this.btnadda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadda.Name = "btnadda";
            this.btnadda.Size = new System.Drawing.Size(219, 29);
            this.btnadda.TabIndex = 2;
            this.btnadda.Text = "<";
            this.btnadda.UseVisualStyleBackColor = true;
            // 
            // btnxoaa
            // 
            this.btnxoaa.Location = new System.Drawing.Point(499, 518);
            this.btnxoaa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoaa.Name = "btnxoaa";
            this.btnxoaa.Size = new System.Drawing.Size(219, 29);
            this.btnxoaa.TabIndex = 2;
            this.btnxoaa.Text = ">";
            this.btnxoaa.UseVisualStyleBackColor = true;
            // 
            // btnXoaall
            // 
            this.btnXoaall.Location = new System.Drawing.Point(751, 518);
            this.btnXoaall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaall.Name = "btnXoaall";
            this.btnXoaall.Size = new System.Drawing.Size(219, 29);
            this.btnXoaall.TabIndex = 2;
            this.btnXoaall.Text = ">>";
            this.btnXoaall.UseVisualStyleBackColor = true;
            // 
            // lvwDanhsach
            // 
            this.lvwDanhsach.Location = new System.Drawing.Point(14, 590);
            this.lvwDanhsach.Name = "lvwDanhsach";
            this.lvwDanhsach.Size = new System.Drawing.Size(1030, 135);
            this.lvwDanhsach.TabIndex = 4;
            this.lvwDanhsach.UseCompatibleStateImageBehavior = false;
            // 
            // FrmThuexe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 749);
            this.Controls.Add(this.lvwDanhsach);
            this.Controls.Add(this.lblnhan);
            this.Controls.Add(this.cktang);
            this.Controls.Add(this.ckgiam);
            this.Controls.Add(this.btnXoaall);
            this.Controls.Add(this.btnxoaa);
            this.Controls.Add(this.btnadda);
            this.Controls.Add(this.btnaddall);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.lblTrehan);
            this.Controls.Add(this.lblThongke);
            this.Controls.Add(this.lblDunghan);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.lblMakh);
            this.Controls.Add(this.lblThongtinkh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmThuexe";
            this.Text = "FrmThuexe";
            this.Load += new System.EventHandler(this.FrmThuexe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhan;
        private System.Windows.Forms.Label lblThongtinkh;
        private System.Windows.Forms.Label lblMakh;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblDunghan;
        private System.Windows.Forms.Label lblThongke;
        private System.Windows.Forms.Label lblTrehan;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox ckgiam;
        private System.Windows.Forms.CheckBox cktang;
        private System.Windows.Forms.Button btnaddall;
        private System.Windows.Forms.Button btnadda;
        private System.Windows.Forms.Button btnxoaa;
        private System.Windows.Forms.Button btnXoaall;
        private System.Windows.Forms.ListView lvwDanhsach;
    }
}