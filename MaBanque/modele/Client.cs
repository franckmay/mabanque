using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque.modele
{
    class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string date_naissance;
        private string adresse;
        private string telephone;
        private List<int> comptes = new List<int>();


        public Client()
        {

        }
        public Client(int id, string nom, string prenom, string date_naissance, string adresse, string telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.adresse = adresse;
            this.telephone = telephone;
        }
        public int NUMCL
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

        public string NOM
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string PRENOM
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string DATENAISSSANCE
        {
            get
            {
                return date_naissance;
            }

            set
            {
                date_naissance = value;
            }
        }
        public string ADRESSE
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }
        public string TELEPHONE
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        internal List<int> Comptes
        {
            get
            {
                return comptes;
            }

            set
            {
                comptes = value;
            }
        }

        public void ajouterCompte(int c)
        {

            this.comptes.Add(c);
        }
        public void supprimerCompte(int c)
        {

            this.comptes.Remove(c);
        }



    }
}
