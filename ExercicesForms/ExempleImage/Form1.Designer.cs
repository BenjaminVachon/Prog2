namespace ExempleImage
{
    partial class FormImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImages));
            this.pictureBoxImages = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImages
            // 
            this.pictureBoxImages.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxImages.Name = "pictureBoxImages";
            this.pictureBoxImages.Size = new System.Drawing.Size(257, 228);
            this.pictureBoxImages.TabIndex = 0;
            this.pictureBoxImages.TabStop = false;
            this.pictureBoxImages.Click += new System.EventHandler(this.pictureBoxImages_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ya3.gif");
            this.imageList1.Images.SetKeyName(1, "star.png");
            // 
            // FormImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.pictureBoxImages);
            this.Name = "FormImages";
            this.Text = "Test Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImages;
        private System.Windows.Forms.ImageList imageList1;
    }
}

