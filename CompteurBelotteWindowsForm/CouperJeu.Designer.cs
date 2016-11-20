namespace CompteurBelotteWindowsForm
{
    partial class CouperJeu
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
            this.buttonPairDessus = new System.Windows.Forms.Button();
            this.buttonImpairDessus = new System.Windows.Forms.Button();
            this.buttonRetournerPair = new System.Windows.Forms.Button();
            this.buttonRetournerImpair = new System.Windows.Forms.Button();
            this.buttonCouper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPairDessus
            // 
            this.buttonPairDessus.Location = new System.Drawing.Point(199, 101);
            this.buttonPairDessus.Name = "buttonPairDessus";
            this.buttonPairDessus.Size = new System.Drawing.Size(162, 66);
            this.buttonPairDessus.TabIndex = 0;
            this.buttonPairDessus.Text = "Pile paire -> pile imapire";
            this.buttonPairDessus.UseVisualStyleBackColor = true;
            this.buttonPairDessus.Click += new System.EventHandler(this.buttonPairDessus_Click);
            // 
            // buttonImpairDessus
            // 
            this.buttonImpairDessus.Location = new System.Drawing.Point(199, 12);
            this.buttonImpairDessus.Name = "buttonImpairDessus";
            this.buttonImpairDessus.Size = new System.Drawing.Size(162, 66);
            this.buttonImpairDessus.TabIndex = 1;
            this.buttonImpairDessus.Text = "Pile impaire -> pile paire";
            this.buttonImpairDessus.UseVisualStyleBackColor = true;
            this.buttonImpairDessus.Click += new System.EventHandler(this.buttonImpairDessus_Click);
            // 
            // buttonRetournerPair
            // 
            this.buttonRetournerPair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRetournerPair.Location = new System.Drawing.Point(12, 101);
            this.buttonRetournerPair.Name = "buttonRetournerPair";
            this.buttonRetournerPair.Size = new System.Drawing.Size(162, 66);
            this.buttonRetournerPair.TabIndex = 2;
            this.buttonRetournerPair.Text = "Retourner pile paire";
            this.buttonRetournerPair.UseVisualStyleBackColor = false;
            this.buttonRetournerPair.Click += new System.EventHandler(this.buttonRetournerPair_Click);
            // 
            // buttonRetournerImpair
            // 
            this.buttonRetournerImpair.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRetournerImpair.Location = new System.Drawing.Point(12, 12);
            this.buttonRetournerImpair.Name = "buttonRetournerImpair";
            this.buttonRetournerImpair.Size = new System.Drawing.Size(162, 66);
            this.buttonRetournerImpair.TabIndex = 3;
            this.buttonRetournerImpair.Text = "Retourner pile impaire";
            this.buttonRetournerImpair.UseVisualStyleBackColor = false;
            this.buttonRetournerImpair.Click += new System.EventHandler(this.buttonRetournerImpair_Click);
            // 
            // buttonCouper
            // 
            this.buttonCouper.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCouper.Location = new System.Drawing.Point(196, 222);
            this.buttonCouper.Name = "buttonCouper";
            this.buttonCouper.Size = new System.Drawing.Size(165, 67);
            this.buttonCouper.TabIndex = 9;
            this.buttonCouper.Text = "Couper et Distribuer";
            this.buttonCouper.UseVisualStyleBackColor = false;
            this.buttonCouper.Click += new System.EventHandler(this.buttonCouper_Click);
            // 
            // CouperJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 380);
            this.Controls.Add(this.buttonCouper);
            this.Controls.Add(this.buttonRetournerImpair);
            this.Controls.Add(this.buttonRetournerPair);
            this.Controls.Add(this.buttonImpairDessus);
            this.Controls.Add(this.buttonPairDessus);
            this.Name = "CouperJeu";
            this.Text = "AfficherMains";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPairDessus;
        private System.Windows.Forms.Button buttonImpairDessus;
        private System.Windows.Forms.Button buttonRetournerPair;
        private System.Windows.Forms.Button buttonRetournerImpair;
        private System.Windows.Forms.Button buttonCouper;
    }
}