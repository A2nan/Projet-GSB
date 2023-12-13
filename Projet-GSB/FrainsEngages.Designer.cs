namespace Projet_GSB
{
    partial class FFrainsEngages
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
            this.BSFrainsEngages = new System.Windows.Forms.BindingSource(this.components);
            this.DGVFrainsEngages = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BSFrainsEngages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFrainsEngages)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFrainsEngages
            // 
            this.DGVFrainsEngages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFrainsEngages.Location = new System.Drawing.Point(12, 34);
            this.DGVFrainsEngages.Name = "DGVFrainsEngages";
            this.DGVFrainsEngages.Size = new System.Drawing.Size(1102, 157);
            this.DGVFrainsEngages.TabIndex = 12;
            this.DGVFrainsEngages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFrainsEngages_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FFrainsEngages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVFrainsEngages);
            this.Name = "FFrainsEngages";
            this.Text = "FrainsEngages";
            this.Load += new System.EventHandler(this.FrainsEngages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSFrainsEngages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFrainsEngages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BSFrainsEngages;
        private System.Windows.Forms.DataGridView DGVFrainsEngages;
        private System.Windows.Forms.Button button1;
    }
}