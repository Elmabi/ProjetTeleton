using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public abstract class Personne
    {
        private string prenom;
        private string surnom;

        public Personne(string prenom, string surnom)
        {
            this.Surnom = surnom;
            this.Prenom = prenom;
        }

        public string Prenom { get => prenom; set => prenom = value; }
        public string Surnom { get => surnom; set => surnom = value; }

        public override string ToString()
        {
            return "Mon prénom est " + Prenom + " et mon surnom est " + Surnom;
        }
    }
}
