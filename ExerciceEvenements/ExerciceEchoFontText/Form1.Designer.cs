namespace ExerciceEchoFontText
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
            this.numericUpDownTaille = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxZone = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaille)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTaille
            // 
            this.numericUpDownTaille.Location = new System.Drawing.Point(12, 40);
            this.numericUpDownTaille.Name = "numericUpDownTaille";
            this.numericUpDownTaille.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTaille.TabIndex = 2;
            this.numericUpDownTaille.ValueChanged += new System.EventHandler(this.numericUpDownTaille_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taille police";
            // 
            // richTextBoxZone
            // 
            this.richTextBoxZone.Location = new System.Drawing.Point(12, 68);
            this.richTextBoxZone.Name = "richTextBoxZone";
            this.richTextBoxZone.Size = new System.Drawing.Size(544, 326);
            this.richTextBoxZone.TabIndex = 0;
            this.richTextBoxZone.Text = "";
            this.richTextBoxZone.TextChanged += new System.EventHandler(this.richTextBoxZone_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 406);
            this.Controls.Add(this.richTextBoxZone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownTaille);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownTaille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxZone;
    }
}

