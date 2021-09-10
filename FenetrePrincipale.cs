using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MesClasses;

namespace ProjetTeleton
{
    public partial class FenetrePrincipale : Form
    {
        #region Mes Constantes 
        private const string TEXT_PAR_DEFAUT_PRENOM = "Prénom";
        private const string TEXT_PAR_DEFAUT_ID_DONATEUR = "ID Donateur";
        private const string TEXT_PAR_DEFAUT_EMAIL = "E-mail (pas obligatoire)";
        private const string TEXT_VIDE = "";
        private const string TEXT_PAR_DEFAUT_NOM = "Nom";
        private const string TEXT_PAR_DEFAUT_TELEPHONE = "Téléphone";
        private const string TEXT_PAR_DEFAUT_MONTANT = "Montant";
        private const string TEXT_PAR_DEFAUT_ID_DON = "ID Don";
        private const string DONATEUR = "Donateur";
        private const string COMMANDITAIRE = "Commanditaire";   
        private const string PRIX = "Prix";
        private const string TEXT_A_DROIT_A_UN = " a droit à un ";
        private const string TEXT_PAR_DEFAUT_ID_COMMANDITAIRE = "ID Commanditaire";
        private const string TEXT_PAR_DEFAUT_ID_PRIX = "ID Prix";
        private const string TEXT_PAR_DEFAUT_DESCRIPTION = "Description";
        private const string TEXT_PAR_DEFAUT_VALEUR = "Valeur";
        private const string TEXT_PAR_DEFAUT_QUANTITE = "Quantité";
        private const char TYPE_CARTE_VISA = 'V';
        private const char TYPE_CARTE_MC = 'M';
        private const char TYPE_CARTE_AMEX = 'A';
        #endregion

        #region Mes Variables 
        private Color BLEU_FONCE = Color.FromArgb(1, 22, 39);
        GestionnaireSTE gestionaireSte = new GestionnaireSTE();
        #endregion

        
        public FenetrePrincipale()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            rbVisa.Checked = true;
        }

        #region MOUVOIR LA FENETRE 

        // Cet session permet de mouvoir la fenetre Principale
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlGauche_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        #endregion

    
        private void btnFermer_Click(object sender, EventArgs e)
        {
            string message = "Désirez-vous réellement quitter cette apllication ? ";
            string titre = "Attention";
            DialogResult reponse = MessageBox.Show(message, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes) Application.Exit();
        }

        private void btnMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnQuitterFenetrePrincipale_Click(object sender, EventArgs e)
        {
            string message = "Désirez-vous réellement vous déconnecter ? ";
            string titre = "Attention";
            DialogResult reponse = MessageBox.Show(message, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                new FenetreConnexion().Show();
                this.Close();
            }
        }


        #region VALIDATION D'INPUT
        // Les méthodes en dessous servent a validé les entrées de l'utilisateur dans les différents TextBox
        public char InputCarte()
        {
            //Par défaut le type la carte séletionner est Visa

            if (rbVisa.Checked) return TYPE_CARTE_VISA;
            if (rbMC.Checked) return TYPE_CARTE_MC;
            if (rbAmex.Checked) return TYPE_CARTE_AMEX;
            return TYPE_CARTE_VISA;
        }

        public string InputNumeroCarte()
        {
            string numeroCarte = txtNumeroCarte.Text;
            Regex regex = new Regex(@"^(((\d){4}(-)){3}(\d){4})$");
            if (regex.IsMatch(numeroCarte))
            {
                return numeroCarte;
            }
            return null;
        }

        public string InputTelephone()
        {
            string telephone = txtTelephone.Text;
            Regex regex = new Regex(@"^\((\d{3})\)(\d{3})\-(\d{4})$");
            if (regex.IsMatch(telephone))
            {
                return telephone;
            }
            return null;
        }

