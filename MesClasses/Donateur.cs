using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Donateur : Personne
    {
     
        private string idDonateur;
        private string email;
        private string telephone;
        private char typeDeCarte;
        private string numeroDeCarte;
        private string dateExpiration;

        public Donateur(string prenom, string surnom, string idDonateur, string adresse, string telephone, char typeDeCarte, 
            string numeroDeCarte, string dateExpiration) : base (prenom, surnom)
        {
            this.idDonateur = idDonateur;
            this.email = adresse;
            this.telephone = telephone;
            this.typeDeCarte = typeDeCarte;
            this.numeroDeCarte = numeroDeCarte;
            this.dateExpiration = dateExpiration;
        }

        public override string ToString()
        {
            return "Prénom : " + base.Prenom
                +" Surnom : " + base.Surnom
                +" ID donateur : " + idDonateur
                + " - Adresse : " + email
                + " - Téléphone : " + telephone
                + "- Type de carte : " + typeDeCarte
                + " - # de carte : " + numeroDeCarte
                + " - Date d'expiration : " + dateExpiration + "\r\n";
        }

     
        public string IdDonateur
        {
            get { return idDonateur; }
            set { idDonateur = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public char TypeDeCarte
        {
            get { return typeDeCarte; }
            set { typeDeCarte = value; }
        }

        public string NumeroDeCarte
        {
            get { return numeroDeCarte; }
            set { numeroDeCarte = value; }
        }

        public string DateExpiration
        {
            get { return dateExpiration; }
            set { dateExpiration = value; }
        }
    }

}
