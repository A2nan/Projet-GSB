namespace Projet_GSB
{
    partial class consult
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
            this.DGVFiche = new System.Windows.Forms.DataGridView();
            this.bsFiche = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBOMois = new System.Windows.Forms.ComboBox();
            this.bsMois = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiche)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFiche
            // 
            this.DGVFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFiche.Location = new System.Drawing.Point(12, 12);
            this.DGVFiche.Name = "DGVFiche";
            this.DGVFiche.Size = new System.Drawing.Size(560, 406);
            this.DGVFiche.TabIndex = 0;
            this.DGVFiche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFiche_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(600, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBOMois);
            this.panel1.Location = new System.Drawing.Point(600, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 164);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionné un mois";
            // 
            // CBOMois
            // 
            this.CBOMois.DataSource = this.bsMois;
            this.CBOMois.FormattingEnabled = true;
            this.CBOMois.Location = new System.Drawing.Point(126, 14);
            this.CBOMois.Name = "CBOMois";
            this.CBOMois.Size = new System.Drawing.Size(121, 21);
            this.CBOMois.TabIndex = 0;
            this.CBOMois.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // consult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DGVFiche);
            this.Name = "consult";
            this.Text = "consult";
            this.Load += new System.EventHandler(this.consult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiche)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFiche;
        private System.Windows.Forms.BindingSource bsFiche;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBOMois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsMois;
    }
}