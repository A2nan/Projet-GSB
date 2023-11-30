namespace Projet_GSB
{
    partial class FmodifMdp
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
            this.mdpcurrent = new System.Windows.Forms.Label();
            this.Newmdp = new System.Windows.Forms.Label();
            this.Verifmdp = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mdpnew = new System.Windows.Forms.TextBox();
            this.currentmdp = new System.Windows.Forms.TextBox();
            this.mdpverif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mdpcurrent
            // 
            this.mdpcurrent.AutoSize = true;
            this.mdpcurrent.Location = new System.Drawing.Point(187, 186);
            this.mdpcurrent.Name = "mdpcurrent";
            this.mdpcurrent.Size = new System.Drawing.Size(162, 13);
            this.mdpcurrent.TabIndex = 0;
            this.mdpcurrent.Text = "Entrez votre mot de passe actuel";
            this.mdpcurrent.Click += new System.EventHandler(this.mdpcurrent_Click);
            // 
            // Newmdp
            // 
            this.Newmdp.AutoSize = true;
            this.Newmdp.Location = new System.Drawing.Point(183, 231);
            this.Newmdp.Name = "Newmdp";
            this.Newmdp.Size = new System.Drawing.Size(175, 13);
            this.Newmdp.TabIndex = 1;
            this.Newmdp.Text = "Entrez votre nouveau mot de passe";
            // 
            // Verifmdp
            // 
            this.Verifmdp.AutoSize = true;
            this.Verifmdp.Location = new System.Drawing.Point(179, 272);
            this.Verifmdp.Name = "Verifmdp";
            this.Verifmdp.Size = new System.Drawing.Size(179, 13);
            this.Verifmdp.TabIndex = 2;
            this.Verifmdp.Text = "Verifiez votre nouveau mot de passe";
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(677, 398);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 3;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(579, 398);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(75, 23);
            this.Annuler.TabIndex = 4;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 54);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "MODIFIEZ VOTRE MOT DE PASSE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mdpnew
            // 
            this.mdpnew.Location = new System.Drawing.Point(377, 231);
            this.mdpnew.Name = "mdpnew";
            this.mdpnew.Size = new System.Drawing.Size(192, 20);
            this.mdpnew.TabIndex = 6;
            // 
            // currentmdp
            // 
            this.currentmdp.Location = new System.Drawing.Point(377, 186);
            this.currentmdp.Name = "currentmdp";
            this.currentmdp.Size = new System.Drawing.Size(192, 20);
            this.currentmdp.TabIndex = 7;
            this.currentmdp.TextChanged += new System.EventHandler(this.currentmdp_TextChanged);
            // 
            // mdpverif
            // 
            this.mdpverif.Location = new System.Drawing.Point(377, 269);
            this.mdpverif.Name = "mdpverif";
            this.mdpverif.Size = new System.Drawing.Size(192, 20);
            this.mdpverif.TabIndex = 8;
            // 
            // FmodifMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mdpverif);
            this.Controls.Add(this.currentmdp);
            this.Controls.Add(this.mdpnew);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Verifmdp);
            this.Controls.Add(this.Newmdp);
            this.Controls.Add(this.mdpcurrent);
            this.Name = "FmodifMdp";
            this.Text = "FmodifMdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mdpcurrent;
        private System.Windows.Forms.Label Newmdp;
        private System.Windows.Forms.Label Verifmdp;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox mdpnew;
        private System.Windows.Forms.TextBox currentmdp;
        private System.Windows.Forms.TextBox mdpverif;
    }
}