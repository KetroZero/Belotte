using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteurBelotteWindowsForm
{
    class TurnCommand : Command
    {
        public Paquet source;
        public Paquet destination;

        public string action = "add";

        public TurnCommand(Paquet source, Paquet destination, string act)
        {
            this.source = source;
            this.destination = destination;
            action = act;
        }

        public override void Undo()
        {
            if (action == "add")
            {
                Remove(source, destination);
            }
            else
            {
                Add(source, destination);
            }
        }

        public override void Redo()
        {
            if (action == "add")
            {
                Add(source, destination);
            }
            else
            {
                Remove(source, destination);
            }
        }

        private void Add(Paquet source, Paquet destination)
        {
            destination.AjouterAuPaquet(source.getCarte(0));
        }

        private void Remove(Paquet source, Paquet destination)
        {
            source.AjouterAuPaquet(destination.getCarte(0));
        }
    }
}
