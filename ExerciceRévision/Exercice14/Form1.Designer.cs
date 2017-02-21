namespace Exercice14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelnblancer = new System.Windows.Forms.Label();
            this.labelpile = new System.Windows.Forms.Label();
            this.labelface = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxPiece = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnblancer
            // 
            this.labelnblancer.AutoSize = true;
            this.labelnblancer.Location = new System.Drawing.Point(144, 235);
            this.labelnblancer.Name = "labelnblancer";
            this.labelnblancer.Size = new System.Drawing.Size(0, 17);
            this.labelnblancer.TabIndex = 0;
            // 
            // labelpile
            // 
            this.labelpile.AutoSize = true;
            this.labelpile.Location = new System.Drawing.Point(12, 232);
            this.labelpile.Name = "labelpile";
            this.labelpile.Size = new System.Drawing.Size(0, 17);
            this.labelpile.TabIndex = 1;
            // 
            // labelface
            // 
            this.labelface.AutoSize = true;
            this.labelface.Location = new System.Drawing.Point(261, 232);
            this.labelface.Name = "labelface";
            this.labelface.Size = new System.Drawing.Size(0, 17);
            this.labelface.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lancer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pile.png");
            this.imageList1.Images.SetKeyName(1, "Face.png");
            // 
            // pictureBoxPiece
            // 
            this.pictureBoxPiece.Location = new System.Drawing.Point(15, 13);
            this.pictureBoxPiece.Name = "pictureBoxPiece";
            this.pictureBoxPiece.Size = new System.Drawing.Size(306, 163);
            this.pictureBoxPiece.TabIndex = 4;
            this.pictureBoxPiece.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pile victoire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Face victoire";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPiece);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelface);
            this.Controls.Add(this.labelpile);
            this.Controls.Add(this.labelnblancer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnblancer;
        private System.Windows.Forms.Label labelpile;
        private System.Windows.Forms.Label labelface;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

