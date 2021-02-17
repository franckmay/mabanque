using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque.modele
{
    class Operation
    {
        private int id;
        private string type;
        private DateTime date;
        private double montant;
        private string motif;
        private int compte1;
        private int compte2;



        public Operation()
        {

        }
        public Operation(string type, double montant, string motif, int compte1)
        {
            this.type = type; this.montant = montant; this.motif = motif; this.compte1 = compte1;
        }
        public Operation(string type, double montant, string motif, int compte1, int compte2)
        {
            this.type = type; this.montant = montant; this.motif = motif; this.compte1 = compte1; this.compte2 = compte2;

        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public double Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }

        public string Motif
        {
            get
            {
                return motif;
            }

            set
            {
                motif = value;
            }
        }

        public int Compte1
        {
            get
            {
                return compte1;
            }

            set
            {
                compte1 = value;
            }
        }

        public int Compte2
        {
            get
            {
                return compte2;
            }

            set
            {
                compte2 = value;
            }
        }



    }
}