        public string InputEmail()
        {

            string email = txtEmail.Text;
            Regex regex = new Regex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$");
            bool isBonEmail = regex.IsMatch(email) || email == String.Empty;

            if (email == TEXT_PAR_DEFAUT_EMAIL) // l'email n'est pas obligatoire
            {
                return String.Empty;
            }
            if (isBonEmail)
            {
                return email;
            }
            string message = "L'email saisie n'est pas valide. Faites attention au format (example@example.ex)";
            string titre = "Attention";
            MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEmail.Focus();
            txtEmail.Text = String.Empty;

            return null;
        }

        public string InputValeurPrix()
        {
            string valeur = txtValeur.Text;
            Regex regex = new Regex(@"^(\d)*(\.|\,)?(\d){0,2}$");
            if (regex.IsMatch(valeur))
            {
                return valeur;
            }
            return null;
        }

        public string InputMontantDon()
        {
            string valeur = txtMontantDon.Text;
            Regex regex = new Regex(@"^(\d)*(\.|\,)?(\d){0,2}$");
            if (regex.IsMatch(valeur))
            {
                return valeur;
            }
            return null;
        }

        public string InputQuantite()
        {
            string quantiteStr = txtQuantite.Text;
            int quantite;

            if (int.TryParse(quantiteStr, out quantite))
            {
                return quantiteStr;
            }
            return null;
        }

        public void InputParDefaut(TextBox textbox, string message)
        {
            textbox.Text = message;
            textbox.ForeColor = Color.Gray;
        }

        // Permet de mettre tous les TextBox en valeur par défaut
        private void Reset()
        {
            InputParDefaut(txtPrenom, TEXT_PAR_DEFAUT_PRENOM);
            InputParDefaut(txtNom, TEXT_PAR_DEFAUT_NOM);
            InputParDefaut(txtEmail, TEXT_PAR_DEFAUT_EMAIL);
            InputParDefaut(txtTelephone, TEXT_PAR_DEFAUT_TELEPHONE);
            InputParDefaut(txtIdDonateur, TEXT_PAR_DEFAUT_ID_DONATEUR);
            InputParDefaut(txtIdDon, TEXT_PAR_DEFAUT_ID_DON);
            InputParDefaut(txtMontantDon, TEXT_PAR_DEFAUT_MONTANT);
            InputParDefaut(txtPrenomCommanditaire, TEXT_PAR_DEFAUT_PRENOM);
            InputParDefaut(txtNomCommanditaire, TEXT_PAR_DEFAUT_NOM);
            InputParDefaut(txtIdCommanditaire, TEXT_PAR_DEFAUT_ID_COMMANDITAIRE);
            InputParDefaut(txtIdPrix, TEXT_PAR_DEFAUT_ID_PRIX);
            InputParDefaut(txtDescription, TEXT_PAR_DEFAUT_DESCRIPTION);
            InputParDefaut(txtValeur, TEXT_PAR_DEFAUT_VALEUR);
            InputParDefaut(txtQuantite, TEXT_PAR_DEFAUT_QUANTITE);
            txtNumeroCarte.Text = String.Empty;
        }
        #endregion


        #region CHECK SI OBJET EXISTE DÉJÀ
        public bool IsCommanditaireExiste(string id)
        {
            foreach (var commanditaire in gestionaireSte.Commanditaires)
            {
                if (id == commanditaire.IdCommanditaire)
                {
                    MessageBox.Show("Ce Commanditaire avec l'id " + id + " existe déjà. Merci");
                    Reset();
                    return true;
                }
            }
            return false;
        }
        public bool IsDonateurExiste(string id)
        {
            foreach (var donateur in gestionaireSte.Donateurs)
            {
                if (id == donateur.IdDonateur)
                {
                    MessageBox.Show("Ce donateur avec l'id " + id + " existe déjà. Merci");
                    Reset();
                    return true;
                }
            }
            return false;
        }
        public bool IsDonExiste(string idDon)
        {
            foreach (var don in gestionaireSte.Dons)
            {
                if (idDon == don.IdDon)
                {
                    MessageBox.Show("Ce don avec l'id " + idDon + " existe déjà. Merci");
                    Reset();
                    return true;
                }
            }
            return false;
        }
        public bool IsPrixExiste(string idPrix)
        {
            foreach (var prix in gestionaireSte.Prix)
            {
                if (idPrix == prix.IdPrix)
                {
                    MessageBox.Show("Ce prix avec l'id " + idPrix + " existe déjà. Merci");
                    Reset();
                    return true;
                }
            }
            return false;
        } 
        #endregion


