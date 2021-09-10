using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Don
    {
        private string idDon;
        private double montantDuDon;
        private string dateDuDon;
        private string idDonateur;

        public Don(string idDon, double montantDuDon, string dateDuDon, string idDonateur)
        {
            this.idDon = idDon;
            this.montantDuDon = montantDuDon;
            this.dateDuDon = dateDuDon;
            this.idDonateur = idDonateur;
        }

        public string IdDon
        {
            get { return idDon; }
            set { idDon = value; }
        }
        public string DateDuDon
        {
            get { return dateDuDon; }
            set { dateDuDon = value; }
        }
        public double MontantDuDon
        {
            get { return montantDuDon; }
            set { montantDuDon = value; }
        }

        public string IdDonateur
        {
            get { return idDonateur; }
            set { idDonateur = value; }
        }

        public override string ToString()
        {
            return "id du don: " + this.idDon
                + "\r\nMontant du don: " + this.montantDuDon
                + "\r\nDate du don: " + this.dateDuDon
                + "\r\nId du donateur: " + this.idDonateur;
        }
    }
}


