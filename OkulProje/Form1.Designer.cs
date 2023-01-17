namespace OkulProje
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
            this.öğrenciPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okulYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciPaneliToolStripMenuItem,
            this.öğrenciDersPaneliToolStripMenuItem,
            this.okulYönetimToolStripMenuItem,
            this.dersPaneliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciPaneliToolStripMenuItem
            // 
            this.öğrenciPaneliToolStripMenuItem.Name = "öğrenciPaneliToolStripMenuItem";
            this.öğrenciPaneliToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.öğrenciPaneliToolStripMenuItem.Text = "Öğrenci Paneli";
            this.öğrenciPaneliToolStripMenuItem.Click += new System.EventHandler(this.öğrenciPaneliToolStripMenuItem_Click);
            // 
            // öğrenciDersPaneliToolStripMenuItem
            // 
            this.öğrenciDersPaneliToolStripMenuItem.Name = "öğrenciDersPaneliToolStripMenuItem";
            this.öğrenciDersPaneliToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.öğrenciDersPaneliToolStripMenuItem.Text = "Öğrenci Ders Paneli";
            this.öğrenciDersPaneliToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDersPaneliToolStripMenuItem_Click);
            // 
            // okulYönetimToolStripMenuItem
            // 
            this.okulYönetimToolStripMenuItem.Name = "okulYönetimToolStripMenuItem";
            this.okulYönetimToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.okulYönetimToolStripMenuItem.Text = "Okul Yönetim";
            this.okulYönetimToolStripMenuItem.Click += new System.EventHandler(this.okulYönetimToolStripMenuItem_Click);
            // 
            // dersPaneliToolStripMenuItem
            // 
            this.dersPaneliToolStripMenuItem.Name = "dersPaneliToolStripMenuItem";
            this.dersPaneliToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dersPaneliToolStripMenuItem.Text = "Ders Paneli";
            this.dersPaneliToolStripMenuItem.Click += new System.EventHandler(this.dersPaneliToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(875, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menüler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okulYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersPaneliToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

