namespace InterfacesGraphiques
{
    partial class FormPrincipal
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
            this.buttonGestionEquipe = new System.Windows.Forms.Button();
            this.buttonJoueur = new System.Windows.Forms.Button();
            this.buttonGestionParties = new System.Windows.Forms.Button();
            this.buttonGestionTournois = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGestionEquipe
            // 
            this.buttonGestionEquipe.Location = new System.Drawing.Point(29, 96);
            this.buttonGestionEquipe.Name = "buttonGestionEquipe";
            this.buttonGestionEquipe.Size = new System.Drawing.Size(152, 23);
            this.buttonGestionEquipe.TabIndex = 0;
            this.buttonGestionEquipe.Text = "Gestion des équipes";
            this.buttonGestionEquipe.UseVisualStyleBackColor = true;
            // 
            // buttonJoueur
            // 
            this.buttonJoueur.Location = new System.Drawing.Point(29, 36);
            this.buttonJoueur.Name = "buttonJoueur";
            this.buttonJoueur.Size = new System.Drawing.Size(152, 23);
            this.buttonJoueur.TabIndex = 0;
            this.buttonJoueur.Text = "Gestion des joueurs";
            this.buttonJoueur.UseVisualStyleBackColor = true;
            // 
            // buttonGestionParties
            // 
            this.buttonGestionParties.Location = new System.Drawing.Point(29, 155);
            this.buttonGestionParties.Name = "buttonGestionParties";
            this.buttonGestionParties.Size = new System.Drawing.Size(152, 23);
            this.buttonGestionParties.TabIndex = 0;
            this.buttonGestionParties.Text = "Gestion des parties";
            this.buttonGestionParties.UseVisualStyleBackColor = true;
            // 
            // buttonGestionTournois
            // 
            this.buttonGestionTournois.Location = new System.Drawing.Point(29, 210);
            this.buttonGestionTournois.Name = "buttonGestionTournois";
            this.buttonGestionTournois.Size = new System.Drawing.Size(152, 23);
            this.buttonGestionTournois.TabIndex = 0;
            this.buttonGestionTournois.Text = "Gestion des tournois";
            this.buttonGestionTournois.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 271);
            this.Controls.Add(this.buttonJoueur);
            this.Controls.Add(this.buttonGestionTournois);
            this.Controls.Add(this.buttonGestionParties);
            this.Controls.Add(this.buttonGestionEquipe);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGestionEquipe;
        private System.Windows.Forms.Button buttonJoueur;
        private System.Windows.Forms.Button buttonGestionParties;
        private System.Windows.Forms.Button buttonGestionTournois;
    }
}

