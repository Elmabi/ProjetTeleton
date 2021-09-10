using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MesClasses;

namespace ProjetTeleton {
    public partial class FenetreSelectionDonateur : Form {

        public String IdDonnateurSelectionne { get; set; }

        // Le constructeur reçoit en argument un string qui sert à construire la liste des items
        // dans le comboBox
        public FenetreSelectionDonateur(string listeDonateur) {
            InitializeComponent();

            listeDonateur = listeDonateur.Remove(listeDonateur.Length - 1);
            String[] liste = listeDonateur.Split(';');

            for (int i = 0; i < liste.Length; i++) {
                cmbSelectDonnateur.Items.Add(liste[i]);
            }   
        }

        // Sert à prendre la sélection de l'utilisateur et garder uniquement le ID du donateur pour le mettre
        // dans un textBox temporaire
        private void cmbSelectDonnateur_SelectedIndexChanged(object sender, EventArgs e) {
            String donnateurSelectionne = cmbSelectDonnateur.SelectedItem.ToString();
            int positionSeparateur = donnateurSelectionne.IndexOf(' ');
            this.IdDonnateurSelectionne = donnateurSelectionne.Substring(0, positionSeparateur);
            txtIdDonnateurTemp.Text = IdDonnateurSelectionne;
        }

        // Renvoi la valeur du textBox à la fénêtre principale
        private void btnSelectionner_Click(object sender, EventArgs e) {
            this.IdDonnateurSelectionne = txtIdDonnateurTemp.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Active le boutton uniquement lorsque l'utilisateur fait une selection.
        private void txtIdDonnateurTemp_TextChanged(object sender, EventArgs e) {
            btnSelectionner.Enabled = true;
            btnSelectionner.BackColor = Color.FromArgb(48, 169, 222);
            btnSelectionner.ForeColor = Color.Black;
        }

       
    }
}
