namespace CompteurBelotteWindowsForm
{
    partial class CreationEquipe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEquipe = new System.Windows.Forms.Button();
            this.buttonValide = new System.Windows.Forms.Button();
            this.labelPair = new System.Windows.Forms.Label();
            this.labelImpair = new System.Windows.Forms.Label();
            this.labelJ2 = new System.Windows.Forms.Label();
            this.labelJ4 = new System.Windows.Forms.Label();
            this.labelJ1 = new System.Windows.Forms.Label();
            this.labelJ3 = new System.Windows.Forms.Label();
            this.textBoxJ1 = new System.Windows.Forms.TextBox();
            this.textBoxJ3 = new System.Windows.Forms.TextBox();
            this.textBoxJ2 = new System.Windows.Forms.TextBox();
            this.textBoxJ4 = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.radioButtonScoreAutre = new System.Windows.Forms.RadioButton();
            this.radioButtonScore1500 = new System.Windows.Forms.RadioButton();
            this.radioButtonScore1000 = new System.Windows.Forms.RadioButton();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDistribuer = new System.Windows.Forms.GroupBox();
            this.radioDistribuer4 = new System.Windows.Forms.RadioButton();
            this.radioDistribuer3 = new System.Windows.Forms.RadioButton();
            this.radioDistribuer2 = new System.Windows.Forms.RadioButton();
            this.radioDistribuer1 = new System.Windows.Forms.RadioButton();
            this.groupBoxScore.SuspendLayout();
            this.groupBoxDistribuer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEquipe
            // 
            this.buttonEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEquipe.Location = new System.Drawing.Point(468, 225);
            this.buttonEquipe.Name = "buttonEquipe";
            this.buttonEquipe.Size = new System.Drawing.Size(147, 45);
            this.buttonEquipe.TabIndex = 1;
            this.buttonEquipe.Text = "Équipes AUTO";
            this.buttonEquipe.UseVisualStyleBackColor = true;
            this.buttonEquipe.Click += new System.EventHandler(this.buttonEquipe_Click);
            // 
            // buttonValide
            // 
            this.buttonValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonValide.Location = new System.Drawing.Point(621, 190);
            this.buttonValide.Name = "buttonValide";
            this.buttonValide.Size = new System.Drawing.Size(147, 80);
            this.buttonValide.TabIndex = 2;
            this.buttonValide.Text = "Valider";
            this.buttonValide.UseVisualStyleBackColor = true;
            this.buttonValide.Click += new System.EventHandler(this.buttonValide_Click);
            // 
            // labelPair
            // 
            this.labelPair.AutoSize = true;
            this.labelPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPair.Location = new System.Drawing.Point(299, 9);
            this.labelPair.Name = "labelPair";
            this.labelPair.Size = new System.Drawing.Size(145, 25);
            this.labelPair.TabIndex = 3;
            this.labelPair.Text = "Equipe paire";
            // 
            // labelImpair
            // 
            this.labelImpair.AutoSize = true;
            this.labelImpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpair.Location = new System.Drawing.Point(18, 9);
            this.labelImpair.Name = "labelImpair";
            this.labelImpair.Size = new System.Drawing.Size(169, 25);
            this.labelImpair.TabIndex = 4;
            this.labelImpair.Text = "Equipe impaire";
            // 
            // labelJ2
            // 
            this.labelJ2.AutoSize = true;
            this.labelJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ2.Location = new System.Drawing.Point(300, 48);
            this.labelJ2.Name = "labelJ2";
            this.labelJ2.Size = new System.Drawing.Size(71, 20);
            this.labelJ2.TabIndex = 5;
            this.labelJ2.Text = "Joueur 2";
            // 
            // labelJ4
            // 
            this.labelJ4.AutoSize = true;
            this.labelJ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ4.Location = new System.Drawing.Point(300, 79);
            this.labelJ4.Name = "labelJ4";
            this.labelJ4.Size = new System.Drawing.Size(71, 20);
            this.labelJ4.TabIndex = 6;
            this.labelJ4.Text = "Joueur 4";
            // 
            // labelJ1
            // 
            this.labelJ1.AutoSize = true;
            this.labelJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ1.Location = new System.Drawing.Point(19, 48);
            this.labelJ1.Name = "labelJ1";
            this.labelJ1.Size = new System.Drawing.Size(71, 20);
            this.labelJ1.TabIndex = 7;
            this.labelJ1.Text = "Joueur 1";
            // 
            // labelJ3
            // 
            this.labelJ3.AutoSize = true;
            this.labelJ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ3.Location = new System.Drawing.Point(19, 79);
            this.labelJ3.Name = "labelJ3";
            this.labelJ3.Size = new System.Drawing.Size(71, 20);
            this.labelJ3.TabIndex = 8;
            this.labelJ3.Text = "Joueur 3";
            // 
            // textBoxJ1
            // 
            this.textBoxJ1.Enabled = false;
            this.textBoxJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxJ1.Location = new System.Drawing.Point(96, 48);
            this.textBoxJ1.Name = "textBoxJ1";
            this.textBoxJ1.Size = new System.Drawing.Size(100, 23);
            this.textBoxJ1.TabIndex = 9;
            this.textBoxJ1.TextChanged += new System.EventHandler(this.textBoxJ1_TextChanged);
            // 
            // textBoxJ3
            // 
            this.textBoxJ3.Enabled = false;
            this.textBoxJ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxJ3.Location = new System.Drawing.Point(96, 79);
            this.textBoxJ3.Name = "textBoxJ3";
            this.textBoxJ3.Size = new System.Drawing.Size(100, 23);
            this.textBoxJ3.TabIndex = 10;
            this.textBoxJ3.TextChanged += new System.EventHandler(this.textBoxJ3_TextChanged);
            // 
            // textBoxJ2
            // 
            this.textBoxJ2.Enabled = false;
            this.textBoxJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxJ2.Location = new System.Drawing.Point(377, 50);
            this.textBoxJ2.Name = "textBoxJ2";
            this.textBoxJ2.Size = new System.Drawing.Size(100, 23);
            this.textBoxJ2.TabIndex = 11;
            this.textBoxJ2.TextChanged += new System.EventHandler(this.textBoxJ2_TextChanged);
            // 
            // textBoxJ4
            // 
            this.textBoxJ4.Enabled = false;
            this.textBoxJ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxJ4.Location = new System.Drawing.Point(377, 78);
            this.textBoxJ4.Name = "textBoxJ4";
            this.textBoxJ4.Size = new System.Drawing.Size(100, 23);
            this.textBoxJ4.TabIndex = 12;
            this.textBoxJ4.TextChanged += new System.EventHandler(this.textBoxJ4_TextChanged);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(585, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(177, 26);
            this.labelScore.TabIndex = 13;
            this.labelScore.Text = "Score à atteindre";
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.textBoxScore);
            this.groupBoxScore.Controls.Add(this.radioButtonScoreAutre);
            this.groupBoxScore.Controls.Add(this.radioButtonScore1500);
            this.groupBoxScore.Controls.Add(this.radioButtonScore1000);
            this.groupBoxScore.Location = new System.Drawing.Point(576, 38);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(192, 99);
            this.groupBoxScore.TabIndex = 14;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Enter += new System.EventHandler(this.groupBoxScore_Enter);
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(86, 73);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore.TabIndex = 3;
            this.textBoxScore.TextChanged += new System.EventHandler(this.textBoxScore_TextChanged);
            // 
            // radioButtonScoreAutre
            // 
            this.radioButtonScoreAutre.AutoSize = true;
            this.radioButtonScoreAutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonScoreAutre.Location = new System.Drawing.Point(14, 72);
            this.radioButtonScoreAutre.Name = "radioButtonScoreAutre";
            this.radioButtonScoreAutre.Size = new System.Drawing.Size(60, 21);
            this.radioButtonScoreAutre.TabIndex = 2;
            this.radioButtonScoreAutre.Text = "Autre";
            this.radioButtonScoreAutre.UseVisualStyleBackColor = true;
            this.radioButtonScoreAutre.CheckedChanged += new System.EventHandler(this.radioButtonScoreAutre_CheckedChanged);
            // 
            // radioButtonScore1500
            // 
            this.radioButtonScore1500.AutoSize = true;
            this.radioButtonScore1500.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonScore1500.Location = new System.Drawing.Point(115, 19);
            this.radioButtonScore1500.Name = "radioButtonScore1500";
            this.radioButtonScore1500.Size = new System.Drawing.Size(58, 21);
            this.radioButtonScore1500.TabIndex = 1;
            this.radioButtonScore1500.Text = "1500";
            this.radioButtonScore1500.UseVisualStyleBackColor = true;
            // 
            // radioButtonScore1000
            // 
            this.radioButtonScore1000.AutoSize = true;
            this.radioButtonScore1000.Checked = true;
            this.radioButtonScore1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonScore1000.Location = new System.Drawing.Point(14, 19);
            this.radioButtonScore1000.Name = "radioButtonScore1000";
            this.radioButtonScore1000.Size = new System.Drawing.Size(58, 21);
            this.radioButtonScore1000.TabIndex = 0;
            this.radioButtonScore1000.TabStop = true;
            this.radioButtonScore1000.Text = "1000";
            this.radioButtonScore1000.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(85, 117);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(111, 20);
            this.labelError.TabIndex = 15;
            this.labelError.Text = "error message";
            this.labelError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Qui va distribuer ?";
            // 
            // groupBoxDistribuer
            // 
            this.groupBoxDistribuer.Controls.Add(this.radioDistribuer4);
            this.groupBoxDistribuer.Controls.Add(this.radioDistribuer3);
            this.groupBoxDistribuer.Controls.Add(this.radioDistribuer2);
            this.groupBoxDistribuer.Controls.Add(this.radioDistribuer1);
            this.groupBoxDistribuer.Location = new System.Drawing.Point(13, 187);
            this.groupBoxDistribuer.Name = "groupBoxDistribuer";
            this.groupBoxDistribuer.Size = new System.Drawing.Size(449, 83);
            this.groupBoxDistribuer.TabIndex = 17;
            this.groupBoxDistribuer.TabStop = false;
            // 
            // radioDistribuer4
            // 
            this.radioDistribuer4.AutoSize = true;
            this.radioDistribuer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioDistribuer4.Location = new System.Drawing.Point(182, 56);
            this.radioDistribuer4.Name = "radioDistribuer4";
            this.radioDistribuer4.Size = new System.Drawing.Size(41, 21);
            this.radioDistribuer4.TabIndex = 3;
            this.radioDistribuer4.Text = "J4";
            this.radioDistribuer4.UseVisualStyleBackColor = true;
            this.radioDistribuer4.CheckedChanged += new System.EventHandler(this.radioDistribuer4_CheckedChanged);
            // 
            // radioDistribuer3
            // 
            this.radioDistribuer3.AutoSize = true;
            this.radioDistribuer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioDistribuer3.Location = new System.Drawing.Point(6, 58);
            this.radioDistribuer3.Name = "radioDistribuer3";
            this.radioDistribuer3.Size = new System.Drawing.Size(41, 21);
            this.radioDistribuer3.TabIndex = 2;
            this.radioDistribuer3.Text = "J3";
            this.radioDistribuer3.UseVisualStyleBackColor = true;
            this.radioDistribuer3.CheckedChanged += new System.EventHandler(this.radioDistribuer3_CheckedChanged);
            // 
            // radioDistribuer2
            // 
            this.radioDistribuer2.AutoSize = true;
            this.radioDistribuer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioDistribuer2.Location = new System.Drawing.Point(182, 19);
            this.radioDistribuer2.Name = "radioDistribuer2";
            this.radioDistribuer2.Size = new System.Drawing.Size(41, 21);
            this.radioDistribuer2.TabIndex = 1;
            this.radioDistribuer2.Text = "J2";
            this.radioDistribuer2.UseVisualStyleBackColor = true;
            this.radioDistribuer2.CheckedChanged += new System.EventHandler(this.radioDistribuer2_CheckedChanged);
            // 
            // radioDistribuer1
            // 
            this.radioDistribuer1.AutoSize = true;
            this.radioDistribuer1.Checked = true;
            this.radioDistribuer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioDistribuer1.Location = new System.Drawing.Point(6, 19);
            this.radioDistribuer1.Name = "radioDistribuer1";
            this.radioDistribuer1.Size = new System.Drawing.Size(41, 21);
            this.radioDistribuer1.TabIndex = 0;
            this.radioDistribuer1.TabStop = true;
            this.radioDistribuer1.Text = "J1";
            this.radioDistribuer1.UseVisualStyleBackColor = true;
            this.radioDistribuer1.CheckedChanged += new System.EventHandler(this.radioDistribuer1_CheckedChanged);
            // 
            // CreationEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 282);
            this.Controls.Add(this.groupBoxDistribuer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.groupBoxScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxJ4);
            this.Controls.Add(this.textBoxJ2);
            this.Controls.Add(this.textBoxJ3);
            this.Controls.Add(this.textBoxJ1);
            this.Controls.Add(this.labelJ3);
            this.Controls.Add(this.labelJ1);
            this.Controls.Add(this.labelJ4);
            this.Controls.Add(this.labelJ2);
            this.Controls.Add(this.labelImpair);
            this.Controls.Add(this.labelPair);
            this.Controls.Add(this.buttonValide);
            this.Controls.Add(this.buttonEquipe);
            this.Name = "CreationEquipe";
            this.Text = "Belotte Tracker";
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.groupBoxDistribuer.ResumeLayout(false);
            this.groupBoxDistribuer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEquipe;
        private System.Windows.Forms.Button buttonValide;
        private System.Windows.Forms.Label labelPair;
        private System.Windows.Forms.Label labelImpair;
        private System.Windows.Forms.Label labelJ2;
        private System.Windows.Forms.Label labelJ4;
        private System.Windows.Forms.Label labelJ1;
        private System.Windows.Forms.Label labelJ3;
        private System.Windows.Forms.TextBox textBoxJ1;
        private System.Windows.Forms.TextBox textBoxJ3;
        private System.Windows.Forms.TextBox textBoxJ2;
        private System.Windows.Forms.TextBox textBoxJ4;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.RadioButton radioButtonScoreAutre;
        private System.Windows.Forms.RadioButton radioButtonScore1500;
        private System.Windows.Forms.RadioButton radioButtonScore1000;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDistribuer;
        private System.Windows.Forms.RadioButton radioDistribuer4;
        private System.Windows.Forms.RadioButton radioDistribuer3;
        private System.Windows.Forms.RadioButton radioDistribuer2;
        private System.Windows.Forms.RadioButton radioDistribuer1;

    }
}

