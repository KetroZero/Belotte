using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompteurBelotteWindowsForm
{
    static class Program
    {
        public static int maxScore = 1000;
        public static int tours;

        public static Joueur J1, J2, J3, J4;
        public static Paquet pilePair;
        public static Paquet pileImpair;
        public static string imgPath = "C:/Users/Utilisateur/Documents/Projets_Visual_Studio/BelotteWindowsForm/CompteurBelotteWindowsForm/Resources/";
        public static ComptePoints comptePoints;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            J1 = new Joueur(1, "J1");
            J2 = new Joueur(2, "J2");
            J3 = new Joueur(3, "J3");
            J4 = new Joueur(4, "J4");

            pilePair = new Paquet();
            pileImpair = new Paquet();

            tours = 0;
            comptePoints = new ComptePoints();
            comptePoints.Hide();

            Application.Run(new CreationEquipe());
        }
    }
}
