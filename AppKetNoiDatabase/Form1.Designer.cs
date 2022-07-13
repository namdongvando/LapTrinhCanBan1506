namespace AppKetNoiDatabase
{
    partial class Form1
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
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhảmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngHóaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcHàngHóaToolStripMenuItem,
            this.sảnPhảmToolStripMenuItem});
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            // 
            // danhMụcHàngHóaToolStripMenuItem
            // 
            this.danhMụcHàngHóaToolStripMenuItem.Name = "danhMụcHàngHóaToolStripMenuItem";
            this.danhMụcHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.danhMụcHàngHóaToolStripMenuItem.Text = "Danh Mục Hàng Hóa";
            this.danhMụcHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.danhMụcHàngHóaToolStripMenuItem_Click);
            // 
            // sảnPhảmToolStripMenuItem
            // 
            this.sảnPhảmToolStripMenuItem.Name = "sảnPhảmToolStripMenuItem";
            this.sảnPhảmToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sảnPhảmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhảmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhảmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 468);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhảmToolStripMenuItem;
    }
}

