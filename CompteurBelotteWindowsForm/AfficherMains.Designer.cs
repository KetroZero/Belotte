namespace CompteurBelotteWindowsForm
{
    partial class AfficherMains
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPairDessus
            // 
            this.buttonPairDessus.Location = new System.Drawing.Point(13, 13);
            this.buttonPairDessus.Name = "buttonPairDessus";
            this.buttonPairDessus.Size = new System.Drawing.Size(162, 66);
            this.buttonPairDessus.TabIndex = 0;
            this.buttonPairDessus.Text = "Pile paire -> pile imapire";
            this.buttonPairDessus.UseVisualStyleBackColor = true;
            // 
            // buttonImpairDessus
            // 
            this.buttonImpairDessus.Location = new System.Drawing.Point(13, 120);
            this.buttonImpairDessus.Name = "buttonImpairDessus";
            this.buttonImpairDessus.Size = new System.Drawing.Size(162, 66);
            this.buttonImpairDessus.TabIndex = 1;
            this.buttonImpairDessus.Text = "Pile impaire -> pile paire";
            this.buttonImpairDessus.UseVisualStyleBackColor = true;
            // 
            // buttonRetournerPair
            // 
            this.buttonRetournerPair.Location = new System.Drawing.Point(181, 12);
            this.buttonRetournerPair.Name = "buttonRetournerPair";
            this.buttonRetournerPair.Size = new System.Drawing.Size(162, 66);
            this.buttonRetournerPair.TabIndex = 2;
            this.buttonRetournerPair.Text = "Retourner pile paire";
            this.buttonRetournerPair.UseVisualStyleBackColor = true;
            // 
            // buttonRetournerImpair
            // 
            this.buttonRetournerImpair.Location = new System.Drawing.Point(181, 120);
            this.buttonRetournerImpair.Name = "buttonRetournerImpair";
            this.buttonRetournerImpair.Size = new System.Drawing.Size(162, 66);
            this.buttonRetournerImpair.TabIndex = 3;
            this.buttonRetournerImpair.Text = "Retourner pile impaire";
            this.buttonRetournerImpair.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(613, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(456, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Carte de coupe, couleur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Carte de coupe, valeur";
            // 
            // AfficherMains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonRetournerImpair);
            this.Controls.Add(this.buttonRetournerPair);
            this.Controls.Add(this.buttonImpairDessus);
            this.Controls.Add(this.buttonPairDessus);
            this.Name = "AfficherMains";
            this.Text = "AfficherMains";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPairDessus;
        private System.Windows.Forms.Button buttonImpairDessus;
        private System.Windows.Forms.Button buttonRetournerPair;
        private System.Windows.Forms.Button buttonRetournerImpair;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}