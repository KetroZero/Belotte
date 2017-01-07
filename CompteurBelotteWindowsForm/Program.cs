using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompteurBelotteWindowsForm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DonneesJeu.J1 = new Joueur(1, "J1");
            DonneesJeu.J2 = new Joueur(2, "J2");
            DonneesJeu.J3 = new Joueur(3, "J3");
            DonneesJeu.J4 = new Joueur(0, "J4");

            DonneesJeu.pilePair = new Paquet();
            DonneesJeu.pileImpair = new Paquet();
            DonneesJeu.pointsPairsParManche = new List<int>();
            DonneesJeu.pointsImpairsParManche = new List<int>();

            DonneesJeu.tours = 0;

            Application.Run(new CreationEquipe());
        }
    }
}
