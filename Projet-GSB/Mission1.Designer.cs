﻿namespace Projet_GSB
{
    partial class Mission1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consulterEtMàjInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterSesRésponsabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMdpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterEtMàjInfoToolStripMenuItem,
            this.consulterSesRésponsabilitéToolStripMenuItem,
            this.modifierMdpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consulterEtMàjInfoToolStripMenuItem
            // 
            this.consulterEtMàjInfoToolStripMenuItem.Name = "consulterEtMàjInfoToolStripMenuItem";
            this.consulterEtMàjInfoToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.consulterEtMàjInfoToolStripMenuItem.Text = "Consulter et màj info";
            this.consulterEtMàjInfoToolStripMenuItem.Click += new System.EventHandler(this.consulterEtMàjInfoToolStripMenuItem_Click);
            // 
            // consulterSesRésponsabilitéToolStripMenuItem
            // 
            this.consulterSesRésponsabilitéToolStripMenuItem.Name = "consulterSesRésponsabilitéToolStripMenuItem";
            this.consulterSesRésponsabilitéToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.consulterSesRésponsabilitéToolStripMenuItem.Text = "Consulter ses résponsabilité";
            // 
            // modifierMdpToolStripMenuItem
            // 
            this.modifierMdpToolStripMenuItem.Name = "modifierMdpToolStripMenuItem";
            this.modifierMdpToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.modifierMdpToolStripMenuItem.Text = "modifier mdp";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Mission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mission1";
            this.Text = "Mission 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consulterEtMàjInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterSesRésponsabilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMdpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

