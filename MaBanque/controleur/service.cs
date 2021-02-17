using MaBanque.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque.controleur
{
    class Service
    {
        ClientDao cDao = new ClientDao();
        Connexion conn = new Connexion();
        bool resp = false;
        public Service()
        {

        }

        public bool Resp
        {
            get
            {
                return resp;
            }

            set
            {
                resp = value;
            }
        }

        public Client seconnecter(string log, string pass)
        {
            
            Client c = cDao.login(log, pass);

            if (c != null) { this.resp = true; }

            return c;
        }

    }
}
