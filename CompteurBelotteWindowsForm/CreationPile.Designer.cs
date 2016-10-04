namespace CompteurBelotteWindowsForm
{
    partial class CreationPile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationPile));
            this.labelTurn = new System.Windows.Forms.Label();
            this.groupBoxJeu = new System.Windows.Forms.GroupBox();
            this.carte4 = new System.Windows.Forms.PictureBox();
            this.carte3 = new System.Windows.Forms.PictureBox();
            this.carte2 = new System.Windows.Forms.PictureBox();
            this.carte1 = new System.Windows.Forms.PictureBox();
            this.buttonPair = new System.Windows.Forms.Button();
            this.buttonImpair = new System.Windows.Forms.Button();
            this.groupBoxCouleur = new System.Windows.Forms.GroupBox();
            this.radioButtonCarreau = new System.Windows.Forms.RadioButton();
            this.radioButtonTrefle = new System.Windows.Forms.RadioButton();
            this.radioButtonCoeur = new System.Windows.Forms.RadioButton();
            this.radioButtonPique = new System.Windows.Forms.RadioButton();
            this.groupBoxCardPick = new System.Windows.Forms.GroupBox();
            this.pickCard8 = new System.Windows.Forms.PictureBox();
            this.pickCard7 = new System.Windows.Forms.PictureBox();
            this.pickCard6 = new System.Windows.Forms.PictureBox();
            this.pickCard5 = new System.Windows.Forms.PictureBox();
            this.pickCard4 = new System.Windows.Forms.PictureBox();
            this.pickCard3 = new System.Windows.Forms.PictureBox();
            this.pickCard2 = new System.Windows.Forms.PictureBox();
            this.pickCard1 = new System.Windows.Forms.PictureBox();
            this.labelPair2 = new System.Windows.Forms.Label();
            this.labelImpair2 = new System.Windows.Forms.Label();
            this.labelpointPair = new System.Windows.Forms.Label();
            this.labelpointimpair = new System.Windows.Forms.Label();
            this.labelAtout = new System.Windows.Forms.Label();
            this.comboBoxAtout = new System.Windows.Forms.ComboBox();
            this.buttonAnnule = new System.Windows.Forms.Button();
            this.groupBoxJeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).BeginInit();
            this.groupBoxCouleur.SuspendLayout();
            this.groupBoxCardPick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.Location = new System.Drawing.Point(12, 31);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(169, 39);
            this.labelTurn.TabIndex = 0;
            this.labelTurn.Text = "Tour (1/8)";
            // 
            // groupBoxJeu
            // 
            this.groupBoxJeu.Controls.Add(this.carte4);
            this.groupBoxJeu.Controls.Add(this.carte3);
            this.groupBoxJeu.Controls.Add(this.carte2);
            this.groupBoxJeu.Controls.Add(this.carte1);
            this.groupBoxJeu.Location = new System.Drawing.Point(191, 12);
            this.groupBoxJeu.Name = "groupBoxJeu";
            this.groupBoxJeu.Size = new System.Drawing.Size(638, 251);
            this.groupBoxJeu.TabIndex = 1;
            this.groupBoxJeu.TabStop = false;
            // 
            // carte4
            // 
            this.carte4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("carte4.ErrorImage")));
            this.carte4.InitialImage = ((System.Drawing.Image)(resources.GetObject("carte4.InitialImage")));
            this.carte4.Location = new System.Drawing.Point(475, 19);
            this.carte4.Name = "carte4";
            this.carte4.Size = new System.Drawing.Size(150, 225);
            this.carte4.TabIndex = 3;
            this.carte4.TabStop = false;
            this.carte4.Click += new System.EventHandler(this.carte4_Click);
            // 
            // carte3
            // 
            this.carte3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("carte3.ErrorImage")));
            this.carte3.InitialImage = ((System.Drawing.Image)(resources.GetObject("carte3.InitialImage")));
            this.carte3.Location = new System.Drawing.Point(319, 19);
            this.carte3.Name = "carte3";
            this.carte3.Size = new System.Drawing.Size(150, 225);
            this.carte3.TabIndex = 2;
            this.carte3.TabStop = false;
            this.carte3.Click += new System.EventHandler(this.carte3_Click);
            // 
            // carte2
            // 
            this.carte2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("carte2.ErrorImage")));
            this.carte2.InitialImage = ((System.Drawing.Image)(resources.GetObject("carte2.InitialImage")));
            this.carte2.Location = new System.Drawing.Point(163, 19);
            this.carte2.Name = "carte2";
            this.carte2.Size = new System.Drawing.Size(150, 225);
            this.carte2.TabIndex = 1;
            this.carte2.TabStop = false;
            this.carte2.Click += new System.EventHandler(this.carte2_Click);
            // 
            // carte1
            // 
            this.carte1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("carte1.ErrorImage")));
            this.carte1.InitialImage = ((System.Drawing.Image)(resources.GetObject("carte1.InitialImage")));
            this.carte1.Location = new System.Drawing.Point(7, 20);
            this.carte1.Name = "carte1";
            this.carte1.Size = new System.Drawing.Size(150, 225);
            this.carte1.TabIndex = 0;
            this.carte1.TabStop = false;
            this.carte1.Click += new System.EventHandler(this.carte1_Click);
            // 
            // buttonPair
            // 
            this.buttonPair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPair.Location = new System.Drawing.Point(876, 13);
            this.buttonPair.Name = "buttonPair";
            this.buttonPair.Size = new System.Drawing.Size(199, 93);
            this.buttonPair.TabIndex = 2;
            this.buttonPair.Text = "Main pour l\'équipe paire";
            this.buttonPair.UseVisualStyleBackColor = false;
            this.buttonPair.Click += new System.EventHandler(this.buttonPair_Click);
            // 
            // buttonImpair
            // 
            this.buttonImpair.BackColor = System.Drawing.SystemColors.Info;
            this.buttonImpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImpair.Location = new System.Drawing.Point(876, 126);
            this.buttonImpair.Name = "buttonImpair";
            this.buttonImpair.Size = new System.Drawing.Size(199, 94);
            this.buttonImpair.TabIndex = 3;
            this.buttonImpair.Text = "Main pour l\'équipe impaire";
            this.buttonImpair.UseVisualStyleBackColor = false;
            this.buttonImpair.Click += new System.EventHandler(this.buttonImpair_Click);
            // 
            // groupBoxCouleur
            // 
            this.groupBoxCouleur.Controls.Add(this.radioButtonCarreau);
            this.groupBoxCouleur.Controls.Add(this.radioButtonTrefle);
            this.groupBoxCouleur.Controls.Add(this.radioButtonCoeur);
            this.groupBoxCouleur.Controls.Add(this.radioButtonPique);
            this.groupBoxCouleur.Location = new System.Drawing.Point(12, 263);
            this.groupBoxCouleur.Name = "groupBoxCouleur";
            this.groupBoxCouleur.Size = new System.Drawing.Size(317, 52);
            this.groupBoxCouleur.TabIndex = 4;
            this.groupBoxCouleur.TabStop = false;
            // 
            // radioButtonCarreau
            // 
            this.radioButtonCarreau.AutoSize = true;
            this.radioButtonCarreau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCarreau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonCarreau.Location = new System.Drawing.Point(229, 19);
            this.radioButtonCarreau.Name = "radioButtonCarreau";
            this.radioButtonCarreau.Size = new System.Drawing.Size(84, 24);
            this.radioButtonCarreau.TabIndex = 3;
            this.radioButtonCarreau.TabStop = true;
            this.radioButtonCarreau.Text = "Carreau";
            this.radioButtonCarreau.UseVisualStyleBackColor = true;
            this.radioButtonCarreau.CheckedChanged += new System.EventHandler(this.radioButtonCarreau_CheckedChanged);
            // 
            // radioButtonTrefle
            // 
            this.radioButtonTrefle.AutoSize = true;
            this.radioButtonTrefle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrefle.ForeColor = System.Drawing.Color.DimGray;
            this.radioButtonTrefle.Location = new System.Drawing.Point(156, 19);
            this.radioButtonTrefle.Name = "radioButtonTrefle";
            this.radioButtonTrefle.Size = new System.Drawing.Size(67, 24);
            this.radioButtonTrefle.TabIndex = 2;
            this.radioButtonTrefle.TabStop = true;
            this.radioButtonTrefle.Text = "Trèfle";
            this.radioButtonTrefle.UseVisualStyleBackColor = true;
            this.radioButtonTrefle.CheckedChanged += new System.EventHandler(this.radioButtonTrefle_CheckedChanged);
            // 
            // radioButtonCoeur
            // 
            this.radioButtonCoeur.AutoSize = true;
            this.radioButtonCoeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCoeur.ForeColor = System.Drawing.Color.Red;
            this.radioButtonCoeur.Location = new System.Drawing.Point(80, 19);
            this.radioButtonCoeur.Name = "radioButtonCoeur";
            this.radioButtonCoeur.Size = new System.Drawing.Size(70, 24);
            this.radioButtonCoeur.TabIndex = 1;
            this.radioButtonCoeur.TabStop = true;
            this.radioButtonCoeur.Text = "Coeur";
            this.radioButtonCoeur.UseVisualStyleBackColor = true;
            this.radioButtonCoeur.CheckedChanged += new System.EventHandler(this.radioButtonCoeur_CheckedChanged);
            // 
            // radioButtonPique
            // 
            this.radioButtonPique.AutoSize = true;
            this.radioButtonPique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPique.Location = new System.Drawing.Point(7, 19);
            this.radioButtonPique.Name = "radioButtonPique";
            this.radioButtonPique.Size = new System.Drawing.Size(67, 24);
            this.radioButtonPique.TabIndex = 0;
            this.radioButtonPique.TabStop = true;
            this.radioButtonPique.Text = "Pique";
            this.radioButtonPique.UseVisualStyleBackColor = true;
            this.radioButtonPique.CheckedChanged += new System.EventHandler(this.radioButtonPique_CheckedChanged);
            // 
            // groupBoxCardPick
            // 
            this.groupBoxCardPick.Controls.Add(this.pickCard8);
            this.groupBoxCardPick.Controls.Add(this.pickCard7);
            this.groupBoxCardPick.Controls.Add(this.pickCard6);
            this.groupBoxCardPick.Controls.Add(this.pickCard5);
            this.groupBoxCardPick.Controls.Add(this.pickCard4);
            this.groupBoxCardPick.Controls.Add(this.pickCard3);
            this.groupBoxCardPick.Controls.Add(this.pickCard2);
            this.groupBoxCardPick.Controls.Add(this.pickCard1);
            this.groupBoxCardPick.Location = new System.Drawing.Point(12, 309);
            this.groupBoxCardPick.Name = "groupBoxCardPick";
            this.groupBoxCardPick.Size = new System.Drawing.Size(1260, 274);
            this.groupBoxCardPick.TabIndex = 5;
            this.groupBoxCardPick.TabStop = false;
            // 
            // pickCard8
            // 
            this.pickCard8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard8.ErrorImage")));
            this.pickCard8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard8.InitialImage")));
            this.pickCard8.Location = new System.Drawing.Point(1098, 13);
            this.pickCard8.Name = "pickCard8";
            this.pickCard8.Size = new System.Drawing.Size(150, 245);
            this.pickCard8.TabIndex = 8;
            this.pickCard8.TabStop = false;
            this.pickCard8.Click += new System.EventHandler(this.pickCard8_Click);
            // 
            // pickCard7
            // 
            this.pickCard7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard7.ErrorImage")));
            this.pickCard7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard7.InitialImage")));
            this.pickCard7.Location = new System.Drawing.Point(942, 13);
            this.pickCard7.Name = "pickCard7";
            this.pickCard7.Size = new System.Drawing.Size(150, 245);
            this.pickCard7.TabIndex = 7;
            this.pickCard7.TabStop = false;
            this.pickCard7.Click += new System.EventHandler(this.pickCard7_Click);
            // 
            // pickCard6
            // 
            this.pickCard6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard6.ErrorImage")));
            this.pickCard6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard6.InitialImage")));
            this.pickCard6.Location = new System.Drawing.Point(786, 13);
            this.pickCard6.Name = "pickCard6";
            this.pickCard6.Size = new System.Drawing.Size(150, 245);
            this.pickCard6.TabIndex = 6;
            this.pickCard6.TabStop = false;
            this.pickCard6.Click += new System.EventHandler(this.pickCard6_Click);
            // 
            // pickCard5
            // 
            this.pickCard5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard5.ErrorImage")));
            this.pickCard5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard5.InitialImage")));
            this.pickCard5.Location = new System.Drawing.Point(630, 13);
            this.pickCard5.Name = "pickCard5";
            this.pickCard5.Size = new System.Drawing.Size(150, 245);
            this.pickCard5.TabIndex = 5;
            this.pickCard5.TabStop = false;
            this.pickCard5.Click += new System.EventHandler(this.pickCard5_Click);
            // 
            // pickCard4
            // 
            this.pickCard4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard4.ErrorImage")));
            this.pickCard4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard4.InitialImage")));
            this.pickCard4.Location = new System.Drawing.Point(474, 13);
            this.pickCard4.Name = "pickCard4";
            this.pickCard4.Size = new System.Drawing.Size(150, 245);
            this.pickCard4.TabIndex = 4;
            this.pickCard4.TabStop = false;
            this.pickCard4.Click += new System.EventHandler(this.pickCard4_Click);
            // 
            // pickCard3
            // 
            this.pickCard3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard3.ErrorImage")));
            this.pickCard3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard3.InitialImage")));
            this.pickCard3.Location = new System.Drawing.Point(318, 13);
            this.pickCard3.Name = "pickCard3";
            this.pickCard3.Size = new System.Drawing.Size(150, 245);
            this.pickCard3.TabIndex = 3;
            this.pickCard3.TabStop = false;
            this.pickCard3.Click += new System.EventHandler(this.pickCard3_Click);
            // 
            // pickCard2
            // 
            this.pickCard2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard2.ErrorImage")));
            this.pickCard2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard2.InitialImage")));
            this.pickCard2.Location = new System.Drawing.Point(162, 13);
            this.pickCard2.Name = "pickCard2";
            this.pickCard2.Size = new System.Drawing.Size(150, 245);
            this.pickCard2.TabIndex = 2;
            this.pickCard2.TabStop = false;
            this.pickCard2.Click += new System.EventHandler(this.pickCard2_Click);
            // 
            // pickCard1
            // 
            this.pickCard1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickCard1.ErrorImage")));
            this.pickCard1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickCard1.InitialImage")));
            this.pickCard1.Location = new System.Drawing.Point(6, 13);
            this.pickCard1.Name = "pickCard1";
            this.pickCard1.Size = new System.Drawing.Size(150, 245);
            this.pickCard1.TabIndex = 1;
            this.pickCard1.TabStop = false;
            this.pickCard1.Click += new System.EventHandler(this.pickCard1_Click);
            // 
            // labelPair2
            // 
            this.labelPair2.AutoSize = true;
            this.labelPair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPair2.Location = new System.Drawing.Point(1106, 47);
            this.labelPair2.Name = "labelPair2";
            this.labelPair2.Size = new System.Drawing.Size(62, 20);
            this.labelPair2.TabIndex = 6;
            this.labelPair2.Text = "J2 && J4";
            // 
            // labelImpair2
            // 
            this.labelImpair2.AutoSize = true;
            this.labelImpair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpair2.Location = new System.Drawing.Point(1110, 164);
            this.labelImpair2.Name = "labelImpair2";
            this.labelImpair2.Size = new System.Drawing.Size(62, 20);
            this.labelImpair2.TabIndex = 7;
            this.labelImpair2.Text = "J1 && J3";
            // 
            // labelpointPair
            // 
            this.labelpointPair.AutoSize = true;
            this.labelpointPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpointPair.Location = new System.Drawing.Point(1106, 86);
            this.labelpointPair.Name = "labelpointPair";
            this.labelpointPair.Size = new System.Drawing.Size(58, 20);
            this.labelpointPair.TabIndex = 8;
            this.labelpointPair.Text = "0/1000";
            // 
            // labelpointimpair
            // 
            this.labelpointimpair.AutoSize = true;
            this.labelpointimpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpointimpair.Location = new System.Drawing.Point(1110, 200);
            this.labelpointimpair.Name = "labelpointimpair";
            this.labelpointimpair.Size = new System.Drawing.Size(58, 20);
            this.labelpointimpair.TabIndex = 9;
            this.labelpointimpair.Text = "0/1000";
            // 
            // labelAtout
            // 
            this.labelAtout.AutoSize = true;
            this.labelAtout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtout.Location = new System.Drawing.Point(19, 92);
            this.labelAtout.Name = "labelAtout";
            this.labelAtout.Size = new System.Drawing.Size(48, 20);
            this.labelAtout.TabIndex = 10;
            this.labelAtout.Text = "Atout";
            // 
            // comboBoxAtout
            // 
            this.comboBoxAtout.FormattingEnabled = true;
            this.comboBoxAtout.Items.AddRange(new object[] {
            "Pique",
            "Coeur",
            "Trèfle",
            "Carreau"});
            this.comboBoxAtout.Location = new System.Drawing.Point(74, 94);
            this.comboBoxAtout.Name = "comboBoxAtout";
            this.comboBoxAtout.Size = new System.Drawing.Size(94, 21);
            this.comboBoxAtout.TabIndex = 11;
            this.comboBoxAtout.Text = "-Atout-";
            this.comboBoxAtout.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtout_SelectedIndexChanged);
            // 
            // buttonAnnule
            // 
            this.buttonAnnule.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnule.Location = new System.Drawing.Point(1110, 240);
            this.buttonAnnule.Name = "buttonAnnule";
            this.buttonAnnule.Size = new System.Drawing.Size(150, 63);
            this.buttonAnnule.TabIndex = 12;
            this.buttonAnnule.Text = "Annuler la dernière main";
            this.buttonAnnule.UseVisualStyleBackColor = false;
            this.buttonAnnule.Click += new System.EventHandler(this.buttonAnnule_Click);
            // 
            // CreationPile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 588);
            this.Controls.Add(this.buttonAnnule);
            this.Controls.Add(this.comboBoxAtout);
            this.Controls.Add(this.labelAtout);
            this.Controls.Add(this.labelpointimpair);
            this.Controls.Add(this.labelpointPair);
            this.Controls.Add(this.labelImpair2);
            this.Controls.Add(this.labelPair2);
            this.Controls.Add(this.groupBoxCardPick);
            this.Controls.Add(this.groupBoxCouleur);
            this.Controls.Add(this.buttonImpair);
            this.Controls.Add(this.buttonPair);
            this.Controls.Add(this.groupBoxJeu);
            this.Controls.Add(this.labelTurn);
            this.Name = "CreationPile";
            this.Text = "CreationPile";
            this.groupBoxJeu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).EndInit();
            this.groupBoxCouleur.ResumeLayout(false);
            this.groupBoxCouleur.PerformLayout();
            this.groupBoxCardPick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pickCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.GroupBox groupBoxJeu;
        private System.Windows.Forms.PictureBox carte2;
        private System.Windows.Forms.PictureBox carte1;
        private System.Windows.Forms.PictureBox carte4;
        private System.Windows.Forms.PictureBox carte3;
        private System.Windows.Forms.Button buttonPair;
        private System.Windows.Forms.Button buttonImpair;
        private System.Windows.Forms.GroupBox groupBoxCouleur;
        private System.Windows.Forms.RadioButton radioButtonCarreau;
        private System.Windows.Forms.RadioButton radioButtonTrefle;
        private System.Windows.Forms.RadioButton radioButtonCoeur;
        private System.Windows.Forms.RadioButton radioButtonPique;
        private System.Windows.Forms.GroupBox groupBoxCardPick;
        private System.Windows.Forms.PictureBox pickCard8;
        private System.Windows.Forms.PictureBox pickCard7;
        private System.Windows.Forms.PictureBox pickCard6;
        private System.Windows.Forms.PictureBox pickCard5;
        private System.Windows.Forms.PictureBox pickCard4;
        private System.Windows.Forms.PictureBox pickCard3;
        private System.Windows.Forms.PictureBox pickCard1;
        private System.Windows.Forms.Label labelPair2;
        private System.Windows.Forms.Label labelImpair2;
        private System.Windows.Forms.PictureBox pickCard2;
        private System.Windows.Forms.Label labelpointPair;
        private System.Windows.Forms.Label labelpointimpair;
        private System.Windows.Forms.Label labelAtout;
        private System.Windows.Forms.ComboBox comboBoxAtout;
        private System.Windows.Forms.Button buttonAnnule;
    }
}