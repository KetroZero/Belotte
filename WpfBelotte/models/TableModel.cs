using CompteurBelotteWindowsForm;
using Microsoft.TeamFoundation.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfBelotte.models
{
    public class TableModel : ViewModelBase
    {
        private Paquet table;
        private List<CarteModel> cartesModel;
        public TableModel(Paquet table)
        {
            this.table = table;

            cartesModel = new List<CarteModel>();
            foreach (Carte c in table.getAllCards())
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
    }
}
