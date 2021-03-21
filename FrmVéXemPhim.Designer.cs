
namespace Csharp1
{
    partial class FrmVéXemPhim
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
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.btnchon = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblnhan
            // 
            this.lblnhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.Location = new System.Drawing.Point(2, 9);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(796, 40);
            this.lblnhan.TabIndex = 0;
            this.lblnhan.Text = "Màn Ảnh";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtien.Location = new System.Drawing.Point(105, 347);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(92, 20);
            this.lblthanhtien.TabIndex = 0;
            this.lblthanhtien.Text = "Thành Tiền:";
            this.lblthanhtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnchon
            // 
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(109, 386);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(130, 37);
            this.btnchon.TabIndex = 1;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(324, 386);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(117, 37);
            this.btnhuy.TabIndex = 1;
            this.btnhuy.Text = "Hủy bỏ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnketthuc.Location = new System.Drawing.Point(528, 386);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(126, 39);
            this.btnketthuc.TabIndex = 1;
            this.btnketthuc.TabStop = false;
            this.btnketthuc.Text = "Kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(213, 347);
            this.txtthanhtien.Multiline = true;
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(461, 33);
            this.txtthanhtien.TabIndex = 2;
            this.txtthanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(109, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 215);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.TabStop = true;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // FrmVéXemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.lblthanhtien);
            this.Controls.Add(this.lblnhan);
            this.Name = "FrmVéXemPhim";
            this.Text = "VéXemPhim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhan;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}