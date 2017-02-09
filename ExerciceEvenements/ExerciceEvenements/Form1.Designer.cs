namespace ExerciceEvenements
{
    partial class FormDessin
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
            this.Couleur = new System.Windows.Forms.GroupBox();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.Taille = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.Couleur.SuspendLayout();
            this.Taille.SuspendLayout();
            this.SuspendLayout();
            // 
            // Couleur
            // 
            this.Couleur.Controls.Add(this.radioButtonBlack);
            this.Couleur.Controls.Add(this.radioButtonGreen);
            this.Couleur.Controls.Add(this.radioButtonRed);
            this.Couleur.Location = new System.Drawing.Point(12, 12);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(172, 165);
            this.Couleur.TabIndex = 0;
            this.Couleur.TabStop = false;
            this.Couleur.Text = "Couleur";
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(7, 78);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(55, 21);
            this.radioButtonBlack.TabIndex = 2;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Noir";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButtonBlack_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(7, 50);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(55, 21);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Vert";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 22);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(71, 21);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Rouge";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // Taille
            // 
            this.Taille.Controls.Add(this.radioButtonLarge);
            this.Taille.Controls.Add(this.radioButtonMedium);
            this.Taille.Controls.Add(this.radioButtonSmall);
            this.Taille.Location = new System.Drawing.Point(13, 184);
            this.Taille.Name = "Taille";
            this.Taille.Size = new System.Drawing.Size(171, 166);
            this.Taille.TabIndex = 1;
            this.Taille.TabStop = false;
            this.Taille.Text = "Taille";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(6, 78);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(139, 21);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "radioButtonLarge";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            this.radioButtonLarge.CheckedChanged += new System.EventHandler(this.radioButtonLarge_CheckedChanged);
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(7, 50);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(144, 21);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "radioButtonMoyen";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            this.radioButtonMedium.CheckedChanged += new System.EventHandler(this.radioButtonMedium_CheckedChanged);
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(6, 23);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(130, 21);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "radioButtonPetit";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            this.radioButtonSmall.CheckedChanged += new System.EventHandler(this.radioButtonSmall_CheckedChanged);
            // 
            // FormDessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 362);
            this.Controls.Add(this.Taille);
            this.Controls.Add(this.Couleur);
            this.Name = "FormDessin";
            this.Text = "Paint de base";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDessin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDessin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDessin_MouseUp);
            this.Couleur.ResumeLayout(false);
            this.Couleur.PerformLayout();
            this.Taille.ResumeLayout(false);
            this.Taille.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Couleur;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.GroupBox Taille;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
    }
}

