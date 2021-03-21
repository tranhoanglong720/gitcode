
namespace Csharp1
{
    partial class frmTinhToan
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
            this.lblso1 = new System.Windows.Forms.Label();
            this.lblso2 = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.txtnhapso1 = new System.Windows.Forms.TextBox();
            this.txtnhapso2 = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.radcong = new System.Windows.Forms.RadioButton();
            this.radtru = new System.Windows.Forms.RadioButton();
            this.radnhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.lblnhan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblso1
            // 
            this.lblso1.AutoSize = true;
            this.lblso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblso1.Location = new System.Drawing.Point(111, 96);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(42, 20);
            this.lblso1.TabIndex = 0;
            this.lblso1.Text = "Số 1";
            // 
            // lblso2
            // 
            this.lblso2.AutoSize = true;
            this.lblso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblso2.Location = new System.Drawing.Point(111, 164);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(42, 20);
            this.lblso2.TabIndex = 1;
            this.lblso2.Text = "Số 2";
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(110, 365);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(63, 20);
            this.lblketqua.TabIndex = 2;
            this.lblketqua.Text = "KếtQuả";
            this.lblketqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnhapso1
            // 
            this.txtnhapso1.BackColor = System.Drawing.SystemColors.Window;
            this.txtnhapso1.Location = new System.Drawing.Point(166, 85);
            this.txtnhapso1.Multiline = true;
            this.txtnhapso1.Name = "txtnhapso1";
            this.txtnhapso1.Size = new System.Drawing.Size(530, 31);
            this.txtnhapso1.TabIndex = 3;
            this.txtnhapso1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnhapso1.TextChanged += new System.EventHandler(this.txtnhapso1_TextChanged);
            // 
            // txtnhapso2
            // 
            this.txtnhapso2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnhapso2.Location = new System.Drawing.Point(166, 152);
            this.txtnhapso2.Multiline = true;
            this.txtnhapso2.Name = "txtnhapso2";
            this.txtnhapso2.Size = new System.Drawing.Size(530, 32);
            this.txtnhapso2.TabIndex = 4;
            this.txtnhapso2.TextChanged += new System.EventHandler(this.txtnhapso2_TextChanged);
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(178, 351);
            this.txtketqua.Multiline = true;
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(518, 34);
            this.txtketqua.TabIndex = 5;
            this.txtketqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtketqua.TextChanged += new System.EventHandler(this.txtketqua_TextChanged);
            // 
            // radcong
            // 
            this.radcong.AutoSize = true;
            this.radcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radcong.Location = new System.Drawing.Point(114, 271);
            this.radcong.Name = "radcong";
            this.radcong.Size = new System.Drawing.Size(65, 24);
            this.radcong.TabIndex = 11;
            this.radcong.TabStop = true;
            this.radcong.Text = "Cộng";
            this.radcong.UseVisualStyleBackColor = true;
            this.radcong.CheckedChanged += new System.EventHandler(this.radcong_CheckedChanged);
            // 
            // radtru
            // 
            this.radtru.AutoSize = true;
            this.radtru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtru.Location = new System.Drawing.Point(265, 271);
            this.radtru.Name = "radtru";
            this.radtru.Size = new System.Drawing.Size(50, 24);
            this.radtru.TabIndex = 12;
            this.radtru.TabStop = true;
            this.radtru.Text = "Trừ";
            this.radtru.UseVisualStyleBackColor = true;
            this.radtru.CheckedChanged += new System.EventHandler(this.radnhan_CheckedChanged);
            // 
            // radnhan
            // 
            this.radnhan.AutoSize = true;
            this.radnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnhan.Location = new System.Drawing.Point(429, 271);
            this.radnhan.Name = "radnhan";
            this.radnhan.Size = new System.Drawing.Size(65, 24);
            this.radnhan.TabIndex = 11;
            this.radnhan.TabStop = true;
            this.radnhan.Text = "Nhân";
            this.radnhan.UseVisualStyleBackColor = true;
            this.radnhan.CheckedChanged += new System.EventHandler(this.radnhan_CheckedChanged);
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChia.Location = new System.Drawing.Point(610, 271);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(59, 24);
            this.radChia.TabIndex = 11;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radnhan_CheckedChanged);
            // 
            // lblnhan
            // 
            this.lblnhan.AutoSize = true;
            this.lblnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.Location = new System.Drawing.Point(317, 30);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(137, 31);
            this.lblnhan.TabIndex = 13;
            this.lblnhan.Text = "Phép Tinh";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnhan);
            this.Controls.Add(this.radtru);
            this.Controls.Add(this.radnhan);
            this.Controls.Add(this.radChia);
            this.Controls.Add(this.radcong);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtnhapso2);
            this.Controls.Add(this.txtnhapso1);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.lblso1);
            this.Name = "frmTinhToan";
            this.Text = "PhepTinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblso1;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtnhapso1;
        private System.Windows.Forms.TextBox txtnhapso2;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.RadioButton radcong;
        private System.Windows.Forms.RadioButton radtru;
        private System.Windows.Forms.RadioButton radnhan;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.Label lblnhan;
    }
}

