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

        private string path = DonneesJeu.imgPath;
        private string cardBack = "carte_dos.bmp";
        private Image cardBack2 = Properties.Resources.carte_dos;

        private Couleur currentAtout;

        private Carte retourne;

        private List<TurnCommand> historique = new List<TurnCommand>();

        public Distribuer()
        {
            InitializeComponent();

            this.Text = "Belotte - Main des joueurs - Tour (" + turn + "/8)";

            labelJ1.Text = DonneesJeu.J1.name;
            labelJ2.Text = DonneesJeu.J2.name;
            labelJ3.Text = DonneesJeu.J3.name;
            labelJ4.Text = DonneesJeu.J4.name;

            labelImpair2.Text = DonneesJeu.J1.name + " et " + DonneesJeu.J3.name;
            labelpointimpair.Text = "0";

            labelPair2.Text = DonneesJeu.J2.name + " et " + DonneesJeu.J4.name;
            labelpointPair.Text = "0";


            pointsImpaire = 0;
            pointsPaire = 0;


            comboAtout.DataSource = Enum.GetValues(typeof(Couleur));
            comboAtout.SelectedIndex = 0;
            comboAtout.DropDownStyle = ComboBoxStyle.DropDownList;
            currentAtout = (Couleur)comboAtout.SelectedIndex;

            comboCouleur.DataSource = Enum.GetValues(typeof(Couleur));
            comboCouleur.SelectedIndex = 0;
            comboCouleur.DropDownStyle = ComboBoxStyle.DropDownList;

            comboValeur.DataSource = Enum.GetValues(typeof(Rang));
            comboValeur.SelectedIndex = 0;
            comboValeur.DropDownStyle = ComboBoxStyle.DropDownList;

            joueurs = new Joueur[] { DonneesJeu.J4, DonneesJeu.J1, DonneesJeu.J2, DonneesJeu.J3 };
            labelNomDonneur.Text = DonneesJeu.donneur.name;
            donneur = DonneesJeu.donneur.numero;

            InitCards();

            table = new Paquet();
            paquet = new Paquet();

            if (DonneesJeu.tours < 1)
            {
                paquet = new Paquet(false);

                InitFirstPlay();
            }
            else
            {
                paquet = new Paquet(false);

                comboCouleur.Visible = true;
                comboValeur.Visible = true;
                pictureRetourne.Visible = true;
                labelCouleur.Visible = true;
                labelValeur.Visible = true;
                labelRetour.Visible = true;

                buttonDonne2.Visible = true;
                buttonDonne3.Visible = true;

                if (DonneesJeu.pileImpair.getLength() >= 32)
                {
                    paquet = DonneesJeu.pileImpair;
                }

                if (DonneesJeu.pilePair.getLength() >= 32)
                {
                    paquet = DonneesJeu.pilePair;
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
            paquet.CouperAvecAtout(retourne);

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
            paquet.CouperAvecAtout(retourne);

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
        }

        private void InitCards()
        {
            initCardByGroup(groupTable);
            initCardByGroup(groupMain1);
            initCardByGroup(groupMain2);
            initCardByGroup(groupMain3);
            initCardByGroup(groupMain4);
        }

        private void initCardByGroup(GroupBox gb)
        {
            foreach (PictureBox pb in gb.Controls)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ImageLocation = path + cardBack;
            }
        }

        private void UpdateHands()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < joueurs[j].getLength())
                    {
                        playerCard(j + 1, i + 1).ImageLocation = path + joueurs[j].getCarte(i).ToImageLocation();
                    }
                    else
                    {
                        playerCard(j + 1, i + 1).ImageLocation = path + cardBack;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (i < table.getLength())
                {
                    tableCards(i + 1).ImageLocation = path + table.getCarte(i).ToImageLocation();
                }
                else
                {
                    tableCards(i + 1).ImageLocation = path + cardBack;
                }
            }
        }

        private void labelJ1_Click(object sender, EventArgs e)
        {
            paquet.DistribuerAtout(DonneesJeu.J1);
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
            paquet.DistribuerAtout(DonneesJeu.J2);
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
            paquet.DistribuerAtout(DonneesJeu.J3);
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
            paquet.DistribuerAtout(DonneesJeu.J4);
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
            GroupBox gb = (player == 1) ? groupMain1 : (player == 2) ? groupMain2 : (player == 3) ? groupMain3 : groupMain4;

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

        private PictureBox tableCards(int cardIndex)
        {
            PictureBox p = new PictureBox();

            foreach (PictureBox pb in groupTable.Controls)
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

        private void SetCardPlayed(PictureBox p, Joueur j)
        {
            if (table.getLength() < 4)
            {
                if (p.ImageLocation != path + cardBack) // not empty space
                {
                    Carte c = new Carte(p.ImageLocation);

                    TransfertAndHistorique(j, table, c);
                }
            }
        }

        private void TransfertAndHistorique(Paquet source, Paquet destination, Carte c)
        {
            TurnCommand tc = new TurnCommand(source, destination, c);
            historique.Add(tc);
            UpdateHands();
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

                    ComptePoints comptePoints = new ComptePoints();
                    comptePoints.SetPoints(pointsPaire, pointsImpaire);
                    comptePoints.Location = this.Location;
                    comptePoints.StartPosition = this.StartPosition;
                    comptePoints.Show();
                    this.Close();
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

                        Form comptePoints = new ComptePoints();
                        comptePoints.Location = this.Location;
                        comptePoints.StartPosition = this.StartPosition;
                        comptePoints.Show();
                        this.Close();
                    }
                }
            }
        }

        private void cancelPlayCard(PictureBox pic)
        {
            Carte c = new Carte(pic.ImageLocation);

            if (pic.ImageLocation != string.Concat(path + cardBack))
            {
                pic.ImageLocation = path + cardBack;

                int index = historique.Count - 1;
                historique[index].Annuler();
                historique.RemoveAt(index);

                UpdateHands();
            }
        }

        private void discardPlayCard(int winner)
        {
            if (gameIsValid())
            {
                foreach (Carte c in table.getAllCards())
                {
                    c.SetAtout(c.couleur == currentAtout);
                }

                UpdatePoints(table.getCarte(0), table.getCarte(1), table.getCarte(2), table.getCarte(3), winner);

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

                //DonneesJeu.pileImpair.AjouterAuPaquet(c1, c2, c3, c4);
                TransfertAndHistorique(table, DonneesJeu.pileImpair, c4);
                TransfertAndHistorique(table, DonneesJeu.pileImpair, c3);
                TransfertAndHistorique(table, DonneesJeu.pileImpair, c2);
                TransfertAndHistorique(table, DonneesJeu.pileImpair, c1);

                if (turn == 8)
                {
                    pointsImpaire += 10;
                    if (DonneesJeu.pilePair.getLength() < 1)
                    {
                        pointsImpaire = 250;
                    }
                }
            }
            else // pair
            {
                pointsPaire += points;

                //DonneesJeu.pilePair.AjouterAuPaquet(c1, c2, c3, c4);
                TransfertAndHistorique(table, DonneesJeu.pilePair, c4);
                TransfertAndHistorique(table, DonneesJeu.pilePair, c3);
                TransfertAndHistorique(table, DonneesJeu.pilePair, c2);
                TransfertAndHistorique(table, DonneesJeu.pilePair, c1);

                if (turn == 8)
                {
                    pointsPaire += 10;
                    if (DonneesJeu.pileImpair.getLength() < 1)
                    {
                        pointsPaire = 250;
                    }
                }
            }

            //table.getAllCards().Clear();

            labelpointimpair.Text = pointsImpaire.ToString();
            labelpointPair.Text = pointsPaire.ToString();

            UpdateHands();

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
            // vide la table avant de restaurer la main precedante
            int tidx = table.getLength();
            for (int j = tidx; j > 0; j--)
            {
                int index = historique.Count - 1;
                historique[index].Annuler();
                historique.RemoveAt(index);
            }

            int hindex = historique.Count - 1;
            // annule les cartes et les points dans la pile paire/impaire
            if (historique[hindex].source == table)
            {
                for (int i = hindex; i > hindex - 4; i--)
                {
                    historique[i].Annuler();
                }
                historique.RemoveRange(hindex - 4, 4);
            }

            UpdateHands();
        }

        private void pickCard1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard1, joueurs[0]);
        }

        private void pickCard2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard2, joueurs[0]);
        }

        private void pickCard3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard3, joueurs[0]);
        }

        private void pickCard4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard4, joueurs[0]);
        }

        private void pickCard5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard5, joueurs[0]);
        }

        private void pickCard6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard6, joueurs[0]);
        }

        private void pickCard7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard7, joueurs[0]);
        }

        private void pickCard8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickCard8, joueurs[0]);
        }

        private void pickTwocard1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard1, joueurs[1]);
        }

        private void pickTwocard2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard2, joueurs[1]);
        }

        private void pickTwocard3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard3, joueurs[1]);
        }

        private void pickTwocard4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard4, joueurs[1]);
        }

        private void pickTwocard5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard5, joueurs[1]);
        }

        private void pickTwocard6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard6, joueurs[1]);
        }

        private void pickTwocard7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard7, joueurs[1]);
        }

        private void pickTwocard8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickTwocard8, joueurs[1]);
        }

        private void pickThree1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree1, joueurs[2]);
        }

        private void pickThree2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree2, joueurs[2]);
        }

        private void pickThree3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree3, joueurs[2]);
        }

        private void pickThree4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree4, joueurs[2]);
        }

        private void pickThree5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree5, joueurs[2]);
        }

        private void pickThree6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree6, joueurs[2]);
        }

        private void pickThree7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree7, joueurs[2]);
        }

        private void pickThree8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickThree8, joueurs[2]);
        }

        private void pickFour1_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour1, joueurs[3]);
        }

        private void pickFour2_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour2, joueurs[3]);
        }

        private void pickFour3_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour3, joueurs[3]);
        }

        private void pickFour4_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour4, joueurs[3]);
        }

        private void pickFour5_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour5, joueurs[3]);
        }

        private void pickFour6_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour6, joueurs[3]);
        }

        private void pickFour7_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour7, joueurs[3]);
        }

        private void pickFour8_Click(object sender, EventArgs e)
        {
            SetCardPlayed(pickFour8, joueurs[3]);
        }

        private void comboAtout_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAtout = (Couleur)comboAtout.SelectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            retourne = new Carte((Rang)comboValeur.SelectedIndex, (Couleur)comboCouleur.SelectedIndex);
            pictureRetourne.ImageLocation = path + retourne.ToImageLocation();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            retourne = new Carte((Rang)comboValeur.SelectedIndex, (Couleur)comboCouleur.SelectedIndex);
            pictureRetourne.ImageLocation = path + retourne.ToImageLocation();
        }

    }
}
