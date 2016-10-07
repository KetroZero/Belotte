using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompteurBelotteWindowsForm
{
    static class Program
    {
        public static int pointsPaire = 0;
        public static int pointsImpaire = 0;
        public static int maxScore = 1000;

        public static Joueur J1, J2, J3, J4;
        public static Paquet pilePair;
        public static Paquet pileImpair;
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

            Application.Run(new CreationEquipe());
        }
    }
}
