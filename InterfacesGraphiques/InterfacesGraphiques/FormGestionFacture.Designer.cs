namespace InterfacesGraphiques
{
    partial class FormGestionFacture
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
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxNomUtilisateur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNbParties = new System.Windows.Forms.TextBox();
            this.textBoxTempsPrenuim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCoutTot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(190, 313);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 0;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // textBoxNomUtilisateur
            // 
            this.textBoxNomUtilisateur.Location = new System.Drawing.Point(186, 21);
            this.textBoxNomUtilisateur.Name = "textBoxNomUtilisateur";
            this.textBoxNomUtilisateur.Size = new System.Drawing.Size(102, 20);
            this.textBoxNomUtilisateur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de partie acheter";
            // 
            // textBoxNbParties
            // 
            this.textBoxNbParties.Location = new System.Drawing.Point(186, 47);
            this.textBoxNbParties.Name = "textBoxNbParties";
            this.textBoxNbParties.Size = new System.Drawing.Size(102, 20);
            this.textBoxNbParties.TabIndex = 1;
            // 
            // textBoxTempsPrenuim
            // 
            this.textBoxTempsPrenuim.Location = new System.Drawing.Point(186, 73);
            this.textBoxTempsPrenuim.Name = "textBoxTempsPrenuim";
            this.textBoxTempsPrenuim.Size = new System.Drawing.Size(102, 20);
            this.textBoxTempsPrenuim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de temps premium acheter";
            // 
            // textBoxCoutTot
            // 
            this.textBoxCoutTot.Location = new System.Drawing.Point(186, 97);
            this.textBoxCoutTot.Name = "textBoxCoutTot";
            this.textBoxCoutTot.Size = new System.Drawing.Size(102, 20);
            this.textBoxCoutTot.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Coût total";
            // 
            // FormGestionFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCoutTot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTempsPrenuim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNbParties);
            this.Controls.Add(this.textBoxNomUtilisateur);
            this.Controls.Add(this.buttonRechercher);
            this.Name = "FormGestionFacture";
            this.Text = "GestionFacture";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxNomUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNbParties;
        private System.Windows.Forms.TextBox textBoxTempsPrenuim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCoutTot;
        private System.Windows.Forms.Label label4;
    }
}