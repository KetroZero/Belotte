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
    public partial class CreationPile : Form
    {
        private string path = "C:/Users/Utilisateur/Documents/Projets_Visual_Studio/BelotteWindowsForm/CompteurBelotteWindowsForm/Images cartes/";
        private string CardBack = "cartes_dos.bmp";

        private Paquet paquetComplet;

        private int pointsImpaire;
        private int pointsPaire;

        private Couleur currentAtout;

        int turn = 0;
        public CreationPile()
        {
            InitializeComponent();

            carte1.ImageLocation = carte2.ImageLocation = carte3.ImageLocation = carte4.ImageLocation = path + CardBack;
            turn = 1;

            labelImpair2.Text = Program.J1.name + " et " + Program.J3.name;
            labelpointimpair.Text = "0";

            labelPair2.Text = Program.J2.name + " et " + Program.J4.name;
            labelpointPair.Text = "0";

            Program.pileImpair = new Paquet();
            Program.pilePair = new Paquet();
            paquetComplet = new Paquet(false);

            comboBoxAtout.DataSource = Enum.GetValues(typeof(Couleur));
            comboBoxAtout.SelectedIndex = 0;
            comboBoxAtout.DropDownStyle = ComboBoxStyle.DropDownList;
            currentAtout = (Couleur)comboBoxAtout.SelectedIndex;

            SwitchImages();

            radioButtonPique.Checked = true;
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

            foreach (PictureBox p in groupBoxCardPick.Controls)
            {
                Carte c = new Carte(p.ImageLocation.Remove(0, path.Length));
                if (!paquetComplet.isInPaquet(c))
                {
                    p.ImageLocation = path + CardBack;
                }
            }
        }

        private void SetCardPlayed(PictureBox p)
        {
            foreach (PictureBox pb in groupBoxJeu.Controls.OfType<PictureBox>().OrderBy(c => c.Name))
            {
                if (pb.ImageLocation == path + CardBack)
                {
                    pb.ImageLocation = p.ImageLocation;

                    Carte c = new Carte(p.ImageLocation.Remove(0, path.Length));
                    paquetComplet.Remove(c);

                    p.ImageLocation = path + CardBack;
                    break;
                }
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
            Carte c = new Carte(carte1.ImageLocation.Remove(0, path.Length));
            paquetComplet.AjouterAuPaquet(c);

            carte1.ImageLocation = path + CardBack;
            SwitchImages();
        }

        private void carte2_Click(object sender, EventArgs e)
        {
            Carte c = new Carte(carte2.ImageLocation.Remove(0, path.Length));
            paquetComplet.AjouterAuPaquet(c);

            carte2.ImageLocation = path + CardBack;
            SwitchImages();
        }

        private void carte3_Click(object sender, EventArgs e)
        {
            Carte c = new Carte(carte3.ImageLocation.Remove(0, path.Length));
            paquetComplet.AjouterAuPaquet(c);

            carte3.ImageLocation = path + CardBack;
            SwitchImages();
        }

        private void carte4_Click(object sender, EventArgs e)
        {
            Carte c = new Carte(carte4.ImageLocation.Remove(0, path.Length));
            paquetComplet.AjouterAuPaquet(c);

            carte4.ImageLocation = path + CardBack;
            SwitchImages();
        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            if (gameIsValid())
            {
                Carte c1 = new Carte(carte1.ImageLocation.Remove(0, path.Length));
                c1.SetAtout(c1.couleur == currentAtout);
                Carte c2 = new Carte(carte2.ImageLocation.Remove(0, path.Length));
                c2.SetAtout(c2.couleur == currentAtout);
                Carte c3 = new Carte(carte3.ImageLocation.Remove(0, path.Length));
                c3.SetAtout(c3.couleur == currentAtout);
                Carte c4 = new Carte(carte4.ImageLocation.Remove(0, path.Length));
                c4.SetAtout(c4.couleur == currentAtout);

                UpdatePoints(c1, c2, c3, c4, 0);

                UpdateTurn();
            }
        }

        private void buttonImpair_Click(object sender, EventArgs e)
        {
            if (gameIsValid())
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
                if (pointsImpaire + pointsPaire >= 162)
                {
                    Form form = new ComptePoints(pointsPaire, pointsImpaire); ;
                    form.Location = this.Location;
                    form.StartPosition = this.StartPosition;
                    form.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("La somme des points est invalide", "Erreur", MessageBoxButtons.OKCancel);

                    if (dr == DialogResult.Cancel)
                    {
                        UpdateTurn();
                    }
                    else if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        Form form = new ComptePoints(pointsPaire, pointsImpaire); ;
                        form.Location = this.Location;
                        form.StartPosition = this.StartPosition;
                        form.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void UpdatePoints(Carte c1, Carte c2, Carte c3, Carte c4, int winner)
        {
            int points = c1.valeur + c2.valeur + c3.valeur + c4.valeur;

            if (winner % 2 == 1) // impaire
            {
                pointsImpaire += points;

                Program.pileImpair.AjouterAuPaquet(c1);
                Program.pileImpair.AjouterAuPaquet(c2);
                Program.pileImpair.AjouterAuPaquet(c3);
                Program.pileImpair.AjouterAuPaquet(c4);

                if (turn == 8)
                {
                    pointsImpaire += 10;
                    if (Program.pilePair.getLength() < 1)
                    {
                        pointsImpaire = 250;
                    }
                }
            }
            else // pair
            {
                pointsPaire += points;

                Program.pilePair.AjouterAuPaquet(c1);
                Program.pilePair.AjouterAuPaquet(c2);
                Program.pilePair.AjouterAuPaquet(c3);
                Program.pilePair.AjouterAuPaquet(c4);

                if (turn == 8)
                {
                    pointsPaire += 10;
                    if (Program.pileImpair.getLength() < 1)
                    {
                        pointsPaire = 250;
                    }
                }
            }

            paquetComplet.Remove(c1);
            paquetComplet.Remove(c2);
            paquetComplet.Remove(c3);
            paquetComplet.Remove(c4);

            labelpointimpair.Text = pointsImpaire.ToString();
            labelpointPair.Text = pointsPaire.ToString();

        }

        private void comboBoxAtout_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAtout = (Couleur)comboBoxAtout.SelectedIndex;
        }

        private bool gameIsValid()
        {
            foreach (PictureBox p in groupBoxJeu.Controls)
            {
                if (p.ImageLocation == path + CardBack)
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonAnnule_Click(object sender, EventArgs e)
        {
            //TODO
        }

    }
}
