using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteurBelotteWindowsForm
{
    class TurnCommand 
    {
        public Paquet source { get; private set; }
        public Paquet destination { get; private set; }
        public Carte carte { get; private set; }


        public TurnCommand(Paquet source, Paquet destination, Carte carte)
        {
            this.source = source;
            this.destination = destination;
            this.carte = carte;

            Transferer();
        }

        private void Transferer()
        {
            destination.AjouterAuPaquet(carte);
            source.Remove(carte);
        }

        public void Annuler()
        {
            source.AjouterAuPaquet(carte);
            destination.Remove(carte);
        }
    }
}
