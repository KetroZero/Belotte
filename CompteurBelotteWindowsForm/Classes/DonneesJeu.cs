using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompteurBelotteWindowsForm
{
    static class DonneesJeu
    {
        public static int maxScore = 1000;
        public static int tours;

        public static Joueur J1, J2, J3, J4;
        public static Joueur donneur;
            
        public static Paquet pilePair;
        public static Paquet pileImpair;

        public static List<int> pointsPairsParManche;
        public static List<int> pointsImpairsParManche;

        public static string imgPath = "C:/Users/Utilisateur/Documents/Projets_Visual_Studio/BelotteWindowsForm/CompteurBelotteWindowsForm/Resources/";

        //private static string dir = Directory.GetParent(Application.StartupPath).Parent.FullName;
        //public static string imgPath = Path.Combine(dir, "Resources");
        //"C:/Users/Utilisateur/Documents/Projets_Visual_Studio/BelotteWindowsForm/CompteurBelotteWindowsForm/Resources/";
    }
}
