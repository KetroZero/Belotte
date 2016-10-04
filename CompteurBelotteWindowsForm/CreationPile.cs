﻿using System;
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
    public partial class CreationPile : Form
    {
        private string path = "C:/Users/Utilisateur/Documents/Projets_Visual_Studio/BelotteWindowsForm/CompteurBelotteWindowsForm/Images cartes/";
        private string CardBack = "cartes_dos.bmp";

        private Paquet pilePair;
        private Paquet pileImpair;

        private Couleur currentAtout;

        int turn = 0;
        public CreationPile()
        {
            InitializeComponent();

            radioButtonPique.Checked = true;
            SwitchImages();

            carte1.ImageLocation = carte2.ImageLocation = carte3.ImageLocation = carte4.ImageLocation = path + CardBack;
            turn = 1;

            labelImpair2.Text = Program.J1.name + " et " + Program.J3.name;
            labelpointimpair.Text = "0";

            labelPair2.Text = Program.J2.name + " et " + Program.J4.name;
            labelpointPair.Text = "0";

            pileImpair = new Paquet();
            pilePair = new Paquet();

            comboBoxAtout.DataSource = Enum.GetValues(typeof(Couleur));
            comboBoxAtout.SelectedIndex = 0;
            comboBoxAtout.DropDownStyle = ComboBoxStyle.DropDownList;
            currentAtout = (Couleur)comboBoxAtout.SelectedItem;
        }

        private void radioButtonPique_CheckedChanged(object sender, EventArgs e)
        {
            SwitchImages();
        }

        private void radioButtonCoeur_CheckedChanged(object sender, EventArgs e)
        {
            SwitchImages();
        }

        private void radioButtonTrefle_CheckedChanged(object sender, EventArgs e)
        {
            SwitchImages();
        }

        private void radioButtonCarreau_CheckedChanged(object sender, EventArgs e)
        {
            SwitchImages();
        }

        private void SwitchImages()
        {
            if (radioButtonPique.Checked)
            {
                SetCardImage("P.bmp");
            }

            if (radioButtonCoeur.Checked)
            {
                SetCardImage("Co.bmp");
            }
            if (radioButtonTrefle.Checked)
            {
                SetCardImage("T.bmp");
            }

            if (radioButtonCarreau.Checked)
            {
                SetCardImage("Ca.bmp");
            }
        }

        private void SetCardImage(string couleur)
        {
            pickCard1.ImageLocation = path + "A_" + couleur;
            pickCard2.ImageLocation = path + "10_" + couleur;
            pickCard3.ImageLocation = path + "K_" + couleur;
            pickCard4.ImageLocation = path + "Q_" + couleur;
            pickCard5.ImageLocation = path + "J_" + couleur;
            pickCard6.ImageLocation = path + "9_" + couleur;
            pickCard7.ImageLocation = path + "8_" + couleur;
            pickCard8.ImageLocation = path + "7_" + couleur;
        }

        private void SetCardPlayed(PictureBox p)
        {
            if (carte1.ImageLocation == path + CardBack)
            {
                carte1.ImageLocation = p.ImageLocation;
            }
            else if (carte2.ImageLocation == path + CardBack)
            {
                carte2.ImageLocation = p.ImageLocation;
            }
            else if (carte3.ImageLocation == path + CardBack)
            {
                carte3.ImageLocation = p.ImageLocation;
            }
            else if (carte4.ImageLocation == path + CardBack)
            {
                carte4.ImageLocation = p.ImageLocation;
            }
        }

        private void pickCard1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard1);
        }

        private void pickCard2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard2);
        }

        private void pickCard3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard3);
        }

        private void pickCard4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard4);
        }

        private void pickCard5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard5);
        }

        private void pickCard6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard6);
        }

        private void pickCard7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard7);
        }

        private void pickCard8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard8);
        }

        private void carte1_Click(object sender, EventArgs e)
        {
            carte1.ImageLocation = path + CardBack;
        }

        private void carte2_Click(object sender, EventArgs e)
        {
            carte2.ImageLocation = path + CardBack;
        }

        private void carte3_Click(object sender, EventArgs e)
        {
            carte3.ImageLocation = path + CardBack;
        }

        private void carte4_Click(object sender, EventArgs e)
        {
            carte4.ImageLocation = path + CardBack;
        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            Carte c1 = new Carte(carte1.ImageLocation.Remove(0, path.Length));
            c1.atout = (c1.couleur == currentAtout);
            Carte c2 = new Carte(carte2.ImageLocation.Remove(0, path.Length));
            c2.atout = (c2.couleur == currentAtout);
            Carte c3 = new Carte(carte3.ImageLocation.Remove(0, path.Length));
            c3.atout = (c3.couleur == currentAtout);
            Carte c4 = new Carte(carte4.ImageLocation.Remove(0, path.Length));
            c4.atout = (c4.couleur == currentAtout);

            UpdatePoints(c1, c2, c3, c4, 0);

            UpdateTurn();
        }

        private void buttonImpair_Click(object sender, EventArgs e)
        {
            Carte c1 = new Carte(carte1.ImageLocation.Remove(0, path.Length));
            c1.SetAtout(c1.couleur == currentAtout);
            Carte c2 = new Carte(carte2.ImageLocation.Remove(0, path.Length));
            c2.SetAtout(c2.couleur == currentAtout);
            Carte c3 = new Carte(carte3.ImageLocation.Remove(0, path.Length));
            c3.SetAtout(c3.couleur == currentAtout);
            Carte c4 = new Carte(carte4.ImageLocation.Remove(0, path.Length));
            c4.SetAtout(c4.couleur == currentAtout);

            UpdatePoints(c1, c2, c3, c4, 1);

            UpdateTurn();
        }

        private void UpdateTurn()
        {
            if (turn < 8)
            {
                turn++;
                labelTurn.Text = string.Format("Tour ({0}/8)", turn);

                carte1.ImageLocation = carte2.ImageLocation = carte3.ImageLocation = carte4.ImageLocation = path + CardBack;

                SwitchImages();
            }
            else
            {
                this.Close();
            }
        }

        private void UpdatePoints(Carte c1, Carte c2, Carte c3, Carte c4, int winner)
        {
            int points = c1.valeur + c2.valeur + c3.valeur + c4.valeur;

            if (winner % 2 == 1) // impaire
            {
                Program.pointsImpaire += points;

                pileImpair.AjouterAuPaquet(c1);
                pileImpair.AjouterAuPaquet(c2);
                pileImpair.AjouterAuPaquet(c3);
                pileImpair.AjouterAuPaquet(c4);
            }
            else // pair
            {
                Program.pointsPaire += points;

                pilePair.AjouterAuPaquet(c1);
                pilePair.AjouterAuPaquet(c2);
                pilePair.AjouterAuPaquet(c3);
                pilePair.AjouterAuPaquet(c4);
            }

            labelpointimpair.Text = Program.pointsImpaire.ToString();
            labelpointPair.Text = Program.pointsPaire.ToString();
        }

        private void comboBoxAtout_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAtout = (Couleur)comboBoxAtout.SelectedItem;
        }
    }
}
