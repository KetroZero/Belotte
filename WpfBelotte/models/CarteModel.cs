using CompteurBelotteWindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.MVVM;

namespace WpfBelotte.models
{
    public class CarteModel : ViewModelBase
    {
        private Carte carte;
        public CarteModel(Carte carte)
        {
            this.carte = carte;
        }

        public string Couleur
        {
            get { return carte.couleur.ToString(); }
        }

        public string Valeur
        {
            get { return carte.valeur.ToString(); }
        }

        public string ImageString
        {
            get { return carte.ToImageLocation(); }
        }
    }
}
