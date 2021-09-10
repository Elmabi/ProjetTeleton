using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class GestionnaireSTE
    {
        private List<Donateur> donateurs = new List<Donateur>();
        private List<Commanditaire> commanditaires = new List<Commanditaire>();
        private List<Don> dons = new List<Don>();
        private List<Prix> prix = new List<Prix>();


        public void AjouterDonateur(string prenom, string surnom, string idDonateur, string email, string telephone
            , char typeDeCarte, string numeroCarte, string dateExpiration)
        {
            Donateur donateur = new Donateur(prenom, surnom, idDonateur, email, telephone, typeDeCarte, numeroCarte, dateExpiration);
            donateurs.Add(donateur);
        }

        public void AjouterCommanditaire( string idCommanditaire, string prenom, string surnom)
        {
            Commanditaire commanditaire = new Commanditaire(idCommanditaire,prenom, surnom);
            commanditaires.Add(commanditaire);
        }

        public void AjouterPrix(string idPrix, string description, double valeur, int qteOriginale,
            int qteDisponible, string iDCommanditaire)
        {
            Prix prixAjout = new Prix(idPrix, description, valeur, qteOriginale, qteDisponible, iDCommanditaire);
            prix.Add(prixAjout);
        }

        public void AjouterDon(string idDon, double montantDon, string dateDon, string idDonateur)
        {
            Don don = new Don(idDon, montantDon, dateDon, idDonateur);
            dons.Add(don);
        }

        public string AfficherDonateurs()
        {
            string chaine = "";
            foreach (var donateurs in donateurs)
            {
                chaine += donateurs.ToString() + "\n";
            }

            return chaine;
        }

        // Receuillir les données des donateurs 
        public string[] DonneeDonateurs()
        {
            string[] infoDonateur = new string[] { "" };
            foreach (var donateurs in donateurs)
            {
                infoDonateur = new string[] { donateurs.IdDonateur, donateurs.Prenom, donateurs.Surnom, donateurs.Email,
            donateurs.Telephone, donateurs.TypeDeCarte.ToString(), donateurs.NumeroDeCarte, donateurs.DateExpiration};
            }

            return infoDonateur;
        }

        // Receuillir les données des commanditaires
        public string[] DonneeCommanditaires()
        {
            string[] infoCommanditaire = new string[] { "" };
            foreach (var commanditaires in commanditaires)
            {
                infoCommanditaire = new string[] {commanditaires.IdCommanditaire, commanditaires.Prenom, commanditaires.Surnom};
            }

            return infoCommanditaire;
        }

        // Receuillir les données des Dons
        public string[] DonneeDon() {
            string[] infoDon = new string[] { "" };

            foreach (var dons in dons) {
                String montantFormat = String.Format("{0:C}", dons.MontantDuDon);
                infoDon = new string[] { dons.IdDon, montantFormat, dons.DateDuDon, dons.IdDonateur};
            }

            return infoDon;
        }

        // Receuillir les données des Prix
        public string[] DonneePrix() {
            string[] infoPrix = new string[] { "" };

            foreach (var varPrix in prix) {
                String valeurFormat = String.Format("{0:C}", varPrix.Valeur);
                infoPrix = new string[] { varPrix.IdPrix, varPrix.Description, valeurFormat, varPrix.Qnte_Disponible.ToString() };
            }

            return infoPrix;
        }

        public string AfficherCommanditaires()
        {
            string chaine = "";
            return chaine;
        }

        public string AfficherPrix()
        {
            string chaine = "";
            return chaine;
        }

        public string AfficherDons()
        {
            string chaine = "";
            foreach (var don in dons) {
                chaine += don.ToString() + "\r\n";
            }
            return chaine;
        }

        // Attribue les points selon le montant du Don
        public int AttribuerPrix(double montant)
        {
            if (montant >= 50 && montant < 200) {
                return 1;
            }
            if (montant >= 200 && montant < 350) {
                return 2;
            }
            if (montant >= 350 && montant < 500) {
                return 3;
            }
            if (montant >= 500) {
                montant = montant - 500;
                montant = Math.Floor(montant / 500) * 500;
                montant = montant / 500;
                return 5 + (4 * Convert.ToInt32(montant));
            }
            return 0;
        }

      
        public List<Donateur> Donateurs { get => donateurs; set => donateurs = value; }
        public List<Commanditaire> Commanditaires { get => commanditaires; set => commanditaires = value; }
        public List<Don> Dons { get => dons; set => dons = value; }
        public List<Prix> Prix { get => prix; set => prix = value; }
    }
}
