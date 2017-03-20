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

        //Models
        private Joueur[] joueurs;// = new Joueur[4];
        private JoueurModel[] joueursModel;// = new JoueurModel[4];
        private ScoresModel scoresModel;
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


        public mainViewModel()
        {
            pilePair = new Paquet();
            pileImpair = new Paquet();

            paquetJeu = new Paquet(false);

            InitFirstPlay();
        }
        private void InitFirstPlay()
        {
            joueurs = new Joueur[nbJoueurs]
            {
                new Joueur(4,"J4"),            
                new Joueur(1,"J1"),
                new Joueur(2,"J2"),
                new Joueur(3,"J3")
            };

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

            var tableTemp = new Paquet(4);
            tableTemp.AjouterAuPaquet(new Carte("carte_dos"));
            tableTemp.AjouterAuPaquet(new Carte("carte_dos"));
            tableTemp.AjouterAuPaquet(new Carte("carte_dos"));
            tableTemp.AjouterAuPaquet(new Carte("carte_dos"));
            table = new TableModel(tableTemp);

            scoresModel = new ScoresModel();
        }

        public JoueurModel[] Joueurs
        {
            get { return joueursModel; }
        }
        public JoueurModel J1
        {
            get { return joueursModel[1]; }
        }
        public JoueurModel J2
        {
            get { return joueursModel[2]; }
        }
        public JoueurModel J3
        {
            get { return joueursModel[3]; }
        }
        public JoueurModel J4
        {
            get { return joueursModel[0]; }
        }

        public TableModel Table
        {
            get { return table; }
        }

        public ScoresModel Scores
        {
            get { return scoresModel; }
        }

   
    }
}
