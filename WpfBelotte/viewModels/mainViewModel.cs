using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompteurBelotteWindowsForm;
using WpfBelotte.models;
using Microsoft.TeamFoundation.MVVM;

namespace WpfBelotte.viewModels
{
    public class mainViewModel : ViewModelBase
    {
        //****************
        //** Constantes 
        //****************
        private const int nbJoueurs = 4;

        //****************
        //** Private 
        //****************

        private Joueur[] joueurs;
        private JoueurModel[] joueursModel;
        private TableModel table;

        //****************
        //** Public 
        //****************
        public int maxScore = 1000;
        public int tours = 0;

        public int idDonneur = 0;

        public Paquet paquetJeu;

        public Paquet pilePair;
        public Paquet pileImpair;

        public List<int> pointsPairsParManche;
        public List<int> pointsImpairsParManche;



        public mainViewModel()
        {
            joueurs = new Joueur[nbJoueurs]
            {
                new Joueur(4,"J4"),            
                new Joueur(1,"J1"),
                new Joueur(2,"J2"),
                new Joueur(3,"J3")
            };

            //joueursModel = new JoueurModel[nbJoueurs]
            // {
            //     new JoueurModel(joueurs[0]),
            //     new JoueurModel(joueurs[1]),
            //     new JoueurModel(joueurs[2]),
            //     new JoueurModel(joueurs[3])
            // };

            pilePair = new Paquet();
            pileImpair = new Paquet();

            pointsPairsParManche = new List<int>();
            pointsImpairsParManche = new List<int>();

            paquetJeu = new Paquet(false);

            InitFirstPlay();
        }

        public JoueurModel[] Joueurs
        {
            get { return joueursModel; }
        }

        public TableModel Table
        {
            get { return table; }
        }

        private void InitFirstPlay()
        {
            for (int i = idDonneur + 1; i < idDonneur + 1 + nbJoueurs; i++)
            {
                paquetJeu.Distribuer3Cartes(joueurs[i % nbJoueurs]);
                paquetJeu.Distribuer2Cartes(joueurs[i % nbJoueurs]);
                paquetJeu.Distribuer3Cartes(joueurs[i % nbJoueurs]);
            }

            joueursModel = new JoueurModel[nbJoueurs]
            {
                new JoueurModel(joueurs[0]),
                new JoueurModel(joueurs[1]),
                new JoueurModel(joueurs[2]),
                new JoueurModel(joueurs[3])
            };

            var tableTemp = new Paquet();
            tableTemp.AjouterAuPaquet(new Carte(Rang.As, Couleur.Carreau));
            tableTemp.AjouterAuPaquet(new Carte(Rang.As, Couleur.Carreau));
            tableTemp.AjouterAuPaquet(new Carte(Rang.As, Couleur.Carreau));
            tableTemp.AjouterAuPaquet(new Carte(Rang.As, Couleur.Carreau));
            table = new TableModel(tableTemp);
        }
    }
}
