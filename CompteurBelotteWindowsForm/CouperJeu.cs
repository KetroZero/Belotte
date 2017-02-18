using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompteurBelotteWindowsForm
{
    public partial class CouperJeu : Form
    {
        public CouperJeu()
        {
            InitializeComponent();
            labelPair.Text = DonneesJeu.J1.name + " et " + DonneesJeu.J3.name + " (Impair)";
            labelImpair.Text = DonneesJeu.J2.name + " et " + DonneesJeu.J4.name + " (Pair)";
        }

        private void buttonRetournerPair_Click(object sender, EventArgs e)
        {
            DonneesJeu.pilePair.RetournerPaquet();
            buttonRetournerPair.Text = (buttonRetournerPair.Text == "Annuler") ? "Compter et retourner la pile paire" : "Annuler";
        }

        private void buttonRetournerImpair_Click(object sender, EventArgs e)
        {
            DonneesJeu.pileImpair.RetournerPaquet();
            buttonRetournerImpair.Text = (buttonRetournerImpair.Text == "Annuler") ? "Compter et retourner la pile impaire" : "Annuler";
        }


        private void buttonPairDessus_Click(object sender, EventArgs e)
        {
            DonneesJeu.pilePair.FusionnerAvec(DonneesJeu.pileImpair);
            DonneesJeu.pilePair.RetournerPaquet();

            buttonPairDessus.Enabled = false;
            buttonImpairDessus.Enabled = false;
        }

        private void buttonImpairDessus_Click(object sender, EventArgs e)
        {
            DonneesJeu.pileImpair.FusionnerAvec(DonneesJeu.pilePair);
            DonneesJeu.pileImpair.RetournerPaquet();

            buttonImpairDessus.Enabled = false;
            buttonPairDessus.Enabled = false;
        }

        private void buttonCouper_Click(object sender, EventArgs e)
        {
            Form form = new Distribuer();
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show();
            this.Close();
        }

    }
}
