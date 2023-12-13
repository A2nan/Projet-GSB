namespace Projet_GSB
{
    partial class FResponsable
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
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRegion1 = new System.Windows.Forms.DataGridView();
            this.bsRegion1 = new System.Windows.Forms.BindingSource(this.components);
            this.Nom = new System.Windows.Forms.Label();
            this.txtboxnom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegion
            // 
            this.dgvRegion.AllowUserToAddRows = false;
            this.dgvRegion.AllowUserToDeleteRows = false;
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(48, 155);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.ReadOnly = true;
            this.dgvRegion.Size = new System.Drawing.Size(225, 217);
            this.dgvRegion.TabIndex = 0;
            this.dgvRegion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegion_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(136, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "CONSULTEZ VOS RESPONSABILITES";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Régions Résponsable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Régions travaille";
            // 
            // dgvRegion1
            // 
            this.dgvRegion1.AllowUserToAddRows = false;
            this.dgvRegion1.AllowUserToDeleteRows = false;
            this.dgvRegion1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion1.Location = new System.Drawing.Point(518, 155);
            this.dgvRegion1.Name = "dgvRegion1";
            this.dgvRegion1.ReadOnly = true;
            this.dgvRegion1.Size = new System.Drawing.Size(241, 217);
            this.dgvRegion1.TabIndex = 4;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(302, 80);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(61, 13);
            this.Nom.TabIndex = 5;
            this.Nom.Text = "Votre nom :";
            this.Nom.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxnom
            // 
            this.txtboxnom.Location = new System.Drawing.Point(369, 77);
            this.txtboxnom.Name = "txtboxnom";
            this.txtboxnom.Size = new System.Drawing.Size(100, 20);
            this.txtboxnom.TabIndex = 6;
            // 
            // FResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxnom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.dgvRegion1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvRegion);
            this.Name = "FResponsable";
            this.Text = "FResponsable";
            this.Load += new System.EventHandler(this.FResponsable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRegion1;
        private System.Windows.Forms.BindingSource bsRegion1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox txtboxnom;
    }
}