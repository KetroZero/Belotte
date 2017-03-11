using System.Collections.Generic;

namespace CompteurBelotteWindowsForm
{
    public class Joueur : Paquet
    {
        public int numero {get;set;}
        public string nom { get; set; }
        public Equipe equipe { get; set; }

        public Joueur(int numeroDeJoueur)
        {
            joueur(numeroDeJoueur);
        }

        public Joueur(int numeroDeJoueur, string nomDeJoueur)
        {
            this.nom = nomDeJoueur; 
            joueur(numeroDeJoueur);
        }

        private void joueur(int numeroDeJoueur)
        {
            this.numero = numeroDeJoueur;
            this.cartes = new List<Carte>();
            this.equipe = numeroDeJoueur % 2 == 0 ? Equipe.Paire : Equipe.Impaire;
        }
    }
}
