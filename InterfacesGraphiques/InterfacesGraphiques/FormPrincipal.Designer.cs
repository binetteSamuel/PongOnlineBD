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
            this.buttonGestionFacture = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGestionEquipe
            // 
            this.buttonGestionEquipe.Location = new System.Drawing.Point(29, 41);
            this.buttonGestionEquipe.Name = "buttonGestionEquipe";
            this.buttonGestionEquipe.Size = new System.Drawing.Size(152, 23);
            this.buttonGestionEquipe.TabIndex = 0;
            this.buttonGestionEquipe.Text = "Gestion des équipes";
            this.buttonGestionEquipe.UseVisualStyleBackColor = true;
            this.buttonGestionEquipe.Click += new System.EventHandler(this.buttonGestionEquipe_Click);
            // 
            // buttonJoueur
            // 
            this.buttonJoueur.Location = new System.Drawing.Point(29, 12);
            this.buttonJoueur.Name = "buttonJoueur";
            this.buttonJoueur.Size = new System.Drawing.Size(152, 23);
            this.buttonJoueur.TabIndex = 0;
            this.buttonJoueur.Text = "Gestion des joueurs";
            this.buttonJoueur.UseVisualStyleBackColor = true;
            this.buttonJoueur.Click += new System.EventHandler(this.buttonJoueur_Click);
            // 
            // buttonGestionParties
            // 
            this.buttonGestionParties.Location = new System.Drawing.Point(29, 70);
            this.buttonGestionParties.Name = "buttonGestionParties";
            this.buttonGestionParties.Size = new System.Drawing.Size(152, 23);
            this.buttonGestionParties.TabIndex = 0;
            this.buttonGestionParties.Text = "Gestion des parties";
            this.buttonGestionParties.UseVisualStyleBackColor = true;
            this.buttonGestionParties.Click += new System.EventHandler(this.buttonGestionParties_Click);
            // 
            // buttonGestionTournois
            // 
            this.buttonGestionTournois.Location = new System.Drawing.Point(29, 99);
            this.buttonGestionTournois.Name = "buttonGestionTournois";
            this.buttonGestionTournois.Size = new System.Drawing.Size(152, 23);
            this.buttonGestionTournois.TabIndex = 0;
            this.buttonGestionTournois.Text = "Gestion des tournois";
            this.buttonGestionTournois.UseVisualStyleBackColor = true;
            this.buttonGestionTournois.Click += new System.EventHandler(this.buttonGestionTournois_Click);
            // 
            // buttonGestionFacture
            // 
            this.buttonGestionFacture.Location = new System.Drawing.Point(29, 128);
            this.buttonGestionFacture.Name = "buttonGestionFacture";
            this.buttonGestionFacture.Size = new System.Drawing.Size(152, 23);
            this.buttonGestionFacture.TabIndex = 0;
            this.buttonGestionFacture.Text = "Gestion des factures";
            this.buttonGestionFacture.UseVisualStyleBackColor = true;
            this.buttonGestionFacture.Click += new System.EventHandler(this.buttonGestionFacture_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(29, 158);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(152, 23);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 271);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonJoueur);
            this.Controls.Add(this.buttonGestionFacture);
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
        private System.Windows.Forms.Button buttonGestionFacture;
        private System.Windows.Forms.Button buttonClient;
    }
}

