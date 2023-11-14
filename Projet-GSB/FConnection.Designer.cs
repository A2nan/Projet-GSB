namespace Projet_GSB
{
    partial class FConnection
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.Identifiant = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.connexion = new System.Windows.Forms.Button();
            this.messageinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 89);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(334, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtmdp
            // 
            this.txtmdp.Location = new System.Drawing.Point(100, 149);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.PasswordChar = '*';
            this.txtmdp.Size = new System.Drawing.Size(334, 20);
            this.txtmdp.TabIndex = 1;
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(31, 92);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(53, 13);
            this.Identifiant.TabIndex = 2;
            this.Identifiant.Text = "Identifiant";
            this.Identifiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(23, 152);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(71, 13);
            this.mdp.TabIndex = 3;
            this.mdp.Text = "Mot de passe";
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(100, 261);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(70, 25);
            this.connexion.TabIndex = 4;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = true;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // messageinfo
            // 
            this.messageinfo.AutoSize = true;
            this.messageinfo.Location = new System.Drawing.Point(97, 211);
            this.messageinfo.Name = "messageinfo";
            this.messageinfo.Size = new System.Drawing.Size(0, 13);
            this.messageinfo.TabIndex = 5;
            this.messageinfo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageinfo);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.Identifiant);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.txtid);
            this.Name = "FConnection";
            this.Text = "FConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.Label messageinfo;
    }
}