using System;
using System.Collections.Generic;

namespace CompteurBelotteWindowsForm
{
    public class Paquet
    {
        protected List<Carte> cartes;
        private int capaciteMax;
        /// <summary>
        /// Create empty deck
        /// </summary>
        public Paquet(int capacite = 32)
        {
            cartes = new List<Carte>();
            capaciteMax = capacite;
        }

        /// <summary>
        /// Create full deck with 32 cards
        /// </summary>
        /// <param name="random">True to shuffle the deck, false to initiaite ordered full deck</param>
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
            DistribuerNCartes(j, 1);
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

        public List<Carte> getAllCards()
        {
            return cartes;
        }

        /// <summary>
        /// Add 4 cards in backward order
        /// </summary>
        public void AjouterAuPaquet(Carte c1, Carte c2, Carte c3, Carte c4)
        {
            cartes.Add(c4);
            cartes.Add(c3);
            cartes.Add(c2);
            cartes.Add(c1);
        }

        /// <summary>
        /// Reverse the order of the deck when couting points face up
        /// </summary>
        public void RetournerPaquet()
        {
            cartes.Reverse();
        }

        public void FusionnerAvec(Paquet p)
        {
            cartes.AddRange(p.cartes);
        }

        public void CouperAvecAtout(Carte retourne)
        {
            List<Carte> move = new List<Carte>();

            int index = cartes.IndexOf(retourne);

            int start = (index + 12) % 32; //  get end of pile

            for (int i = start; i < start + 20; i++) // insert 20 card before reveal Atout
            {
                move.Add(cartes[i % 32]);
            }

            //move.Reverse(); // reverse order to match dealing method

            foreach (Carte c in move)
            {
                cartes.Remove(c);
            }

            cartes.InsertRange(0, move); // add at top

            int newIdx = cartes.IndexOf(retourne);
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

        private void DistribuerNCartes(Paquet p, int nbcartes)
        {
            for (int i = 0; i < nbcartes; i++)
            {
                p.AjouterAuPaquet(getCarte(0));
                cartes.RemoveAt(0);
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

        public string voirCartes()
        {
            string retour = string.Empty;

            for (int i = 0; i < cartes.Count; i++)
            {
                retour += "[" + cartes[i].ToString() + "], ";
            }

            return retour;
        }

        public string voirCartesShort()
        {
            string retour = string.Empty;
            for (int i = 0; i < cartes.Count; i++)
            {
                retour += "[" + cartes[i].ToShortString() + "], ";
            }

            return retour;
        }
    }
}
