using System.Collections.Generic;

namespace CompteruBelotteConsole
{
    public class Joueur
    {
        public int numero;
        public List<Carte> cartes;

        public Joueur(int numeroDeJoueur)
        {
            numero = numeroDeJoueur;
            cartes = new List<Carte>();
        }

        public void ajouterCarte(Carte c)
        {
            cartes.Add(c);
        }

        public void jouerCarte(Carte c)
        {
            cartes.Remove(c);
        }

        public string voirCartes()
        {
            string retour = string.Empty;
            foreach (Carte c in cartes)
            {
                retour += "[" + c.ToString() + "], ";
            }

            return retour;
        }

        public string voirCartesShort()
        {
            string retour = string.Empty;
            foreach (Carte c in cartes)
            {
                retour += "[" + c.ToShortString() + "], ";
            }

            return retour;
        }
    }
}
