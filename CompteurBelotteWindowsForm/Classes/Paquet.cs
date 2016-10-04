using System;
using System.Collections.Generic;

namespace CompteurBelotteWindowsForm
{
    public class Paquet
    {
        private List<Carte> cartes;

        public Paquet()
        {
            cartes = new List<Carte>();
        }

        public Paquet(bool random)
        {
            cartes = new List<Carte>();

            foreach (Couleur c in Enum.GetValues(typeof(Couleur)))
            {
                foreach (Rang r in Enum.GetValues(typeof(Rang)))
                {
                    cartes.Add(new Carte(r, c));
                }
            }

            if (random)
            {
                Melanger();
            }
        }

        public void Distribuer3Cartes(Joueur j)
        {
            DistribuerNCartes(j, 3);
        }
        public void Distribuer2Cartes(Joueur j)
        {
            DistribuerNCartes(j, 2);
        }

        public void DistribuerAtout(Joueur j)
        {
            j.ajouterCarte(Distribuer());
        }

        public Carte montrerAtout()
        {
            return getCarte(0);
        }

        public Carte getCarte(int index)
        {
            return cartes[index];
        }

        public void AjouterAuPaquet(Carte c)
        {
            cartes.Add(c);
        }

        public void RetournerPaquet()
        {
            cartes.Reverse();
        }

        public void FusionnerAvec(Paquet p)
        {
            cartes.AddRange(p.cartes);
        }

        public void Couper(Carte derniere)
        {
            int index = cartes.IndexOf(derniere);
            if (index >= 0 && index < cartes.Count - 1)
            {
                index++; //  get next card
                List<Carte> move = cartes.GetRange(index, cartes.Count - index);
                cartes.RemoveRange(index, cartes.Count - index);
                cartes.InsertRange(0, move);
            }
        }

        public void Remove(Carte c)
        {
            cartes.Remove(c);
        }

        public int getLength()
        {
            return cartes.Count;
        }

        public bool isInPaquet(Carte c)
        {
            c.SetAtout(false);

            return cartes.Contains(c);
        }

        public void SetCouleurAtout(Couleur couleur)
        {
            foreach (Carte c in cartes)
            {
                c.atout = (c.couleur == couleur);
            }
        }

        /**********************/
        // ##### Private #####
        /**********************/

        private void DistribuerNCartes(Joueur j, int nbcartes)
        {
            for (int i = 0; i < nbcartes; i++)
            {
                j.ajouterCarte(Distribuer());
            }
        }
        private void Melanger()
        {
            System.Random r = new System.Random();

            int n = 32;
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                Carte temp = cartes[k];
                cartes[k] = cartes[n];
                cartes[n] = temp;
            }
        }

        private Carte Distribuer()
        {
            Carte c = getCarte(0);
            cartes.RemoveAt(0);
            return c;
        }

    }
}
