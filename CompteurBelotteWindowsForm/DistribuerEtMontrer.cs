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
    public partial class Distribuer : Form
    {
        private Paquet paquet;
        private Paquet table;
        private Joueur[] joueurs;

        private int turn = 1;
        private int donneur = 1;
        private int pointsImpaire;
        private int pointsPaire;

        private string path = Program.imgPath;
        private string cardBack = "carte_dos.bmp";
        private Image cardBack2 = Properties.Resources.carte_dos;

        private Couleur currentAtout;

        private Carte retourne;

        private List<TurnCommand> historique = new List<TurnCommand>();

        public Distribuer()
        {
            InitializeComponent();

            this.Text = "Belotte - Main des joueurs - Tour (" + turn + "/8)";

            labelJ1.Text = Program.J1.name;
            labelJ2.Text = Program.J2.name;
            labelJ3.Text = Program.J3.name;
            labelJ4.Text = Program.J4.name;

            labelImpair2.Text = Program.J1.name + " et " + Program.J3.name;
            labelpointimpair.Text = "0";

            labelPair2.Text = Program.J2.name + " et " + Program.J4.name;
            labelpointPair.Text = "0";

            pointsImpaire = 0;
            pointsPaire = 0;


            comboAtout.DataSource = Enum.GetValues(typeof(Couleur));
            comboAtout.SelectedIndex = 0;
            comboAtout.DropDownStyle = ComboBoxStyle.DropDownList;
            currentAtout = (Couleur)comboAtout.SelectedIndex;

            comboDonneur.Items.Add(Program.J1.name);
            comboDonneur.Items.Add(Program.J2.name);
            comboDonneur.Items.Add(Program.J3.name);
            comboDonneur.Items.Add(Program.J4.name);
            comboDonneur.SelectedIndex = 0;
            comboDonneur.DropDownStyle = ComboBoxStyle.DropDownList;

            comboCouleur.DataSource = Enum.GetValues(typeof(Couleur));
            comboCouleur.SelectedIndex = 0;
            comboAtout.DropDownStyle = ComboBoxStyle.DropDownList;

            comboValeur.DataSource = Enum.GetValues(typeof(Rang));
            comboCouleur.SelectedIndex = 0;
            comboAtout.DropDownStyle = ComboBoxStyle.DropDownList;

            joueurs = new Joueur[] { Program.J4, Program.J1, Program.J2, Program.J3 };

            InitCards();

            table = new Paquet();
            paquet = new Paquet();

            if (Program.pileImpair.getLength() < 1 && Program.pilePair.getLength() < 1)
            {
                paquet = new Paquet(false);

                InitFirstPlay();
            }
            else
            {

                comboCouleur.Visible = true;
                comboValeur.Visible = true;
                pictureRetourne.Visible = true;
                labelCouleur.Visible = true;
                labelValeur.Visible = true;
                labelRetour.Visible = true;

                buttonDonne2.Visible = true;
                buttonDonne3.Visible = true;

                if (Program.pileImpair.getLength() >= 32)
                {
                    paquet = Program.pileImpair;
                }

                if (Program.pilePair.getLength() >= 32)
                {
                    paquet = Program.pilePair;
                }
            }
        }

        private void InitFirstPlay()
        {
            for (int i = 0; i < 4; i++)
            {
                paquet.Distribuer3Cartes(joueurs[i]);
                paquet.Distribuer2Cartes(joueurs[i]);
                paquet.Distribuer3Cartes(joueurs[i]);
            }

            UpdateHands();

            comboCouleur.Visible = false;
            comboValeur.Visible = false;
            pictureRetourne.Visible = false;
            labelCouleur.Visible = false;
            labelValeur.Visible = false;
            labelRetour.Visible = false;

            buttonDonne2.Visible = false;
            buttonDonne3.Visible = false;
        }

        private void buttonDonne3_Click(object sender, EventArgs e)
        {
            for (int i = donneur; i < donneur + 4; i++)
            {
                paquet.Distribuer3Cartes(joueurs[i % 4]);
            }

            for (int i = donneur; i < donneur + 4; i++)
            {
                paquet.Distribuer2Cartes(joueurs[i % 4]);
            }

            buttonDonne3.Enabled = false;
            buttonDonne2.Enabled = false;

            UpdateHands();
        }

        private void buttonDonne2_Click(object sender, EventArgs e)
        {
            for (int i = donneur; i < donneur + 4; i++)
            {
                paquet.Distribuer2Cartes(joueurs[i % 4]);
            }

            for (int i = donneur; i < donneur + 4; i++)
            {
                paquet.Distribuer3Cartes(joueurs[i % 4]);
            }

            buttonDonne3.Enabled = false;
            buttonDonne2.Enabled = false;

            UpdateHands();

            Carte retourne = paquet.montrerAtout();
            pictureRetourne.Image = (Image)Properties.Resources.ResourceManager.GetObject(retourne.ToImageLocation());

        }

        private void InitCards()
        {
            foreach (PictureBox pb in groupTable.Controls)
            {
                pb.ImageLocation = path + cardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            foreach (PictureBox pb in groupMain1.Controls)
            {
                pb.ImageLocation = path + cardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            foreach (PictureBox pb in groupMain2.Controls)
            {
                pb.ImageLocation = path + cardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            foreach (PictureBox pb in groupMain3.Controls)
            {
                pb.ImageLocation = path + cardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            foreach (PictureBox pb in groupMain4.Controls)
            {
                pb.ImageLocation = path + cardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void UpdateHands()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < joueurs[j].getNbCard())
                    {
                        //playerCard(j + 1, i + 1).Image = (Image)Properties.Resources.ResourceManager.GetObject(joueurs[j].cartes[i].ToImageLocation());
                        playerCard(j + 1, i + 1).ImageLocation = path + joueurs[j].cartes.getCarte(i).ToImageLocation();
                    }
                }
            }
        }

        private void labelJ1_Click(object sender, EventArgs e)
        {
            paquet.DistribuerAtout(Program.J1);
            pictureRetourne.Visible = false;

            for (int i = donneur; i < donneur + 4; i++)
            {
                if (i % 4 == 1)
                {
                    paquet.Distribuer2Cartes(joueurs[i % 4]);
                }
                else
                {
                    paquet.Distribuer3Cartes(joueurs[i % 4]);
                }
            }

            UpdateHands();
            labelJ1.Enabled = labelJ2.Enabled = labelJ3.Enabled = labelJ4.Enabled = false;

        }

        private void labelJ2_Click(object sender, EventArgs e)
        {
            paquet.DistribuerAtout(Program.J2);
            pictureRetourne.Visible = false;
            for (int i = donneur; i < donneur + 4; i++)
            {
                if (i % 3 == 2)
                {
                    paquet.Distribuer2Cartes(joueurs[i % 4]);
                }
                else
                {
                    paquet.Distribuer3Cartes(joueurs[i % 4]);
                }
            }

            UpdateHands();
            labelJ1.Enabled = labelJ2.Enabled = labelJ3.Enabled = labelJ4.Enabled = false;
        }

        private void labelJ3_Click(object sender, EventArgs e)
        {
            paquet.DistribuerAtout(Program.J3);
            pictureRetourne.Visible = false;
            for (int i = donneur; i < donneur + 4; i++)
            {
                if (i % 3 == 3)
                {
                    paquet.Distribuer2Cartes(joueurs[i % 4]);
                }
                else
                {
                    paquet.Distribuer3Cartes(joueurs[i % 4]);
                }
            }

            UpdateHands();

            labelJ1.Enabled = labelJ2.Enabled = labelJ3.Enabled = labelJ4.Enabled = false;

        }

        private void labelJ4_Click(object sender, EventArgs e)
        {
            paquet.DistribuerAtout(Program.J4);
            pictureRetourne.Visible = false;
            for (int i = donneur; i < donneur + 4; i++)
            {
                if (i % 4 == 0)
                {
                    paquet.Distribuer2Cartes(joueurs[i % 4]);
                }
                else
                {
                    paquet.Distribuer3Cartes(joueurs[i % 4]);
                }
            }

            UpdateHands();
            labelJ1.Enabled = labelJ2.Enabled = labelJ3.Enabled = labelJ4.Enabled = false;

        }

        private PictureBox playerCard(int player, int cardIndex)
        {
            PictureBox p = new PictureBox();
            GroupBox gb = groupMain1;

            gb = (player == 1) ? groupMain1 : (player == 2) ? groupMain2 : (player == 3) ? groupMain3 : groupMain4;

            foreach (PictureBox pb in gb.Controls)
            {
                if (pb.Name.Contains(cardIndex.ToString()))
                {
                    p = pb;
                    break;
                }
            }

            return p;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Form form = new Distribuer();
            form.Show();
            this.Close();
        }

        private void SetCardPlayed(PictureBox p)
        {
            foreach (PictureBox pb in groupTable.Controls.OfType<PictureBox>().OrderBy(c => c.Name))
            {
                if (pb.ImageLocation == path + cardBack)
                {
                    pb.ImageLocation = p.ImageLocation;
                    Carte c = new Carte(p.ImageLocation);
                    paquet.Remove(c);
                    table.AjouterAuPaquet(c);
                    p.ImageLocation = path + cardBack;
                    break;
                }
            }
            // TODO : trouver quel joueur a joué la carte pour REMOVE dans la pile du joueur
            historique.Add(new TurnCommand(paquet, table, "add"));
        }



        private void UpdateTurn()
        {
            if (turn < 8)
            {
                turn++;
                this.Text = "Belotte - Main des joueurs - Tour (" + turn + "/8)";

            }
            else
            {
                if (pointsImpaire + pointsPaire >= 162) // could be 250 or 182
                {
                    DialogResult dr = MessageBox.Show("La somme des points est valide", "Verification", MessageBoxButtons.OK);

                    Program.comptePoints.Location = this.Location;
                    Program.comptePoints.StartPosition = this.StartPosition;
                    Program.comptePoints.SetPoints(pointsPaire, pointsImpaire);
                    Program.comptePoints.Show();
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
                        Program.comptePoints.Location = this.Location;
                        Program.comptePoints.StartPosition = this.StartPosition;
                        Program.comptePoints.SetPoints(pointsPaire, pointsImpaire);
                        Program.comptePoints.Show();
                        this.Close();
                    }
                }
            }
        }

        private void cancelPlayCard(PictureBox pic)
        {
            Carte c = new Carte(pic.ImageLocation);
            paquet.AjouterAuPaquet(c);

            pic.ImageLocation = path + cardBack;

            historique[historique.Count - 1].Undo();

            UpdateHands();
        }

        private void discardPlayCard(int winner)
        {
            if (gameIsValid())
            {
                Carte c1 = new Carte(pictureT1.ImageLocation);
                c1.SetAtout(c1.couleur == currentAtout);
                Carte c2 = new Carte(pictureT2.ImageLocation);
                c2.SetAtout(c2.couleur == currentAtout);
                Carte c3 = new Carte(pictureT3.ImageLocation);
                c3.SetAtout(c3.couleur == currentAtout);
                Carte c4 = new Carte(pictureT4.ImageLocation);
                c4.SetAtout(c4.couleur == currentAtout);

                UpdatePoints(c1, c2, c3, c4, winner);

                UpdateTurn();

                pictureT1.ImageLocation = pictureT2.ImageLocation = pictureT3.ImageLocation = pictureT4.ImageLocation = path + cardBack;
            }
        }

        private void UpdatePoints(Carte c1, Carte c2, Carte c3, Carte c4, int winner)
        {
            int points = c1.valeur + c2.valeur + c3.valeur + c4.valeur;

            if (winner % 2 == 1) // impaire
            {
                pointsImpaire += points;

                Program.pileImpair.AjouterAuPaquet(c1, c2, c3, c4);

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

                Program.pilePair.AjouterAuPaquet(c1, c2, c3, c4);

                if (turn == 8)
                {
                    pointsPaire += 10;
                    if (Program.pileImpair.getLength() < 1)
                    {
                        pointsPaire = 250;
                    }
                }
            }

            paquet.Remove(c1);
            paquet.Remove(c2);
            paquet.Remove(c3);
            paquet.Remove(c4);

            labelpointimpair.Text = pointsImpaire.ToString();
            labelpointPair.Text = pointsPaire.ToString();

        }

        private void comboBoxAtout_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAtout = (Couleur)comboAtout.SelectedIndex;
        }

        private bool gameIsValid()
        {
            foreach (PictureBox p in groupTable.Controls)
            {
                if (p.ImageLocation == path + cardBack)
                {
                    return false;
                }
            }
            return true;
        }

        private void pictureT1_Click(object sender, EventArgs e)
        {
            cancelPlayCard(pictureT1);
        }

        private void pictureT2_Click(object sender, EventArgs e)
        {
            cancelPlayCard(pictureT2);
        }

        private void pictureT3_Click(object sender, EventArgs e)
        {
            cancelPlayCard(pictureT3);
        }

        private void pictureT4_Click(object sender, EventArgs e)
        {
            cancelPlayCard(pictureT4);
        }

        private void buttonImpair_Click(object sender, EventArgs e)
        {
            discardPlayCard(1);
        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            discardPlayCard(0);
        }

        private void buttonAnnule_Click_1(object sender, EventArgs e)
        {

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

        private void pickTwocard1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard1);
        }

        private void pickTwocard2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard2);
        }

        private void pickTwocard3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard3);
        }

        private void pickTwocard4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard4);
        }

        private void pickTwocard5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard5);
        }

        private void pickTwocard6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard6);
        }

        private void pickTwocard7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard7);
        }

        private void pickTwocard8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard8);
        }

        private void pickThree1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree1);
        }

        private void pickThree2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree2);
        }

        private void pickThree3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree3);
        }

        private void pickThree4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree4);
        }

        private void pickThree5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree5);
        }

        private void pickThree6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree6);
        }

        private void pickThree7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree7);
        }

        private void pickThree8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree8);
        }

        private void pickFour1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour1);
        }

        private void pickFour2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour2);
        }

        private void pickFour3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour3);
        }

        private void pickFour4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour4);
        }

        private void pickFour5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour5);
        }

        private void pickFour6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour6);
        }

        private void pickFour7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour7);
        }

        private void pickFour8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour8);
        }

        private void comboDonneur_SelectedIndexChanged(object sender, EventArgs e)
        {
            donneur = comboDonneur.SelectedIndex;
        }

        private void comboAtout_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAtout = (Couleur)comboAtout.SelectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            retourne = new Carte((Rang)comboValeur.SelectedIndex, (Couleur)comboCouleur.SelectedIndex);
            pictureRetourne.ImageLocation = retourne.ToImageLocation();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            retourne = new Carte((Rang)comboValeur.SelectedIndex, (Couleur)comboCouleur.SelectedIndex);
            pictureRetourne.ImageLocation = retourne.ToImageLocation();
        }

    }
}
