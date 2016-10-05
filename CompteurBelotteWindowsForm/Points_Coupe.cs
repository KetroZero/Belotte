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
    public partial class Points_Coupe : Form
    {
        private int scorePair = 1;
        private int scoreImpair = 150;

        private int totalPair = 0;
        private int totalImpair = 0;
        public Points_Coupe(int pair, int impair)
        {
            InitializeComponent();

            scorePair = pair;
            scoreImpair = impair;
        }

        private void groupAtout_Enter(object sender, EventArgs e)
        {
            ConvertScore(scorePair, scoreImpair, checkBelottePair.Checked, checkBelotteImpair.Checked);
        }

        private void ConvertScore(int pair, int impair, bool belottePair, bool belotteImpair)
        {
            totalPair = 0;// 10 * (int)Math.Round((double)pair / 10);
            totalImpair = 0;//10 * (int)Math.Round((double)impair / 10);

            if (radioButtonImpair.Checked) // Impair à pris l'atout
            {
                if (impair >= 82)
                {
                    totalImpair = 10 * (int)Math.Round((double)impair / 10) + (belotteImpair ? 20 : 0);
                    totalPair = 10 * (int)Math.Round((double)pair / 10) + (belottePair ? 20 : 0);
                }
                else
                {
                    if (belotteImpair)
                    {
                        if (impair + 20 >= 82)
                        {
                            totalImpair = 10 * (int)Math.Round((double)impair / 10) + 20;
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
                        totalPair = 160 + (belottePair ? 20 : 0); ;
                    }
                }

            }

            if (radioButtonPair.Checked)
            {

                if (pair >= 82)
                {
                    totalPair = 10 * (int)Math.Round((double)pair / 10) + (belottePair ? 20 : 0);
                    totalImpair = 10 * (int)Math.Round((double)impair / 10) + (belotteImpair ? 20 : 0);
                }
                else
                {
                    if (belottePair)
                    {
                        if (pair + 20 >= 82)
                        {
                            totalPair = 10 * (int)Math.Round((double)pair / 10) + 20;
                            totalImpair = 10 * (int)Math.Round((double)impair / 10);
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
            labelTotalPair.Text = "Total : " +totalPair;
            labelTotalImpair.Text = "Total : " + totalImpair;

            labelPointPair1.Text = "Points du tas : " + scorePair;
            labelPointsImpair.Text = "Points du tas : " + scoreImpair;
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            listBoxPair.Items.Add(totalPair);
            listBoxImpair.Items.Add(totalImpair);

            buttonValide.Enabled = false;

            int cumulPair = 0;
            foreach (int i in listBoxPair.Items)
            {
                cumulPair += i;
            }

            int cumulImpair = 0;
            foreach (int i in listBoxImpair.Items)
            {
                cumulImpair += i;
            }

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
    }
}
