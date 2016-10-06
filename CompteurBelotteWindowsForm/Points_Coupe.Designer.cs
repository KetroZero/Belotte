namespace CompteurBelotteWindowsForm
{
    partial class Points_Coupe
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
            this.labelEquipePair = new System.Windows.Forms.Label();
            this.labelEquipeImapir = new System.Windows.Forms.Label();
            this.labelJ2J4 = new System.Windows.Forms.Label();
            this.labelJ1J3 = new System.Windows.Forms.Label();
            this.groupAtout = new System.Windows.Forms.GroupBox();
            this.checkBelotteImpair = new System.Windows.Forms.CheckBox();
            this.checkBelottePair = new System.Windows.Forms.CheckBox();
            this.radioButtonImpair = new System.Windows.Forms.RadioButton();
            this.radioButtonPair = new System.Windows.Forms.RadioButton();
            this.labelRemporte = new System.Windows.Forms.Label();
            this.labelPointPair1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPointsImpair = new System.Windows.Forms.Label();
            this.labelTotalPair = new System.Windows.Forms.Label();
            this.labelTotalImpair = new System.Windows.Forms.Label();
            this.buttonValide = new System.Windows.Forms.Button();
            this.listBoxPair = new System.Windows.Forms.ListBox();
            this.listBoxImpair = new System.Windows.Forms.ListBox();
            this.labelCumulPair = new System.Windows.Forms.Label();
            this.labelCumulImpair = new System.Windows.Forms.Label();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.groupAtout.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEquipePair
            // 
            this.labelEquipePair.AutoSize = true;
            this.labelEquipePair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEquipePair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipePair.Location = new System.Drawing.Point(508, 9);
            this.labelEquipePair.Name = "labelEquipePair";
            this.labelEquipePair.Size = new System.Drawing.Size(137, 26);
            this.labelEquipePair.TabIndex = 0;
            this.labelEquipePair.Text = "Equipe Paire";
            // 
            // labelEquipeImapir
            // 
            this.labelEquipeImapir.AutoSize = true;
            this.labelEquipeImapir.BackColor = System.Drawing.SystemColors.Info;
            this.labelEquipeImapir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipeImapir.Location = new System.Drawing.Point(711, 9);
            this.labelEquipeImapir.Name = "labelEquipeImapir";
            this.labelEquipeImapir.Size = new System.Drawing.Size(159, 26);
            this.labelEquipeImapir.TabIndex = 1;
            this.labelEquipeImapir.Text = "Equipe Impaire";
            // 
            // labelJ2J4
            // 
            this.labelJ2J4.AutoSize = true;
            this.labelJ2J4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ2J4.Location = new System.Drawing.Point(509, 57);
            this.labelJ2J4.Name = "labelJ2J4";
            this.labelJ2J4.Size = new System.Drawing.Size(65, 20);
            this.labelJ2J4.TabIndex = 4;
            this.labelJ2J4.Text = "J2 et J4";
            // 
            // labelJ1J3
            // 
            this.labelJ1J3.AutoSize = true;
            this.labelJ1J3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ1J3.Location = new System.Drawing.Point(712, 57);
            this.labelJ1J3.Name = "labelJ1J3";
            this.labelJ1J3.Size = new System.Drawing.Size(65, 20);
            this.labelJ1J3.TabIndex = 5;
            this.labelJ1J3.Text = "J1 et J3";
            // 
            // groupAtout
            // 
            this.groupAtout.Controls.Add(this.checkBelotteImpair);
            this.groupAtout.Controls.Add(this.checkBelottePair);
            this.groupAtout.Controls.Add(this.radioButtonImpair);
            this.groupAtout.Controls.Add(this.radioButtonPair);
            this.groupAtout.Location = new System.Drawing.Point(12, 57);
            this.groupAtout.Name = "groupAtout";
            this.groupAtout.Size = new System.Drawing.Size(285, 75);
            this.groupAtout.TabIndex = 6;
            this.groupAtout.TabStop = false;
            // 
            // checkBelotteImpair
            // 
            this.checkBelotteImpair.AutoSize = true;
            this.checkBelotteImpair.Location = new System.Drawing.Point(165, 42);
            this.checkBelotteImpair.Name = "checkBelotteImpair";
            this.checkBelotteImpair.Size = new System.Drawing.Size(59, 17);
            this.checkBelotteImpair.TabIndex = 3;
            this.checkBelotteImpair.Text = "Belotte";
            this.checkBelotteImpair.UseVisualStyleBackColor = true;
            this.checkBelotteImpair.CheckedChanged += new System.EventHandler(this.checkBelotteImpair_CheckedChanged);
            // 
            // checkBelottePair
            // 
            this.checkBelottePair.AutoSize = true;
            this.checkBelottePair.Location = new System.Drawing.Point(165, 19);
            this.checkBelottePair.Name = "checkBelottePair";
            this.checkBelottePair.Size = new System.Drawing.Size(59, 17);
            this.checkBelottePair.TabIndex = 2;
            this.checkBelottePair.Text = "Belotte";
            this.checkBelottePair.UseVisualStyleBackColor = true;
            this.checkBelottePair.CheckedChanged += new System.EventHandler(this.checkBelottePair_CheckedChanged);
            // 
            // radioButtonImpair
            // 
            this.radioButtonImpair.AutoSize = true;
            this.radioButtonImpair.Location = new System.Drawing.Point(6, 42);
            this.radioButtonImpair.Name = "radioButtonImpair";
            this.radioButtonImpair.Size = new System.Drawing.Size(99, 17);
            this.radioButtonImpair.TabIndex = 1;
            this.radioButtonImpair.TabStop = true;
            this.radioButtonImpair.Text = "Impaire J1 et J3";
            this.radioButtonImpair.UseVisualStyleBackColor = true;
            this.radioButtonImpair.CheckedChanged += new System.EventHandler(this.radioButtonImpair_CheckedChanged);
            // 
            // radioButtonPair
            // 
            this.radioButtonPair.AutoSize = true;
            this.radioButtonPair.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPair.Name = "radioButtonPair";
            this.radioButtonPair.Size = new System.Drawing.Size(89, 17);
            this.radioButtonPair.TabIndex = 0;
            this.radioButtonPair.TabStop = true;
            this.radioButtonPair.Text = "Paire J2 et J4";
            this.radioButtonPair.UseVisualStyleBackColor = true;
            this.radioButtonPair.CheckedChanged += new System.EventHandler(this.radioButtonPair_CheckedChanged);
            // 
            // labelRemporte
            // 
            this.labelRemporte.AutoSize = true;
            this.labelRemporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemporte.Location = new System.Drawing.Point(15, 24);
            this.labelRemporte.Name = "labelRemporte";
            this.labelRemporte.Size = new System.Drawing.Size(135, 20);
            this.labelRemporte.TabIndex = 7;
            this.labelRemporte.Text = "Qui à pris l\'atout ?";
            // 
            // labelPointPair1
            // 
            this.labelPointPair1.AutoSize = true;
            this.labelPointPair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointPair1.Location = new System.Drawing.Point(16, 212);
            this.labelPointPair1.Name = "labelPointPair1";
            this.labelPointPair1.Size = new System.Drawing.Size(109, 20);
            this.labelPointPair1.TabIndex = 8;
            this.labelPointPair1.Text = "Points du tas :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Equipe Paire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Equipe Impaire";
            // 
            // labelPointsImpair
            // 
            this.labelPointsImpair.AutoSize = true;
            this.labelPointsImpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsImpair.Location = new System.Drawing.Point(194, 212);
            this.labelPointsImpair.Name = "labelPointsImpair";
            this.labelPointsImpair.Size = new System.Drawing.Size(109, 20);
            this.labelPointsImpair.TabIndex = 11;
            this.labelPointsImpair.Text = "Points du tas :";
            // 
            // labelTotalPair
            // 
            this.labelTotalPair.AutoSize = true;
            this.labelTotalPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPair.Location = new System.Drawing.Point(19, 252);
            this.labelTotalPair.Name = "labelTotalPair";
            this.labelTotalPair.Size = new System.Drawing.Size(56, 20);
            this.labelTotalPair.TabIndex = 12;
            this.labelTotalPair.Text = "Total : ";
            // 
            // labelTotalImpair
            // 
            this.labelTotalImpair.AutoSize = true;
            this.labelTotalImpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalImpair.Location = new System.Drawing.Point(194, 252);
            this.labelTotalImpair.Name = "labelTotalImpair";
            this.labelTotalImpair.Size = new System.Drawing.Size(56, 20);
            this.labelTotalImpair.TabIndex = 13;
            this.labelTotalImpair.Text = "Total : ";
            // 
            // buttonValide
            // 
            this.buttonValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValide.Location = new System.Drawing.Point(20, 361);
            this.buttonValide.Name = "buttonValide";
            this.buttonValide.Size = new System.Drawing.Size(131, 72);
            this.buttonValide.TabIndex = 14;
            this.buttonValide.Text = "Valider";
            this.buttonValide.UseVisualStyleBackColor = true;
            this.buttonValide.Click += new System.EventHandler(this.buttonValide_Click);
            // 
            // listBoxPair
            // 
            this.listBoxPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPair.FormattingEnabled = true;
            this.listBoxPair.ItemHeight = 24;
            this.listBoxPair.Location = new System.Drawing.Point(513, 115);
            this.listBoxPair.Name = "listBoxPair";
            this.listBoxPair.Size = new System.Drawing.Size(132, 292);
            this.listBoxPair.TabIndex = 15;
            // 
            // listBoxImpair
            // 
            this.listBoxImpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxImpair.FormattingEnabled = true;
            this.listBoxImpair.ItemHeight = 24;
            this.listBoxImpair.Location = new System.Drawing.Point(716, 115);
            this.listBoxImpair.Name = "listBoxImpair";
            this.listBoxImpair.Size = new System.Drawing.Size(132, 292);
            this.listBoxImpair.TabIndex = 16;
            // 
            // labelCumulPair
            // 
            this.labelCumulPair.AutoSize = true;
            this.labelCumulPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCumulPair.Location = new System.Drawing.Point(530, 413);
            this.labelCumulPair.Name = "labelCumulPair";
            this.labelCumulPair.Size = new System.Drawing.Size(44, 20);
            this.labelCumulPair.TabIndex = 17;
            this.labelCumulPair.Text = "Total";
            // 
            // labelCumulImpair
            // 
            this.labelCumulImpair.AutoSize = true;
            this.labelCumulImpair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCumulImpair.Location = new System.Drawing.Point(733, 413);
            this.labelCumulImpair.Name = "labelCumulImpair";
            this.labelCumulImpair.Size = new System.Drawing.Size(44, 20);
            this.labelCumulImpair.TabIndex = 18;
            this.labelCumulImpair.Text = "Total";
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(197, 361);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(131, 72);
            this.buttonSuivant.TabIndex = 19;
            this.buttonSuivant.Text = "Tour suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // Points_Coupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 445);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.labelCumulImpair);
            this.Controls.Add(this.labelCumulPair);
            this.Controls.Add(this.listBoxImpair);
            this.Controls.Add(this.listBoxPair);
            this.Controls.Add(this.buttonValide);
            this.Controls.Add(this.labelTotalImpair);
            this.Controls.Add(this.labelTotalPair);
            this.Controls.Add(this.labelPointsImpair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPointPair1);
            this.Controls.Add(this.labelRemporte);
            this.Controls.Add(this.groupAtout);
            this.Controls.Add(this.labelJ1J3);
            this.Controls.Add(this.labelJ2J4);
            this.Controls.Add(this.labelEquipeImapir);
            this.Controls.Add(this.labelEquipePair);
            this.Name = "Points_Coupe";
            this.Text = "Points_Coupe";
            this.groupAtout.ResumeLayout(false);
            this.groupAtout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEquipePair;
        private System.Windows.Forms.Label labelEquipeImapir;
        private System.Windows.Forms.Label labelJ2J4;
        private System.Windows.Forms.Label labelJ1J3;
        private System.Windows.Forms.GroupBox groupAtout;
        private System.Windows.Forms.RadioButton radioButtonImpair;
        private System.Windows.Forms.RadioButton radioButtonPair;
        private System.Windows.Forms.CheckBox checkBelotteImpair;
        private System.Windows.Forms.CheckBox checkBelottePair;
        private System.Windows.Forms.Label labelRemporte;
        private System.Windows.Forms.Label labelPointPair1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPointsImpair;
        private System.Windows.Forms.Label labelTotalPair;
        private System.Windows.Forms.Label labelTotalImpair;
        private System.Windows.Forms.Button buttonValide;
        private System.Windows.Forms.ListBox listBoxPair;
        private System.Windows.Forms.ListBox listBoxImpair;
        private System.Windows.Forms.Label labelCumulPair;
        private System.Windows.Forms.Label labelCumulImpair;
        private System.Windows.Forms.Button buttonSuivant;
    }
}