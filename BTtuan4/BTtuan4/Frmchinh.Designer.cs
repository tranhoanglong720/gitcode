namespace BTtuan4
{
    partial class Frmchinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuchucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuchucnangthuexe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuchucnang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuchucnang
            // 
            this.mnuchucnang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuchucnangthuexe});
            this.mnuchucnang.Name = "mnuchucnang";
            this.mnuchucnang.Size = new System.Drawing.Size(77, 20);
            this.mnuchucnang.Text = "Chức năng";
            // 
            // mnuchucnangthuexe
            // 
            this.mnuchucnangthuexe.Name = "mnuchucnangthuexe";
            this.mnuchucnangthuexe.Size = new System.Drawing.Size(152, 22);
            this.mnuchucnangthuexe.Text = "Thuê xe";
            this.mnuchucnangthuexe.Click += new System.EventHandler(this.mnuchucnangthuexe_Click);
            // 
            // Frmchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 498);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmchinh";
            this.Text = "FrmChinh";
            this.Load += new System.EventHandler(this.Frmchinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuchucnang;
        private System.Windows.Forms.ToolStripMenuItem mnuchucnangthuexe;
    }
}

