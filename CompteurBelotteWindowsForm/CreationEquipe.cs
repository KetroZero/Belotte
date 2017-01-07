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
    public partial class CreationEquipe : Form
    {
        public CreationEquipe()
        {
            InitializeComponent();
            DonneesJeu.donneur = DonneesJeu.J1;
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            textBoxJ1.Enabled = true;
            textBoxJ2.Enabled = true;
            textBoxJ3.Enabled = true;
            textBoxJ4.Enabled = true;

            textBoxJ1.Text = "J1";
            textBoxJ2.Text = "J2";
            textBoxJ3.Text = "J3";
            textBoxJ4.Text = "J4";

            labelError.Visible = false;
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            bool error = false;
            try
            {
                if (TextBoxIsValid(textBoxJ1))
                {
                    DonneesJeu.J1 = new Joueur(1, textBoxJ1.Text);
                }

                if (TextBoxIsValid(textBoxJ1))
                {
                    DonneesJeu.J2 = new Joueur(2, textBoxJ2.Text);
                }
                if (TextBoxIsValid(textBoxJ1))
                {
                    DonneesJeu.J3 = new Joueur(3, textBoxJ3.Text);
                }
                if (TextBoxIsValid(textBoxJ1))
                {
                    DonneesJeu.J4 = new Joueur(4, textBoxJ4.Text);
                }
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
                labelError.Visible = true;
                error = true;
            }

            if (!error)
            {
                Form distribuer = new Distribuer();
                distribuer.Location = this.Location;
                distribuer.StartPosition = this.StartPosition;
                distribuer.Show();
                this.Hide();
            }

        }

        private bool TextBoxIsValid(TextBox control)
        {
            return !string.IsNullOrWhiteSpace(control.Text);
        }

        private void groupBoxScore_Enter(object sender, EventArgs e)
        {
            if (radioButtonScore1000.Checked)
            {
                DonneesJeu.maxScore = 1000;//int.Parse(radioButtonScore1000.Text);
            }

            if (radioButtonScore1500.Checked)
            {
                DonneesJeu.maxScore = 1500;//int.Parse(radioButtonScore1500.Text);
            }

            if (radioButtonScoreAutre.Checked)
            {
                try
                {
                    DonneesJeu.maxScore = int.Parse(textBoxScore.Text);
                }
                catch (Exception ex)
                {
                    textBoxScore.Text = "";
                }
            }
        }

        private void textBoxScore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DonneesJeu.maxScore = int.Parse(textBoxScore.Text);
            }
            catch (Exception ex)
            {
                textBoxScore.Text = "";
            }
        }

        private void radioButtonScoreAutre_CheckedChanged(object sender, EventArgs e)
        {
            textBoxScore.Enabled = radioButtonScoreAutre.Checked;
        }

        private void textBoxJ1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxJ1.Text))
            {
                radioDistribuer1.Text = textBoxJ1.Text;
            }
            else
            {
                radioDistribuer1.Text = "Joueur 1";
            }
        }

        private void textBoxJ2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxJ2.Text))
            {
                radioDistribuer2.Text = textBoxJ2.Text;
            }
            else
            {
                radioDistribuer2.Text = "Joueur 2";
            }
        }

        private void textBoxJ3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxJ3.Text))
            {
                radioDistribuer3.Text = textBoxJ3.Text;
            }
            else
            {
                radioDistribuer3.Text = "Joueur 3";
            }

        }

        private void textBoxJ4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxJ4.Text))
            {
                radioDistribuer4.Text = textBoxJ4.Text;
            }
            else
            {
                radioDistribuer4.Text = "Joueur 4";
            }

        }

        private void radioDistribuer1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDistribuer1.Checked)
            {
                DonneesJeu.donneur = DonneesJeu.J1;
            }
        }

        private void radioDistribuer2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDistribuer2.Checked)
            {
                DonneesJeu.donneur = DonneesJeu.J2;
            }
        }

        private void radioDistribuer3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioDistribuer3.Checked)
            {
                DonneesJeu.donneur = DonneesJeu.J3;
            }
        }

        private void radioDistribuer4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioDistribuer4.Checked)
            {
                DonneesJeu.donneur = DonneesJeu.J4;
            }
        }
    }
}
