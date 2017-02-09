namespace ExercicesDevinerNombre
{
    partial class Form1
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
            this.textBoxEssaie = new System.Windows.Forms.TextBox();
            this.buttonAccepter = new System.Windows.Forms.Button();
            this.labelDefi = new System.Windows.Forms.Label();
            this.labelProposition = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.buttonRetry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEssaie
            // 
            this.textBoxEssaie.Location = new System.Drawing.Point(114, 85);
            this.textBoxEssaie.Name = "textBoxEssaie";
            this.textBoxEssaie.Size = new System.Drawing.Size(176, 22);
            this.textBoxEssaie.TabIndex = 0;
            // 
            // buttonAccepter
            // 
            this.buttonAccepter.Location = new System.Drawing.Point(114, 113);
            this.buttonAccepter.Name = "buttonAccepter";
            this.buttonAccepter.Size = new System.Drawing.Size(176, 23);
            this.buttonAccepter.TabIndex = 1;
            this.buttonAccepter.Text = "Accepter";
            this.buttonAccepter.UseVisualStyleBackColor = true;
            this.buttonAccepter.Click += new System.EventHandler(this.buttonAccepter_Click);
            // 
            // labelDefi
            // 
            this.labelDefi.AutoSize = true;
            this.labelDefi.Location = new System.Drawing.Point(12, 9);
            this.labelDefi.Name = "labelDefi";
            this.labelDefi.Size = new System.Drawing.Size(388, 17);
            this.labelDefi.TabIndex = 2;
            this.labelDefi.Text = "J\'ai générer un nombre aléatoire entre 1 et 1000 deviner le !";
            // 
            // labelProposition
            // 
            this.labelProposition.AutoSize = true;
            this.labelProposition.Location = new System.Drawing.Point(101, 65);
            this.labelProposition.Name = "labelProposition";
            this.labelProposition.Size = new System.Drawing.Size(203, 17);
            this.labelProposition.TabIndex = 3;
            this.labelProposition.Text = "Entrer un nombre pour deviner";
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Location = new System.Drawing.Point(133, 170);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(0, 17);
            this.labelResultat.TabIndex = 4;
            // 
            // buttonRetry
            // 
            this.buttonRetry.Location = new System.Drawing.Point(13, 181);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(114, 23);
            this.buttonRetry.TabIndex = 5;
            this.buttonRetry.Text = "Recommencer";
            this.buttonRetry.UseVisualStyleBackColor = true;
            this.buttonRetry.Click += new System.EventHandler(this.buttonRetry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 216);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.labelProposition);
            this.Controls.Add(this.labelDefi);
            this.Controls.Add(this.buttonAccepter);
            this.Controls.Add(this.textBoxEssaie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEssaie;
        private System.Windows.Forms.Button buttonAccepter;
        private System.Windows.Forms.Label labelDefi;
        private System.Windows.Forms.Label labelProposition;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.Button buttonRetry;
    }
}

