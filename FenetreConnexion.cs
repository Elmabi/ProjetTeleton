using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetTeleton
{
    public partial class FenetreConnexion : Form
    {
        private const string NOM_UTILISATEUR = "2021";
        private const string MOT_DE_PASSE = "2021";
        int count = 0; // Pour ne pas permettre plus de 3 essaies d'échec connexion 

        public FenetreConnexion()
        {
            InitializeComponent();
        }
        private void btnConnexion2_Click(object sender, EventArgs e)
        {
            string utilisateur = txtUsername.Text;
            string mdp = txtPassword.Text;

            if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(mdp))
            {
                // Si les variables contiennent des valeurs, comparaison avec les valeurs attendues.
                if (utilisateur == NOM_UTILISATEUR && mdp == MOT_DE_PASSE)
                {
                    this.Close();
                    FenetrePrincipale fenetrePrincipale = new FenetrePrincipale();
                    fenetrePrincipale.Show();

                }
                else
                {
                    // Nous sélectionnons le texte saisi dans txtUtilisateur et nous lui donnons le focus.
                    MessageBox.Show("Entrees non valides.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtUsername.SelectAll();
                    txtUsername.Focus();

                    count++; // incremente de 1 a chaque mauvais essaie
                    if (count >= 3)
                    {
                        MessageBox.Show("Vous avez epuisé vos trois essaies, veuillez réessayer plus tard!"
                            , "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtUsername.Focus();
            }
        }

        private void btnReessayer_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Nom d'utilisateur";
            txtPassword.Text = "Mot de Passe";
            txtUsername.SelectAll();
            txtUsername.Focus();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //On s'assure que l'utilisateur veut fermer
            DialogResult reponse;
            reponse = MessageBox.Show("Desirez vous quitter ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si c'est le cas, on ferme
            if (reponse == DialogResult.Yes) Application.Exit();
           
                
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
            txtUsername.Focus();
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }


    }
}
