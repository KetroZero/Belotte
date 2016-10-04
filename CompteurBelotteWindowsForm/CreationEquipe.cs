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

        public Joueur GetJ1()
        {
            return new Joueur(0);
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

            Joueur J1, J2, J3, J4;

            try
            {
                if (TextBoxIsValid(textBoxJ1))
                {
                    J1 = new Joueur(1, textBoxJ1.Text);
                }

                if (TextBoxIsValid(textBoxJ1))
                {
                    J2 = new Joueur(2, textBoxJ2.Text);
                }
                if (TextBoxIsValid(textBoxJ1))
                {
                    J3 = new Joueur(3, textBoxJ3.Text);
                }
                if (TextBoxIsValid(textBoxJ1))
                {
                    J4 = new Joueur(4, textBoxJ4.Text);
                }
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
                labelError.Visible = true;
            }

            Form pile = new CreationPile();
            pile.Location = this.Location;
            pile.StartPosition = this.StartPosition;
            pile.FormClosing += delegate { this.Show(); };
            pile.Show();
            this.Hide();

        }

        private bool TextBoxIsValid(TextBox control)
        {
            Exception ex = new BelotteException();
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                ex = new Exception("Format de nom incorrect.");
            }

            if (string.IsNullOrEmpty(control.Text))
            {
                ex = new Exception("Le nom est vide.");
            }

            return ex.Message == null;
        }
    }
}
