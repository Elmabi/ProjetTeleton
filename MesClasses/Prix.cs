using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Prix
    {
        private string idPrix;
        private string description;
        private double valeur;

        private int qnte_Originale;
        private int qnte_Disponible;
        private string idCommanditaire;

        public Prix(string iDPrix, string description, double valeur, int qnte_Originale, 
            int qnte_Disponible, string iDCommanditaire)
        {
            idPrix = iDPrix;
            this.description = description;
            this.valeur = valeur;
            this.qnte_Originale = qnte_Originale;
            this.qnte_Disponible = qnte_Disponible;
            idCommanditaire = iDCommanditaire;
        }

        public string IdPrix { get => idPrix; set => idPrix = value; }
        public string Description { get => description; set => description = value; }
        public double Valeur { get => valeur; set => valeur = value; }
        public int Qnte_Originale { get => qnte_Originale; set => qnte_Originale = value; }
        public int Qnte_Disponible { get => qnte_Disponible; set => qnte_Disponible = value; }
        public string IdCommanditaire { get => idCommanditaire; set => idCommanditaire = value; }

        public override string ToString()
        {
            string chaine = "Je suis " + description + ", mon Id : " + idPrix + ", ma valeur " + valeur
                + ", Qte originale : " + Qnte_Originale + ", Quantité disponible : " + Qnte_Disponible 
                + ", ID Commmanditaire:  " + idCommanditaire;
            return chaine;
        }

        public void Deduire(int nombre) { 
        }
    }
}
