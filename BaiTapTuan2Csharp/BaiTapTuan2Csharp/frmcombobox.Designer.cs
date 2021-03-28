
namespace BaiTapTuan2Csharp
{
    partial class frmCombobox
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
            this.lblNhapso = new System.Windows.Forms.Label();
            this.lbldanhsach = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.lstdanhsach = new System.Windows.Forms.ListBox();
            this.cboso = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnchan = new System.Windows.Forms.Button();
            this.btnsonguyento = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapso
            // 
            this.lblNhapso.AutoSize = true;
            this.lblNhapso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapso.Location = new System.Drawing.Point(70, 42);
            this.lblNhapso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapso.Name = "lblNhapso";
            this.lblNhapso.Size = new System.Drawing.Size(68, 20);
            this.lblNhapso.TabIndex = 0;
            this.lblNhapso.Text = "Nhập số";
            // 
            // lbldanhsach
            // 
            this.lbldanhsach.AutoSize = true;
            this.lbldanhsach.Location = new System.Drawing.Point(562, 63);
            this.lbldanhsach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldanhsach.Name = "lbldanhsach";
            this.lbldanhsach.Size = new System.Drawing.Size(166, 20);
            this.lbldanhsach.TabIndex = 0;
            this.lbldanhsach.Text = "Danh sách các ước số";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(74, 98);
            this.txtnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(196, 26);
            this.txtnhap.TabIndex = 1;
            this.txtnhap.TextChanged += new System.EventHandler(this.txtnhap_TextChanged);
            // 
            // lstdanhsach
            // 
            this.lstdanhsach.FormattingEnabled = true;
            this.lstdanhsach.ItemHeight = 20;
            this.lstdanhsach.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "10"});
            this.lstdanhsach.Location = new System.Drawing.Point(556, 88);
            this.lstdanhsach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstdanhsach.Name = "lstdanhsach";
            this.lstdanhsach.Size = new System.Drawing.Size(327, 124);
            this.lstdanhsach.TabIndex = 2;
            // 
            // cboso
            // 
            this.cboso.FormattingEnabled = true;
            this.cboso.Items.AddRange(new object[] {
            "20",
            "18",
            "19"});
            this.cboso.Location = new System.Drawing.Point(64, 180);
            this.cboso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboso.Name = "cboso";
            this.cboso.Size = new System.Drawing.Size(405, 28);
            this.cboso.TabIndex = 3;
            this.cboso.SelectedIndexChanged += new System.EventHandler(this.cboso_SelectedIndexChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(356, 416);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(135, 55);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Th&oát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(556, 251);
            this.btnTong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(327, 55);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "&Tổng các ước số";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnchan
            // 
            this.btnchan.Location = new System.Drawing.Point(556, 334);
            this.btnchan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnchan.Name = "btnchan";
            this.btnchan.Size = new System.Drawing.Size(327, 55);
            this.btnchan.TabIndex = 4;
            this.btnchan.Text = "&Số lượng các ước số chẵn";
            this.btnchan.UseVisualStyleBackColor = true;
            this.btnchan.Click += new System.EventHandler(this.btnchan_Click);
            // 
            // btnsonguyento
            // 
            this.btnsonguyento.Location = new System.Drawing.Point(556, 416);
            this.btnsonguyento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsonguyento.Name = "btnsonguyento";
            this.btnsonguyento.Size = new System.Drawing.Size(327, 55);
            this.btnsonguyento.TabIndex = 4;
            this.btnsonguyento.Text = "Số lượng các ước số &nguyên tố";
            this.btnsonguyento.UseVisualStyleBackColor = true;
            this.btnsonguyento.Click += new System.EventHandler(this.btnsonguyento_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(296, 69);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(135, 55);
            this.btncapnhat.TabIndex = 4;
            this.btncapnhat.Text = "&Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // frmCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 543);
            this.Controls.Add(this.btnsonguyento);
            this.Controls.Add(this.btnchan);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.cboso);
            this.Controls.Add(this.lstdanhsach);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.lbldanhsach);
            this.Controls.Add(this.lblNhapso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCombobox";
            this.Text = "Combobox";
            this.Load += new System.EventHandler(this.frmCombobox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapso;
        private System.Windows.Forms.Label lbldanhsach;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.ListBox lstdanhsach;
        private System.Windows.Forms.ComboBox cboso;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnchan;
        private System.Windows.Forms.Button btnsonguyento;
        private System.Windows.Forms.Button btncapnhat;
    }
}

