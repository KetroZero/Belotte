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
        private Carte coupe;

        bool init = false;
        public CouperJeu()
        {
            InitializeComponent();

            comboValeur.DataSource = Enum.GetValues(typeof(Rang));
            comboValeur.DropDownStyle = ComboBoxStyle.DropDownList;

            comboCouleur.DataSource = Enum.GetValues(typeof(Couleur));
            comboCouleur.DropDownStyle = ComboBoxStyle.DropDownList;

            comboValeur.SelectedIndex = 0;
            comboCouleur.SelectedIndex = 0;

            init = true;
            //coupe = new Carte((Rang)comboValeur.SelectedItem, (Couleur)comboCouleur.SelectedItem, false);
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

        private void comboCouleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (init)
            {
                coupe = new Carte((Rang)comboValeur.SelectedItem, (Couleur)comboCouleur.SelectedItem, false);
            }
        }

        private void comboValeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (init)
            {
                coupe = new Carte((Rang)comboValeur.SelectedItem, (Couleur)comboCouleur.SelectedItem, false);
            }
        }

        private void buttonPairDessus_Click(object sender, EventArgs e)
        {
            Program.pilePair.FusionnerAvec(Program.pileImpair);
            buttonPairDessus.Enabled = false;
            buttonImpairDessus.Enabled = false;
        }

        private void buttonImpairDessus_Click(object sender, EventArgs e)
        {
            Program.pileImpair.FusionnerAvec(Program.pilePair);
            buttonImpairDessus.Enabled = false;
            buttonPairDessus.Enabled = false;
        }

        private void buttonCouper_Click(object sender, EventArgs e)
        {
            Form form = new DistribuerEtMontrer();
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show();
            this.Close();
        }

    }
}
