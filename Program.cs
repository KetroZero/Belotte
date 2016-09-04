using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteruBelotteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 32;
            int donneur = 2;

            Console.WriteLine("---- Initialisation du paquet ----");
            Paquet paquet = new Paquet();

            Console.WriteLine("Ajouter les cartes manuellement ? O/N");
            string manuel = Console.ReadLine();

            if (manuel.ToUpper() == "N")
            {

                Couleur c = Couleur.Carreau;
                paquet.AjouterAuPaquet(new Carte(Rang.As, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Roi, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dame, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Valet, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dix, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Neuf, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Huit, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Sept, c));

                c = Couleur.Coeur;
                paquet.AjouterAuPaquet(new Carte(Rang.As, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Roi, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dame, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Valet, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dix, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Neuf, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Huit, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Sept, c));

                c = Couleur.Pique;
                paquet.AjouterAuPaquet(new Carte(Rang.As, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Roi, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dame, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Valet, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dix, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Neuf, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Huit, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Sept, c));

                c = Couleur.Trefle;
                paquet.AjouterAuPaquet(new Carte(Rang.As, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Roi, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dame, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Valet, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Dix, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Neuf, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Huit, c));
                paquet.AjouterAuPaquet(new Carte(Rang.Sept, c));

                Console.WriteLine("----- Mode Automatique");
            }
            else
            {
                while (paquet.getLength() < max)
                {
                    Console.WriteLine("{0}/{1} -- Ajouter une carte: Spade / Heart / Club / Diamond", paquet.getLength(), max);
                    string InputCarte = Console.ReadLine();

                    Carte carte = new Carte();

                    if (carte.isCarte(InputCarte))
                    {
                        paquet.AjouterAuPaquet(carte);
                    }
                    else
                    {
                        Console.WriteLine("Typing error. Try again");
                    }
                }
            }

            Console.WriteLine("-- Paquet Complet --");
            Console.WriteLine("---- Couper ----");

            Carte carteCoupe;
            string InputCarteCoupe = "init";
            do
            {
                carteCoupe = new Carte();
                Console.WriteLine("Derniere carte après coupe ? ");
                InputCarteCoupe = Console.ReadLine();

                if (!carteCoupe.isCarte(InputCarteCoupe))
                {
                    Console.WriteLine("Typing error. Try again");
                }
            }
            while (!carteCoupe.isCarte(InputCarteCoupe));

            Console.WriteLine("Before ###" + paquet.getCarte(0));
            paquet.Couper(carteCoupe);
            Console.WriteLine("After " + paquet.getCarte(0) + "###");

            Console.WriteLine("-- Jeu coupé --");

            Joueur[] joueurs = new Joueur[4] {  new Joueur(1),
                                                new Joueur(2),
                                                new Joueur(3),
                                                new Joueur(4)
                                             };

            for (int i = donneur; i < donneur + 4; i++)
            {
                paquet.Distribuer3Cartes(joueurs[i % 4]);
                Console.WriteLine("3 cartes distribuées -- J{0}", joueurs[i % 4].numero);
            }

            for (int i = donneur; i < donneur + 4; i++)
            {
                paquet.Distribuer2Cartes(joueurs[i % 4]);
                Console.WriteLine("2 cartes distribuées --J{0}", joueurs[i % 4].numero);
            }

            Console.WriteLine("---- Retourner ATOUT ----");
            Console.WriteLine("Atout: " + paquet.montrerAtout().ToString() + " # " + paquet.montrerAtout().ToShortString());

            for (int i = donneur; i < donneur + 4; i++)
            {
                Console.WriteLine("Main J{0} - {1}", joueurs[i % 4].numero, joueurs[i % 4].voirCartes());
            }

            Console.WriteLine("----- Joueur 2 prend l'atout ATOUT -----");
            paquet.DistribuerAtout(joueurs[1]); // joueur 2 prend l'atout
            paquet.Distribuer3Cartes(joueurs[0]);
            paquet.Distribuer2Cartes(joueurs[1]);// joueur 2 prend 2 cartes seulement
            paquet.Distribuer3Cartes(joueurs[2]);
            paquet.Distribuer3Cartes(joueurs[3]);
            Console.WriteLine("---- Cartes distribuées ----");

            for (int i = donneur; i < donneur + 4; i++)
            {
                Console.WriteLine("Main J{0} - {1}", joueurs[i % 4].numero, joueurs[i % 4].voirCartesShort());
            }

            Console.ReadLine();
        }
    }
}
