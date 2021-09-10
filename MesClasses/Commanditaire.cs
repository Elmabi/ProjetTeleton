using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
  
    public class Commanditaire : Personne
    {

        private string idCommanditaire;

        public Commanditaire (string idCommanditaire, string prenom, string surnom) : base (prenom, surnom)
        {
            this.idCommanditaire = idCommanditaire;
        }

        public string IdCommanditaire { get => idCommanditaire; set => idCommanditaire = value; }

        public override string ToString()
        {
            return base.ToString() +  "idCommanditaire # " + this.idCommanditaire + "\r\n";
        }
    }
}


