namespace Projet_GSB
{
    partial class FMenu
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
            this.missionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // missionsToolStripMenuItem
            // 
            this.missionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mission1ToolStripMenuItem,
            this.mission2ToolStripMenuItem,
            this.mission3ToolStripMenuItem});
            this.missionsToolStripMenuItem.Name = "missionsToolStripMenuItem";
            this.missionsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.missionsToolStripMenuItem.Text = "Missions";
            // 
            // mission1ToolStripMenuItem
            // 
            this.mission1ToolStripMenuItem.Name = "mission1ToolStripMenuItem";
            this.mission1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission1ToolStripMenuItem.Text = "Mission 1";
            this.mission1ToolStripMenuItem.Click += new System.EventHandler(this.mission1ToolStripMenuItem_Click);
            // 
            // mission2ToolStripMenuItem
            // 
            this.mission2ToolStripMenuItem.Name = "mission2ToolStripMenuItem";
            this.mission2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission2ToolStripMenuItem.Text = "Mission 2";
            this.mission2ToolStripMenuItem.Click += new System.EventHandler(this.mission2ToolStripMenuItem_Click);
            // 
            // mission3ToolStripMenuItem
            // 
            this.mission3ToolStripMenuItem.Name = "mission3ToolStripMenuItem";
            this.mission3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission3ToolStripMenuItem.Text = "Mission 3";
            this.mission3ToolStripMenuItem.Click += new System.EventHandler(this.mission3ToolStripMenuItem_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem missionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission3ToolStripMenuItem;
    }
}