        private static void AjoutAvecSuccess(String chaine)
        {
            string message = $"{chaine} ajouter avec succès";
            MessageBox.Show(message);
        }

        // Affiche le message à l'utilisateur si l'input n'est pas valide sinon retourne l'input
        public String BonInput(object input, string text, string textPardefaut)
        {
            if (String.IsNullOrEmpty(text) || text == textPardefaut)
            {
                string message = "Le " + textPardefaut + " saisie n'est pas valide.";
                string titre = "Attention";
                MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Focus(input);
                return null;
            }

            return text;
        }

        // Met le Focus sur l'objet passé en paramétre si c'est un TextBox
        public void Focus(object input)
        {
            if (input is TextBox)
            {
                TextBox textBox = (TextBox)input;
                textBox.Text = String.Empty;
                textBox.ForeColor = BLEU_FONCE;
                textBox.Focus();
            }
        }
       
        // Retourne le nom du Donateur en fonction de son ID
        private String NomDonateur(string idDonateur)
        {
            string nomDonateur = "";
            foreach (var item in gestionaireSte.Donateurs)
            {
                if (idDonateur == item.IdDonateur)
                {
                    nomDonateur = $"{item.Prenom} {item.Surnom}";
                }
            }
            return nomDonateur;
        }

        private void btnAjouterDonateur_Click(object sender, EventArgs e)
        {
            RendreTousLesDataGridViewInvisible();

            string prenom = BonInput(txtPrenom, txtPrenom.Text, TEXT_PAR_DEFAUT_PRENOM); if (prenom == null) return;
            string surnom = BonInput(txtNom, txtNom.Text, TEXT_PAR_DEFAUT_NOM); if (surnom == null) return;
            string email = InputEmail(); if (email == null) return;
            string telephone = BonInput(txtTelephone, InputTelephone(), TEXT_PAR_DEFAUT_TELEPHONE); if (telephone == null) return;
            string id = BonInput(txtIdDonateur, txtIdDonateur.Text, TEXT_PAR_DEFAUT_ID_DONATEUR); if (id == null) return;
            if (IsDonateurExiste(id)) return;
            char typeDeCarte = InputCarte();
            string numeroDecarte = BonInput(txtNumeroCarte, InputNumeroCarte(), "numéro de la carte");
            if (numeroDecarte == null) return;
            string dateExpiration = BonInput(dateExpirationCarte, dateExpirationCarte.Text, TEXT_VIDE);

            // Après validation des inputs, elles sont stockées dans le Gestionaire STE et puis ajouter dans un
            //datagridView
            gestionaireSte.AjouterDonateur(prenom, surnom, id, email, telephone, typeDeCarte, numeroDecarte, dateExpiration);
            dgvInfoDonateur.Rows.Add(gestionaireSte.DonneeDonateurs());

            AjoutAvecSuccess(DONATEUR);
            Reset();
        }

        private void RendreTousLesDataGridViewInvisible()
        {
            dgvInfoDonateur.Visible = false;
            dgvInfoDon.Visible = false;
            dgvCommanditaire.Visible = false;
            dgvPrix.Visible = false;
        }

        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            bool isPasDeDonateur = gestionaireSte.Donateurs.Count <= 0;

            if (isPasDeDonateur)
            {
                MessageErreur("donateur");
                return;
            }

