﻿namespace Projet_GSB
{
    partial class Mission3
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DGVFiche = new System.Windows.Forms.DataGridView();
            this.BSFiche = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remplir Frais d\'Engageement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consulté vos fiches";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DGVFiche
            // 
            this.DGVFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFiche.Location = new System.Drawing.Point(12, 12);
            this.DGVFiche.Name = "DGVFiche";
            this.DGVFiche.Size = new System.Drawing.Size(777, 363);
            this.DGVFiche.TabIndex = 2;
            this.DGVFiche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFiche_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modifier ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Mission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DGVFiche);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Mission3";
            this.Text = " Mission 3";
            this.Load += new System.EventHandler(this.Mission3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSFiche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DGVFiche;
        private System.Windows.Forms.BindingSource BSFiche;
        private System.Windows.Forms.Button button3;
    }
}