using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteurBelotteWindowsForm
{
    public class Carte
    {
        public int valeur;
        public Rang rang;
        public Couleur couleur;
        public bool atout;

        private bool verso; // cote verso, carte_dos.bmp
        /// <summary>
        /// Creer un instance de la class carte
        /// </summary>
        /// <param name="rank">Rang de la carte (de 7 à As) </param>
        /// <param name="color">Couleur de la carte</param>
        /// <param name="asset">La couleur de la carte est un atout, faux par defaut</param>
        public Carte(Rang rank, Couleur color, bool asset = false)
        {
            rang = rank;
            couleur = color;
            atout = asset;

            verso = false;
            valeur = rankToValeur(rank, asset);
        }
        public Carte()
        {
            valeur = -10;
            verso = true;
        }

        public Carte(string imageName, bool atout = false)
        {
            string[] cardArgs = imageName.Split(new char[] { '_', '.' });

            switch (cardArgs[0])
            {
                default: verso = true;
                    break; // throw Exception ??

                case "A": rang = Rang.As;
                    break;
                case "K": rang = Rang.Roi;
                    break;
                case "Q": rang = Rang.Dame;
                    break;
                case "J": rang = Rang.Valet;
                    break;
                case "10": rang = Rang.Dix;
                    break;
                case "9": rang = Rang.Neuf;
                    break;
                case "8": rang = Rang.Huit;
                    break;
                case "7": rang = Rang.Sept;
                    break;
            }

            switch (cardArgs[1])
            {
                default: verso = true;
                    break; // throw Exception ??

                case "Ca": couleur = Couleur.Carreau;
                    break;
                case "Co": couleur = Couleur.Coeur;
                    break;
                case "P": couleur = Couleur.Pique;
                    break;
                case "T": couleur = Couleur.Trefle;
                    break;
            }

            this.atout = atout;

            valeur = rankToValeur(rang, atout);
        }

        public void SetAtout(bool atout)
        {
            this.atout = atout;
            valeur = rankToValeur(rang, atout);
        }

        public bool isCarte(string description)
        {
            char[] carteChar = description.ToUpper().ToCharArray();

            // too many character
            if (carteChar.Length > 3)
            {
                return false;
            }

            // too few character
            if (carteChar.Length < 2)
            {
                return false;
            }

            // in case input is DIX (10) AS = 'A' DIX = '1' ou "10"
            if (carteChar.Length == 3)
            {
                carteChar[0] = '1';
                carteChar[1] = carteChar[2];
            }



            switch (carteChar[0])
            {
                default: return false;

                case 'A': rang = Rang.As;
                    break;
                case 'R': rang = Rang.Roi;
                    break;
                case 'D': rang = Rang.Dame;
                    break;
                case 'V': rang = Rang.Valet;
                    break;
                case '1': rang = Rang.Dix;
                    break;
                case '9': rang = Rang.Neuf;
                    break;
                case '8': rang = Rang.Huit;
                    break;
                case '7': rang = Rang.Sept;
                    break;

            }

            switch (carteChar[1])
            {
                default: return false;

                case 'D': couleur = Couleur.Carreau;
                    break;
                case 'S': couleur = Couleur.Pique;
                    break;
                case 'C': couleur = Couleur.Trefle;
                    break;
                case 'H': couleur = Couleur.Coeur;
                    break;
            }

            valeur = rankToValeur(rang, false);

            //all ok
            return true;
        }

        override public string ToString()
        {
            return rang.ToString() + " de " + couleur.ToString();
        }

        public string ToShortString()
        {
            string rank = "initR";
            string color = "initC";

            switch (rang)
            {
                default: rank = "-1";
                    break;

                case Rang.As: rank = "A";
                    break;
                case Rang.Sept: rank = "7";
                    break;
                case Rang.Huit: rank = "8";
                    break;
                case Rang.Neuf: rank = "9";
                    break;
                case Rang.Dix: rank = "10";
                    break;
                case Rang.Valet: rank = "V";
                    break;
                case Rang.Dame: rank = "D";
                    break;
                case Rang.Roi: rank = "R";
                    break;
            }

            switch (couleur)
            {
                default: color = "-2";
                    break;
                case Couleur.Carreau: color = "Ca";
                    break;
                case Couleur.Coeur: color = "Co";
                    break;
                case Couleur.Pique: color = "Pi";
                    break;
                case Couleur.Trefle: color = "Tr";
                    break;
            }

            return rank + color;
        }

        private int rankToValeur(Rang rank, bool asset)
        {
            if (verso)
            {
                return -10; //verso, not visible card
            }

            switch (rank)
            {
                default: return -1;

                case Rang.As: return 11;
                case Rang.Roi: return 4;
                case Rang.Dame: return 3;
                case Rang.Valet: return asset ? 20 : 2;
                case Rang.Dix: return 10;
                case Rang.Neuf: return asset ? 14 : 0;  // float 0.09
                case Rang.Huit: return 0;               // float 0.08
                case Rang.Sept: return 0;               // float 0.07
            }

        }

        public override bool Equals(Object obj)
        {
            Carte test = obj as Carte;
            return this.rang.Equals(test.rang) && this.couleur == test.couleur;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string ToImageLocation()
        {
            if (verso)
            {
                return "carte_dos.bmp";
            }

            string card = "init";

            switch (rang)
            {
                default: card = "carte";
                    break;

                case Rang.As: card = "A";
                    break;
                case Rang.Roi: card = "K";
                    break;
                case Rang.Dame: card = "Q";
                    break;
                case Rang.Valet: card = "J";
                    break;
                case Rang.Dix: card = "10";
                    break;
                case Rang.Neuf: card = "9";
                    break;
                case Rang.Huit: card = "8";
                    break;
                case Rang.Sept: card = "7";
                    break;
            }

            switch (couleur)
            {
                default: card += "_dos";
                    break;

                case Couleur.Carreau: card += "_Ca";
                    break;
                case Couleur.Coeur: card += "_Co";
                    break;
                case Couleur.Pique: card += "_P";
                    break;
                case Couleur.Trefle: card += "_T";
                    break;
            }

            card += ".bmp";

            return card;
        }
    }
}
