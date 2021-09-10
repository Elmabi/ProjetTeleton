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

    /* Cet fénêtre permet d'afficher le prix gagné par un donateur. 
     * Le constructeur prend en paramètre le nom et le prenom du donateur en question 
     * et l'affiche sur un label
     */
    public partial class FenetreAffichagePrix : Form
    {


        public FenetreAffichagePrix(string nomPrenomDonateur)
        {

            InitializeComponent();
            lblPrixFormPrix.Text = nomPrenomDonateur;
        }

        private void btnOKFormPrix_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
