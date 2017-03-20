using CompteurBelotteWindowsForm;
using Microsoft.TeamFoundation.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfBelotte.models
{
    public class JoueurModel : ViewModelBase
    {
        private Joueur joueur;
        private List<CarteModel> cartesModel;                    

        public JoueurModel(Joueur j)
        {
            this.joueur = j;

            cartesModel = new List<CarteModel>();
            foreach (Carte c in joueur.getAllCards())
            {
                cartesModel.Add(new CarteModel(c));
            }
        }

        public List<CarteModel> ImagesCartes
        {
            get
            {
                return cartesModel;
            }
        }

        public string Nom
        {
            get { return joueur.nom; }
            set { joueur.nom = value; }
        }

        public int Numero
        {
            get { return joueur.numero; }
            set { joueur.numero = value; }
        }

        public string Equipe
        {
            get { return joueur.equipe.ToString(); }
        }

    }
}
