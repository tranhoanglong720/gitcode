
namespace Csharp1
{
    partial class FrmPtBac2
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
            this.lblnhapa = new System.Windows.Forms.Label();
            this.lblnhapb = new System.Windows.Forms.Label();
            this.lblnhapc = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.txtnhapa = new System.Windows.Forms.TextBox();
            this.txtnhapb = new System.Windows.Forms.TextBox();
            this.txtnhapc = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnhan
            // 
            this.lblnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.Location = new System.Drawing.Point(126, 29);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(576, 31);
            this.lblnhan.TabIndex = 0;
            this.lblnhan.Text = "Phương Trình Bậc 2:Ax^2+Bx+C=0";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnhapa
            // 
            this.lblnhapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhapa.Location = new System.Drawing.Point(126, 87);
            this.lblnhapa.Name = "lblnhapa";
            this.lblnhapa.Size = new System.Drawing.Size(66, 20);
            this.lblnhapa.TabIndex = 0;
            this.lblnhapa.Text = "Nhập A:";
            // 
            // lblnhapb
            // 
            this.lblnhapb.AutoSize = true;
            this.lblnhapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhapb.Location = new System.Drawing.Point(126, 146);
            this.lblnhapb.Name = "lblnhapb";
            this.lblnhapb.Size = new System.Drawing.Size(66, 20);
            this.lblnhapb.TabIndex = 0;
            this.lblnhapb.Text = "Nhập B:";
            // 
            // lblnhapc
            // 
            this.lblnhapc.AutoSize = true;
            this.lblnhapc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhapc.Location = new System.Drawing.Point(126, 221);
            this.lblnhapc.Name = "lblnhapc";
            this.lblnhapc.Size = new System.Drawing.Size(66, 20);
            this.lblnhapc.TabIndex = 0;
            this.lblnhapc.Text = "Nhập C:";
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(126, 289);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(63, 20);
            this.lblketqua.TabIndex = 0;
            this.lblketqua.Text = "KếtQuả";
            // 
            // txtnhapa
            // 
            this.txtnhapa.Location = new System.Drawing.Point(198, 76);
            this.txtnhapa.Multiline = true;
            this.txtnhapa.Name = "txtnhapa";
            this.txtnhapa.Size = new System.Drawing.Size(504, 31);
            this.txtnhapa.TabIndex = 1;
            this.txtnhapa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnhapa.TextChanged += new System.EventHandler(this.txtnhapa_TextChanged);
            // 
            // txtnhapb
            // 
            this.txtnhapb.Location = new System.Drawing.Point(198, 130);
            this.txtnhapb.Multiline = true;
            this.txtnhapb.Name = "txtnhapb";
            this.txtnhapb.Size = new System.Drawing.Size(504, 36);
            this.txtnhapb.TabIndex = 1;
            this.txtnhapb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnhapb.TextChanged += new System.EventHandler(this.txtnhapb_TextChanged);
            // 
            // txtnhapc
            // 
            this.txtnhapc.Location = new System.Drawing.Point(198, 203);
            this.txtnhapc.Multiline = true;
            this.txtnhapc.Name = "txtnhapc";
            this.txtnhapc.Size = new System.Drawing.Size(504, 38);
            this.txtnhapc.TabIndex = 1;
            this.txtnhapc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnhapc.TextChanged += new System.EventHandler(this.txtnhapc_TextChanged);
            // 
            // txtketqua
            // 
            this.txtketqua.AcceptsTab = true;
            this.txtketqua.Location = new System.Drawing.Point(198, 272);
            this.txtketqua.Multiline = true;
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(504, 37);
            this.txtketqua.TabIndex = 1;
            this.txtketqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTinh
            // 
            this.btnTinh.Enabled = false;
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(198, 355);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(146, 28);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "&Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(379, 355);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(143, 28);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(580, 355);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 28);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Th&oát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FrmPtBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtnhapc);
            this.Controls.Add(this.txtnhapb);
            this.Controls.Add(this.txtnhapa);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.lblnhapc);
            this.Controls.Add(this.lblnhapb);
            this.Controls.Add(this.lblnhapa);
            this.Controls.Add(this.lblnhan);
            this.Name = "FrmPtBac2";
            this.Text = "FrmPtBac2";
            this.Load += new System.EventHandler(this.FrmPtBac2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhan;
        private System.Windows.Forms.Label lblnhapa;
        private System.Windows.Forms.Label lblnhapb;
        private System.Windows.Forms.Label lblnhapc;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtnhapa;
        private System.Windows.Forms.TextBox txtnhapb;
        private System.Windows.Forms.TextBox txtnhapc;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
    }
}