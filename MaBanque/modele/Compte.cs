using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque.modele
{
    class Compte
    {
        public static int increment_id = 0;
        private int id;
        private int titulaire;
        private double solde;
        private DateTime date_ouverture;
        private Client proprio;
        private double decouv = 0;

        public Compte() {
            this.id = increment_id;
            increment_id++;
        }
        public Compte( Client c)
        {
            this.id = increment_id;
            increment_id++;
            solde = 0;
            proprio = c;
            this.date_ouverture = DateTime.Now;
            this.proprio.ajouterCompte(this.ID);
        }

        public Compte(int titulaire, double solde, double decouv, Client c)
        {
            this.id = id;
            this.titulaire = titulaire;
            this.solde = solde;
            this.decouv = decouv;
            this.date_ouverture = DateTime.Now;
            proprio = c;
            this.proprio.ajouterCompte(this.ID);
        }

        //propriétés
        public int ID
        {
            get
            {
                return id;
            }

        }

        public int TITULAIRE
        {
            get
            {
                return titulaire;
            }

            set
            {
                titulaire = value;
            }
        }

        internal Client Proprio
        {
            get
            {
                return proprio;
            }
        }

        /// <param name="value"></param>
        /// <returns></returns>
        public bool setDecouv(double value)

        {

            bool res = false;

            if (this.solde > -value)
            {
                decouv = value;

                res = true;
            }


            return (res);

        }

        public string Description
        {
            get { return id + " " + titulaire + " " + " solde: " + solde + " Euros" + " - decouvert: " + Decouv + " Euros"; }
        }

        public double Decouv
        {
            get
            {
                return decouv;
            }
        }

        public double Solde
        {
            get
            {
                return solde;
            }

            set
            {
                solde = value;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="mont"></param>
        public bool crediter(double mont)
        {
            this.solde = this.solde + mont;
            return true;
        }
        /// <summary>
        /// </summary>
        /// <param name="mont"></param>
        /// <returns></returns>
        public bool débiter(double mont)
        {
            if (solde - mont < -decouv)
            {
                return false;
            }
            else
            {
                solde = solde - mont;
                return true;
            }
        }
    }
}
