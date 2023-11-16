namespace Projet_GSB
{
    partial class FConsultInfo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.Label();
            this.textRue = new System.Windows.Forms.Label();
            this.textCp = new System.Windows.Forms.Label();
            this.textVille = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(29, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(731, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "CONSULTEZ VOS INFORMATIONS NOMINATIVES";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNom
            // 
            this.textNom.AutoSize = true;
            this.textNom.Location = new System.Drawing.Point(270, 133);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(32, 13);
            this.textNom.TabIndex = 1;
            this.textNom.Text = "NOM";
            // 
            // textPrenom
            // 
            this.textPrenom.AutoSize = true;
            this.textPrenom.Location = new System.Drawing.Point(270, 164);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(54, 13);
            this.textPrenom.TabIndex = 2;
            this.textPrenom.Text = "PRENOM";
            // 
            // textRue
            // 
            this.textRue.AutoSize = true;
            this.textRue.Location = new System.Drawing.Point(270, 201);
            this.textRue.Name = "textRue";
            this.textRue.Size = new System.Drawing.Size(30, 13);
            this.textRue.TabIndex = 3;
            this.textRue.Text = "RUE";
            // 
            // textCp
            // 
            this.textCp.AutoSize = true;
            this.textCp.Location = new System.Drawing.Point(270, 238);
            this.textCp.Name = "textCp";
            this.textCp.Size = new System.Drawing.Size(82, 13);
            this.textCp.TabIndex = 4;
            this.textCp.Text = "CODE POSTAL";
            this.textCp.Click += new System.EventHandler(this.label4_Click);
            // 
            // textVille
            // 
            this.textVille.AutoSize = true;
            this.textVille.Location = new System.Drawing.Point(270, 274);
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(36, 13);
            this.textVille.TabIndex = 5;
            this.textVille.Text = "VILLE";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(375, 271);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxVille.TabIndex = 8;
            // 
            // textBoxCp
            // 
            this.textBoxCp.Location = new System.Drawing.Point(375, 235);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(100, 20);
            this.textBoxCp.TabIndex = 9;
            // 
            // textBoxRue
            // 
            this.textBoxRue.Location = new System.Drawing.Point(375, 198);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(100, 20);
            this.textBoxRue.TabIndex = 10;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(375, 161);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 11;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(375, 130);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 12;
            // 
            // FConsultInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxRue);
            this.Controls.Add(this.textBoxCp);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textVille);
            this.Controls.Add(this.textCp);
            this.Controls.Add(this.textRue);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textBox1);
            this.Name = "FConsultInfo";
            this.Text = "FConsultInfo";
            this.Load += new System.EventHandler(this.FConsultInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textNom;
        private System.Windows.Forms.Label textPrenom;
        private System.Windows.Forms.Label textRue;
        private System.Windows.Forms.Label textCp;
        private System.Windows.Forms.Label textVille;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
    }
}