            // Permet d'afficher le dataGridView concerné et fermer les autres
            dgvInfoDon.Visible = false;
            dgvCommanditaire.Visible = false;
            dgvInfoDonateur.Visible = true;
            dgvPrix.Visible = false;
        }

        private void btnAjouterDon_Click(object sender, EventArgs e)
        {
            RendreTousLesDataGridViewInvisible();

            bool isDonnateurExiste = gestionaireSte.Donateurs.Count >= 1;

            if (!isDonnateurExiste)
            {
                String message = "Vous devez ajouter au moins un donateur avant de pouvoir ajouter un don";
                String titre = "Attention";
                MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string idDon = BonInput(txtIdDon, txtIdDon.Text, TEXT_PAR_DEFAUT_ID_DON); if (idDon == null) return;
            string montant = BonInput(txtMontantDon, InputMontantDon(), TEXT_PAR_DEFAUT_MONTANT); if (montant == null) return;
            DateTime date = DateTime.Now;

            // Ne permet d'entrer un don si le don existe déjà
            if (IsDonExiste(idDon)) return;

            String idDonnateur = txtIdDonateur.Text;
            bool isIdDonnateurManquant = (String.IsNullOrEmpty(idDonnateur) || idDonnateur == TEXT_PAR_DEFAUT_ID_DONATEUR);
            if (isIdDonnateurManquant)
            {
                idDonnateur = IdDonateurTrouve();
                
            }

            String dateFormat = date.ToShortDateString();
            String montantCorrectionVirgule = montant.Replace('.', ',');

            // Après validation des inputs, elles sont stockées dans le Gestionaire STE et puis ajouter dans un
            //datagridView
            gestionaireSte.AjouterDon(idDon, Double.Parse(montantCorrectionVirgule), dateFormat, idDonnateur);
            dgvInfoDon.Rows.Add(gestionaireSte.DonneeDon());
            Reset();

            // Calcule le nombre de points pour le prix selon le montant du don
            int pointsPrix = gestionaireSte.AttribuerPrix(Double.Parse(montantCorrectionVirgule));

            // Affiche le prix gagné et le nom du donateur sur une autre fenetre
            FenetreAffichagePrix affichePrix = new FenetreAffichagePrix(PrixGagne(pointsPrix, NomDonateur(idDonnateur)));
            affichePrix.ShowDialog();
        }

        private void btnAfficherDon_Click(object sender, EventArgs e)
        {
            bool isPasDeDon = gestionaireSte.Dons.Count <= 0;
            if (isPasDeDon)
            {
                MessageErreur("don");
                return;
            }

            // Permet d'afficher le dataGridView concerné et fermer les autres
            dgvInfoDon.Visible = true;
            dgvInfoDonateur.Visible = false;
            dgvCommanditaire.Visible = false;
            dgvPrix.Visible = false;

        }

        // Permet d'afficher une erreur s'il n'ya pas encore de don, de donateur, de commanditaire ou de prix.
        private  void MessageErreur(string chaine)
        {
            string message = "Actuellement vous n'avez aucun " + chaine + ". Merci";
            string titre = "Attention";
            MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAjouterCommanditaire_Click(object sender, EventArgs e)
        {
            RendreTousLesDataGridViewInvisible();

            string id = BonInput(txtIdCommanditaire, txtIdCommanditaire.Text, TEXT_PAR_DEFAUT_ID_COMMANDITAIRE); if (id == null) return;
            string prenom = BonInput(txtPrenomCommanditaire, txtPrenomCommanditaire.Text, TEXT_PAR_DEFAUT_PRENOM); if (prenom == null) return;
            string surnom = BonInput(txtNomCommanditaire, txtNomCommanditaire.Text, TEXT_PAR_DEFAUT_NOM); if (surnom == null) return;
            if (IsCommanditaireExiste(id)) return;

            // Après validation des inputs, elles sont stockées dans le Gestionaire STE et puis ajouter dans un
            //datagridView
            gestionaireSte.AjouterCommanditaire(id, prenom, surnom);
            dgvCommanditaire.Rows.Add(gestionaireSte.DonneeCommanditaires());

            AjoutAvecSuccess(COMMANDITAIRE);
            Reset();
        }

        private void btnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            bool isPasDeCommanditaire = gestionaireSte.Commanditaires.Count <= 0;
            if (isPasDeCommanditaire)
            {
                MessageErreur("commanditaire");
                return;
            }

            // Permet d'afficher le dataGridView concerné et fermer les autres
            dgvInfoDon.Visible = false;
            dgvCommanditaire.Visible = true;
            dgvInfoDonateur.Visible = false;
            dgvPrix.Visible = false;

        }

        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            RendreTousLesDataGridViewInvisible();

            string id = BonInput(txtIdPrix, txtIdPrix.Text, TEXT_PAR_DEFAUT_ID_PRIX); if (id == null) return;
            string description = BonInput(txtDescription, txtDescription.Text, TEXT_PAR_DEFAUT_DESCRIPTION); if (description == null) return;
            string valeur = BonInput(txtValeur, InputValeurPrix(), TEXT_PAR_DEFAUT_VALEUR); if (valeur == null) return;
            string quantite = BonInput(txtQuantite, InputQuantite(), TEXT_PAR_DEFAUT_QUANTITE); if (quantite == null) return;
            if (IsPrixExiste(id)) return;

            String valeurCorrectionVirgule = valeur.Replace('.', ',');

            // Après validation des inputs, elles sont stockées dans le Gestionaire STE et puis ajouter dans un
            //datagridView
            gestionaireSte.AjouterPrix(id, description, Double.Parse(valeurCorrectionVirgule), 0, int.Parse(quantite), "");
            dgvPrix.Rows.Add(gestionaireSte.DonneePrix());

            AjoutAvecSuccess(PRIX);
            Reset();
        }

        private void btnAfficherPrix_Click(object sender, EventArgs e)
        {
            if (gestionaireSte.Prix.Count <= 0)
            {
                MessageErreur("prix");
                return;
            }

            // Permet d'afficher le dataGridView concerné et fermer les autres
            dgvInfoDon.Visible = false;
            dgvCommanditaire.Visible = false;
            dgvInfoDonateur.Visible = false;
            dgvPrix.Visible = true;
        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {
            RendreTousLesDataGridViewInvisible();
        }

        // Fonction servant à trouver un ID Donateur si le txtBox ID Donateur est vide
        private String IdDonateurTrouve()
        {
            string idDonateur = "";
            String listeDonateur = "";

            // Permet de construire la liste du menu deroulant dans la fenetre trouve Id Donnateur
            foreach (var donateur in gestionaireSte.Donateurs)
            {
                int i = 0;
                listeDonateur += donateur.IdDonateur + " - " + donateur.Prenom + " " + donateur.Surnom + " - " + donateur.Telephone + ";";
                i++;
            }

            // Ça ouvre la fenetre pour trouve le Id du donnateur et reçoit la selection de l'utilisateur
            using (FenetreSelectionDonateur selectionDonateur = new FenetreSelectionDonateur(listeDonateur))
            {
                var retourSelectionDonnateur = selectionDonateur.ShowDialog();
                if (retourSelectionDonnateur == DialogResult.OK)
                {
                    idDonateur = selectionDonateur.IdDonnateurSelectionne;
                }
            }

            return idDonateur;
        }

        // Retourne le prix gagné en fonction du nombre de points obtenu selon le montant du don du donateur
        private String PrixGagne(int nombreDePoint, string nomDonateur)
        {
            String lePrix = TEXT_VIDE;

            if (nombreDePoint < 10)
            {
                return nomDonateur + TEXT_A_DROIT_A_UN + "calendrier";
            }
            if (nombreDePoint < 15)
            {
                return nomDonateur + TEXT_A_DROIT_A_UN + "repas pour deux";
            }
            if (nombreDePoint < 20)
            {
                return nomDonateur + TEXT_A_DROIT_A_UN + "BBQ";
            }
            if (nombreDePoint > 19)
            {
                return nomDonateur + TEXT_A_DROIT_A_UN + "téléviseur";
            }
            return lePrix;
        }


        #region METHODES POUR LES MOUSE ENTER, MOUSE LEAVE ET MOUSE HOVER SUR LES TEXTBOX

        // Remet le text par défaut quand la souris quitte le textBox
        public new void MouseLeave(string textParDefaut, string textVide, TextBox textBox)
        {
            if (textBox.Text == textVide)
            {
                textBox.Text = textParDefaut;
                textBox.ForeColor = Color.Gray;
            }
        }

        // Met  le text vide quand la souris entre dans  le textBox
        private new void MouseEnter(string textParDefaut, string textVide, TextBox textBox)
        {
            if (textBox.Text == textParDefaut)
            {
                textBox.Text = textVide;
                textBox.ForeColor = BLEU_FONCE;
            }
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_PRENOM, TEXT_VIDE, txtPrenom);
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            toolTipEntrees.SetToolTip(txtEmail, "utilisateur@courriel.com");
            toolTipEntrees.IsBalloon = true;
        }

        private void txtTelephone_MouseHover(object sender, EventArgs e)
        {
            toolTipEntrees.SetToolTip(txtTelephone, "(514)888-9999");
            toolTipEntrees.IsBalloon = true;

        }

        private void txtNumeroCarte_MouseHover(object sender, EventArgs e)
        {
            toolTipEntrees.SetToolTip(txtNumeroCarte, "9723-0000-0000-0000");
            toolTipEntrees.IsBalloon = true;
        }

        private void txtMontantDon_MouseHover(object sender, EventArgs e)
        {
            toolTipEntrees.SetToolTip(txtMontantDon, "12345.12");
            toolTipEntrees.IsBalloon = true;
        }

        private void txtIdDonateur_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_ID_DONATEUR, TEXT_VIDE, txtIdDonateur);
        }

        private void txtIdDonateur_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_ID_DONATEUR, TEXT_VIDE, txtIdDonateur);
        }

        private void txtIdDon_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_ID_DON, TEXT_VIDE, txtIdDon);
        }

        private void txtIdDon_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_ID_DON, TEXT_VIDE, txtIdDon);
        }

        private void txtPrenom_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_PRENOM, TEXT_VIDE, txtPrenom);
        }

        private void txtPrenom_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_PRENOM, TEXT_VIDE, txtPrenom);
        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_EMAIL, TEXT_VIDE, txtEmail);
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_EMAIL, TEXT_VIDE, txtEmail);
        }

        private void txtNom_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_NOM, TEXT_VIDE, txtNom);
        }

        private void txtNom_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_NOM, TEXT_VIDE, txtNom);
        }

        private void txtTelephone_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_TELEPHONE, TEXT_VIDE, txtTelephone);
        }

        private void txtTelephone_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_TELEPHONE, TEXT_VIDE, txtTelephone);
        }

        private void txtMontantDon_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_MONTANT, TEXT_VIDE, txtMontantDon);
        }

        private void txtMontantDon_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_MONTANT, TEXT_VIDE, txtMontantDon);
        }

        private void txtIdCommanditaire_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_ID_COMMANDITAIRE, TEXT_VIDE, txtIdCommanditaire);
        }

        private void txtIdCommanditaire_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_ID_COMMANDITAIRE, TEXT_VIDE, txtIdCommanditaire);
        }

        private void txtPrenomCommanditaire_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_PRENOM, TEXT_VIDE, txtPrenomCommanditaire);
        }

        private void txtPrenomCommanditaire_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_PRENOM, TEXT_VIDE, txtPrenomCommanditaire);
        }

        private void txtNomCommanditaire_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_NOM, TEXT_VIDE, txtNomCommanditaire);
        }

        private void txtNomCommanditaire_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_NOM, TEXT_VIDE, txtNomCommanditaire);
        }

        private void textboxIdPrix_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_ID_PRIX, TEXT_VIDE, txtIdPrix);
        }

        private void textboxIdPrix_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_ID_PRIX, TEXT_VIDE, txtIdPrix);
        }

        private void textboxDescription_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_DESCRIPTION, TEXT_VIDE, txtDescription);
        }

        private void textboxDescription_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_DESCRIPTION, TEXT_VIDE, txtDescription);
        }

        private void txtValeur_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_VALEUR, TEXT_VIDE, txtValeur);
        }

        private void txtValeur_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_VALEUR, TEXT_VIDE, txtValeur);
        }

        private void txtQuantite_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(TEXT_PAR_DEFAUT_QUANTITE, TEXT_VIDE, txtQuantite);
        }

        private void txtQuantite_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(TEXT_PAR_DEFAUT_QUANTITE, TEXT_VIDE, txtQuantite);
        }

        #endregion

    }
}
