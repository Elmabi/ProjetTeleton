using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetTeleton
{
    public partial class FenetreAccueil : Form
    {
        public FenetreAccueil()
        {
            InitializeComponent();

            // Les infos du projets sont cachées par défaut
            pnlInformations.Visible = false;
            pnlTelethonDesc.Visible = false;
        }


        #region CET SESSION PERMET DE MOUVOIR CET FENÊTRE

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Permet de mouvoir la fenêtre à travers le bouton gauche de la souris
        private void FenetreAccueil_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } 
        #endregion

        // Boutton pour ouvrir la page de connexion afin de rentrer l'utilisateur + mot de passe
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FenetreConnexion fenetreConnexion = new FenetreConnexion();
            pnlInformations.Visible = false;
            pnlTelethonDesc.Visible = false;
            fenetreConnexion.ShowDialog();
            this.Hide();
        }

        private void btnQuitterLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       // Affichage des infos du projet
        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnlInformations.Visible = !pnlInformations.Visible;
            pnlTelethonDesc.Visible = !pnlTelethonDesc.Visible;
        }  
    }
}
