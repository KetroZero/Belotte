using System.Collections.Generic;

namespace CompteurBelotteWindowsForm
{
    public class Joueur
    {
        public int numero;
        public string name;
        public Paquet cartes;

        public Joueur(int numeroDeJoueur)
        {
            numero = numeroDeJoueur;
            cartes = new Paquet();
        }
        public Joueur(int numeroDeJoueur,string nomDeJoueur)
        {
            numero = numeroDeJoueur;
            name = nomDeJoueur;
            cartes = new Paquet();
        }

        public void ajouterCarte(Carte c)
        {
            cartes.AjouterAuPaquet(c);
        }

        public void jouerCarte(Carte c)
        {
            cartes.Remove(c);
        }

        public int getNbCard()
        {
            return cartes.getLength();
        }

        public string voirCartes()
        {
            string retour = string.Empty;

            for (int i = 0; i < cartes.getLength();i++ )
            {
                retour += "[" + cartes.getCarte(i).ToString() + "], ";
            }

            return retour;
        }

        public string voirCartesShort()
        {
            string retour = string.Empty;
            for (int i = 0; i < cartes.getLength(); i++)
            {
                retour += "[" + cartes.getCarte(i).ToShortString() + "], ";
            }

            return retour;
        }
    }
}
