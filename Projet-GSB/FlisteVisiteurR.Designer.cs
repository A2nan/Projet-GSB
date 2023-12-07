namespace Projet_GSB
{
    partial class FlisteVisiteurR
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
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(229, 66);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 21);
            this.cboRegion.TabIndex = 0;
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.AllowUserToAddRows = false;
            this.dgvVisiteur.AllowUserToDeleteRows = false;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(103, 118);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.Size = new System.Drawing.Size(550, 258);
            this.dgvVisiteur.TabIndex = 1;
            this.dgvVisiteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.bsRegion_CurrentChanged);
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(390, 66);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboSecteur.TabIndex = 2;
            // 
            // FlisteVisiteurR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboSecteur);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.cboRegion);
            this.Name = "FlisteVisiteurR";
            this.Text = "FlisteVisiteurR";
            this.Load += new System.EventHandler(this.FlisteVisiteurR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.BindingSource bsSecteur;
    }
}