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
    public partial class ComptePoints : Form
    {
        private int scorePair = 1;
        private int scoreImpair = 150;

        private int totalPair = 0;
        private int totalImpair = 0;
        public ComptePoints()
        {
            InitializeComponent();

            labelPair1.Text = radioButtonPair.Text = DonneesJeu.J2.name + " et " + DonneesJeu.J4.name + " (Paire)";
            labelImpair1.Text = radioButtonImpair.Text = DonneesJeu.J1.name + " et " + DonneesJeu.J3.name + " (Impaire)";
        }

        public void SetPoints(int pair, int impair)
        {
            scorePair = pair;
            scoreImpair = impair;

            buttonSuivant.Enabled = false;
            buttonSuivant.Visible = false;
            buttonValide.Enabled = true;
        }

        private void ConvertScore(int pair, int impair, bool belottePair, bool belotteImpair)
        {
            totalPair = 0;
            totalImpair = 0;

            int modI = (impair % 10);
            int offsetI = (modI > 5) ? 10 - modI : -modI;

            int modP = (pair % 10);
            int offsetP = (modP > 5) ? 10 - modP : -modP;

            if (radioButtonImpair.Checked) // Impair à pris l'atout
            {
                if (impair >= 82)
                {
                    totalImpair = impair + offsetI;
                    totalPair = pair + offsetP;
                }
                else
                {
                    if (belotteImpair)
                    {
                        if (impair + 20 >= 82)
                        {
                            totalImpair = impair + offsetI + 20;
                            totalPair = pair + offsetP;
                        }
                        else
                        {
                            totalImpair = 20;
                            totalPair = 160;
                        }
                    }
                    else
                    {
                        totalImpair = 0;
                        totalPair = 160 + (belottePair ? 20 : 0);
                    }
                }

            }

            if (radioButtonPair.Checked)
            {

                if (pair >= 82)
                {
                    totalPair = pair + offsetP;
                    totalImpair = impair + offsetI;
                }
                else
                {
                    if (belottePair)
                    {
                        if (pair + 20 >= 82)
                        {
                            totalPair = pair + offsetP + 20;
                            totalImpair = impair + offsetI;
                        }
                        else
                        {
                            totalPair = 20;
                            totalImpair = 160;
                        }
                    }
                    else
                    {
                        totalPair = 0;
                        totalImpair = 160 + (belotteImpair ? 20 : 0);
                    }
                }
            }

            DisplayScore();
        }


        private void DisplayScore()
        {
            labelTotalPair.Text = "Total : " + totalPair;
            labelTotalImpair.Text = "Total : " + totalImpair;

            labelPointPair1.Text = "Points du tas : " + scorePair;
            labelPointsImpair.Text = "Points du tas : " + scoreImpair;
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            buttonValide.Enabled = false;
            buttonSuivant.Enabled = true;
            buttonSuivant.Visible = true;

            DonneesJeu.pointsImpairsParManche.Add(totalPair);
            DonneesJeu.pointsPairsParManche.Add(totalImpair);

            foreach (int p in DonneesJeu.pointsImpairsParManche)
            {
                listBoxImpair.Items.Add(p);
            }

            foreach (int p in DonneesJeu.pointsPairsParManche)
            {
                listBoxPair.Items.Add(p);
            }

            int cumulPair = DonneesJeu.pointsPairsParManche.Sum();
            int cumulImpair = DonneesJeu.pointsImpairsParManche.Sum();

            labelCumulPair.Text = "Cumule [ " + cumulPair + " ]";
            labelCumulImpair.Text = "Cumule [ " + cumulImpair + " ]";
        }

        private void radioButtonPair_CheckedChanged(object sender, EventArgs e)
        {
            ConvertScore(scorePair, scoreImpair, checkBelottePair.Checked, checkBelotteImpair.Checked);
        }

        private void radioButtonImpair_CheckedChanged(object sender, EventArgs e)
        {
            ConvertScore(scorePair, scoreImpair, checkBelottePair.Checked, checkBelotteImpair.Checked);
        }

        private void checkBelottePair_CheckedChanged(object sender, EventArgs e)
        {
            checkBelotteImpair.Enabled = !checkBelottePair.Checked;
            ConvertScore(scorePair, scoreImpair, checkBelottePair.Checked, checkBelotteImpair.Checked);
        }

        private void checkBelotteImpair_CheckedChanged(object sender, EventArgs e)
        {
            checkBelottePair.Enabled = !checkBelotteImpair.Checked;
            ConvertScore(scorePair, scoreImpair, checkBelottePair.Checked, checkBelotteImpair.Checked);
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            DonneesJeu.tours++;

            Form form = new CouperJeu();
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show();
            this.Hide();
        }
    }
}
