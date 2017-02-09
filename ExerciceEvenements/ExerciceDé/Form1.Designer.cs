namespace ExerciceDé
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxnoir = new System.Windows.Forms.CheckBox();
            this.checkBoxblanc = new System.Windows.Forms.CheckBox();
            this.checkBoxrouge = new System.Windows.Forms.CheckBox();
            this.numericUpDownnoir = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownblanc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownrouge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonaccept = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnoir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownblanc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrouge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dé noir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dé blanc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dé Rouge";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de livraison";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom, Prenom";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 3;
            // 
            // checkBoxnoir
            // 
            this.checkBoxnoir.AutoSize = true;
            this.checkBoxnoir.Location = new System.Drawing.Point(250, 80);
            this.checkBoxnoir.Name = "checkBoxnoir";
            this.checkBoxnoir.Size = new System.Drawing.Size(89, 21);
            this.checkBoxnoir.TabIndex = 4;
            this.checkBoxnoir.Text = "J\'en veux";
            this.checkBoxnoir.UseVisualStyleBackColor = true;
            this.checkBoxnoir.CheckedChanged += new System.EventHandler(this.checkBoxnoir_CheckedChanged);
            // 
            // checkBoxblanc
            // 
            this.checkBoxblanc.AutoSize = true;
            this.checkBoxblanc.Location = new System.Drawing.Point(250, 107);
            this.checkBoxblanc.Name = "checkBoxblanc";
            this.checkBoxblanc.Size = new System.Drawing.Size(89, 21);
            this.checkBoxblanc.TabIndex = 5;
            this.checkBoxblanc.Text = "J\'en veux";
            this.checkBoxblanc.UseVisualStyleBackColor = true;
            this.checkBoxblanc.CheckedChanged += new System.EventHandler(this.checkBoxblanc_CheckedChanged);
            // 
            // checkBoxrouge
            // 
            this.checkBoxrouge.AutoSize = true;
            this.checkBoxrouge.Location = new System.Drawing.Point(250, 136);
            this.checkBoxrouge.Name = "checkBoxrouge";
            this.checkBoxrouge.Size = new System.Drawing.Size(89, 21);
            this.checkBoxrouge.TabIndex = 6;
            this.checkBoxrouge.Text = "J\'en veux";
            this.checkBoxrouge.UseVisualStyleBackColor = true;
            this.checkBoxrouge.CheckedChanged += new System.EventHandler(this.checkBoxrouge_CheckedChanged);
            // 
            // numericUpDownnoir
            // 
            this.numericUpDownnoir.Location = new System.Drawing.Point(489, 78);
            this.numericUpDownnoir.Name = "numericUpDownnoir";
            this.numericUpDownnoir.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownnoir.TabIndex = 7;
            // 
            // numericUpDownblanc
            // 
            this.numericUpDownblanc.Location = new System.Drawing.Point(489, 106);
            this.numericUpDownblanc.Name = "numericUpDownblanc";
            this.numericUpDownblanc.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownblanc.TabIndex = 8;
            // 
            // numericUpDownrouge
            // 
            this.numericUpDownrouge.Location = new System.Drawing.Point(489, 135);
            this.numericUpDownrouge.Name = "numericUpDownrouge";
            this.numericUpDownrouge.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownrouge.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Votre coûts final est de :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(434, 22);
            this.textBox3.TabIndex = 11;
            // 
            // buttonaccept
            // 
            this.buttonaccept.Location = new System.Drawing.Point(415, 206);
            this.buttonaccept.Name = "buttonaccept";
            this.buttonaccept.Size = new System.Drawing.Size(193, 23);
            this.buttonaccept.TabIndex = 12;
            this.buttonaccept.Text = "Passez commande";
            this.buttonaccept.UseVisualStyleBackColor = true;
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(7, 206);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(124, 23);
            this.buttonreset.TabIndex = 13;
            this.buttonreset.Text = "Reinitialisé";
            this.buttonreset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 276);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttonaccept);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownrouge);
            this.Controls.Add(this.numericUpDownblanc);
            this.Controls.Add(this.numericUpDownnoir);
            this.Controls.Add(this.checkBoxrouge);
            this.Controls.Add(this.checkBoxblanc);
            this.Controls.Add(this.checkBoxnoir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnoir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownblanc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrouge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxnoir;
        private System.Windows.Forms.CheckBox checkBoxblanc;
        private System.Windows.Forms.CheckBox checkBoxrouge;
        private System.Windows.Forms.NumericUpDown numericUpDownnoir;
        private System.Windows.Forms.NumericUpDown numericUpDownblanc;
        private System.Windows.Forms.NumericUpDown numericUpDownrouge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonaccept;
        private System.Windows.Forms.Button buttonreset;
    }
}

