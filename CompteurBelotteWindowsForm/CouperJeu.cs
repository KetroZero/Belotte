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
        }

        private void buttonRetournerPair_Click(object sender, EventArgs e)
        {
            Program.pilePair.RetournerPaquet();
            buttonRetournerPair.Text = (buttonRetournerPair.Text == "Annuler") ? "Retourner pile paire" : "Annuler";
        }

        private void buttonRetournerImpair_Click(object sender, EventArgs e)
        {
            Program.pileImpair.RetournerPaquet();
            buttonRetournerImpair.Text = (buttonRetournerImpair.Text == "Annuler") ? "Retourner pile impaire" : "Annuler";
        }


        private void buttonPairDessus_Click(object sender, EventArgs e)
        {
            Program.pilePair.FusionnerAvec(Program.pileImpair);
            Program.pilePair.RetournerPaquet();

            buttonPairDessus.Enabled = false;
            buttonImpairDessus.Enabled = false;
        }

        private void buttonImpairDessus_Click(object sender, EventArgs e)
        {
            Program.pileImpair.FusionnerAvec(Program.pilePair);
            Program.pileImpair.RetournerPaquet();

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
