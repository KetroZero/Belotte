﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteruBelotteConsole
{
    public class Carte
    {

        public int valeur;
        public Rang nom;
        public Couleur couleur;
        public bool atout;

        /// <summary>
        /// Creer un instance de la class carte
        /// </summary>
        /// <param name="rank">Rang de la carte (de 7 à As) </param>
        /// <param name="color">Couleur de la carte</param>
        /// <param name="asset">La couleur de la carte est un atout, faux par defaut</param>
        public Carte(Rang rank, Couleur color, bool asset = false)
        {
            nom = rank;
            couleur = color;
            atout = asset;

            valeur = rankToValeur(rank, asset);
        }
        public Carte()
        {
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

                case 'A': nom = Rang.As;
                    break;
                case 'R': nom = Rang.Roi;
                    break;
                case 'D': nom = Rang.Dame;
                    break;
                case 'V': nom = Rang.Valet;
                    break;
                case '1': nom = Rang.Dix;
                    break;
                case '9': nom = Rang.Neuf;
                    break;
                case '8': nom = Rang.Huit;
                    break;
                case '7': nom = Rang.Sept;
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

            valeur = rankToValeur(nom, false);

            //all ok
            return true;
        }

        override public string ToString()
        {
            if (nom == null || couleur == null)
            {
                return "nom couleur";
            }
            else
            {
                return nom.ToString() + " de " + couleur.ToString();
            }
        }

        public string ToShortString()
        {
            string rank = "initR";
            string color = "initC";

            switch (nom)
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
                case Couleur.Carreau: color = "D";
                    break;
                case Couleur.Coeur: color = "H";
                    break;
                case Couleur.Pique: color = "S";
                    break;
                case Couleur.Trefle: color = "C";
                    break;
            }

            return rank + color;
        }

        private int rankToValeur(Rang rank, bool asset)
        {
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
            return this.nom.Equals(test.nom) && this.couleur == test.couleur;
        }
    }
}
