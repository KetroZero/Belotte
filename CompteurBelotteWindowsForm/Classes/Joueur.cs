using System.Collections.Generic;

namespace CompteurBelotteWindowsForm
{
    public class Joueur : Paquet
    {
        public int numero;
        public string name;

        public Joueur(int numeroDeJoueur)
        {
            numero = numeroDeJoueur;
            cartes = new List<Carte>();
        }
        public Joueur(int numeroDeJoueur, string nomDeJoueur)
        {
            numero = numeroDeJoueur;
            name = nomDeJoueur;
            cartes = new List<Carte>();
        }
    }
}
