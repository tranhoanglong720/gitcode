
namespace Tuan3
{
    partial class frmBai18
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
            this.btndsngaunhien = new System.Windows.Forms.Button();
            this.btnxoadangchon = new System.Windows.Forms.Button();
            this.btnxoatenson = new System.Windows.Forms.Button();
            this.btnxoahole = new System.Windows.Forms.Button();
            this.btntangchu = new System.Windows.Forms.Button();
            this.btngiamchu = new System.Windows.Forms.Button();
            this.btnhoadautu = new System.Windows.Forms.Button();
            this.btnxoatatca = new System.Windows.Forms.Button();
            this.lstdanhsach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btndsngaunhien
            // 
            this.btndsngaunhien.Location = new System.Drawing.Point(70, 32);
            this.btndsngaunhien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndsngaunhien.Name = "btndsngaunhien";
            this.btndsngaunhien.Size = new System.Drawing.Size(300, 43);
            this.btndsngaunhien.TabIndex = 0;
            this.btndsngaunhien.Text = "Nhập tên ngẫu nhiên";
            this.btndsngaunhien.UseVisualStyleBackColor = true;
            this.btndsngaunhien.Click += new System.EventHandler(this.btndsngaunhien_Click);
            // 
            // btnxoadangchon
            // 
            this.btnxoadangchon.Location = new System.Drawing.Point(705, 89);
            this.btnxoadangchon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoadangchon.Name = "btnxoadangchon";
            this.btnxoadangchon.Size = new System.Drawing.Size(354, 43);
            this.btnxoadangchon.TabIndex = 0;
            this.btnxoadangchon.Text = "Xóa Phần tử đang chọn";
            this.btnxoadangchon.UseVisualStyleBackColor = true;
            this.btnxoadangchon.Click += new System.EventHandler(this.btnxoadangchon_Click);
            // 
            // btnxoatenson
            // 
            this.btnxoatenson.Location = new System.Drawing.Point(705, 142);
            this.btnxoatenson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoatenson.Name = "btnxoatenson";
            this.btnxoatenson.Size = new System.Drawing.Size(354, 43);
            this.btnxoatenson.TabIndex = 0;
            this.btnxoatenson.Text = "Xóa phần tử có tên là Sơn";
            this.btnxoatenson.UseVisualStyleBackColor = true;
            this.btnxoatenson.Click += new System.EventHandler(this.btnxoatenson_Click);
            // 
            // btnxoahole
            // 
            this.btnxoahole.Location = new System.Drawing.Point(705, 194);
            this.btnxoahole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoahole.Name = "btnxoahole";
            this.btnxoahole.Size = new System.Drawing.Size(354, 43);
            this.btnxoahole.TabIndex = 0;
            this.btnxoahole.Text = "Xóa phần tử có họ là Lê";
            this.btnxoahole.UseVisualStyleBackColor = true;
            this.btnxoahole.Click += new System.EventHandler(this.btnxoahole_Click);
            // 
            // btntangchu
            // 
            this.btntangchu.Location = new System.Drawing.Point(705, 246);
            this.btntangchu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntangchu.Name = "btntangchu";
            this.btntangchu.Size = new System.Drawing.Size(354, 43);
            this.btntangchu.TabIndex = 0;
            this.btntangchu.Text = "Chuyển phần tử đang chọn thành chữ Hoa";
            this.btntangchu.UseVisualStyleBackColor = true;
            this.btntangchu.Click += new System.EventHandler(this.btntangchu_Click);
            // 
            // btngiamchu
            // 
            this.btngiamchu.Location = new System.Drawing.Point(705, 298);
            this.btngiamchu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngiamchu.Name = "btngiamchu";
            this.btngiamchu.Size = new System.Drawing.Size(354, 43);
            this.btngiamchu.TabIndex = 0;
            this.btngiamchu.Text = "Chuyển phần tử đang chọn thành chữ thường";
            this.btngiamchu.UseVisualStyleBackColor = true;
            this.btngiamchu.Click += new System.EventHandler(this.btngiamchu_Click);
            // 
            // btnhoadautu
            // 
            this.btnhoadautu.Location = new System.Drawing.Point(705, 351);
            this.btnhoadautu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhoadautu.Name = "btnhoadautu";
            this.btnhoadautu.Size = new System.Drawing.Size(354, 78);
            this.btnhoadautu.TabIndex = 0;
            this.btnhoadautu.Text = "Chuyển PT đang chọn thành chữ vitết Hoa đầu từ";
            this.btnhoadautu.UseVisualStyleBackColor = true;
            this.btnhoadautu.Click += new System.EventHandler(this.btnhoadautu_Click);
            // 
            // btnxoatatca
            // 
            this.btnxoatatca.Location = new System.Drawing.Point(705, 442);
            this.btnxoatatca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoatatca.Name = "btnxoatatca";
            this.btnxoatatca.Size = new System.Drawing.Size(354, 43);
            this.btnxoatatca.TabIndex = 0;
            this.btnxoatatca.Text = "Xóa tất cả các phần tử";
            this.btnxoatatca.UseVisualStyleBackColor = true;
            this.btnxoatatca.Click += new System.EventHandler(this.btnxoatatca_Click);
            // 
            // lstdanhsach
            // 
            this.lstdanhsach.FormattingEnabled = true;
            this.lstdanhsach.ItemHeight = 20;
            this.lstdanhsach.Location = new System.Drawing.Point(72, 105);
            this.lstdanhsach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstdanhsach.Name = "lstdanhsach";
            this.lstdanhsach.Size = new System.Drawing.Size(298, 464);
            this.lstdanhsach.TabIndex = 1;
            // 
            // frmBai18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lstdanhsach);
            this.Controls.Add(this.btnxoatatca);
            this.Controls.Add(this.btnhoadautu);
            this.Controls.Add(this.btngiamchu);
            this.Controls.Add(this.btntangchu);
            this.Controls.Add(this.btnxoahole);
            this.Controls.Add(this.btnxoatenson);
            this.Controls.Add(this.btnxoadangchon);
            this.Controls.Add(this.btndsngaunhien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBai18";
            this.Text = "frmchuoi";
            this.Load += new System.EventHandler(this.frmBai18_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndsngaunhien;
        private System.Windows.Forms.Button btnxoadangchon;
        private System.Windows.Forms.Button btnxoatenson;
        private System.Windows.Forms.Button btnxoahole;
        private System.Windows.Forms.Button btntangchu;
        private System.Windows.Forms.Button btngiamchu;
        private System.Windows.Forms.Button btnhoadautu;
        private System.Windows.Forms.Button btnxoatatca;
        private System.Windows.Forms.ListBox lstdanhsach;
    }
}

