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
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            textBoxJ1.Enabled = true;
            textBoxJ2.Enabled = true;
            textBoxJ3.Enabled = true;
            textBoxJ4.Enabled = true;

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
                    Program.J1 = new Joueur(1, textBoxJ1.Text);
                }

                if (TextBoxIsValid(textBoxJ1))
                {
                    Program.J2 = new Joueur(2, textBoxJ2.Text);
                }
                if (TextBoxIsValid(textBoxJ1))
                {
                    Program.J3 = new Joueur(3, textBoxJ3.Text);
                }
                if (TextBoxIsValid(textBoxJ1))
                {
                    Program.J4 = new Joueur(4, textBoxJ4.Text);
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
                Form pile = new CreationPile();
                pile.Location = this.Location;
                pile.StartPosition = this.StartPosition;
                pile.FormClosing += delegate { this.Show(); };
                pile.Show();
                this.Hide();
            }

        }

        private bool TextBoxIsValid(TextBox control)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                throw new Exception("Format de nom incorrect.");
                isValid = false;

            }

            if (string.IsNullOrEmpty(control.Text))
            {
                throw new Exception("Le nom est vide.");
                isValid = false;
            }

            return isValid;
        }

        private void groupBoxScore_Enter(object sender, EventArgs e)
        {
            if (radioButtonScore1000.Checked)
            {
                Program.maxScore = int.Parse(radioButtonScore1000.Text);
            }

            if (radioButtonScore1500.Checked)
            {
                Program.maxScore = int.Parse(radioButtonScore1500.Text);
            }

            if (radioButtonScoreAutre.Checked)
            {
                try
                {
                    Program.maxScore = int.Parse(textBoxScore.Text);
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
                Program.maxScore = int.Parse(textBoxScore.Text);
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
    }
}
