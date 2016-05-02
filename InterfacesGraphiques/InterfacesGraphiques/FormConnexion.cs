using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesGraphiques
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string commandText = "";

            try
            {

                #region Étape 1 : Établir la connexion avec la base de données

                con = new SqlConnection(Properties.Settings.Default.pongdevConnectionString);
                con.Open();

                #endregion

                #region Étape 2 : Inscrire la commande à exécuter

                // Créer la commande à exécuter
                commandText = "SELECT MotDePasse FROM joueurs WHERE Nom = @NOM"; // Commande à exécuter.
                cmd = new SqlCommand(commandText); // Création de la commande
                cmd.Connection = con; // Association de la commande avec la connexion

                // Ajouter le paramète (Plus sécuritaire)
                // @DA : Le nom du paramètre
                // System.Data.SqlDbType.Varchar : Son type
                // -1 : Sa taille dans la table
                // DA : Son nom dans la table
                cmd.Parameters.Add(new SqlParameter("@NOM", System.Data.SqlDbType.VarChar, -1, "NOM"));

                // Récupère la valeur entrée dans la zone de texte
                cmd.Parameters["@NOM"].Value = textBoxNomUtilisateur.Text;

                #endregion

                #region Étape 3 : Exécuter la commande

                rdr = cmd.ExecuteReader();

                // Effectuer le traitement
                // Affiche le nom de l'élève
                if (rdr.HasRows)
                {
                    rdr.Read();
                    textBoxMotDePasse.Text = rdr["MotDePasse"].ToString();
                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé");
                }

            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Fermer le SqlDataReader 
                if (rdr != null)
                {
                    rdr.Close();
                }

                #endregion

                #region Étape 4 : Fermer la connexion

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                #endregion
            }
        }
    }
}
