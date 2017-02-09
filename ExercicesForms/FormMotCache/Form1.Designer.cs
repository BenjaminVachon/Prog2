namespace FormMotCache
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
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.textBoxCache = new System.Windows.Forms.TextBox();
            this.textBoxAfficher = new System.Windows.Forms.TextBox();
            this.checkBoxGras = new System.Windows.Forms.CheckBox();
            this.checkBoxItalique = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(12, 237);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(525, 23);
            this.buttonAfficher.TabIndex = 0;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // textBoxCache
            // 
            this.textBoxCache.Location = new System.Drawing.Point(13, 13);
            this.textBoxCache.Name = "textBoxCache";
            this.textBoxCache.Size = new System.Drawing.Size(525, 22);
            this.textBoxCache.TabIndex = 1;
            this.textBoxCache.Text = "sick roast";
            this.textBoxCache.UseSystemPasswordChar = true;
            // 
            // textBoxAfficher
            // 
            this.textBoxAfficher.Location = new System.Drawing.Point(13, 42);
            this.textBoxAfficher.Name = "textBoxAfficher";
            this.textBoxAfficher.ReadOnly = true;
            this.textBoxAfficher.Size = new System.Drawing.Size(525, 22);
            this.textBoxAfficher.TabIndex = 2;
            // 
            // checkBoxGras
            // 
            this.checkBoxGras.AutoSize = true;
            this.checkBoxGras.Location = new System.Drawing.Point(108, 91);
            this.checkBoxGras.Name = "checkBoxGras";
            this.checkBoxGras.Size = new System.Drawing.Size(61, 21);
            this.checkBoxGras.TabIndex = 3;
            this.checkBoxGras.Text = "Gras";
            this.checkBoxGras.UseVisualStyleBackColor = true;
            this.checkBoxGras.CheckedChanged += new System.EventHandler(this.checkBoxGras_CheckedChanged);
            // 
            // checkBoxItalique
            // 
            this.checkBoxItalique.AutoSize = true;
            this.checkBoxItalique.Location = new System.Drawing.Point(321, 91);
            this.checkBoxItalique.Name = "checkBoxItalique";
            this.checkBoxItalique.Size = new System.Drawing.Size(75, 21);
            this.checkBoxItalique.TabIndex = 4;
            this.checkBoxItalique.Text = "Italique";
            this.checkBoxItalique.UseVisualStyleBackColor = true;
            this.checkBoxItalique.CheckedChanged += new System.EventHandler(this.checkBoxItalique_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 272);
            this.Controls.Add(this.checkBoxItalique);
            this.Controls.Add(this.checkBoxGras);
            this.Controls.Add(this.textBoxAfficher);
            this.Controls.Add(this.textBoxCache);
            this.Controls.Add(this.buttonAfficher);
            this.Name = "Form1";
            this.Text = "Mot Caché";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.TextBox textBoxCache;
        private System.Windows.Forms.TextBox textBoxAfficher;
        private System.Windows.Forms.CheckBox checkBoxGras;
        private System.Windows.Forms.CheckBox checkBoxItalique;
    }
}

