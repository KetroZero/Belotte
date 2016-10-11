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
        private Joueur[] joueurs;
        private int donneur = 1;

        private string path = "C:/Users/Utilisateur/Documents/Projets_Visual_Studio/BelotteWindowsForm/CompteurBelotteWindowsForm/Images cartes/";
        private string CardBack = "cartes_dos.bmp";

        public Distribuer()
        {
            InitializeComponent();

            radioButton1.Text = labelJ1.Text = Program.J1.name;
            radioButton2.Text = labelJ2.Text = Program.J2.name;
            radioButton3.Text = labelJ3.Text = Program.J3.name;
            radioButton4.Text = labelJ4.Text = Program.J4.name;

            paquet = new Paquet();

            if (Program.pileImpair.getLength() >= 32)
            {
                paquet = Program.pileImpair;
            }

            if (Program.pilePair.getLength() >= 32)
            {
                paquet = Program.pilePair;
            }

            joueurs = new Joueur[] { Program.J4, Program.J1, Program.J2, Program.J3 };

            InitCards();

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

            Carte retourne = paquet.montrerAtout();
            pictureRetourne.ImageLocation = path + retourne.ToImageLocation();


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
            pictureRetourne.ImageLocation = path + retourne.ToImageLocation();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            donneur = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            donneur = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            donneur = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            donneur = 0;
        }

        private void InitCards()
        {
            foreach (PictureBox pb in groupMain1.Controls)
            {
                pb.ImageLocation = path + CardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            foreach (PictureBox pb in groupMain2.Controls)
            {
                pb.ImageLocation = path + CardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            foreach (PictureBox pb in groupMain3.Controls)
            {
                pb.ImageLocation = path + CardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            foreach (PictureBox pb in groupMain4.Controls)
            {
                pb.ImageLocation = path + CardBack;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void UpdateHands()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < joueurs[j].cartes.Count)
                    {
                        playerCard(j + 1, i + 1).ImageLocation = path + joueurs[j].cartes[i].ToImageLocation();
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
            Form form = new CreationPile();
            form.Show();
            this.Close();
        }
    }
}
